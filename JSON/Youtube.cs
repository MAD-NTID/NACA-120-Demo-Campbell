public class Youtube
{
    private string url;
    public string URL
    {
        get { return url; }
        set{url = value;}
    }

    private DateTime dateWatched;
    public DateTime DateWatched
    {
        get { return dateWatched; }
        set { dateWatched = value; }
    }

    private string category;
    public string Category
    {
        get { return category; }
        set { category = value; }
    }

    public Youtube(string url, DateTime dateWatched, string category)
    {
        this.Category = category;
        this.URL = url;
        this.DateWatched = dateWatched;
    }

    public override string ToString()
    {
        return $"{url}:{dateWatched}:{category}";
    }



}