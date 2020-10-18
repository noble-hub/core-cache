using Enyim.Caching;

namespace MemCached
{
    internal class CacheRepository : ICacheRepository
    {
        private readonly IMemcachedClient memcachedClient;

        public CacheRepository(IMemcachedClient memcachedClient)
        {
            this.memcachedClient = memcachedClient;
        }
        public void Save<T>(string key, T value)
        {
            memcachedClient.Set(key, value, 1);
        }
    }
}