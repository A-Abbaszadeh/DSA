using static DSA.Common.Utilities.ArrayHelper;

int[] A = GenerateRandomArray<int>(isRepeat: true);
PrintArray(A);

// Find max in A
int max = A[0];
foreach (var item in A)
{
    if (item > max)
        max = item;
}

// Count the values of A cells
int[] counter = new int[max + 1];
foreach (var item in A)
{
    counter[item]++;
}

PrintArray(counter);

//Sort A
int index = 0;
for (int i = 0; i < max + 1; i++)
{
    while (counter[i] > 0)
    {
        A[index] = i;
        index++;
        counter[i]--;
    }
}

PrintArray(A);