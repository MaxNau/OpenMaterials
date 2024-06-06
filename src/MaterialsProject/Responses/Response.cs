using System.Collections.Generic;

namespace MaterialsProject.Responses
{
    public class Response<T>
    {
        public List<T> Data { get; set; }
        public Meta Meta { get; set; }
    }
}
