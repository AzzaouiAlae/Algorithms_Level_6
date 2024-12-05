namespace Linear_Search;

class Program
{
    static int linear_Search(int[] arr, int numToFind)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == numToFind)
                return i;
        }
        return -1;
    }
    static void print_result_of_Search(int numToFind, int result)
    {
        if (result != -1)
            Console.WriteLine($"Number {numToFind} found in index {result}");
        else
            Console.WriteLine($"Number {numToFind} not found");
    }
    static void Main(string[] args)
    {
        int [] arr = {64, 34, 25, 12, 22, 11, 90, 0};
        int numToFind = 0;
        int result = linear_Search(arr, numToFind);

        print_result_of_Search(numToFind, result);
    }
}
