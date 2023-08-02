namespace _6A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValidM.IsValid("{{{([)]}}}"));
            Console.WriteLine(IsValidM.IsValid("{}{}{{"));
            Console.WriteLine(IsValidM.IsValid("{<<>>}([)]"));
        }
    }
}