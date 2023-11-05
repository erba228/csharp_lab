using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace algorithms_via_winforms;
public partial class QuickSortForm : Form
{
    private List<int[]> iterationsList;
    public QuickSortForm()
    {
        InitializeComponent();
        iterationsList = new List<int[]>();
    }

    private void buttonSort_Click(object sender, EventArgs e)
    {
        int[] array = ParseArray(textBoxUnsortedArray.Text);

        if (array == null)
        {
            MessageBox.Show("Пожалуйста, введите массив для сортировки.");
            return;
        }

        listBoxIterations.Items.Clear(); // Clear the listBoxIterations before sorting

        iterationsList.Clear();
        int[] copyArray = (int[])array.Clone(); // Create a copy of the array

        // Measure the sorting time
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        QuickSortWithIterations(copyArray, 0, copyArray.Length - 1);

        stopwatch.Stop();

        // Calculate the elapsed time
        TimeSpan timeElapsed = stopwatch.Elapsed;

        textBoxSortedArray.Text = string.Join(", ", copyArray);

        // Update the listbox with the iterations
        for (int i = 0; i < iterationsList.Count; i++)
        {
            UpdateListBox(iterationsList[i], i);
        }

        // Show the time taken in the iterations list
        listBoxIterations.Items.Add($"Время сортировки: {timeElapsed.TotalMilliseconds} мс");
    }

    private int[] ParseArray(string input)
    {
        string[] stringArray = input.Split(',');
        int[] array;

        try
        {
            array = Array.ConvertAll(stringArray, s => int.Parse(s.Trim()));
        }
        catch (Exception)
        {
            return null;
        }

        return array;
    }

    private void buttonGenerate_Click(object sender, EventArgs e)
    {
        if (int.TryParse(textBoxArraySize.Text, out int arraySize))
        {
            int[] array = GenerateRandomArray(arraySize);
            textBoxUnsortedArray.Text = string.Join(", ", array);
        }
        else
        {
            MessageBox.Show("Пожалуйста, введите целое число для размера массива.");
        }
    }

    private int[] GenerateRandomArray(int size)
    {
        int[] array = new int[size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 100); // Generate random numbers between 1 and 100
        }

        return array;
    }

    private static void QuickSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(array, left, right);
            QuickSort(array, left, pivot - 1);
            QuickSort(array, pivot + 1, right);
        }
    }

    private static int Partition(int[] array, int left, int right)
    {
        int pivot = array[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                Swap(ref array[i], ref array[j]);
            }
        }

        Swap(ref array[i + 1], ref array[right]);
        return i + 1;
    }

    private void QuickSortWithIterations(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivot = PartitionWithIterations(array, left, right);
            iterationsList.Add((int[])array.Clone()); // Add a copy of the array to the list
            QuickSortWithIterations(array, left, pivot - 1);
            QuickSortWithIterations(array, pivot + 1, right);
        }
    }

    private int PartitionWithIterations(int[] array, int left, int right)
    {
        int pivot = array[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                Swap(ref array[i], ref array[j]);
            }
        }

        Swap(ref array[i + 1], ref array[right]);
        return i + 1;
    }

    private void UpdateListBox(int[] array, int iteration)
    {
        listBoxIterations.Items.Add($"Итерация {iteration + 1}: {string.Join(", ", array)}");
    }

    private static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}

