using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp1222.Helpers;



namespace WindowsFormsApp1222
{   
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private bool isSeriesContainPointWithX(double x) {
            bool result = false;

            foreach (var pointItem in chart.Series["Points"].Points)
            {
                if (pointItem.XValue == x)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        private void CreateNewPoint_MouseClick(object sender, MouseEventArgs e)
        {
            double x = Math.Floor(chart.ChartAreas[0].AxisX.PixelPositionToValue(e.X));
            double y = Math.Floor(chart.ChartAreas[0].AxisY.PixelPositionToValue(e.Y));

            POINT point = new POINT(x, y);

            if (!isSeriesContainPointWithX(point.X)) {

                string[] a = { point.X.ToString(), point.Y.ToString() };

                chart.Series["Points"].Points.AddXY(point.X, point.Y);
                Table.Rows.Add(a);
            }

            updateChart();
        }

        private void CreateChart_Click(object sender, EventArgs e)
        {
            int width, height;

            int.TryParse(XSize.Text, out width);
            int.TryParse(YSize.Text, out height);

            if (width == 0 || height == 0) return;

            chart.Enabled = true;

            Table.Rows.Clear();

            foreach (var collection in chart.Series) {
                collection.Points.Clear();
            }

            width /= 10;
            height /= 10;

            for (int i = 0; i < 10; i++) {
                chart.Series["ForSizeSet"].Points.AddXY(width * i, height * i);
            }
        }

        private void RemovePointButton_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection selectedCollection = Table.SelectedRows;
            foreach (DataGridViewRow Item in selectedCollection) {
                double xToCompare = Convert.ToDouble(Item.Cells[0].Value);
                double yToCompare = Convert.ToDouble(Item.Cells[1].Value);

                if (xToCompare == 0 || yToCompare == 0) continue;

                foreach (var point in chart.Series["Points"].Points)
                {
                    if (point.XValue == xToCompare && point.YValues[0] == yToCompare)
                    {
                        chart.Series["Points"].Points.Remove(point);

                        break;
                    }
                }

                Table.Rows.Remove(Item);
            }

            //при удалении точек заново заполняем заголовки строк
            for (int i = 1; i < Table.RowCount - 1; i++)
            {
                Table.Rows[i].HeaderCell.Value = (i+1).ToString();
            }
        }

        private void Table_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            double changes = Convert.ToDouble(Table.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            double ToCompare = Convert.ToDouble(Table.Rows[e.RowIndex].Cells[e.ColumnIndex == 1 ? 0 : 1].Value);
            foreach (var point in chart.Series["Points"].Points)
            {
                bool check = e.ColumnIndex == 0 ? point.YValues[0] == ToCompare : point.XValue == ToCompare;

                double newx = point.XValue == ToCompare ? point.XValue : changes;
                double newy = point.YValues[0] == ToCompare ? point.YValues[0] : changes;

                if (check)
                {
                    chart.Series["Points"].Points.Remove(point);

                    if (!isSeriesContainPointWithX(changes))
                    {
                        chart.Series["Points"].Points.AddXY(newx, newy);
                    }
                    else 
                    {
                        Table.Rows.Remove(Table.Rows[e.RowIndex]);
                    }

                    break;
                }
            }
        }

        private void ClearMathSeries() {
            chart.Series["MNK"].Points.Clear();
            chart.Series["Piecewise"].Points.Clear();
            chart.Series["Linear"].Points.Clear();
        }

        private void updateChart() 
        {
            int degree;
            int.TryParse(Degree.Text, out degree);

            ClearMathSeries();

            if (degree < 1) return;
            if (chart.Series["Points"].Points.Count < 2) return;

            SortedList<double, double> points = new SortedList<double, double>();

            foreach (var point in chart.Series["Points"].Points) {
                points.Add(point.XValue, point.YValues[0]);
            }

            foreach (var point in MathFunctions.Piecewise(points)) {
                chart.Series["Piecewise"].Points.AddXY(point.Key, point.Value);
            }

            foreach (var point in MathFunctions.Linear(points)) {
                chart.Series["Linear"].Points.AddXY(point.Key, point.Value);
            }

            //изменено имя метода
            foreach (var point in MathFunctions.ApproximateUniversal(points, degree))
            {
                chart.Series["MNK"].Points.AddXY(point.Key, point.Value);
            }
        }

        private void MNKButton_CheckedChanged(object sender, EventArgs e)
        {
            chart.Series["MNK"].Enabled = MNKCheckBox.Checked;

            updateChart();
        }

        private void PiecewiseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            chart.Series["Piecewise"].Enabled = PiecewiseCheckBox.Checked;

            updateChart();
        }

        private void LinearCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            chart.Series["Linear"].Enabled = LinearCheckBox.Checked;

            updateChart();
        }

        private void Degree_TextChanged(object sender, EventArgs e)
        {
             updateChart();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string line;

            if (chart.Enabled == false) {
                MessageBox.Show("Chart не создан");

                return;
            }

            var open = new OpenFileDialog
            {
                AddExtension = true,
                DefaultExt = "txt",
                Filter = @"Текстовые файлы (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true

            };

            if (open.ShowDialog() == DialogResult.Cancel)
                return;

            var file = new StreamReader(open.FileName);

            while ((line = file.ReadLine()) != null)
            {
                string[] cors = line.Split(';');
                POINT point = new POINT(Convert.ToDouble(cors[0]), Convert.ToDouble(cors[1]));

                Table.Rows.Add(point.X, point.Y);

                chart.Series["Points"].Points.AddXY(point.X, point.Y);
            }

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var save = new SaveFileDialog
            {
                AddExtension = true,
                DefaultExt = "txt",
                Filter = @"Текстовые файлы (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true

            };

            if (save.ShowDialog() != DialogResult.OK) return;
            var sw = new StreamWriter(save.FileName, true, Encoding.UTF8);

            foreach (DataGridViewRow row in Table.Rows) //запись
                if (!row.IsNewRow)
                {
                    var first = true;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (!first) sw.Write(";");
                        sw.Write(cell.Value.ToString());
                        first = false;
                    }
                    sw.WriteLine();
                }
            sw.Close();
        }

        private void О_ПрограммеtoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Программа апроксимации функции \n " +
               "Создатель программы: Васильев Владислав \n " +
               "Научный Руководитель: Рогов Александр Юрьевич", "Информация о программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ВыходtoolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void XSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void Table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Table_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int delta = Table.RowCount - e.RowIndex ;
            int Index = 1;

            //при открытии файла мы работаем с последней строкой4; при добавлении точки вручную - с предпоследней
            if (delta != 1)
            {
                delta = 0;
            }
            
            //получаем значение из предыдущей строки
            if (e.RowIndex - delta - 1 >= 0)
            {
                Index = Convert.ToInt32(Table.Rows[e.RowIndex - delta - 1].HeaderCell.Value) + 1; 
            }
            
            //задаем заголовок текущей строки
            if (e.RowIndex - delta >= 0)
            {
                Table.Rows[e.RowIndex - delta].HeaderCell.Value = Index.ToString();
            }
        }

        private void СправкаtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Formspravka программа = new Formspravka();
            программа.ShowDialog();
        }

        private void YSize_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
