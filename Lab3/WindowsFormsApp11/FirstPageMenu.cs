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
    public partial class FirstPageMenu : Form
    {
        //private ToolStripMenuItem fileItem_Tables;
        //private ToolStripMenuItem fileItem_Tables_Groups;
        //private ToolStripMenuItem fileItem_Tables_Subjects;
        //private ToolStripMenuItem fileItem_Tables_Students;
        //private ToolStripMenuItem fileItem_Tables_Groups_has_Subj;
        //private ToolStripMenuItem fileItem_Tables_Student_has_Subj;

        //private ToolStripMenuItem fileItem_Procedures;
        //private ToolStripMenuItem fileItem_Exit;

        public FirstPageMenu()
        {
            InitializeComponent();

            //fileItem_Tables = new ToolStripMenuItem("Таблицы");
            //fileItem_Procedures = new ToolStripMenuItem("Запросы");
            //fileItem_Exit = new ToolStripMenuItem("Выход");
            //fileItem_Tables_Groups = new ToolStripMenuItem("Группы");
            //fileItem_Tables_Students = new ToolStripMenuItem("Студенты");
            //fileItem_Tables_Subjects = new ToolStripMenuItem("Предметы");
            //fileItem_Tables_Groups_has_Subj = new ToolStripMenuItem("Предметы групп");
            //fileItem_Tables_Student_has_Subj = new ToolStripMenuItem("Предметы студентов");

            //fileItem_Tables.DropDownItems.Add(fileItem_Tables_Groups);
            //fileItem_Tables.DropDownItems.Add(fileItem_Tables_Students);
            //fileItem_Tables.DropDownItems.Add(fileItem_Tables_Subjects);
            //fileItem_Tables.DropDownItems.Add(fileItem_Tables_Groups_has_Subj);
            //fileItem_Tables.DropDownItems.Add(fileItem_Tables_Student_has_Subj);

            //menuStrip1.Items.Add(fileItem_Tables);
            //menuStrip1.Items.Add(fileItem_Procedures);
            //menuStrip1.Items.Add(fileItem_Exit);
        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Groups sendTo = new Groups();
            sendTo.ShowDialog();
        }

        private void предметыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subjects sendTo = new Subjects();
            sendTo.ShowDialog();
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Students sendTo = new Students();
            sendTo.ShowDialog();
        }

        private void предметыГруппToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Groups_has_Subj sendTo = new Groups_has_Subj();
            sendTo.ShowDialog();
        }

        private void предметыСтудентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_has_Subj sendTo = new Student_has_Subj();
            sendTo.ShowDialog();
        }

        private void запрос1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task1 sendTo = new Task1();
            sendTo.ShowDialog();
        }

        private void запрос2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Task2 sendTo = new Task2();
            sendTo.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }



}
