using System.Collections.Generic;

namespace MaterialsProject.Responses.Materials.Tasks
{
    public class TrajectoryDoc
    {
        public string TaskId { get; set; }
        public List<Trajectory> Trajectories { get; set; }
    }
}
