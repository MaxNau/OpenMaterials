using System;

namespace OScience.Common.Http
{
    internal class UriQueryBuilder
    {
        private readonly UriBuilder _builder;

        internal UriQueryBuilder(string baseAddress)
        {
            _builder = new UriBuilder(baseAddress);
        }

        internal void AppendQuery(string query)
        {
            if (!string.IsNullOrEmpty(query))
            {
                _builder.Query = _builder.Query.Length > 1 ? $"{_builder.Query.Substring(1)}&{query}" : query;
            }
        }

        internal void SetPath(string path)
        {
            _builder.Path = path;
        }

        internal Uri Build()
        {
            return _builder.Uri;
        }
    }
}
