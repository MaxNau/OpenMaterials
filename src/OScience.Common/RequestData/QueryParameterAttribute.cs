using System;

namespace OScience.Common.RequestData
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
