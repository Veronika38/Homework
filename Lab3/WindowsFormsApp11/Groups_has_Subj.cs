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
    public partial class Groups_has_Subj : Form
    {
        public Groups_has_Subj()
        {
            InitializeComponent();
            DisplayData();
        }
        //Загрузка данных
        private void DisplayData()
        {
            sqlConnection2.Open();
            DataTable dt = new DataTable();
            sqlDataAdapter1.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlConnection2.Close();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Код группы";
            dataGridView1.Columns[2].HeaderText = "Название предмета";
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].HeaderText = "Количество часов";
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].HeaderText = "Тип аттестации";
            dataGridView1.Columns[4].Width = 150;
        }
        //Очищаем поля ввода
        private void ClearTextBoxes()
        {
            textBox1.Text = ""; comboBox1.SelectedIndex = -1; comboBox2.SelectedIndex = -1; comboBox3.SelectedIndex = -1;
        }
        //Загрузка формы
        private void Groups_has_Subj_Load(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            DataTable dg = new DataTable(), dg1 = new DataTable();
            sqlDataAdapter2.Fill(dg);
            comboBox1.DataSource = dg;
            sqlDataAdapter3.Fill(dg1);
            comboBox2.DataSource = dg1;
            comboBox3.Items.Add("credit");
            comboBox3.Items.Add("exam");
            sqlConnection1.Close();
            ClearTextBoxes();
        }
        //Кнопка добавить
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && comboBox3.Text!="")
            {
                try
                {
                    sqlConnection2.Open();
                    sqlInsertCommand1.Parameters["@Groups_Cipher_of_group"].Value = Convert.ToInt32(comboBox1.SelectedValue);
                    sqlInsertCommand1.Parameters["@Subjects_Cipher_of_subject"].Value = Convert.ToInt32(comboBox2.SelectedValue);
                    sqlInsertCommand1.Parameters["@Number_of_study_hours"].Value = Convert.ToInt32(textBox1.Text);
                    sqlInsertCommand1.Parameters["@Type_of_certification"].Value = comboBox3.Text;
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
            if (comboBox1.Text != "" && comboBox2.Text!= "")
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value != null)
                    {
                        //Console.WriteLine(dataGridView1.Rows[i].Cells[2].Value.ToString().Equals(comboBox2.SelectedValue.ToString()));
                        //Console.WriteLine("   Table: "+ dataGridView1.Rows[i].Cells[1].Value.ToString()+"        "+ "   Table: " + dataGridView1.Rows[i].Cells[2].Value.ToString());
                        if (dataGridView1.Rows[i].Cells[1].Value.Equals(comboBox1.Text) && dataGridView1.Rows[i].Cells[2].Value.Equals(comboBox2.Text))
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
            if (textBox1.Text != "" && comboBox3.Text != "")
            {
                try
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;
                    sqlConnection2.Open();
                    sqlUpdateCommand1.Parameters["@Self_table_id"].Value = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
                    sqlUpdateCommand1.Parameters["@Groups_Cipher_of_group"].Value = Convert.ToInt32(comboBox1.SelectedValue);
                    sqlUpdateCommand1.Parameters["@Subjects_Cipher_of_subject"].Value = Convert.ToInt32(comboBox2.SelectedValue);
                    sqlUpdateCommand1.Parameters["@Number_of_study_hours"].Value = Convert.ToInt32(textBox1.Text);
                    sqlUpdateCommand1.Parameters["@Type_of_certification"].Value = comboBox3.Text;
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
            sqlDeleteCommand1.Parameters["@Self_table_id"].Value = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
            sqlDeleteCommand1.ExecuteNonQuery();
            sqlConnection2.Close();
            DisplayData();
        }
    }
}
