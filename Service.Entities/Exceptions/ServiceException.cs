using System.Runtime.Serialization;

namespace Service.Entities.Exceptions
{
    [DataContract]
    public class ServiceException
    {
        [DataMember]
        public string ErrorMessage { get; set; }

        [DataMember]
        public  string StackTrace { get; set; }
    }
}
