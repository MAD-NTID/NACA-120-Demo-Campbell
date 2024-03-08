public class Sale{
    private int quantity;
    public int Quantity
    {
        get { return quantity;}
    }

    private string itemNumber;
    public string ItemNumber
    {
        get { return itemNumber; }
        
    }

    private double price;
    public double Price
    {
        get { return price; }
    
    }

    private string description;
    public string Description
    {
        get { return description; }
       
    }

    public Sale(string itemNumber, string description, int quantity, double price)
    {
        this.itemNumber = itemNumber;
        this.description = description;
        this.price = price;
        this.quantity = quantity;

    }

    public override string ToString()
    {
        return $"{itemNumber} {description} {price} {quantity}";
    }




}