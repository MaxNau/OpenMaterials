using System.Reflection;

namespace ApiClient.Http.Cache
{
    internal interface IPrecompiledCache
    {
        void Precompile(Assembly assembly);
    }
}
