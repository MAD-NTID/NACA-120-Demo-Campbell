using System.Reflection.Metadata.Ecma335;

public class PlayListMediaStack<T> : PlayListMedia<T>
{
    private IStack<T> playlist;
    
    public PlayListMediaStack()
    {
        this.playlist = new Stack<T>();
    }
    
    public override void Add(T media)
    {
        this.playlist.Push(media);
        this.totalMedia = this.playlist.Count;
        //or this.totalMedia++;
    }

    public override T Play()
    {
        this.totalMedia = this.playlist.Count;
        return this.playlist.Pop();
    
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