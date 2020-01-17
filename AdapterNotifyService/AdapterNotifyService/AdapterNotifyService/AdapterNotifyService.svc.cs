using AdapterNotifyService.DataContract;

namespace AdapterNotifyService
{
    public class AdapterNotifyService : IAdapterNotifyService
    {
        public OnResponseReceivedRequest Test(OnResponseReceivedRequest onResponseReceivedRequest)
        {
            return onResponseReceivedRequest;
        }

        public OnResponseReceivedResponse OnResponseReceived(OnResponseReceivedRequest onResponseReceivedRequest)
        {

            return new OnResponseReceivedResponse();
        }

        public OnSupplierRequestReceivedResponse OnSupplierRequestReceived(OnSupplierRequestReceivedRequest onSupplierRequestReceivedRequest)
        {

            return new OnSupplierRequestReceivedResponse();
        }
    }
}
