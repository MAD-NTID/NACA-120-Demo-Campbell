public class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>
{
    private int count;
    public int Count => count;

    private const double LOAD_FACTOR = 0.70;

    public double LoadFactor =>LOAD_FACTOR;

    private const int DEFAULT_CAPACITY = 5;
    private int capacity;

    public Dictionary(int capacity)
    {
        this.capacity = capacity;
        this.hashTable = new IKeyValuePair<TKey, TValue>[capacity];
    }

    public Dictionary():this(DEFAULT_CAPACITY)
    {
        
    }

    private IKeyValuePair<TKey,TValue>[] hashTable;

    public void Add(TKey key, TValue value)
    {
        this.EnsureCapacity();

        //prevent duplication
        if(this.ContainsKey(key))
            throw new ArgumentException("Duplicate key not allowed!!!!!!!");

        //find the location to insert
        int location = this.LinearProbing(key);

        //make the pair
        IKeyValuePair<TKey, TValue> kvp = new KeyValuePair<TKey, TValue>(key, value);

        //insert the element
        this.hashTable[location] = kvp;

        count++;
    }

    public void Clear()
    {
        this.hashTable = new IKeyValuePair<TKey, TValue>[capacity];

        count = 0;
    }

    public bool ContainsKey(TKey key)
    {
       return this.LinearProbing(key, true) >=0;
    }

    public bool ContainsValue(TValue value)
    {
        for(int i = 0; i < capacity; i++)
        {
            IKeyValuePair<TKey, TValue> kvp = this.hashTable[i];
            if(kvp is not null)
            {
                if(EqualityComparer<TValue>.Default.Equals(value, kvp.Value))
                    return true;
            }
        }

        return false;
    }

    public IKeyValuePair<TKey, TValue> Get(TKey key)
    {
        if(!this.ContainsKey(key))
            throw new ArgumentException("No such key bruh");
        
        int location = this.LinearProbing(key, true);
        return this.hashTable[location];
    }

    public bool Remove(TKey key)
    {
        if(!this.ContainsKey(key))
            return false;

        int location = this.LinearProbing(key, true);
        this.hashTable[location] = null;
        count--;
        return true;
    }

    public int GetIndex(TKey key)
    {
        int hash = key.GetHashCode();
        //force hashcode to always be positive
        //you can use Math.Abs if you prefer
        if(hash < 0)
            hash*=-1;
        
        //make sure it stay in the limit(range)
        int index = hash % capacity;
        return index;


    }

    public void EnsureCapacity()
    {
       //check current load factor
       double loadFactor = count/(double)capacity;

       //almost full?
       if(loadFactor >= this.LoadFactor)
       {
            //increase the size
            this.capacity = capacity * 2;
            IKeyValuePair<TKey, TValue>[] copy = new IKeyValuePair<TKey, TValue>[capacity];

            for(int i = 0; i < this.hashTable.Length; i++) 
            {
                copy[i] = this.hashTable[i];
            }

            //update old hashtable to new hashtable
            this.hashTable = copy;
       }
    }

    private int LinearProbing(TKey key, bool searchForExistingKey = false)
    {
        //start at a specific index
        int startIndex = this.GetIndex(key);
        int index = startIndex;

        do
        {
            IKeyValuePair<TKey, TValue> kvp = this.hashTable[index];

            //we are searching for existing key
            if(searchForExistingKey && kvp is not null){
                if(EqualityComparer<TKey>.Default.Equals(key, kvp.Key))
                    return index;
            } 
            //we are not in search for existing key mode
            else if(!searchForExistingKey && kvp is null) 
            {
                return index;
            }

            index = (index + 1)  % capacity;

        }while(startIndex!=index);


        return -1;
    }
}