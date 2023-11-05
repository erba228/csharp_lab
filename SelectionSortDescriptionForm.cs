using System;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;

namespace algorithms_via_winforms
{
    public partial class SelectionSortDescriptionForm : Form
    {
        public SelectionSortDescriptionForm()
        {
            InitializeComponent();
        }

        private void SelectionSortDescriptionForm_Load(object sender, EventArgs e)
        {
            textBoxDescription.Text = "Сортировка выборкой (Selection Sort) - это простой алгоритм сортировки, " +
                "который находит минимальный элемент в неотсортированной части массива и перемещает его в начало отсортированной части. " +
                "Этот процесс повторяется до тех пор, пока весь массив не будет отсортирован.\r\n\r\n" +
                "Описание алгоритма\r\n" +
                "1. Находим минимальный элемент в неотсортированной части массива.\r\n" +
                "2. Меняем местами найденный минимальный элемент с первым элементом в неотсортированной части.\r\n" +
                "3. Переходим к следующему элементу в неотсортированной части и повторяем шаги 1 и 2.\r\n" +
                "4. Повторяем шаги 1-3 для всего массива, пока не получим отсортированный массив.";

            textBoxDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBoxDescription.ReadOnly = true;
            textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBoxDescription.Dock = DockStyle.Fill;

            
        }
    }
}
