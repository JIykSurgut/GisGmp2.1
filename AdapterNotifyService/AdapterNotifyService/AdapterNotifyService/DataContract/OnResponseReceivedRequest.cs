using System;
using System.Runtime.Serialization;

namespace AdapterNotifyService.DataContract
{
  
    public class OnResponseReceivedRequest
    {

        public string RequestMessageId { get; set; }


        
        public string RequestStatus { get; set; }



        public string RequestError { get; set; }


        //2019-12-31T15:12:39+05:00
   
        public DateTime RequestSendDate { get; set; }


        //true
        public bool RequestSendDateSpecified { get; set; }

        public OnResponseReceivedRequestResponse Response { get; set; }
    }
}