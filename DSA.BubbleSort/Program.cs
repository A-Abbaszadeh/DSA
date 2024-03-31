using static DSA.Common.Utilities.ArrayHelper;

var A = GenerateRandomArray<float>(min: -10);

PrintArray(A);

A = new BubbleSort<float>().Execute(A);

PrintArray(A);