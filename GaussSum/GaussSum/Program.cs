namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i <= number; i++)
            {
                sum += i;
                
            }
            Console.WriteLine("The sum (Gauss Sum Formula): " + sum);

            double avg;

            avg = sum / number;

            if (avg > 50)
            {
                Console.WriteLine("The average is greater than 50...");
            }
            else
            {
                Console.WriteLine("The average is less than 50...");
            }
            Console.ReadLine();
        }
    }
}
