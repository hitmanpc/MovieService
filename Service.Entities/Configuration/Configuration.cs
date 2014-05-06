using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Service.Entities.Configuration
{
    [DataContract]
    public class Configuration
    {
        [DataMember]
        public Images images { get; set; }

        [DataMember]
        public List<string> change_keys { get; set; }

        [DataContract]
        public class Images
        {
            [DataMember]
            public string base_url { get; set; }

            [DataMember]
            public string secure_base_url { get; set; }
            
            [DataMember]
            public List<string> backdrop_sizes { get; set; }
            
            [DataMember]
            public List<string> logo_sizes { get; set; }
            
            [DataMember]
            public List<string> poster_sizes { get; set; }
            
            [DataMember]
            public List<string> profile_sizes { get; set; }
            
            [DataMember]
            public List<string> still_sizes { get; set; }
        }

    }
}
