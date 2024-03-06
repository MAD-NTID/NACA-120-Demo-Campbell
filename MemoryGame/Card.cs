public class Card
{
    private string color;
    private string shape;
    private bool flip;

    public string Color{
        get{return color;}
    }

    public string Shape
    {
        get{return shape;}
    }

    public Card(string shape, string color)
    {
        this.color = color;
        this.shape = shape;
        this.flip = false;
    }

    public override bool Equals(object? obj)
    {
        Card card = (Card)obj;
        return this.color == card.color && this.shape == card.shape;

    }

    public void Reveal(bool status)
    {
        this.flip = status;
    }

    public override string ToString()
    {
        if(flip)
            return $"{this.shape}-->{this.color}";
        return "*";
    }
}