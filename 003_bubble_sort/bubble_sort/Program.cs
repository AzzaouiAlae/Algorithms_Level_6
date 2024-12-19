namespace bubble_sort;

class Program
{
    static void swap(ref int num1, ref int num2)
    {
        int temp;

        temp = num1;
        num1 = num2;
        num2 = temp;
    }
    
    static void buble_sort(int []Nums)
    {
        for(int j = 0; j < Nums.Length; j++)
        {
            for(int i = 1; i < Nums.Length - j; i++)
            {
                if( Nums[i -1] > Nums[i])
                    swap(ref Nums[i -1], ref Nums[i]);
            }
        }
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
        int []arr = {34, 64, 25, 12, 22, 11, 90};
        buble_sort(arr);
        print_nums(arr);
    }
}
