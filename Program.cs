namespace Codewars_sum_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            Console.WriteLine(Kata.sumStrings(s1, s2));
            Console.ReadKey();
        }
    }
}