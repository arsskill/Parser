
namespace Perser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListTitles = new System.Windows.Forms.ListBox();
            this.StartPoint = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.EndPoint = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Abort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // ListTitles
            // 
            this.ListTitles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListTitles.FormattingEnabled = true;
            this.ListTitles.ItemHeight = 20;
            this.ListTitles.Location = new System.Drawing.Point(28, 23);
            this.ListTitles.Name = "ListTitles";
            this.ListTitles.Size = new System.Drawing.Size(296, 404);
            this.ListTitles.TabIndex = 0;
            // 
            // StartPoint
            // 
            this.StartPoint.AutoSize = true;
            this.StartPoint.Location = new System.Drawing.Point(365, 23);
            this.StartPoint.Name = "StartPoint";
            this.StartPoint.Size = new System.Drawing.Size(73, 20);
            this.StartPoint.TabIndex = 1;
            this.StartPoint.Text = "StartPoint";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(365, 58);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(365, 152);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // EndPoint
            // 
            this.EndPoint.AutoSize = true;
            this.EndPoint.Location = new System.Drawing.Point(365, 117);
            this.EndPoint.Name = "EndPoint";
            this.EndPoint.Size = new System.Drawing.Size(67, 20);
            this.EndPoint.TabIndex = 3;
            this.EndPoint.Text = "EndPoint";
            this.EndPoint.Click += new System.EventHandler(this.label2_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(365, 222);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(155, 29);
            this.Start.TabIndex = 5;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            // 
            // Abort
            // 
            this.Abort.Location = new System.Drawing.Point(365, 286);
            this.Abort.Name = "Abort";
            this.Abort.Size = new System.Drawing.Size(155, 29);
            this.Abort.TabIndex = 6;
            this.Abort.Text = "Abort";
            this.Abort.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Abort);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.EndPoint);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.StartPoint);
            this.Controls.Add(this.ListTitles);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListTitles;
        private System.Windows.Forms.Label StartPoint;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label EndPoint;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Abort;
    }
}

