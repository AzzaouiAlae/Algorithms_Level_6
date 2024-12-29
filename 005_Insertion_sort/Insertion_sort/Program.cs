namespace Insertion_sort;

class Program
{
    static void print_nums(int[] nums)
    {
        for( int i = 0; i < nums.Length; i++)
            Console.Write($"{nums[i]}  ");
        Console.WriteLine();
    }
    static void insertion_sort(int []nums)
    {
        int key; 
        for(int i = 1, j; i < nums.Length; i++)
        {
            key = nums[i];
            for(j = i  - 1; j >= 0 && key < nums[j]; j--)
            {
                nums[j + 1] = nums[j];

                if(!(j-1 >= 0 && key < nums[j - 1]))
                    nums[j] = key;
            }
        }
    }
    static void Main(string[] args)
    {
        Console.Clear();
        int []Arr = {9, 2, 8, 6, 7, 12, 5, 13, 4, 14, 10,11, 3};
        int []Arr2 = {64, 34, 25, 12, 22, 11, 63};
        insertion_sort(Arr);
        print_nums(Arr);
    }

}
