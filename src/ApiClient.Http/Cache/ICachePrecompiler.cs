namespace ApiClient.Http.Cache
{
    internal interface ICachePrecompiler<T>
    {
        void PrecompileCache(params IPrecompiledCache[] precompiledCaches);
    }
}
