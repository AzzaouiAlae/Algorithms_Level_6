using System.Security.Cryptography;

class clsSortedSet
{
    static public void start()
    {
        SortedSet<int> sortedSet = new();

        sortedSet.Add(5);
        sortedSet.Add(2);
        sortedSet.Add(8);
        sortedSet.Add(3);

        Console.WriteLine("SortedSet elements:");
        foreach (int i in sortedSet)
            Console.WriteLine($"{i} ");

        int target = 3;
        if(sortedSet.Contains(target))
            Console.WriteLine($"\nNumber {target} exists in the sortedSet");
        
        Console.WriteLine("\nSortedSet elements:");
        sortedSet.Remove(target);
        foreach (int i in sortedSet)
            Console.WriteLine($"{i} ");
    }
    static public void LINQ1()
    {
        SortedSet<int> sortedSet = new SortedSet<int>() {1, 2, 3, 4, 5, 6};

        var filterdSet = sortedSet.Where(x => x > 2);
        Console.WriteLine("Filtered Set:"); 
        foreach(var item in filterdSet)
            Console.Write(item + " ");
        Console.WriteLine();
        var sum = sortedSet.Sum(x => x);
        Console.WriteLine(sum);
        Console.WriteLine($"Max value in sortedSet {sortedSet.Max(x => x)}");
        Console.WriteLine($"Min value in sortedSet {sortedSet.Min(x => x)}");
        Console.WriteLine($"Avg VAlue in sortedSet {sortedSet.Average()}");

        Console.WriteLine($"SotedSet is desc order {string.Join(", ", sortedSet.OrderByDescending(x => x))}");
    }
    static public void LINQ2()
    {
        SortedSet<int> nums = new SortedSet<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        var evenNumberSquared = nums.Where(x => x % 2 == 0).Select(x => x * x);
        Console.WriteLine("Squares of even numers:");
        foreach (var item in evenNumberSquared)
            Console.Write(item + " ");
        Console.WriteLine();
    }
    static public void union_intersection_Difference_subset_superset_ops()
    {
        SortedSet<int> set1 = new SortedSet<int>() {1, 2, 3, 4, 5};
        SortedSet<int> set2 = new SortedSet<int>() {3, 4, 5, 6, 7};

        SortedSet<int> unionSet = new (set1);
        unionSet.UnionWith(set2);
        Console.WriteLine("Union:" + string.Join(", ", unionSet));
        
        SortedSet<int> intersectset = new(set1);
        intersectset.IntersectWith(set2);
        Console.WriteLine("\nIntersection: " + string.Join(", ", intersectset));

        SortedSet<int> differenceSet = new(set1);
        differenceSet.ExceptWith(set2);
        Console.WriteLine("\nDifference (set1 - set 2):  " + string.Join(", ", differenceSet));

        
        if(set1.IsSubsetOf(set2))
        Console.WriteLine("\nSet1 is a subset of Set2");
        else
        Console.WriteLine("\nset1 is not subset of set2");

        if(set1.IsSupersetOf(set2))
            Console.WriteLine("\nSet1 is a superset of set2");
        else
        Console.WriteLine("\nSet1 is not a ssuperset of set2");
    }
    static public void Comparing_sortedSets_including_equality_subset_superset()
    {
        SortedSet<int> set1 = new SortedSet<int>{1, 2, 3, 4, 5};
        SortedSet<int> set2 = new SortedSet<int>{3, 4, 5, 6, 7};

        bool areEqual = set1.SetEquals(set2);
        Console.WriteLine("Are set1 and set2 equal? " + areEqual);

        

    }
}