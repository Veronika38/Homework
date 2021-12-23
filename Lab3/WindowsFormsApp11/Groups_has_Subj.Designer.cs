﻿
namespace WindowsFormsApp
{
    partial class Groups_has_Subj
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
            this.components = new System.ComponentModel.Container();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupshasSubjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lab2_checkDataSet = new WindowsFormsApp.Lab2_checkDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection2 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.groups_has_SubjectsTableAdapter = new WindowsFormsApp.Lab2_checkDataSetTableAdapters.Groups_has_SubjectsTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter2 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter3 = new System.Data.SqlClient.SqlDataAdapter();
            this.groupsTableAdapter = new WindowsFormsApp.Lab2_checkDataSetTableAdapters.GroupsTableAdapter();
            this.subjectsTableAdapter = new WindowsFormsApp.Lab2_checkDataSetTableAdapters.SubjectsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupshasSubjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab2_checkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDelete.Location = new System.Drawing.Point(415, 392);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(174, 40);
            this.buttonDelete.TabIndex = 24;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonInsert.Location = new System.Drawing.Point(206, 392);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(174, 40);
            this.buttonInsert.TabIndex = 23;
            this.buttonInsert.Text = "Добавить";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonUpdate.Location = new System.Drawing.Point(415, 346);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(174, 40);
            this.buttonUpdate.TabIndex = 22;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonFind.Location = new System.Drawing.Point(206, 346);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(174, 40);
            this.buttonFind.TabIndex = 21;
            this.buttonFind.Text = "Найти";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(643, 226);
            this.dataGridView1.TabIndex = 20;
            // 
            // groupshasSubjectsBindingSource
            // 
            this.groupshasSubjectsBindingSource.DataMember = "Groups_has_Subjects";
            this.groupshasSubjectsBindingSource.DataSource = this.lab2_checkDataSet;
            // 
            // lab2_checkDataSet
            // 
            this.lab2_checkDataSet.DataSetName = "Lab2_checkDataSet";
            this.lab2_checkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(400, 301);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 26);
            this.textBox1.TabIndex = 27;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lab2_check;Integrated Security" +
    "=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "dbo.SeeAllGroupsHasSubj";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Connection = this.sqlConnection2;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlConnection2
            // 
            this.sqlConnection2.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Lab2_check;Integrated Security" +
    "=True";
            this.sqlConnection2.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "dbo.InsertNewGroup_FOR_Groups_has_Subj";
            this.sqlInsertCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlInsertCommand1.Connection = this.sqlConnection2;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Groups_Cipher_of_group", System.Data.SqlDbType.Int, 4, "Groups_Cipher_of_group"),
            new System.Data.SqlClient.SqlParameter("@Subjects_Cipher_of_subject", System.Data.SqlDbType.Int, 4, "Subjects_Cipher_of_subject"),
            new System.Data.SqlClient.SqlParameter("@Number_of_study_hours", System.Data.SqlDbType.Int, 4, "Number_of_study_hours"),
            new System.Data.SqlClient.SqlParameter("@Type_of_certification", System.Data.SqlDbType.VarChar, 20, "Type_of_certification")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = "dbo.UpdateGroup_From_Groups_has_Subj";
            this.sqlUpdateCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlUpdateCommand1.Connection = this.sqlConnection2;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Self_table_id", System.Data.SqlDbType.Int, 4, "Self_table_id"),
            new System.Data.SqlClient.SqlParameter("@Groups_Cipher_of_group", System.Data.SqlDbType.Int, 4, "Groups_Cipher_of_group"),
            new System.Data.SqlClient.SqlParameter("@Subjects_Cipher_of_subject", System.Data.SqlDbType.Int, 4, "Subjects_Cipher_of_subject"),
            new System.Data.SqlClient.SqlParameter("@Number_of_study_hours", System.Data.SqlDbType.Int, 4, "Number_of_study_hours"),
            new System.Data.SqlClient.SqlParameter("@Type_of_certification", System.Data.SqlDbType.VarChar, 20, "Type_of_certification")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "dbo.DeleteAnyGroup_FROM_Groups_has_Subj";
            this.sqlDeleteCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlDeleteCommand1.Connection = this.sqlConnection2;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Self_table_id", System.Data.SqlDbType.Int, 4, "Self_table_id")});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SeeAllGroupsHasSubj", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Code_of_group", "Code_of_group"),
                        new System.Data.Common.DataColumnMapping("Name_of_subject", "Name_of_subject"),
                        new System.Data.Common.DataColumnMapping("Number_of_study_hours", "Number_of_study_hours"),
                        new System.Data.Common.DataColumnMapping("Type_of_certification", "Type_of_certification")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // groups_has_SubjectsTableAdapter
            // 
            this.groups_has_SubjectsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(567, 299);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(151, 28);
            this.comboBox3.TabIndex = 28;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.subjectsBindingSource;
            this.comboBox2.DisplayMember = "Name_of_subject";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(233, 301);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(161, 28);
            this.comboBox2.TabIndex = 29;
            this.comboBox2.ValueMember = "Cipher_of_subject";
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "Subjects";
            this.subjectsBindingSource.DataSource = this.lab2_checkDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.groupsBindingSource;
            this.comboBox1.DisplayMember = "Code_of_group";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(66, 301);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 28);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.ValueMember = "Cipher_of_group";
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.lab2_checkDataSet;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "dbo.SelectAllGroups";
            this.sqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand2.Connection = this.sqlConnection1;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlDataAdapter2
            // 
            this.sqlDataAdapter2.SelectCommand = this.sqlSelectCommand2;
            this.sqlDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SelectAllGroups", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Cipher_of_group", "Cipher_of_group"),
                        new System.Data.Common.DataColumnMapping("Code_of_group", "Code_of_group"),
                        new System.Data.Common.DataColumnMapping("Number_of_group", "Number_of_group"),
                        new System.Data.Common.DataColumnMapping("Date_of_foundation", "Date_of_foundation")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "dbo.SelectAllSubjects";
            this.sqlSelectCommand3.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand3.Connection = this.sqlConnection1;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlDataAdapter3
            // 
            this.sqlDataAdapter3.SelectCommand = this.sqlSelectCommand3;
            this.sqlDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SelectAllSubjects", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Cipher_of_subject", "Cipher_of_subject"),
                        new System.Data.Common.DataColumnMapping("Name_of_subject", "Name_of_subject"),
                        new System.Data.Common.DataColumnMapping("Name_of_professor", "Name_of_professor")})});
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Код группы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Предмет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Количество часов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(601, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Тип аттестации";
            // 
            // Groups_has_Subj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Groups_has_Subj";
            this.Text = "Groups_has_Subj";
            this.Load += new System.EventHandler(this.Groups_has_Subj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupshasSubjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab2_checkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private Lab2_checkDataSet lab2_checkDataSet;
        private System.Windows.Forms.BindingSource groupshasSubjectsBindingSource;
        private Lab2_checkDataSetTableAdapters.Groups_has_SubjectsTableAdapter groups_has_SubjectsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter2;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter3;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private Lab2_checkDataSetTableAdapters.GroupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private Lab2_checkDataSetTableAdapters.SubjectsTableAdapter subjectsTableAdapter;
        private System.Data.SqlClient.SqlConnection sqlConnection2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}