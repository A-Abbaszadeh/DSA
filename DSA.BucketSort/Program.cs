using static DSA.Common.Utilities.ArrayHelper;

var A = GenerateRandomArray<int>(min:10, max: 99, length:10);

PrintArray(A);

var buckets = new BucketSort<int>
                        (new BubbleSort<int>())
                        .Execute(A);

PrintArray(buckets);