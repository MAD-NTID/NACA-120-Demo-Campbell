public class KeyValuePair<TKey, TValue> : IKeyValuePair<TKey, TValue>
{
    private TKey key;
    private TValue value;

    public TKey Key => key;

    public TValue Value => value;

    public KeyValuePair(TKey key, TValue value)
    {
        this.key = key;
        this.value = value;
    }

    public override string ToString()
    {
        return $"{this.key}:{this.value}";

    }
}