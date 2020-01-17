using AdapterNotifyService.DataContract;
using System.ServiceModel;

namespace AdapterNotifyService
{
    [ServiceContract]
    public interface IAdapterNotifyService
    {
        [OperationContract]
        OnResponseReceivedRequest Test(OnResponseReceivedRequest onResponseReceivedRequest);

        [OperationContract]
        OnResponseReceivedResponse OnResponseReceived(OnResponseReceivedRequest onResponseReceivedRequest);

        [OperationContract]
        OnSupplierRequestReceivedResponse OnSupplierRequestReceived(OnSupplierRequestReceivedRequest onSupplierRequestReceivedRequest);
    }  
}
