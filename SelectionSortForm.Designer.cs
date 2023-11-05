namespace algorithms_via_winforms
{
    partial class SelectionSortForm
    {
        private TextBox textBoxSortedArray; 
        private TextBox textBoxUnsortedArray;
        private Button buttonSort;
        private Label labelUnsortedArray;
        private Label labelSortedArray;
        private Label labelIteration;  // Add this line
        private ListBox listBoxIterations;
        private TextBox textBoxArraySize; // Add a TextBox for array size
        private Button buttonGenerate;

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
            this.textBoxUnsortedArray = new TextBox();
            this.textBoxSortedArray = new TextBox();
            this.buttonSort = new Button();
            this.labelUnsortedArray = new Label();
            this.labelSortedArray = new Label();
            this.labelIteration = new Label();
            this.listBoxIterations = new ListBox();
            this.textBoxArraySize = new TextBox();
            this.buttonGenerate = new Button();

            this.SuspendLayout();

            this.labelUnsortedArray.AutoSize = true;
            this.labelUnsortedArray.Location = new System.Drawing.Point(70, 20);
            this.labelUnsortedArray.Text = "Исходный массив:";

            this.labelSortedArray.AutoSize = true;
            this.labelSortedArray.Location = new System.Drawing.Point(70, 110);
            this.labelSortedArray.Text = "Отсортированный массив:";

            this.textBoxUnsortedArray.Location = new System.Drawing.Point(70, 50);
            this.textBoxUnsortedArray.Size = new System.Drawing.Size(300, 50);
            this.textBoxUnsortedArray.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Regular);

            this.textBoxSortedArray.Location = new System.Drawing.Point(70, 140);
            this.textBoxSortedArray.Size = new System.Drawing.Size(300, 50);
            this.textBoxSortedArray.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Regular);
            
            this.buttonSort.Location = new System.Drawing.Point(630, 20);
            this.buttonSort.Size = new System.Drawing.Size(150, 50);
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.BackColor = System.Drawing.Color.LightBlue;

            this.labelIteration.AutoSize = true;
            this.labelIteration.Location = new System.Drawing.Point(70, 200);        this.labelIteration.Text = "Итерации:"; // Initial iteration label
            this.labelIteration.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Regular);

            this.listBoxIterations.Location = new System.Drawing.Point(70, 230);
            this.listBoxIterations.Size = new System.Drawing.Size(610, 100);
            this.listBoxIterations.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Regular);
            this.textBoxArraySize.Location = new System.Drawing.Point(70, 340);
            this.textBoxArraySize.Size = new System.Drawing.Size(150, 20);
            this.textBoxArraySize.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);

            this.buttonGenerate.Location = new System.Drawing.Point(230, 335);
            this.buttonGenerate.Size = new System.Drawing.Size(120, 30);
            this.buttonGenerate.Text = "Сгенерировать";
            this.buttonGenerate.BackColor = System.Drawing.Color.LightBlue;
            this.buttonGenerate.Click += new EventHandler(this.buttonGenerate_Click);
            this.buttonSort.Click += new EventHandler(this.buttonSort_Click);

            this.ClientSize = new System.Drawing.Size(790, 500); // Adjust the form size

            this.Text = "Сортировка выборкой (Selection Sort)";
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(557, 355);

            this.Controls.Add(this.labelUnsortedArray);
            this.Controls.Add(this.textBoxUnsortedArray);
            this.Controls.Add(this.labelSortedArray);
            this.Controls.Add(this.textBoxSortedArray);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.labelIteration); // Add the iteration label
            this.Controls.Add(this.listBoxIterations);
            this.Controls.Add(this.textBoxArraySize);
            this.Controls.Add(this.buttonGenerate);

            this.ResumeLayout(false);
        }

        #endregion
    }
}
