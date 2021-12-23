using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
            DisplayData();
        }
        //Загрузка данных
        private void DisplayData()
        {
            sqlConnection1.Open();
            DataTable dt = new DataTable();
            sqlDataAdapter1.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection1.Close();
        }
        //Очищаем поля ввода
        private void ClearTextBoxes()
        {
            textBox1.Text = ""; textBox2.Text = "";
        }
        //Обновить данные после закрытия
        private void Subjects_Deactivate(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(this.lab2_checkDataSet.Subjects);
            //this.groupsTableAdapter.Fill(this.lab2_checkDataSet.Subjects);
        }

        //Кнопка добавить
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                try
                {
                    sqlConnection1.Open();
                    sqlInsertCommand1.Parameters["@Name_of_subject"].Value = textBox1.Text;
                    sqlInsertCommand1.Parameters["@Name_of_professor"].Value = textBox2.Text;
                    sqlInsertCommand1.ExecuteNonQuery();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Запись уже имеется!");
                }
                finally
                {
                    sqlConnection1.Close();
                    ClearTextBoxes();
                    DisplayData();
                }
            }
            else
            {
                MessageBox.Show("Недостаточно данных!");
            }
        }
        //Кнопка найти
        private void buttonFind_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            if (textBox1.Text != "")
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value != null)
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString().Equals(textBox1.Text))
                        {
                            dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[1];
                            dataGridView1.Rows[i].Selected = true;
                            return;
                        }
                    }
                }
                MessageBox.Show("Данной записи не существует!");
            }
            else
            {
                MessageBox.Show("Поля не заполнены!");
            }
        }
        //Кнопка изменить
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                sqlConnection1.Open();
                sqlUpdateCommand1.Parameters["@Cipher_of_subject"].Value = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
                sqlUpdateCommand1.Parameters["@Name_of_subject"].Value = textBox1.Text;
                sqlUpdateCommand1.Parameters["@Name_of_professor"].Value = textBox2.Text;
                sqlUpdateCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                ClearTextBoxes();
                DisplayData();
            }
            else
            {
                MessageBox.Show("Поля не заполнены!");
            }

        }
        //Кнопка удалить
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            sqlConnection1.Open();
            sqlDeleteCommand1.Parameters["@Cipher_of_subject"].Value = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
            sqlDeleteCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
            DisplayData();
        }
    }
}
