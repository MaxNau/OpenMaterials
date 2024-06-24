namespace ApiClient.Http.Cache
{
    internal interface ICache<out T> where T: class
    {
        T Get<CachedType>();
    }
}
