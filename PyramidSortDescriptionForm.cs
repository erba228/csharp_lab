using System;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;

namespace algorithms_via_winforms
{
    public partial class PyramidSortDescriptionForm : Form
    {
        public PyramidSortDescriptionForm()
        {
            InitializeComponent();
        }

        private void PyramidSortDescriptionForm_Load(object sender, EventArgs e)
        {
            // Задайте описание алгоритма Quick Sort в текстовом поле.
            textBoxDescription.Text = "Пирамидальная сортировка (HeapSort) — это метод сортировки сравнением, " +
                "основанный на такой структуре данных как двоичная куча. Она похожа на сортировку выбором, " +
                "где мы сначала ищем максимальный элемент и помещаем его в конец. Далее мы повторяем ту же операцию " +
                "для оставшихся элементов.\r\n\r\n" +
                "Что такое двоичная куча?\r\n" +
                "Давайте сначала определим законченное двоичное дерево. Законченное двоичное дерево — это двоичное дерево, " +
                "в котором каждый уровень, за исключением, возможно, последнего, имеет полный набор узлов, " +
                "и все листья расположены как можно левее (Источник Википедия).\r\n\r\n" +
                "Двоичная куча — это законченное двоичное дерево, в котором элементы хранятся в особом порядке: " +
                "значение в родительском узле больше (или меньше) значений в его двух дочерних узлах. " +
                "Первый вариант называется max-heap, а второй — min-heap.";

            // Настройте стили текстового поля
            textBoxDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBoxDescription.ReadOnly = true;
            textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBoxDescription.Dock = DockStyle.Fill;

            
        }
    }
}
