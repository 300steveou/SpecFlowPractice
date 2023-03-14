namespace HomeWorkForSpecFlow.TransferShipping;
 
public interface IShippingLogic
{
    int QueryStatus(FilterShippingModel filter);
}