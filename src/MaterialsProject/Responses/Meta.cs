using System;
using System.Collections.Generic;

namespace MaterialsProject.Responses
{
    public class Meta
    {
        public string ApiVersion { get; set; }
        
        public DateTimeOffset TimeStamp { get; set; }

        public long TotalDoc { get; set; }

        public long MaxLimit { get; set; }

        public List<string> DefaultFields { get; set; }
    }
}
