using static DSA.Common.Utilities.ArrayHelper;

int[] A = GenerateRandomArray<int>(min: -10);
PrintArray(A);


for (int i = 0; i < A.Length; i++)
{
    int minIndex = i;
    for (int j = i + 1; j < A.Length; j++)
    {
        if (A[minIndex] > A[j])
        {
            minIndex = j;
        }
    }

    (A[i], A[minIndex]) = (A[minIndex], A[i]);

    PrintArray(A, i);
}