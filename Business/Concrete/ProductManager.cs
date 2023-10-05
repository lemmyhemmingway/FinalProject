using System.ComponentModel.DataAnnotations;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Utilities.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using ValidationException = System.ComponentModel.DataAnnotations.ValidationException;

namespace Business.Concrete;

public class ProductManager : IProductService
{
    private readonly IProductDal _productDal;
    private readonly ICategoryService _categoryService;

    public ProductManager(IProductDal productDal, ICategoryService categoryService)
    {
        _productDal = productDal;
        _categoryService = categoryService;
    }

    public IDataResult<List<Product>> GetAll()
    {
        return new SuccessDataResult<List<Product>>(_productDal.GetAll());
    }


    [ValidationAspect(typeof(ProductValidator))]
    public IResult Add(Product product)
    {
        var result = BusinessRules.Run(CheckProductNameIsUnique(product.ProductName),
            CheckIfProductCountOfCategoryCorrect(product.CategoryId),
            CheckIfCategoryLimitExceeded());
        if (result != null)
        {
            return result;
        }

        _productDal.Add(product);
        return new SuccessResult(Messages.ProductAdded);
    }

    public IDataResult<List<Product>> GetByCategoryId(int id)
    {
        return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id),
            Messages.ProductListed);
    }

    public IDataResult<List<Product>> GetByUnitPrice(decimal minPrice, decimal maxPrice)
    {
        return new SuccessDataResult<List<Product>>(_productDal.GetAll(p =>
            p.UnitPrice > minPrice && p.UnitPrice < maxPrice));
    }

    public IDataResult<List<ProductDetailDto>> GetProductDetails()
    {
        return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
    }

    public IDataResult<Product> GetById(int id)
    {
        return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == id));
    }

    private IResult CheckIfProductCountOfCategoryCorrect(int categoryId)
    {
        var result = _productDal.GetAll(p => p.CategoryId == categoryId).Count;
        if (result > 10)
        {
            return new ErrorResult("Category Hata");
        }

        return new SuccessResult();
    }

    private IResult CheckProductNameIsUnique(string productName)
    {
        var result = _productDal.GetAll(p => p.ProductName == productName).Any();
        if (result)
        {
            return new ErrorResult("Product Name Hata");
        }

        return new SuccessResult();
    }

    private IResult CheckIfCategoryLimitExceeded()
    {
        var result = _categoryService.GetAll();
        if (result.Data.Count > 15)
        {
            return new ErrorResult();
        }

        return new SuccessResult();
    }
}