public abstract class PlayListMedia<T> : IPlayListMedia<T>
{
    protected int totalMedia;


    public int TotalMedia
    {
        get{return this.totalMedia;}
    }

    public PlayListMedia()
    {
        this.totalMedia = 0;
    }

    public abstract void Add(T media);

    public abstract T Play();

    public abstract T ShowNextMedia();

}
