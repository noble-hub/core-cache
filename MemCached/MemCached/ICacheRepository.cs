namespace MemCached
{
    internal interface ICacheRepository
    {
        void Save<T>(string key, T value);
    }
}