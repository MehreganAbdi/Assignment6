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
    }
}
