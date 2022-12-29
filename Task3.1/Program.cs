namespace Task3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); 
            int count = (int)Math.Log10(number) + 1;
            if (count == 5)
            {
                int result = (400000 + number) * 10 + 2;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("5 reqemli olalidir");
            }
                

        }
    }
}