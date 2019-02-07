namespace Sort
{
    public class BubbleSort : ISort
    {
        public void Sort(ref int[] data)
        {
            int length = data.Length;
            int temp = 0;

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - (i + 1); j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }
        }
    }
}
