using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class OrderManager: IOrderService
{
    private IOrderDal _orderDal;

    public OrderManager(IOrderDal orderDal)
    {
        _orderDal = orderDal;

    }
    
    public List<Order> GetAll()
    {
        return _orderDal.GetAll();
    }
}