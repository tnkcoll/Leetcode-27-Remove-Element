namespace Leetcode_27_Remove_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 3 };
            int val = 3;
            int[] expectedNums = { 0 };
            int k = RemoveElement(nums, val);

            Console.WriteLine(k);
            foreach (int i in nums)
            {
                Console.Write($"{i} ");
            }

            
        }

        static int RemoveElement(int[] nums, int val)
        {
            int i = 0;
            int j = nums.Length - 1;

            int count = nums.Length;


            while (i <= j)
            {
                if (nums[i] != val)
                {
                    i++;
                }
                else if (nums[i] == val && nums[j] != val)
                {
                    nums[i] = 0;
                    SwapElement(nums, i, j);
                    count--;
                    i++;
                    j--;
                }
                else if (nums[i] == val && nums[j] == val)
                {
                    nums[j] = 0;
                    count--;
                    j--;
                }
            }
            
            return count;

        }

        static void SwapElement(int[] ints, int num1, int num2)
        {
            int temp = ints[num1];
            ints[num1] = ints[num2];
            ints[num2] = temp;
        }
    }
}
