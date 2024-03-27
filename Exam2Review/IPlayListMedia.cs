public interface IPlayListMedia<T>
{
    public abstract void Add(T media);
    public abstract T ShowNextMedia();
    public abstract T Play();
    public int TotalMedia{get;}

    

}