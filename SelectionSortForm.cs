using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace algorithms_via_winforms;
public partial class SelectionSortForm : Form
{
    private int iterationCounter;

    public SelectionSortForm()
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
        
        listBoxIterations.Items.Clear();
        iterationCounter = 0;

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        SelectionSort(array);
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

    private void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                Swap(ref array[i], ref array[minIndex]);
                UpdateListBox(array); // Add this line
            }
        }
    }

    private void UpdateListBox(int[] array)
    {
        iterationCounter++;
        listBoxIterations.Items.Add($"Итерация {iterationCounter}: {string.Join(", ", array)}");
    }

    private static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}

