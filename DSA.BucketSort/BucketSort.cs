using System.Numerics;

public class BucketSort<T> where T : INumber<T>
{
    private readonly BubbleSort<T> _bubbleSort;

    public BucketSort(BubbleSort<T> bubbleSort)
    {
        _bubbleSort = bubbleSort;
    }
    public List<T>[] Execute(T[] A)
    {
        List<T>[] buckets = new List<T>[10];
        for (int i = 0; i < buckets.Length; i++)
        {
            buckets[i] = new List<T>();
        }

        foreach (var item in A)
        {
            int tens = GetRadix(item, radix: 10);
            buckets[tens].Add(item);
        }

        buckets = _bubbleSort.Execute(buckets);

        return buckets;
    }

    private int GetRadix(T input, int radix)
    {
        dynamic value = input;
        return (int)(value / radix);
    }
}