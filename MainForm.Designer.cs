namespace algorithms_via_winforms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;

            var mainTextLabel = new Label
            {
                Text = "Добро пожаловать, дорогой школьник! Данный тренажер создан для того, чтобы ты и твои друзья могли понять, как работают некоторые виды алгоритмов. Перед собой в верхнем углу экрана ты видишь кнопку 'Алгоритмы'. Кликни по ней и в выпадающем окне тебе будет доступен список алгоритмов, которые ты можешь изучить!",
                Font = new Font("Arial", 12, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Padding = new Padding(20)
            };

            var panel = new Panel();
            panel.BackColor = Color.LightBlue;
            panel.Dock = DockStyle.Top;
            panel.AutoSize = true;
            panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel.Controls.Add(new MenuStrip() { Items = { CreateAlgorithmsMenu(), CreateDescriptionMenu() } });

            this.Controls.Add(panel);
            this.Controls.Add(mainTextLabel);
        }

        private ToolStripMenuItem CreateAlgorithmsMenu()
        {
            var algorithmsMenu = new ToolStripMenuItem("Алгоритмы");
            algorithmsMenu.ForeColor = Color.Black;

            var quickSortMenuItem = new ToolStripMenuItem("Быстрая сортировка (Quick Sort)");
            quickSortMenuItem.Click += openQuickSortFormToolStripMenuItem_Click;
            algorithmsMenu.DropDownItems.Add(quickSortMenuItem);

            var quickSortDescription = "Быстрая сортировка (Quick Sort) - это один из наиболее эффективных алгоритмов сортировки. " +
                "Он использует стратегию 'разделяй и властвуй', разбивая массив на подмассивы, " +
                "сортируя их отдельно и затем объединяя весь массив в отсортированную последовательность.";

            quickSortMenuItem.ToolTipText = quickSortDescription;

            var selectionSortMenuItem = new ToolStripMenuItem("Сортировка выборкой (Selection Sort)");
            selectionSortMenuItem.Click += openSelectionSortFormToolStripMenuItem_Click;
            algorithmsMenu.DropDownItems.Add(selectionSortMenuItem);

            var selectionSortDescription = "Сортировка выборкой (Selection Sort) - это простой алгоритм сортировки, " +
                "который находит минимальный элемент в неотсортированной части массива и перемещает его в начало отсортированной части. " +
                "Этот процесс повторяется до тех пор, пока весь массив не будет отсортирован.";

            selectionSortMenuItem.ToolTipText = selectionSortDescription;

            var pyramidSortMenuItem = new ToolStripMenuItem("Сортировка пирамидой (Pyramid Sort)");
            pyramidSortMenuItem.Click += openPyramidSortFormToolStripMenuItem_Click;
            algorithmsMenu.DropDownItems.Add(pyramidSortMenuItem);

            var pyramidSortDescription = "Сортировка пирамидой (Pyramid Sort) - это алгоритм сортировки, " +
                "который использует структуру данных 'пирамида' для сортировки элементов. " +
                "Он строит пирамиду из элементов массива и последовательно извлекает наименьший элемент, " +
                "перемещая его в конец отсортированной части массива.";

            pyramidSortMenuItem.ToolTipText = pyramidSortDescription;

            algorithmsMenu.Font = new Font("Arial", 12, FontStyle.Bold);

            foreach (ToolStripMenuItem item in algorithmsMenu.DropDownItems)
            {
                item.BackColor = Color.LightBlue;
                item.ForeColor = Color.Black;
                item.Font = new Font("Arial", 10, FontStyle.Regular);
            }

            return algorithmsMenu;
        }

        private ToolStripMenuItem CreateDescriptionMenu()
        {
            var descriptionMenu = new ToolStripMenuItem("Описание");
            descriptionMenu.ForeColor = Color.Black;

            var quickSortMenuItem = new ToolStripMenuItem("Быстрая сортировка (Quick Sort)");
            quickSortMenuItem.Click += openQuickSortDescriptionFormToolStripMenuItem_Click;
            descriptionMenu.DropDownItems.Add(quickSortMenuItem);

            var selectionSortMenuItem = new ToolStripMenuItem("Сортировка выборкой (Selection Sort)");
            selectionSortMenuItem.Click += openSelectionSortDescriptionFormToolStripMenuItem_Click;
            descriptionMenu.DropDownItems.Add(selectionSortMenuItem);

            var pyramidSortMenuItem = new ToolStripMenuItem("Сортировка пирамидой (Pyramid Sort)");
            pyramidSortMenuItem.Click += openPyramidSortDescriptionFormToolStripMenuItem_Click;
            descriptionMenu.DropDownItems.Add(pyramidSortMenuItem);

            descriptionMenu.Font = new Font("Arial", 12, FontStyle.Bold);

            foreach (ToolStripMenuItem item in descriptionMenu.DropDownItems)
            {
                item.BackColor = Color.LightBlue;
                item.ForeColor = Color.Black;
                item.Font = new Font("Arial", 10, FontStyle.Regular);
            }

            return descriptionMenu;
        }

        #endregion
    }
}
