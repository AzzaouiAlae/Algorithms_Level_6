namespace selection_sort
{
    enum enSort {
        ascending,
        descending
    }
    class Program
    {
        static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
        static void SelectionSort_ascending(int []nums)
        {
            for(int i = 0; i < nums.Length - 1; i++)
            {
                for(int j = i, k = j + 1; k < nums.Length; k++)
                {
                    if(nums[j] > nums[k])
                        j = k;
                    if(k == nums.Length - 1 && nums[i] > nums[j])
                        Swap(ref nums[i], ref nums[j]);
                }
            }
        }
        static void SelectionSort_descending(int []nums)
        {
            for(int i = 0; i < nums.Length - 1; i++)
            {
                for(int j = i, k = j + 1; k < nums.Length; k++)
                {
                    if(nums[j] < nums[k])
                        j = k;
                    if(k == nums.Length - 1 && nums[i] < nums[k])
                        Swap(ref nums[i], ref nums[k]);
                }
            }
        }
        static void SelectionSort(int []nums, enSort sort)
        {
            if(sort == enSort.ascending)
                SelectionSort_ascending(nums);
            else
                SelectionSort_descending(nums);
        }
        static void print_nums(int[] nums)
        {
            for( int i = 0; i < nums.Length; i++)
                Console.Write($"{nums[i]}  ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.Clear();
            int []Arr = {64, 34, 25, 12, 22, 11, 63};

            SelectionSort(Arr, enSort.ascending);
            print_nums(Arr);
        }
    }
}