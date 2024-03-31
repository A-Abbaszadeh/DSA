using static DSA.Common.Utilities.ArrayHelper;

int[] A = GenerateRandomArray<int>(min:-10);
Console.Write("A = ");
PrintArray(A);
int key;
int j;
for (int i = 1; i < A.Length; i++)
{
    key = A[i];
    j = i - 1;
    while (j >= 0 && A[j] > key)
    {
        A[j + 1] = A[j];  // Shift to right
        j = j - 1;
    }
    A[j + 1] = key;
    PrintArray(A,i);
}
Console.Write("Sorted = ");
PrintArray(A);