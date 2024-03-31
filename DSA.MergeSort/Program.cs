using static DSA.Common.Utilities.ArrayHelper;

int[] A = GenerateRandomArray<int>(min: -10);
int[] SortedA = new int[A.Length];

PrintArray(A);

SortedA = MergeSort(A);

PrintArray(SortedA);

int[] MergeSort(int[] inputArray)
{
    int mid = inputArray.Length / 2;

    int[] rightHalfArray = new int[mid];
    int[] leftHalfArray = new int[inputArray.Length - mid];

    int[] SortedinputArray = new int[inputArray.Length];

    switch (inputArray.Length)
    {
        case 1:
            return inputArray;
        case 2:
            if (inputArray[0] > inputArray[1])
            {
                (inputArray[0], inputArray[1]) = (inputArray[1], inputArray[0]);
                return inputArray;
            }
            return inputArray;
        default:

            rightHalfArray = MergeSort(inputArray[..mid]);
            leftHalfArray = MergeSort(inputArray[mid..]);

            int i = 0 , j = 0;
            int sortCounter = 0;

            while (i < rightHalfArray.Length && j < leftHalfArray.Length)
            {
                if (rightHalfArray[i] <= leftHalfArray[j])
                {
                    SortedinputArray[sortCounter] = rightHalfArray[i];
                    i++;
                    sortCounter++;
                } else
                {
                    SortedinputArray[sortCounter] = leftHalfArray[j];
                    j++;
                    sortCounter++;
                }
            }

            //Merge Array
            while (i < rightHalfArray.Length)
            {
                SortedinputArray[sortCounter] = rightHalfArray[i];
                i++;
                sortCounter++;
            }
            while (j < leftHalfArray.Length)
            {
                SortedinputArray[sortCounter] = leftHalfArray[j];
                j++;
                sortCounter++;
            }
            break;
    }

    return SortedinputArray;
}