namespace UIController.Views
{
    partial class StudentView
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDeleteStudentView = new System.Windows.Forms.Button();
            this.bntEditStudentView = new System.Windows.Forms.Button();
            this.bntAddStudentView = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCancelStudentView = new System.Windows.Forms.Button();
            this.btnSaveStudentView = new System.Windows.Forms.Button();
            this.txtStudentAge = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCloseStudentView = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "СТУДЕНТЫ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnCloseStudentView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 61);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 389);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDeleteStudentView);
            this.tabPage1.Controls.Add(this.bntEditStudentView);
            this.tabPage1.Controls.Add(this.bntAddStudentView);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.txtSearchBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список студентов";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStudentView
            // 
            this.btnDeleteStudentView.Location = new System.Drawing.Point(679, 144);
            this.btnDeleteStudentView.Name = "btnDeleteStudentView";
            this.btnDeleteStudentView.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStudentView.TabIndex = 6;
            this.btnDeleteStudentView.Text = "Удалить";
            this.btnDeleteStudentView.UseVisualStyleBackColor = true;
            // 
            // bntEditStudentView
            // 
            this.bntEditStudentView.Location = new System.Drawing.Point(679, 106);
            this.bntEditStudentView.Name = "bntEditStudentView";
            this.bntEditStudentView.Size = new System.Drawing.Size(75, 23);
            this.bntEditStudentView.TabIndex = 5;
            this.bntEditStudentView.Text = "Редактировать";
            this.bntEditStudentView.UseVisualStyleBackColor = true;
            // 
            // bntAddStudentView
            // 
            this.bntAddStudentView.Location = new System.Drawing.Point(679, 68);
            this.bntAddStudentView.Name = "bntAddStudentView";
            this.bntAddStudentView.Size = new System.Drawing.Size(75, 23);
            this.bntAddStudentView.TabIndex = 4;
            this.bntAddStudentView.Text = "Добавить студента";
            this.bntAddStudentView.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 287);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(562, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(9, 24);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(513, 20);
            this.txtSearchBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Найти студента";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCancelStudentView);
            this.tabPage2.Controls.Add(this.btnSaveStudentView);
            this.tabPage2.Controls.Add(this.txtStudentAge);
            this.tabPage2.Controls.Add(this.txtStudentName);
            this.tabPage2.Controls.Add(this.txtStudentID);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 363);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Студент";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCancelStudentView
            // 
            this.btnCancelStudentView.Location = new System.Drawing.Point(113, 202);
            this.btnCancelStudentView.Name = "btnCancelStudentView";
            this.btnCancelStudentView.Size = new System.Drawing.Size(75, 23);
            this.btnCancelStudentView.TabIndex = 7;
            this.btnCancelStudentView.Text = "Отменить";
            this.btnCancelStudentView.UseVisualStyleBackColor = true;
            // 
            // btnSaveStudentView
            // 
            this.btnSaveStudentView.Location = new System.Drawing.Point(32, 202);
            this.btnSaveStudentView.Name = "btnSaveStudentView";
            this.btnSaveStudentView.Size = new System.Drawing.Size(75, 23);
            this.btnSaveStudentView.TabIndex = 6;
            this.btnSaveStudentView.Text = "Сохранить";
            this.btnSaveStudentView.UseVisualStyleBackColor = true;
            // 
            // txtStudentAge
            // 
            this.txtStudentAge.Location = new System.Drawing.Point(32, 141);
            this.txtStudentAge.Name = "txtStudentAge";
            this.txtStudentAge.Size = new System.Drawing.Size(156, 20);
            this.txtStudentAge.TabIndex = 5;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(32, 85);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(156, 20);
            this.txtStudentName.TabIndex = 4;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(32, 40);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(156, 20);
            this.txtStudentID.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Возраст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ИД Студента";
            // 
            // btnCloseStudentView
            // 
            this.btnCloseStudentView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCloseStudentView.ForeColor = System.Drawing.Color.Transparent;
            this.btnCloseStudentView.Location = new System.Drawing.Point(763, 18);
            this.btnCloseStudentView.Name = "btnCloseStudentView";
            this.btnCloseStudentView.Size = new System.Drawing.Size(25, 23);
            this.btnCloseStudentView.TabIndex = 1;
            this.btnCloseStudentView.Text = "X";
            this.btnCloseStudentView.UseVisualStyleBackColor = false;
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "StudentView";
            this.Text = "StudentView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCancelStudentView;
        private System.Windows.Forms.Button btnSaveStudentView;
        private System.Windows.Forms.TextBox txtStudentAge;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteStudentView;
        private System.Windows.Forms.Button bntEditStudentView;
        private System.Windows.Forms.Button bntAddStudentView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCloseStudentView;
    }
}