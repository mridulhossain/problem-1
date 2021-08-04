using System;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { -1, -2, -3, -4, -5 };
            int target = -8;
            int[] result = new int[2];
            result = TwoSum(nums,target);
            Console.WriteLine("Output : [" + result[0] + "," + result[1] +"]");
        }


        public static int[] TwoSum( int[] nums, int target)
        {
            int[] output = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {

                if (target == 0)
                {
                   
                    

                    if (nums[i] < 0)
                    {
                        int positive = nums[i] * -1;
                        
                        for (int a = 0; a < nums.Length; a++)
                        {
                            if (i != a &&  nums[a] == positive)
                            {
                                output[0] = i;
                                output[1] = a;
                            }
                        }
                    }
                    else
                    {
                            for (int a = 0; a < nums.Length; a++)
                            {
                                  if(i != a && target == nums[a])
                                  {
                                    output[0] = i;
                                    output[1] = a;
                                  }
                            }
                    }
                }
                else if (target < 0)
                {
                    int positive = nums[i] * -1;
                    int find = target + positive;

                    for (int a = 0; a < nums.Length; a++)
                    {
                        if (i != a && find == nums[a])
                        {

                            output[0] = i;
                            output[1] = a;

                        }
                    }
                }
                else
                {
                    if (nums[i] < target)
                    {
                        int find = target - nums[i];

                        for (int a = 0; a < nums.Length; a++)
                        {
                            if (i != a && find == nums[a])
                            {

                                output[0] = i;
                                output[1] = a;

                            }
                        }
                    }
                }
            }
            Array.Sort(output);
            return output;
        }
    }
}
