namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            bool english = false;
            int starting, ending, count;
            Console.Write("Hello! For English, please press \"E\" key: ");
            english = Console.ReadKey().KeyChar.ToString().ToUpper() == "E";
            Console.WriteLine(!english ? "\nBaslangic sayisini giriniz." : "\nEnter the starting number.");
            starting = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(!english ? "Bitis sayisini giriniz." : "Enter the ending number.");
            ending = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(!english ? "Listede kaç sayı olsun?" : "How many numbers are on the list?");
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
