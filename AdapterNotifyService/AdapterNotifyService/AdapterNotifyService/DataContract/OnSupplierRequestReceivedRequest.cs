using System.Runtime.Serialization;

namespace AdapterNotifyService.DataContract
{
    [DataContract]
    public class OnSupplierRequestReceivedRequest
    {
        [DataMember]
        public string RequestMessageId { get; set; }

        [DataMember]
        public System.Xml.XmlElement RequestContent { get; set; }

        [DataMember]
        public AttachmentInfo[] Attachment { get; set; }
    }
}