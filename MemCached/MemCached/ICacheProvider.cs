namespace MemCached
{
    internal interface ICacheProvider
    {
        T Get<T>(string key);
    }
}