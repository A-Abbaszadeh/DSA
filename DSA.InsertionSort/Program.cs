using DSA.Common.Utilities;
using static DSA.Common.Utilities.ArrayHelper;

var A = GenerateRandomArray<int>(min: -10);
Console.Write("Array A = ");
PrintArray(A);

A = new InsertionSort<int>().Execute(A);

Console.Write("Sorted = ");
PrintArray(A);