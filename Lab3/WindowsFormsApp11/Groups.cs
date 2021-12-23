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
    public partial class Groups : Form
    {
        public Groups()
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
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
        }
        //Обновить данные после закрытия
        private void Groups_Deactivate(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(this.lab2_checkDataSet.Groups);
            //this.groupsTableAdapter.Fill(this.lab2_checkDataSet.Groups);
        }

        //Кнопка добавить
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                try
                {
                    sqlConnection1.Open();
                    sqlInsertCommand1.Parameters["@Code_of_group"].Value = textBox1.Text;
                    sqlInsertCommand1.Parameters["@Number_of_group"].Value = Convert.ToInt32(textBox2.Text);
                    sqlInsertCommand1.Parameters["@Date_of_foundation"].Value = Convert.ToInt32(textBox3.Text);
                    sqlInsertCommand1.ExecuteNonQuery();
                    ClearTextBoxes();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ошибка приведения типов!");
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Запись уже имеется!");
                }
                finally
                {
                    sqlConnection1.Close();
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
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                try
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;
                    sqlConnection1.Open();
                    sqlUpdateCommand1.Parameters["@Cipher_of_group"].Value = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
                    sqlUpdateCommand1.Parameters["@Code_of_group"].Value = textBox1.Text;
                    sqlUpdateCommand1.Parameters["@Number_of_group"].Value = Convert.ToInt32(textBox2.Text);
                    sqlUpdateCommand1.Parameters["@Date_of_foundation"].Value = Convert.ToInt32(textBox3.Text);
                    sqlUpdateCommand1.ExecuteNonQuery();
                    ClearTextBoxes();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ошибка приведения типов!");
                }
                finally
                {
                    sqlConnection1.Close();
                    DisplayData();
                }
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
            sqlDeleteCommand1.Parameters["@Cipher_of_group"].Value = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
            sqlDeleteCommand1.ExecuteNonQuery();
            sqlConnection1.Close();
            DisplayData();
        }
    }
}
