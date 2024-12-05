namespace Binary_Search;

class Program
{
    static int binasry_search(int []arr, int value)
    {
        int i = 0;
        int start = 0, end = arr.Length, middle;
        while(start != end && start < end)
        {
            middle = ((end - start) / 2) + start;
            if(arr[middle] == value)
                return middle;
            if(arr[middle] > value)
                end = middle;
            if(arr[middle] < value)
                start = middle;
            i++;
            Console.WriteLine(i.ToString());
        } 
        return -1;
    } 
    static void print_result_of_Search(int value, int result)
    {
        if (result != -1)
            Console.WriteLine($"Number {value} found in index {result}");
        else
            Console.WriteLine($"Number {value} not found");
    }
    static void Main(string[] args)
    {
        int []arr = {22,25,37,41,45,46,49,51,55,58,70,80,82,90,95};
        int value = 45;
        int result = binasry_search(arr, value);

        print_result_of_Search(value, result);
    }
}
