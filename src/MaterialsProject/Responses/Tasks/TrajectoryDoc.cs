using System.Collections.Generic;

namespace MaterialsProject.Responses.Tasks
{
    public class TrajectoryDoc
    {
        public string TaskId { get; set; }
        public List<Trajectory> Trajectories { get; set; }
    }
}
