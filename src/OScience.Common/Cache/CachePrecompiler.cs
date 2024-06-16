using System.Reflection;

namespace OScience.Common.Cache
{
    internal class CachePrecompiler<T> : ICachePrecompiler<T>
    {
        void ICachePrecompiler<T>.PrecompileCache(params IPrecompiledCache[] precompiledCaches)
        {
            var assembly = Assembly.GetAssembly(typeof(T));
            foreach (var cache in precompiledCaches)
            {
                cache.Precompile(assembly);
            }
        }
    }
}
