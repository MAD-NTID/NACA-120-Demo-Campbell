const double COMMISSION_RATE = 0.07;
double commission = 0;
int MINIMUM_SALES = 10000;


Console.Write("Enter total sale:");
double totalSale = double.Parse(Console.ReadLine());

if(totalSale>=MINIMUM_SALES)
{
    commission = totalSale * COMMISSION_RATE;
}

Console.WriteLine($"Justin, your commission is: {commission:C}");