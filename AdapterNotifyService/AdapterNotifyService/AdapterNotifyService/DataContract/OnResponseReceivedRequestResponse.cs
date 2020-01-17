using System;
using System.Runtime.Serialization;
using System.Xml;

namespace AdapterNotifyService.DataContract
{
    [DataContract]
    public partial class OnResponseReceivedRequestResponse
    {
        [DataMember]
        public string ResponseMessageId { get; set; }

        [DataMember]
        public string ResponseType { get; set; }

        [DataMember]
        public DateTime ResponseDate { get; set; }

        [DataMember]
        public XmlElement ResponseContent { get; set; }

        //[DataMember]
        //public AttachmentInfo[] Attachment { get; set; }

        [DataMember]
        public string AsyncProcessingStatusCategory { get; set; }
    }
}