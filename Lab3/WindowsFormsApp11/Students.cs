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
    public partial class Students : Form
    {
        public Students()
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
            dataGridView1.Columns[0].HeaderText = "Код зачетки";
            dataGridView1.Columns[1].HeaderText = "ФИО студента";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].HeaderText = "Код группы";
            dataGridView1.Columns[3].HeaderText = "Пол";
            dataGridView1.Columns[4].HeaderText = "Дата рождения";
        }
        //Очищаем поля ввода
        private void ClearTextBoxes()
        {
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; comboBox1.SelectedIndex = -1; comboBox2.SelectedIndex=-1;
        }
        //Загрузка формы
        private void Students_Load(object sender, EventArgs e)
        {
            sqlConnection2.Open();
            DataTable dg = new DataTable();
            sqlDataAdapter2.Fill(dg);
            comboBox1.DataSource = dg;
            sqlConnection2.Close();
            comboBox2.Items.Add("M");
            comboBox2.Items.Add("W");
            ClearTextBoxes();
        }
        //Обновить данные после закрытия
        private void Students_Deactivate(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(this.lab2_checkDataSet.Subjects);
            //this.groupsTableAdapter.Fill(this.lab2_checkDataSet.Subjects);
        }

        //Кнопка добавить
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox2.Text!="")
            {
                try
                {
                    sqlConnection2.Open();
                    sqlInsertCommand1.Parameters["@Code_of_record_book"].Value = Convert.ToInt32(textBox1.Text);
                    sqlInsertCommand1.Parameters["@Groups_Cipher_of_group"].Value = Convert.ToInt32(comboBox1.SelectedValue);
                    sqlInsertCommand1.Parameters["@Full_name"].Value = textBox2.Text;
                    sqlInsertCommand1.Parameters["@Gender"].Value = comboBox2.Text;
                    sqlInsertCommand1.Parameters["@Date_of_birth"].Value = DateTime.Parse(textBox3.Text);
                    sqlInsertCommand1.ExecuteNonQuery();
                    ClearTextBoxes();
                } catch (FormatException)
                {
                    MessageBox.Show("Ошибка приведения типов!");
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Запись уже имеется!");
                }
                finally
                {
                    sqlConnection2.Close();
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
                    if (dataGridView1.Rows[i].Cells[0].Value != null)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString().Equals(textBox1.Text))
                        {
                            dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
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
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox2.Text!="")
            {
                try
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;
                    sqlConnection2.Open();
                    sqlUpdateCommand1.Parameters["@Code_of_record_book"].Value = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
                    sqlUpdateCommand1.Parameters["@Groups_Cipher_of_group"].Value = Convert.ToInt32(comboBox1.SelectedValue);
                    sqlUpdateCommand1.Parameters["@Gender"].Value = comboBox2.Text;
                    sqlUpdateCommand1.Parameters["@Full_name"].Value = textBox2.Text;
                    sqlUpdateCommand1.Parameters["@Date_of_birth"].Value = DateTime.Parse(textBox3.Text);
                    sqlUpdateCommand1.ExecuteNonQuery();
                    ClearTextBoxes();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ошибка приведения типов!");
                }
                finally
                {
                    sqlConnection2.Close();
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
            sqlConnection2.Open();
            sqlDeleteCommand1.Parameters["@Code_of_record_book"].Value = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
            sqlDeleteCommand1.ExecuteNonQuery();
            sqlConnection2.Close();
            DisplayData();
        }

    }
}
