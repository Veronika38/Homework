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

    public partial class Student_has_Subj : Form
    {
        SortedDictionary<int,string> MapOfSubjects;
        int GroupValue = 0;
        int SubjectKey = 0;

        public Student_has_Subj()
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
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Код зачётки";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].HeaderText = "Предмет";
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].HeaderText = "Результат аттестации";
        }
        //Загрузка формы
        private void Student_has_Subj_Load(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            DataTable dg = new DataTable();
            sqlDataAdapter2.Fill(dg);
            comboBox1.DataSource = dg;
            sqlConnection1.Close();
            ClearComboBoxes();

        }
        //Очищаем поля ввода
        private void ClearComboBoxes()
        {
            comboBox2.SelectedIndex=-1;comboBox3.SelectedIndex=-1; comboBox1.SelectedIndex = -1;
        }
        //Формируем варианты предметов на основе comboBox1.SelectedValue
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            sqlConnection2.Open();
            DataTable dtGHS = new DataTable(), dtSt = new DataTable(), dtSub = new DataTable();
            sqlDataAdapter4.Fill(dtGHS);
            sqlDataAdapter3.Fill(dtSub);
            sqlDataAdapter2.Fill(dtSt);
            sqlConnection2.Close();

            MapOfSubjects = new SortedDictionary<int,string>();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            
            for (int i = 0; i < dtSt.Rows.Count; i++)
            {
                if (Convert.ToInt32(dtSt.Rows[i][0]) == Convert.ToInt32(comboBox1.SelectedValue))
                {
                    GroupValue = Convert.ToInt32(dtSt.Rows[i][1]);
                    break;
                }
            }
            for (int i = 0; i < dtGHS.Rows.Count; i++)
            {
                if (Convert.ToInt32(dtGHS.Rows[i][1]) == GroupValue)
                {
                    MapOfSubjects.Add(Convert.ToInt32(dtGHS.Rows[i][2]),"");
                }
            }
            for (int i = 0; i < dtSub.Rows.Count; i++)
            {
                if (MapOfSubjects.ContainsKey(Convert.ToInt32(dtSub.Rows[i][0])))
                {
                    MapOfSubjects[Convert.ToInt32(dtSub.Rows[i][0])] = dtSub.Rows[i][1].ToString();
                    comboBox2.Items.Add(dtSub.Rows[i][1].ToString());
                }
            }
        }
        //Формируем варианты результатов аттестации на основе comboBox2.SelectedValue
        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            sqlConnection2.Open();
            DataTable dtGHS = new DataTable(), dtSt = new DataTable();
            sqlDataAdapter4.Fill(dtGHS);
            sqlDataAdapter2.Fill(dtSt);
            sqlConnection2.Close();
            
            comboBox3.Items.Clear();

            SubjectKey = MapOfSubjects.FirstOrDefault(x => x.Value == comboBox2.Text).Key;
            //Console.WriteLine(myKey);

            for (int i = 0; i < dtGHS.Rows.Count; i++)
            {
                //Console.WriteLine(Convert.ToInt32(dtGHS.Rows[i][1]) + "          " + GroupValue);
                //Console.WriteLine(Convert.ToInt32(dtGHS.Rows[i][2]) + "          " + SubjectKey);

                if (Convert.ToInt32(dtGHS.Rows[i][1]) == GroupValue && Convert.ToInt32(dtGHS.Rows[i][2]) == SubjectKey)
                {
                    if (dtGHS.Rows[i][4].ToString().Trim().Equals("credit"))
                    {
                        comboBox3.Items.Add("credit");
                        comboBox3.Items.Add("not credit");
                    }
                    else
                    {
                        comboBox3.Items.Add("5");
                        comboBox3.Items.Add("4");
                        comboBox3.Items.Add("3");
                        comboBox3.Items.Add("2");
                        comboBox3.Items.Add("1");
                    }
                    break;
                }
            }
        }
        //Кнопка добавить
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" && comboBox3.Text != "")
            {
                try
                {
                    sqlConnection1.Open();
                    sqlInsertCommand1.Parameters["@Students_Code_of_record_book"].Value = Convert.ToInt32(comboBox1.SelectedValue);
                    sqlInsertCommand1.Parameters["@Subjects_Cipher_of_subject"].Value = SubjectKey;
                    sqlInsertCommand1.Parameters["@Result_of_certification"].Value = comboBox3.Text;
                    sqlInsertCommand1.ExecuteNonQuery();
                    ClearComboBoxes();
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
            if (comboBox1.Text != "" && comboBox2.Text != "")
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value != null)
                    {
                        //Console.WriteLine(dataGridView1.Rows[i].Cells[2].Value.ToString().Equals(comboBox2.SelectedValue.ToString()));
                        //Console.WriteLine("   Table: "+ dataGridView1.Rows[i].Cells[1].Value.ToString()+"        "+ "   Table: " + dataGridView1.Rows[i].Cells[2].Value.ToString());
                        if (Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value) == Convert.ToInt32(comboBox1.Text) && dataGridView1.Rows[i].Cells[2].Value.Equals(comboBox2.Text))
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
            if(comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text!="")
            {
                try
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;
                    sqlConnection1.Open();
                    sqlUpdateCommand1.Parameters["@Self_table_id"].Value = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
                    sqlUpdateCommand1.Parameters["@Code_of_record_book"].Value = Convert.ToInt32(comboBox1.SelectedValue);
                    sqlUpdateCommand1.Parameters["@Subjects_Cipher_of_subject"].Value = SubjectKey;
                    sqlUpdateCommand1.Parameters["@Result_of_certification"].Value = comboBox3.Text;
                    sqlUpdateCommand1.ExecuteNonQuery();
                    ClearComboBoxes();
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
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            sqlConnection1.Open();
            sqlDeleteCommand1.Parameters["@Self_table_id"].Value = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString());
            sqlDeleteCommand1.ExecuteNonQuery();
            ClearComboBoxes();
            sqlConnection1.Close();
            DisplayData();
        }
    }
}
