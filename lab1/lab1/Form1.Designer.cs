
namespace lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.Button_disk_info = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_dinamic = new System.Windows.Forms.Button();
            this.button_obzor = new System.Windows.Forms.Button();
            this.textBox_folder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_create = new System.Windows.Forms.Button();
            this.button_rename = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.textBox_direct = new System.Windows.Forms.TextBox();
            this.button_direct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Сopy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_file = new System.Windows.Forms.RadioButton();
            this.radioButton_folder = new System.Windows.Forms.RadioButton();
            this.button_select_file = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_timer_work = new System.Windows.Forms.TextBox();
            this.button_createrinfo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(203, 15);
            this.Output.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(546, 429);
            this.Output.TabIndex = 0;
            this.Output.Text = "";
            this.Output.TextChanged += new System.EventHandler(this.Output_TextChanged);
            // 
            // Button_disk_info
            // 
            this.Button_disk_info.Location = new System.Drawing.Point(12, 13);
            this.Button_disk_info.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_disk_info.Name = "Button_disk_info";
            this.Button_disk_info.Size = new System.Drawing.Size(186, 51);
            this.Button_disk_info.TabIndex = 1;
            this.Button_disk_info.Text = "Информация о дисках";
            this.Button_disk_info.UseVisualStyleBackColor = true;
            this.Button_disk_info.Click += new System.EventHandler(this.Button_disk_info_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(12, 131);
            this.button_reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(186, 51);
            this.button_reset.TabIndex = 2;
            this.button_reset.Text = "Сбросить";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.Button_reset_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button_dinamic
            // 
            this.button_dinamic.Location = new System.Drawing.Point(12, 72);
            this.button_dinamic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_dinamic.Name = "button_dinamic";
            this.button_dinamic.Size = new System.Drawing.Size(186, 51);
            this.button_dinamic.TabIndex = 3;
            this.button_dinamic.Text = "Динамич. обновление\r\nВКЛ/ВЫКЛ\r\n";
            this.button_dinamic.UseVisualStyleBackColor = true;
            this.button_dinamic.Click += new System.EventHandler(this.Button_dinamic_Click);
            // 
            // button_obzor
            // 
            this.button_obzor.Location = new System.Drawing.Point(897, 539);
            this.button_obzor.Name = "button_obzor";
            this.button_obzor.Size = new System.Drawing.Size(62, 27);
            this.button_obzor.TabIndex = 4;
            this.button_obzor.Text = "Обзор";
            this.button_obzor.UseVisualStyleBackColor = true;
            this.button_obzor.Click += new System.EventHandler(this.button_obzor_Click);
            // 
            // textBox_folder
            // 
            this.textBox_folder.Location = new System.Drawing.Point(203, 539);
            this.textBox_folder.Name = "textBox_folder";
            this.textBox_folder.Size = new System.Drawing.Size(688, 27);
            this.textBox_folder.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(203, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите, с чем вы хотите работать";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(142, 543);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Путь :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(102, 590);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Название :";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(203, 589);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(687, 27);
            this.textBox_name.TabIndex = 9;
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(204, 635);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(125, 35);
            this.button_create.TabIndex = 10;
            this.button_create.Text = "Создать";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click_1);
            // 
            // button_rename
            // 
            this.button_rename.Location = new System.Drawing.Point(335, 635);
            this.button_rename.Name = "button_rename";
            this.button_rename.Size = new System.Drawing.Size(142, 35);
            this.button_rename.TabIndex = 11;
            this.button_rename.Text = "Переименовать";
            this.button_rename.UseVisualStyleBackColor = true;
            this.button_rename.Click += new System.EventHandler(this.button_rename_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(483, 635);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(120, 35);
            this.button_delete.TabIndex = 12;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // textBox_direct
            // 
            this.textBox_direct.Location = new System.Drawing.Point(204, 739);
            this.textBox_direct.Name = "textBox_direct";
            this.textBox_direct.Size = new System.Drawing.Size(687, 27);
            this.textBox_direct.TabIndex = 13;
            // 
            // button_direct
            // 
            this.button_direct.Location = new System.Drawing.Point(897, 739);
            this.button_direct.Name = "button_direct";
            this.button_direct.Size = new System.Drawing.Size(62, 27);
            this.button_direct.TabIndex = 14;
            this.button_direct.Text = "Обзор";
            this.button_direct.UseVisualStyleBackColor = true;
            this.button_direct.Click += new System.EventHandler(this.button_direct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(143, 743);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Путь :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(204, 698);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(375, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Выберите директорию копирования";
            // 
            // button_Сopy
            // 
            this.button_Сopy.Location = new System.Drawing.Point(203, 786);
            this.button_Сopy.Name = "button_Сopy";
            this.button_Сopy.Size = new System.Drawing.Size(125, 35);
            this.button_Сopy.TabIndex = 17;
            this.button_Сopy.Text = "Копировать";
            this.button_Сopy.UseVisualStyleBackColor = true;
            this.button_Сopy.Click += new System.EventHandler(this.button_Сopy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_file);
            this.groupBox1.Controls.Add(this.radioButton_folder);
            this.groupBox1.Location = new System.Drawing.Point(582, 451);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(84, 82);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // radioButton_file
            // 
            this.radioButton_file.AutoSize = true;
            this.radioButton_file.Location = new System.Drawing.Point(6, 46);
            this.radioButton_file.Name = "radioButton_file";
            this.radioButton_file.Size = new System.Drawing.Size(66, 24);
            this.radioButton_file.TabIndex = 1;
            this.radioButton_file.Text = "Файл";
            this.radioButton_file.UseVisualStyleBackColor = true;
            // 
            // radioButton_folder
            // 
            this.radioButton_folder.AutoSize = true;
            this.radioButton_folder.Checked = true;
            this.radioButton_folder.Location = new System.Drawing.Point(6, 16);
            this.radioButton_folder.Name = "radioButton_folder";
            this.radioButton_folder.Size = new System.Drawing.Size(73, 24);
            this.radioButton_folder.TabIndex = 0;
            this.radioButton_folder.TabStop = true;
            this.radioButton_folder.Text = "Папка";
            this.radioButton_folder.UseVisualStyleBackColor = true;
            // 
            // button_select_file
            // 
            this.button_select_file.Location = new System.Drawing.Point(965, 539);
            this.button_select_file.Name = "button_select_file";
            this.button_select_file.Size = new System.Drawing.Size(118, 27);
            this.button_select_file.TabIndex = 20;
            this.button_select_file.Text = "Выбрать файл";
            this.button_select_file.UseVisualStyleBackColor = true;
            this.button_select_file.Click += new System.EventHandler(this.button_select_file_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(910, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Время работы программы:";
            // 
            // textBox_timer_work
            // 
            this.textBox_timer_work.Location = new System.Drawing.Point(1116, 12);
            this.textBox_timer_work.Name = "textBox_timer_work";
            this.textBox_timer_work.ReadOnly = true;
            this.textBox_timer_work.Size = new System.Drawing.Size(103, 27);
            this.textBox_timer_work.TabIndex = 23;
            this.textBox_timer_work.Text = "00:00:00";
            this.textBox_timer_work.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_createrinfo
            // 
            this.button_createrinfo.Font = new System.Drawing.Font("Times New Roman", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_createrinfo.Location = new System.Drawing.Point(1116, 45);
            this.button_createrinfo.Name = "button_createrinfo";
            this.button_createrinfo.Size = new System.Drawing.Size(103, 39);
            this.button_createrinfo.TabIndex = 24;
            this.button_createrinfo.Text = "Информация о создателе";
            this.button_createrinfo.UseVisualStyleBackColor = true;
            this.button_createrinfo.Click += new System.EventHandler(this.button_createrinfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1231, 836);
            this.Controls.Add(this.button_createrinfo);
            this.Controls.Add(this.textBox_timer_work);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_select_file);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Сopy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_direct);
            this.Controls.Add(this.textBox_direct);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_rename);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_folder);
            this.Controls.Add(this.button_obzor);
            this.Controls.Add(this.button_dinamic);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.Button_disk_info);
            this.Controls.Add(this.Output);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Button Button_disk_info;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_dinamic;
        private System.Windows.Forms.Button button_obzor;
        private System.Windows.Forms.TextBox textBox_folder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Button button_rename;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox textBox_direct;
        private System.Windows.Forms.Button button_direct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Сopy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_file;
        private System.Windows.Forms.RadioButton radioButton_folder;
        private System.Windows.Forms.Button button_select_file;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_timer;
        private System.Windows.Forms.TextBox textBox_timer_work;
        private System.Windows.Forms.Button button_createrinfo;
    }
}

