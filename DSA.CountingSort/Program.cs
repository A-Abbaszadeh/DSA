using static DSA.Common.Utilities.ArrayHelper;

int[] A = GenerateRandomArray<int>(isRepeat: true);

PrintArray(A);

(A, int[] counterArray) = new CountingSort().Execute(A);

PrintArray(counterArray);
PrintArray(A);