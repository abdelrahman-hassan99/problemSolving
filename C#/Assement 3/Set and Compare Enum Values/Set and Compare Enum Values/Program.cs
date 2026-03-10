using System;

enum OrderStatus
{
    Pending,
    Shipped,
    Delivered,
    Cancelled
}

class Program
{
    static void Main()
    {
        OrderStatus currentStatus = OrderStatus.Delivered;

        string message = GetOrderStatusMessage(currentStatus);
        Console.WriteLine(message);
    }

    static string GetOrderStatusMessage(OrderStatus status)
    {
        if (status == OrderStatus.Delivered)
        {
            return "Your order has been delivered!";
        }
        else if (status == OrderStatus.Shipped)
        {
            return "Your order is on the way.";
        }
        else if (status == OrderStatus.Pending)
        {
            return "Your order is being processed.";
        }
        else if (status == OrderStatus.Cancelled)
        {
            return "Your order was cancelled.";
        }
        else
        {
            return "Unknown order status.";
        }
    }
}
