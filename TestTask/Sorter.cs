namespace TestTask
{
    public static class Sorter
    {
        public static void BubbleSort(this List<int> array)
        {
            var tmp = 0;
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array.Count - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        tmp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = tmp;
                    }
                }
            }
        }
    }
}
