using System;
using System.Windows.Forms;

namespace algorithms_via_winforms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void openQuickSortFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Отображение формы для реализации алгоритма QuickSort
            var quickSortForm = new QuickSortForm();
            quickSortForm.Show();
        }

        private void openSelectionSortFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Отображение формы для реализации алгоритма SelectionSort
            var selectionSortForm = new SelectionSortForm();
            selectionSortForm.Show();
        }

        private void openPyramidSortFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Отображение формы для реализации алгоритма PyramidSort
            var pyramidSortForm = new PyramidSortForm();
            pyramidSortForm.Show();
        }

        private void openQuickSortDescriptionFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var quickSortDescriptionForm = new QuickSortDescriptionForm();
            quickSortDescriptionForm.ShowDialog();
        }

        private void openSelectionSortDescriptionFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectionSortDescriptionForm = new SelectionSortDescriptionForm();
            selectionSortDescriptionForm.ShowDialog();
        }

        private void openPyramidSortDescriptionFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pyramidSortDescriptionForm = new PyramidSortDescriptionForm();
            pyramidSortDescriptionForm.ShowDialog();
        }
    }
}
