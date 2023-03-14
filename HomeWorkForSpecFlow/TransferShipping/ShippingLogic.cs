namespace HomeWorkForSpecFlow.TransferShipping;

public class ShippingLogic : IShippingLogic
{
    // 這裡不知道為什麼要用private
    public List<TransferShippingViewModel> _transferShippingViewModels;
    
    public int QueryStatus(FilterShippingModel filter)
    {
        var result = (int)this._transferShippingViewModels.SingleOrDefault(s => s.ShippingNo == filter.ShippingNo).Status;

        return result;
    }
}