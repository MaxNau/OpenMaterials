using System;

namespace MaterialsProject.Responses.Common
{
    public class Origin
    {
        public string Name { get; set; }

        public string TaskId { get; set; }

        public DateTimeOffset LastUpdated { get; set; }
    }
}
