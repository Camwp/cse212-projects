public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    public static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        int[] result = new int[select.Length];
        int index1 = 0; // Index for list1
        int index2 = 0; // Index for list2

        for (int i = 0; i < select.Length; i++)
        {
            if (select[i] == 1)
            {
                // If the selector is 1, select the next element from list1
                result[i] = list1[index1];
                index1++; // Move to the next element in list1
            }
            else if (select[i] == 2)
            {
                // If the selector is 2, select the next element from list2
                result[i] = list2[index2];
                index2++; // Move to the next element in list2
            }
        }

        return result;
    }
}