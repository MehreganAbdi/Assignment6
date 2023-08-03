using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6B
{
    public static class UniqueCounter
    {
        public static int CountOfUniques(int[] nums)
        {
            Array.Sort(nums);
            int modalVariable = nums[0];
            int counter = 1;

            for(int i = 1; i < nums.Length; i++)
            {
                if(modalVariable != nums[i])
                {
                    counter++;
                    modalVariable = nums[i];
                }
            }
            return counter;
        }





        public static int CountOfUniques2(int[] nums)
        {
            int modalVariable = nums[0];
            int counter = 1;


            if(nums.Length > 0)
            {
                for(int i = 0; i < nums.Length; i++)
                {
                    for (int j =0; j< nums.Length; j++)
                    {
                        if(modalVariable > nums[j])
                        {
                            Swap<int>(ref modalVariable,ref nums[j]);
                        }
                    }
                }

                modalVariable = nums[0];
                foreach (var item in nums)
                {
                    if(modalVariable != item)
                    {
                        modalVariable = item;
                        counter++;
                    }
                }
            }
            else
            {
                counter = 0;
            }
            return counter;
        }




        public static void Swap<T>(ref T x1 ,ref T x2)
        {
            T Z = x1 ;
            x1 = x2 ;
            x2 = Z ;

        } 
    }
}
