using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Service.Entities.Movies
{
    [DataContract]
    public class MovieSearch
    {
        [DataMember]
        public int page { get; set; }

        [DataMember]
        public List<Result> results { get; set; }

        [DataMember]
        public int total_pages { get; set; }

        [DataMember]
        public int total_results { get; set; }

        [DataContract]
        public class Result
        {
            [DataMember]
            public bool adult { get; set; }
            [DataMember]
            public string backdrop_path { get; set; }
            [DataMember]
            public int id { get; set; }
            [DataMember]
            public string original_title { get; set; }
            [DataMember]
            public string release_date { get; set; }
            [DataMember]
            public string poster_path { get; set; }
            [DataMember]
            public double popularity { get; set; }
            [DataMember]
            public string title { get; set; }
            [DataMember]
            public double vote_average { get; set; }
            [DataMember]
            public int vote_count { get; set; }
        }

    }
}
