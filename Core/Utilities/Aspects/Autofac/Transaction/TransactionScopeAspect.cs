using System.Transactions;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;

namespace Core.Utilities.Aspects.Autofac.Transaction;

public class TransactionScopeAspect : MethodInterception
{
    public override void Intercept(IInvocation invocation)
    {
        using var transactionScope = new TransactionScope();
        try
        {
            invocation.Proceed();
            transactionScope.Complete();
        }
        catch (Exception e)
        {
            transactionScope.Dispose();
            throw;
        }
    }
}