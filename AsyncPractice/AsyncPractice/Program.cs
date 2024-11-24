namespace AsyncPractice
{
    internal class Program
    {
        async static Task  Main(string[] args)
        {
            Console.WriteLine($"Inside main method : {DateTime.Now}");
            Task t1 = BookAvailability();
            Task t2 = DeliveryPossibility();
            await Task.WhenAll( t1, t2 );

            Console.WriteLine($"When all is completed : {DateTime.Now}");

            await Order();
            Console.WriteLine($"Transaction is completed : {DateTime.Now}");

            Console.ReadLine();
        }
        static async Task BookAvailability()
        {
            Console.WriteLine($"Checking book availablity : {DateTime.Now}");
            await Task.Delay(120000);
            await Task.CompletedTask;
            Console.WriteLine($"Booking availability is completed :{DateTime.Now}");
        }

        static async Task DeliveryPossibility()
        {
            Console.WriteLine($"Checking for delivery possibility : {DateTime.Now}");
            await Task.Delay(120000);
            await Task.CompletedTask;
            Console.WriteLine($"Delivery possiblity completed :{DateTime.Now}");
        }

        static async Task Order()
        {
            Console.WriteLine($"Book is underprocessing : {DateTime.Now}");
            await Task.CompletedTask ;
            Console.WriteLine($"Book is ordered : {DateTime.Now}");
        }
    }
}
