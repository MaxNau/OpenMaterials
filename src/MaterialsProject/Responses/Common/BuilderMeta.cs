using System;

namespace MaterialsProject.Responses.Common
{
    public class BuilderMeta
    {
        public string EmmetVersion { get; set; }
        public string PymatgenVersion { get; set; }
        public int PullRequest { get; set; }
        public string DatabaseVersion { get; set; }
        public DateTime BuildDate { get; set; }
        public string License { get; set; }
    }
}
