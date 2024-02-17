using System;

namespace SortingAppYouSource
{
    class StringSorter
    {
        public string BubbleSort(string input)
        {
            // Convert string to char array for sorting
            char[] charArray = input.ToCharArray();

            // Perform BubbleSort
            for (int i = 0; i < charArray.Length - 1; i++)
            {
                for (int j = 0; j < charArray.Length - 1 - i; j++)
                {
                    if (charArray[j] > charArray[j + 1])
                    {
                        // Swap characters
                        char temp = charArray[j];
                        charArray[j] = charArray[j + 1];
                        charArray[j + 1] = temp;
                    }
                }
            }

            // Convert sorted char array back to string
            return new string(charArray);
        }

        public string QuickSort(string input)
        {
            // Convert string to char array for sorting
            char[] charArray = input.ToCharArray();

            // Perform QuickSort
            QuickSortHelper(charArray, 0, charArray.Length - 1);

            // Convert sorted char array back to string
            return new string(charArray);
        }

        private void QuickSortHelper(char[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(arr, left, right);
                QuickSortHelper(arr, left, pivotIndex - 1);
                QuickSortHelper(arr, pivotIndex + 1, right);
            }
        }

        private int Partition(char[] arr, int left, int right)
        {
            char pivot = arr[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    // Swap characters
                    char temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // Swap characters
            char temp2 = arr[i + 1];
            arr[i + 1] = arr[right];
            arr[right] = temp2;

            return i + 1;
        }

        public string MergeSort(string input)
        {
            // Convert string to char array for sorting
            char[] charArray = input.ToCharArray();

            // Perform MergeSort
            MergeSortHelper(charArray, 0, charArray.Length - 1);

            // Convert sorted char array back to string
            return new string(charArray);
        }

        private void MergeSortHelper(char[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSortHelper(arr, left, mid);
                MergeSortHelper(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        private void Merge(char[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            char[] L = new char[n1];
            char[] R = new char[n2];

            Array.Copy(arr, left, L, 0, n1);
            Array.Copy(arr, mid + 1, R, 0, n2);

            int i = 0, j = 0, k = left;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
    }
}
