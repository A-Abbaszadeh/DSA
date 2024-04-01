using static DSA.Common.Utilities.ArrayHelper;

public class InsertionSort<T>
{
    public T[] Execute(T[] inputArray, bool isShowStep)
    {
        dynamic key;
        int j;
        for (int i = 1; i < inputArray.Length; i++)
        {
            key = inputArray[i];
            j = i - 1;
            while (j >= 0 && inputArray[j] > key)
            {
                inputArray[j + 1] = inputArray[j];  // Shift to right
                j = j - 1;
            }
            inputArray[j + 1] = key;

            if (isShowStep) PrintArray(inputArray, i);
        }

        return inputArray;
    }

    public T[] Execute(T[] inputArray)
    {
        return Execute(inputArray, true);
    }
}