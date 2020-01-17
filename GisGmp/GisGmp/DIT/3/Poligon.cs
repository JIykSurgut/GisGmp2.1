using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GisGmp.DIT._3
{
    class Poligon
    {
        AdapterNotifyServiceClient client = new AdapterNotifyServiceClient();
        public Poligon()
        {
             OnSupplierRequestReceivedResponse r = client.OnSupplierRequestReceived(null);

            client.OnResponseReceived(
                new OnResponseReceivedRequest(){ 
                Response = new OnResponseReceivedRequestResponse() { 
                
                }
                });


            new OnResponseReceivedResponse()
            {
                
            };

            new OnResponseReceivedResponse1()
            {
                OnResponseReceivedResponse = new OnResponseReceivedResponse() { }
            };

        }

    }
}
