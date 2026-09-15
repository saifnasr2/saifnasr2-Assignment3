namespace CSharpBasicsAssignment;

public class Order
{
    public int OrderId;
    public string CustomerName;
    public int Quantity;
    public decimal UnitPrice;
    public decimal TotalPrice;
    public bool IsPaid;
    public double DiscountPercent;
    public string ShippingCity;
    public char Priority;
    public long ItemCode;

    public void CalculateTotal()
    {
        
        TotalPrice = Quantity * UnitPrice * (1 - (decimal)DiscountPercent / 100);


    }

    public void PrintSummary()
    {
        Console.WriteLine($"The order id is {OrderId} , The Customer name is {CustomerName} , The total price is {TotalPrice} and the status of payment is {IsPaid}");
    }

}