using System.Reflection;

namespace OScience.Common.Cache
{
    internal interface IPrecompiledCache
    {
        void Precompile(Assembly assembly);
    }
}
