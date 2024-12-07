namespace ConsoleApp46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userMessage;
            int numbersOfRepeat;

            Console.Write("Напишите любое слово: ");
            userMessage = Console.ReadLine();
            Console.Write("Сколько раз его вывести на экран?: ");
            numbersOfRepeat = Convert.ToInt32(Console.ReadLine());

            while (numbersOfRepeat > 0)
            {
                Console.WriteLine(userMessage);
                numbersOfRepeat--;
            }
        }
    }
}