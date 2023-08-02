namespace _6A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Examples:
            string str1 = "()[]{}";
            string str2 = "()[({})]";
            string str3 = "{{{(}}}";

            char[] array1 = str1.ToCharArray();
            char[] array2 = str2.ToCharArray();
            char[] array3 = str3.ToCharArray();
//$"{str1} : {IsValidM.IsValid(array1)} \n" +
            Console.WriteLine(
                $"{str2} : {IsValidM.IsValid(array2)}\n"+
                $"{str3} : {IsValidM.IsValid(array3)}");



        }
    }
}