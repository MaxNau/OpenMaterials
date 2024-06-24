using System;

namespace ApiClient.Http.RequestData
{
    [AttributeUsage(AttributeTargets.Property)]
    public class QueryParameterAttribute : Attribute
    {
        public QueryParameterAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
