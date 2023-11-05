using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace algorithms_via_winforms;
public partial class AnalyzeForm : Form
{
    private int iterationCounter;

    public AnalyzeForm()
    {
        InitializeComponent();
    }

    private void buttonSort_Click(object sender, EventArgs e)
    {
        int[] array = ParseArray(textBoxUnsortedArray.Text);

        if (array == null)
        {
            MessageBox.Show("Пожалуйста, введите массив для сортировки.");
            return;
        }

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        PyramidSort(array);
        stopwatch.Stop();

        // Calculate the elapsed time
        TimeSpan timeElapsed = stopwatch.Elapsed;

        // Show the time taken in the iterations list
        listBoxIterations.Items.Add($"Время сортировки: {timeElapsed.TotalMilliseconds} мс");

        textBoxSortedArray.Text = string.Join(", ", array);
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

    private static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    private void PyramidSort(int[] array)
    {
        int n = array.Length;

        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(array, n, i);
            UpdateListBox(array); 
        }

        for (int i = n - 1; i > 0; i--)
        {
            Swap(ref array[0], ref array[i]);
            Heapify(array, i, 0);
            UpdateListBox(array);
        }
    }

    private void Heapify(int[] array, int n, int i)
    {
        int largest = i;
        int l = 2 * i + 1;
        int r = 2 * i + 2;

        if (l < n && array[l] > array[largest])
            largest = l;

        if (r < n && array[r] > array[largest])
            largest = r;

        if (largest != i)
        {
            Swap(ref array[i], ref array[largest]);
            Heapify(array, n, largest);
            UpdateListBox(array);
        }
    }

    private void UpdateListBox(int[] array)
    {
        iterationCounter++;
        listBoxIterations.Items.Add($"Итерация {iterationCounter}: {string.Join(", ", array)}");
    }
}