using Enyim.Caching;
namespace MemCached
{
    internal class CacheProvider : ICacheProvider
    {
        private readonly IMemcachedClient memCachedClient;

        public CacheProvider(IMemcachedClient memCachedClient)
        {
            this.memCachedClient = memCachedClient;
        }

        public T Get<T>(string key)
        {
            return memCachedClient.Get<T>(key);
        }
    }
}