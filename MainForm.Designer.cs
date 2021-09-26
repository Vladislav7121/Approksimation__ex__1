
namespace WindowsFormsApp1222
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LinearCheckBox = new System.Windows.Forms.CheckBox();
            this.PiecewiseCheckBox = new System.Windows.Forms.CheckBox();
            this.RemovePointButton = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CreateChart = new System.Windows.Forms.Button();
            this.YSize = new System.Windows.Forms.TextBox();
            this.XSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MNKCheckBox = new System.Windows.Forms.CheckBox();
            this.Degree = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Table = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.СправкаtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.О_ПрограммеtoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ВыходtoolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LinearCheckBox
            // 
            this.LinearCheckBox.AutoSize = true;
            this.LinearCheckBox.Location = new System.Drawing.Point(56, 668);
            this.LinearCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LinearCheckBox.Name = "LinearCheckBox";
            this.LinearCheckBox.Size = new System.Drawing.Size(223, 24);
            this.LinearCheckBox.TabIndex = 1;
            this.LinearCheckBox.Text = "Линейная интерполяция";
            this.LinearCheckBox.UseVisualStyleBackColor = true;
            this.LinearCheckBox.CheckedChanged += new System.EventHandler(this.LinearCheckBox_CheckedChanged);
            // 
            // PiecewiseCheckBox
            // 
            this.PiecewiseCheckBox.AutoSize = true;
            this.PiecewiseCheckBox.Location = new System.Drawing.Point(56, 703);
            this.PiecewiseCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PiecewiseCheckBox.Name = "PiecewiseCheckBox";
            this.PiecewiseCheckBox.Size = new System.Drawing.Size(303, 24);
            this.PiecewiseCheckBox.TabIndex = 2;
            this.PiecewiseCheckBox.Text = "Кусочно-постоянная интерполяция";
            this.PiecewiseCheckBox.UseVisualStyleBackColor = true;
            this.PiecewiseCheckBox.CheckedChanged += new System.EventHandler(this.PiecewiseCheckBox_CheckedChanged);
            // 
            // RemovePointButton
            // 
            this.RemovePointButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.RemovePointButton.Location = new System.Drawing.Point(16, 488);
            this.RemovePointButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemovePointButton.Name = "RemovePointButton";
            this.RemovePointButton.Size = new System.Drawing.Size(366, 70);
            this.RemovePointButton.TabIndex = 3;
            this.RemovePointButton.Text = "Удалить";
            this.RemovePointButton.UseVisualStyleBackColor = false;
            this.RemovePointButton.Click += new System.EventHandler(this.RemovePointButton_Click);
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.chart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Enabled = false;
            this.chart.Location = new System.Drawing.Point(424, 55);
            this.chart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.Red;
            series1.LabelForeColor = System.Drawing.Color.Red;
            series1.MarkerBorderColor = System.Drawing.Color.Red;
            series1.Name = "Points";
            series1.ShadowColor = System.Drawing.Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Enabled = false;
            series2.Name = "MNK";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Enabled = false;
            series3.Name = "Piecewise";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Enabled = false;
            series4.MarkerColor = System.Drawing.Color.Blue;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle;
            series4.Name = "Linear";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.Color = System.Drawing.Color.Transparent;
            series5.LabelForeColor = System.Drawing.Color.Transparent;
            series5.Name = "ForSizeSet";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Series.Add(series4);
            this.chart.Series.Add(series5);
            this.chart.Size = new System.Drawing.Size(778, 897);
            this.chart.TabIndex = 4;
            this.chart.Text = "chart";
            this.chart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CreateNewPoint_MouseClick);
            // 
            // CreateChart
            // 
            this.CreateChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CreateChart.Location = new System.Drawing.Point(57, 870);
            this.CreateChart.Name = "CreateChart";
            this.CreateChart.Size = new System.Drawing.Size(294, 80);
            this.CreateChart.TabIndex = 5;
            this.CreateChart.Text = "Создать декартову систему\r\n(очистить график)";
            this.CreateChart.UseVisualStyleBackColor = false;
            this.CreateChart.Click += new System.EventHandler(this.CreateChart_Click);
            // 
            // YSize
            // 
            this.YSize.Location = new System.Drawing.Point(228, 830);
            this.YSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.YSize.Name = "YSize";
            this.YSize.Size = new System.Drawing.Size(121, 26);
            this.YSize.TabIndex = 6;
            this.YSize.Text = "60";
            this.YSize.TextChanged += new System.EventHandler(this.YSize_TextChanged);
            // 
            // XSize
            // 
            this.XSize.Location = new System.Drawing.Point(57, 830);
            this.XSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.XSize.Name = "XSize";
            this.XSize.Size = new System.Drawing.Size(133, 26);
            this.XSize.TabIndex = 7;
            this.XSize.Text = "10";
            this.XSize.TextChanged += new System.EventHandler(this.XSize_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 806);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ширина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 806);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Высота";
            // 
            // MNKCheckBox
            // 
            this.MNKCheckBox.AutoSize = true;
            this.MNKCheckBox.Location = new System.Drawing.Point(56, 738);
            this.MNKCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MNKCheckBox.Name = "MNKCheckBox";
            this.MNKCheckBox.Size = new System.Drawing.Size(270, 24);
            this.MNKCheckBox.TabIndex = 10;
            this.MNKCheckBox.Text = "Метод наименьших квадратов";
            this.MNKCheckBox.UseVisualStyleBackColor = true;
            this.MNKCheckBox.CheckedChanged += new System.EventHandler(this.MNKButton_CheckedChanged);
            // 
            // Degree
            // 
            this.Degree.Location = new System.Drawing.Point(57, 623);
            this.Degree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Degree.Name = "Degree";
            this.Degree.Size = new System.Drawing.Size(290, 26);
            this.Degree.TabIndex = 11;
            this.Degree.Text = "1";
            this.Degree.TextChanged += new System.EventHandler(this.Degree_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 598);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Степень ";
            // 
            // Table
            // 
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.Table.Location = new System.Drawing.Point(18, 55);
            this.Table.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Table.Name = "Table";
            this.Table.RowHeadersWidth = 82;
            this.Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Table.Size = new System.Drawing.Size(364, 423);
            this.Table.TabIndex = 14;
            this.Table.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellEndEdit);
            this.Table.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellValueChanged);
            this.Table.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Table_RowsAdded);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "X";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Y";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.СправкаtoolStripMenuItem1,
            this.О_ПрограммеtoolStripMenuItem2,
            this.ВыходtoolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1443, 33);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // СправкаtoolStripMenuItem1
            // 
            this.СправкаtoolStripMenuItem1.Name = "СправкаtoolStripMenuItem1";
            this.СправкаtoolStripMenuItem1.Size = new System.Drawing.Size(97, 29);
            this.СправкаtoolStripMenuItem1.Text = "Справка";
            this.СправкаtoolStripMenuItem1.Click += new System.EventHandler(this.СправкаtoolStripMenuItem1_Click);
            // 
            // О_ПрограммеtoolStripMenuItem2
            // 
            this.О_ПрограммеtoolStripMenuItem2.Name = "О_ПрограммеtoolStripMenuItem2";
            this.О_ПрограммеtoolStripMenuItem2.Size = new System.Drawing.Size(141, 29);
            this.О_ПрограммеtoolStripMenuItem2.Text = "О программе";
            this.О_ПрограммеtoolStripMenuItem2.Click += new System.EventHandler(this.О_ПрограммеtoolStripMenuItem2_Click);
            // 
            // ВыходtoolStripMenuItem3
            // 
            this.ВыходtoolStripMenuItem3.Name = "ВыходtoolStripMenuItem3";
            this.ВыходtoolStripMenuItem3.Size = new System.Drawing.Size(206, 29);
            this.ВыходtoolStripMenuItem3.Text = "Выход из программы";
            this.ВыходtoolStripMenuItem3.Click += new System.EventHandler(this.ВыходtoolStripMenuItem3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1443, 840);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Degree);
            this.Controls.Add(this.MNKCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.XSize);
            this.Controls.Add(this.YSize);
            this.Controls.Add(this.CreateChart);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.RemovePointButton);
            this.Controls.Add(this.PiecewiseCheckBox);
            this.Controls.Add(this.LinearCheckBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Аппроксимация функции";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox LinearCheckBox;
        private System.Windows.Forms.CheckBox PiecewiseCheckBox;
        private System.Windows.Forms.Button RemovePointButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button CreateChart;
        private System.Windows.Forms.TextBox YSize;
        private System.Windows.Forms.TextBox XSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox MNKCheckBox;
        private System.Windows.Forms.TextBox Degree;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem СправкаtoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem О_ПрограммеtoolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ВыходtoolStripMenuItem3;
    }
}

