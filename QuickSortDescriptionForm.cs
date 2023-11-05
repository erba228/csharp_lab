using System;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;

namespace algorithms_via_winforms
{
    public partial class QuickSortDescriptionForm : Form
    {
        public QuickSortDescriptionForm()
        {
            InitializeComponent();
        }

        private void QuickSortDescriptionForm_Load(object sender, EventArgs e)
        {
            // Задайте описание алгоритма Quick Sort в текстовом поле.
            textBoxDescription.Text = "Быстрая сортировка (Quick Sort) - это один из наиболее эффективных алгоритмов сортировки. " +
                "Он использует стратегию 'разделяй и властвуй', разбивая массив на подмассивы, " +
                "сортируя их отдельно и затем объединяя весь массив в отсортированную последовательность.\r\n\r\n" +
                "Алгоритм быстрой сортировки является рекурсивным, поэтому для простоты процедура на вход будет " +
                "принимать границы участка массива от l включительно и до r не включительно. Понятно, что " +
                "для того, чтобы отсортировать весь массив, в качестве параметра l надо передать 0, " +
                "а в качестве r — n, где по традиции n обозначает длину массива.\r\n\r\n" +
                "В основе алгоритма быстрой сортировки лежит процедура partition. Partition выбирает некоторый " +
                "элемент массива и переставляет элементы участка массива таким образом, чтобы массив " +
                "разбился на 2 части: левая часть содержит элементы, которые меньше этого элемента, " +
                "а правая часть содержит элементы, которые больше или равны этого элемента. " +
                "Такой разделяющий элемент называется пивотом.";

            // Настройте стили текстового поля
            textBoxDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBoxDescription.ReadOnly = true;
            textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBoxDescription.Dock = DockStyle.Fill;

            
        }
    }
}
