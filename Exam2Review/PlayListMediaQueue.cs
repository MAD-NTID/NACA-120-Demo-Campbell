public class PlayListMediaQueue<T> : PlayListMedia<T>
{
    private IQueue<T> playlist;
    
    public PlayListMediaQueue()
    {
        this.playlist = new Queue<T>();
    }
    
    public override void Add(T media)
    {
        this.playlist.Enqueue(media);
        this.totalMedia = this.playlist.Count;
        //or this.totalMedia++;
    }

    public override T Play()
    {
        T media = this.playlist.Dequeue();
        this.totalMedia = this.playlist.Count;
        return media;
    
    }

    public override T ShowNextMedia()
    {
        return this.playlist.Peek();
    }

    public override string ToString()
    {
        return this.playlist.ToString();
    }
}