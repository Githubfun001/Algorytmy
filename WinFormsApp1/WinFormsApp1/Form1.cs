using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        private int[] currentNumbers;

        public Form1()
        {
            InitializeComponent();

            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 1000000;
            numericUpDown1.Value = 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int amount = (int)numericUpDown1.Value;

            int minValue = 0;
            int maxValue = 10000;

            currentNumbers = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                currentNumbers[i] = random.Next(minValue, maxValue);
            }

            UpdateLabelOutput();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string[] inputArray = input.Split(',');

            currentNumbers = inputArray.Select(int.Parse).ToArray();

            UpdateLabelOutput();
        }
        private void UpdateLabelOutput()
        {
            int maxDisplay = 15;
            if (currentNumbers.Length <= maxDisplay)
            {
                label2.Text = "Liczby: " + string.Join(", ", currentNumbers);
            }
            else
            {
                label2.Text = "Liczby: " + string.Join(", ", currentNumbers.Take(maxDisplay)) + " ...";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SortAndMeasureTime(BubbleSort, "Bubble Sort");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SortAndMeasureTime(InsertionSort, "Insertion Sort");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            SortAndMeasureTime(MergeSort, "Merge Sort");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            SortAndMeasureTime(CountingSort, "Counting Sort");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            SortAndMeasureTime(QuickSort, "Quick Sort");
        }
        private void SortAndMeasureTime(Func<int[], int[]> sortingAlgorithm, string algorithmName)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            currentNumbers = sortingAlgorithm(currentNumbers);

            stopwatch.Stop();

            UpdateLabelOutput();

            long elapsedTicks = stopwatch.ElapsedTicks;
            double elapsedMilliseconds = (double)elapsedTicks / Stopwatch.Frequency * 1000; // Przeliczenie ticków na ms



            label1.Text = $"{algorithmName} - Czas sortowania: {elapsedMilliseconds:F3} ms"; // Użyj bardziej precyzyjnego wyniku
        }

        private int[] MergeSort(int[] array)
        {
            if (array.Length <= 1)
                return array;

            int mid = array.Length / 2;
            int[] left = array.Take(mid).ToArray();
            int[] right = array.Skip(mid).ToArray();

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        private int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                    result[k++] = left[i++];
                else
                    result[k++] = right[j++];
            }

            while (i < left.Length)
                result[k++] = left[i++];
            while (j < right.Length)
                result[k++] = right[j++];

            return result;
        }
        private int[] BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (array[j] > array[j + 1])
                    {
                        int tempVar = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tempVar;
                    }
            return array;
        }
        private int[] InsertionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
            return array;
        }
        private int[] CountingSort(int[] array)
        {
            int n = array.Length;

            int max = array.Max();

            int[] countArray = new int[max + 1];

            for (int i = 0; i < n; i++)
            {
                countArray[array[i]]++;
            }
            for (int i = 1; i <= max; i++)
            {
                countArray[i] += countArray[i - 1];
            }
            int[] outputArray = new int[n];

            for (int i = n - 1; i >= 0; i--)
            {
                outputArray[countArray[array[i]] - 1] = array[i];
                countArray[array[i]]--;
            }
            return outputArray;
        }
        private int[] QuickSort(int[] array)
        {
            QuickSortStart(array, 0, array.Length - 1);
            return array;
        }

        private void QuickSortStart(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);
                QuickSortStart(array, low, pivotIndex - 1);
                QuickSortStart(array, pivotIndex + 1, high);
            }
        }

        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low;

            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    Swap(array, i, j);
                    i++;
                }
            }
            Swap(array, i, high);
            return i;
        }
        private void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
