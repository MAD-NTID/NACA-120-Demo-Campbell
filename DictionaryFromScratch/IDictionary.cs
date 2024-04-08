public interface IDictionary<TKey, TValue>
{
    public int Count{get;}
    public void Add(TKey key, TValue value);
    public bool Remove(TKey key);
    public void Clear();

    public bool ContainsKey(TKey key);
    public bool ContainsValue(TValue value);

    public IKeyValuePair<TKey, TValue> Get(TKey key);

    public int GetIndex(TKey key);

    public void EnsureCapacity();

    public double LoadFactor{get;}
}