namespace algorithms_via_winforms;

partial class PyramidSortDescriptionForm
{
    PictureBox pictureBox = new PictureBox();

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
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(0, 0);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(800, 200);
            this.textBoxDescription.TabIndex = 0;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.StartPosition = FormStartPosition.CenterScreen;

            this.pictureBox.Image = Image.FromFile(@"C:\Users\User\Desktop\algorithms_via_winforms\pyramid_sort.gif"); 
            this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; 
            this.pictureBox.Dock = DockStyle.Bottom; 
            this.pictureBox.Height = 300; 
            this.Controls.Add(pictureBox);
            this.Controls.Add(this.textBoxDescription);
            this.Name = "PyramidSortDescriptionForm";
            this.Text = "Описание алгоритма Pyramid Sort";
            this.Load += new System.EventHandler(this.PyramidSortDescriptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxDescription;
}