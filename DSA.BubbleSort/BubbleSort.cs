using static DSA.Common.Utilities.ArrayHelper;

public class BubbleSort<T> where T : IComparable<T>
{
    public T[] Execute(T[] inputArray, bool isPrintSteps)
    {
        bool swapFlag = false;

        for (int i = 0; i < inputArray.Length; i++)
        {
            for (int j = inputArray.Length - 1; j > i; j--)
            {
                if (inputArray[j].CompareTo(inputArray[j - 1]) < 0) // (A[j] < A[j - 1])
                {
                    (inputArray[j], inputArray[j - 1]) = (inputArray[j - 1], inputArray[j]); //swap a bubble
                    swapFlag = true;
                }
               
                if (isPrintSteps) PrintArray(inputArray, j);
            }
            if (isPrintSteps) Console.WriteLine($"Count = {i}");

            if (!swapFlag)
            {
                break;
            }
            swapFlag = false;
        }

        return inputArray;
    }

    public T[] Execute(T[] inputArray)
    {
        return Execute(inputArray, false);
    }    
    public List<T>[] Execute(List<T>[] inputArray)
    {
        for (int i = 0; i < inputArray.Length; i++)
        {
            inputArray[i] = this.Execute(inputArray[i].ToArray())
                                .ToList();
        }

        return inputArray;
    }
}