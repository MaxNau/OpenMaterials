using OScience.MaterialsProject.RequestParameters;
using System.Threading.Tasks;

namespace OScience.MaterialsProject.Endpoints
{
    public interface ICore
    {
        Task<T> GetAsync<T>();
        Task<T> GetAsync<T>(MaterialsQuery materialsParameters, PagingParameters pagingParameters);
    }
}
