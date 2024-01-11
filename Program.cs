namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int starting, ending, count;
            Console.WriteLine("Enter the starting number.");
            starting = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ending number.");
            ending = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many numbers are on the list?");
            count = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                int rndmnm;
                do
                {
                    rndmnm = rnd.Next(starting, ending);
                }
                while (Array.IndexOf(numbers, rndmnm) != -1);
                numbers[i] = rndmnm;
            }
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
