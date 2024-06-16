namespace OScience.Common.Cache
{
    internal interface ICachePrecompiler<T>
    {
        void PrecompileCache(params IPrecompiledCache[] precompiledCaches);
    }
}
