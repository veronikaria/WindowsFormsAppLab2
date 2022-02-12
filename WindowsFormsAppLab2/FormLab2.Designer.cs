
namespace WindowsFormsAppLab2
{
    partial class FormLab2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLab2));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.labelXn = new System.Windows.Forms.Label();
            this.labelXk = new System.Windows.Forms.Label();
            this.labelXh = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.textBoxXn = new System.Windows.Forms.TextBox();
            this.textBoxXk = new System.Windows.Forms.TextBox();
            this.textBoxXh = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonCalc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.textBoxA);
            this.groupBoxInput.Controls.Add(this.textBoxXh);
            this.groupBoxInput.Controls.Add(this.textBoxXk);
            this.groupBoxInput.Controls.Add(this.textBoxXn);
            this.groupBoxInput.Controls.Add(this.labelA);
            this.groupBoxInput.Controls.Add(this.labelXh);
            this.groupBoxInput.Controls.Add(this.labelXk);
            this.groupBoxInput.Controls.Add(this.labelXn);
            this.groupBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInput.Location = new System.Drawing.Point(410, 26);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(375, 217);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввід даних";
            // 
            // labelXn
            // 
            this.labelXn.AutoSize = true;
            this.labelXn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelXn.Location = new System.Drawing.Point(7, 35);
            this.labelXn.Name = "labelXn";
            this.labelXn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelXn.Size = new System.Drawing.Size(173, 17);
            this.labelXn.TabIndex = 0;
            this.labelXn.Text = "Початкове значення Xn";
            // 
            // labelXk
            // 
            this.labelXk.AutoSize = true;
            this.labelXk.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelXk.Location = new System.Drawing.Point(28, 78);
            this.labelXk.Name = "labelXk";
            this.labelXk.Size = new System.Drawing.Size(155, 17);
            this.labelXk.TabIndex = 1;
            this.labelXk.Text = "Кінцеве значення Xk";
            // 
            // labelXh
            // 
            this.labelXh.AutoSize = true;
            this.labelXh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelXh.Location = new System.Drawing.Point(39, 125);
            this.labelXh.Name = "labelXh";
            this.labelXh.Size = new System.Drawing.Size(140, 17);
            this.labelXh.TabIndex = 2;
            this.labelXh.Text = "Значення кроку Xh";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(93, 175);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(88, 17);
            this.labelA.TabIndex = 3;
            this.labelA.Text = "Значення А";
            // 
            // textBoxXn
            // 
            this.textBoxXn.Location = new System.Drawing.Point(191, 32);
            this.textBoxXn.Name = "textBoxXn";
            this.textBoxXn.Size = new System.Drawing.Size(164, 24);
            this.textBoxXn.TabIndex = 4;
            // 
            // textBoxXk
            // 
            this.textBoxXk.Location = new System.Drawing.Point(191, 75);
            this.textBoxXk.Name = "textBoxXk";
            this.textBoxXk.Size = new System.Drawing.Size(164, 24);
            this.textBoxXk.TabIndex = 5;
            // 
            // textBoxXh
            // 
            this.textBoxXh.Location = new System.Drawing.Point(191, 123);
            this.textBoxXh.Name = "textBoxXh";
            this.textBoxXh.Size = new System.Drawing.Size(164, 24);
            this.textBoxXh.TabIndex = 6;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(191, 172);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(164, 24);
            this.textBoxA.TabIndex = 7;
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnY});
            this.dg.Location = new System.Drawing.Point(25, 276);
            this.dg.Name = "dg";
            this.dg.RowHeadersWidth = 51;
            this.dg.RowTemplate.Height = 24;
            this.dg.Size = new System.Drawing.Size(353, 361);
            this.dg.TabIndex = 2;
            // 
            // ColumnX
            // 
            this.ColumnX.HeaderText = "X";
            this.ColumnX.MinimumWidth = 6;
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.Width = 125;
            // 
            // ColumnY
            // 
            this.ColumnY.HeaderText = "Y";
            this.ColumnY.MinimumWidth = 6;
            this.ColumnY.Name = "ColumnY";
            this.ColumnY.Width = 125;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(423, 276);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(582, 361);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalc.Location = new System.Drawing.Point(800, 171);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(261, 72);
            this.buttonCalc.TabIndex = 4;
            this.buttonCalc.Text = "Обрахунок значень та побудова графіка";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // FormLab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 675);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormLab2";
            this.Text = "Lab2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxXh;
        private System.Windows.Forms.TextBox textBoxXk;
        private System.Windows.Forms.TextBox textBoxXn;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelXh;
        private System.Windows.Forms.Label labelXk;
        private System.Windows.Forms.Label labelXn;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnY;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonCalc;
    }
}

