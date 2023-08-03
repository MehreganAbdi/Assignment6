namespace _6B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1,1 , 0,0,4,3 };
            int[] nums2 = { 10,4,7,13,2,4,10 };


            Console.WriteLine(UniqueCounter.CountOfUniques(nums));
            Console.WriteLine(UniqueCounter.CountOfUniques2(nums));


            Console.WriteLine(UniqueCounter.CountOfUniques(nums2));
            Console.WriteLine(UniqueCounter.CountOfUniques2(nums2));



        }
    }
}