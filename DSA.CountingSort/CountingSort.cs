public class CountingSort
{
    public (int[], int[]) Execute(int[] inputArray)
    {
        // Find max in A
        int max = inputArray[0];
        foreach (var item in inputArray)
        {
            if (item > max)
                max = item;
        }

        // Count the values of inputArray cells
        int[] counterArray = new int[max + 1];
        int[] backupCounterArray = new int[max + 1];
        foreach (var item in inputArray)
        {
            counterArray[item]++;
        }

        counterArray.CopyTo(backupCounterArray, 0);

        //Sort A
        int index = 0;
        for (int i = 0; i < max + 1; i++)
        {
            while (counterArray[i] > 0)
            {
                inputArray[index] = i;
                index++;
                counterArray[i]--;
            }
        }

        return (inputArray, backupCounterArray);
    }
}