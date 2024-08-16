namespace ExceptionHandlingExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Customer cutomerOne = new Customer("First Class", 1, "Karthik", new DateTime(1990,1,1));
            Airlines airlines = new Airlines()
            {
                AirlineId = 1,
                AirlineName = "Air Italia",
            };

            try
            {
                double totalAmount = airlines.CalculateFare(cutomerOne);
                Console.WriteLine("Calculated fare for the person is : " + totalAmount);

            }
            catch (Exception ex) 
            {
                Console.WriteLine("Caught an exception : " + ex.ToString());
            }
        }
    }
}
