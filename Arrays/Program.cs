namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 1. Deklarera
            //int[] scores;

            //// 2. Skapa
            //scores = new int[10];

            int[] numbers = new int[4];
            numbers[0] = 1;
            numbers[1] = 3;
            numbers[2] = 45;
            numbers[3] = 5;

            Console.WriteLine(numbers[2]);
            Console.ReadLine();
        }
    }
}