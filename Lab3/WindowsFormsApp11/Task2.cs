using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }
        //Получаем данные
        private void buttonGet_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("dbo.Procedure_2", sqlConnection1);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = cmd;
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].HeaderText = "Код группы";
            dataGridView1.Columns[1].HeaderText = "Предмет";
            dataGridView1.Columns[2].HeaderText = "ФИО студента";
            dataGridView1.Columns[3].HeaderText = "Результат";
            dataGridView1.Columns[4].HeaderText = "Количество неатестованных";

            sqlConnection1.Close();
        }

        //Экспорт данных
        private void buttonExport_Click(object sender, EventArgs e)
        {

            Excel.Application excelApp = new Excel.Application();
            excelApp.Application.Workbooks.Add(Type.Missing);
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                excelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (j > dataGridView1.Columns.Count - 2)
                        excelApp.Cells[i + 2, j + 1] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                    else
                        excelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            excelApp.Columns.AutoFit();
            excelApp.Visible = true;

        }
    }
}
