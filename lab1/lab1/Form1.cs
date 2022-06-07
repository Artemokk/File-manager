using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Timers;
using System.Reflection;

namespace lab1
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer timer = null;

        public MethodInfo mth;
        public object cls;

        public Form1()
        {
            InitializeComponent();

            timer = new System.Timers.Timer(1000);
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);
            timer.Start();

            
            Assembly asm = Assembly.LoadFrom(Application.StartupPath + "\\" + "createrinfo.dll"); //загружаем библиотеку из папки с исполняемым файлом
            Type classtype = asm.GetType("createrinfo.main"); //загружаем класс main из нашей библиотеки
            cls = Activator.CreateInstance(classtype); // создаем экземпляр нашего класса, который будет использоваться при вызове функции
            mth = classtype.GetMethod("createrinfo"); //ищем метод с названием "createrinfo"

        }

        DateTime time = new DateTime(0);

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            time = time.AddSeconds(1);
            textBox_timer_work.Invoke((MethodInvoker)delegate
            {
                textBox_timer_work.Text = time.ToLongTimeString();
            });
        }

        private void Button_disk_info_Click(object sender, EventArgs e)
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                try
                {
                    Output.AppendText("Имя диска: " + drive.Name + "\nТип диска: " + drive.DriveType + "\n");
                    if (drive.IsReady == true)
                    {
                        Output.AppendText("Файловая система: " + drive.DriveFormat +
                            "\nОбъем доступного свободного места для данного пользователя: " + Math.Round((double)drive.AvailableFreeSpace / 1024 / 1024 / 1024, 1) + " ГБ" +
                            "\nКорневой каталог диска: " + drive.RootDirectory +
                            "\nОбщий объем свободного места, доступного на диске: " + Math.Round((double)drive.TotalFreeSpace / 1024 / 1024 / 1024, 1) + " ГБ" +
                            "\nРазмер диска: " + Math.Round((double)drive.TotalSize / 1024 / 1024 / 1024, 1) + " ГБ" +
                            "\nМетка тома диска: " + drive.VolumeLabel + "\n");
                    }
                }
                catch { }

                Output.AppendText("\n");
            }
        }

        private void Button_reset_Click(object sender, EventArgs e)
        {
            Output.ResetText();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                try
                {
                    Output.AppendText("Имя диска: " + drive.Name + "\nТип диска: " + drive.DriveType + "\n");
                    if (drive.IsReady == true)
                    {
                        Output.AppendText("Файловая система: " + drive.DriveFormat +
                            "\nОбъем доступного свободного места для данного пользователя: " + Math.Round((double)drive.AvailableFreeSpace / 1024 / 1024 / 1024, 1) + " ГБ" +
                            "\nКорневой каталог диска: " + drive.RootDirectory +
                            "\nОбщий объем свободного места, доступного на диске: " + Math.Round((double)drive.TotalFreeSpace / 1024 / 1024 / 1024, 1) + " ГБ" +
                            "\nРазмер диска: " + Math.Round((double)drive.TotalSize / 1024 / 1024 / 1024, 1) + " ГБ" +
                            "\nМетка тома диска: " + drive.VolumeLabel + "\n");
                    }
                }
                catch { }

                Output.AppendText("\n");
            }
        }

        private void Button_dinamic_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void Output_TextChanged(object sender, EventArgs e)
        {
            Output.SelectionStart = Output.Text.Length;
            Output.ScrollToCaret();
        }

        private void button_obzor_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox_folder.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button_create_Click_1(object sender, EventArgs e)
        {
            if (radioButton_folder.Checked)
            {
                bool exists = Directory.Exists(textBox_folder.Text + "\\" + textBox_name.Text);
                if (!exists)
                {
                    if (textBox_name.Text == "")
                    {
                        MessageBox.Show("Введите название папки!");
                    }
                    else
                        Directory.CreateDirectory(textBox_folder.Text + "\\" + textBox_name.Text);
                }
                else
                {
                    MessageBox.Show("Папка с таким именем уже существует!");
                }
                textBox_name.Clear();
            }

            if (radioButton_file.Checked)
            {
                bool exists = File.Exists(textBox_folder.Text + "\\" + textBox_name.Text);
                if (!exists)
                {
                    if (textBox_name.Text == "")
                    {
                        MessageBox.Show("Введите название файла!");
                    }
                    else
                    {
                        FileStream fs = File.Create(path: textBox_folder.Text + "\\" + textBox_name.Text);
                        fs.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Файл с таким именем уже существует!");
                }
                textBox_name.Clear();
            }
        }

        private void button_rename_Click(object sender, EventArgs e)
        {
            if (radioButton_folder.Checked)
            {
                bool exists = Directory.Exists(textBox_folder.Text + "\\" + textBox_name.Text);
                if (!exists)
                {
                    if (textBox_name.Text == "")
                    {
                        MessageBox.Show("Введите название папки!");
                    }
                    else
                    {
                        int ind = textBox_folder.Text.LastIndexOf("\\");
                        Directory.Move(textBox_folder.Text, textBox_folder.Text.Remove(ind + 1) + textBox_name.Text);

                    }
                }
                else
                {
                    MessageBox.Show("Папка с таким именем уже существует!");
                }
                textBox_name.Clear();
            }

            if (radioButton_file.Checked)
            {
                bool exists = File.Exists(textBox_folder.Text + "\\" + textBox_name.Text);
                if (!exists)
                {
                    if (textBox_name.Text == "")
                    {
                        MessageBox.Show("Введите название файла!");
                    }
                    else
                    {
                        int ind = textBox_folder.Text.LastIndexOf("\\");
                        File.Move(textBox_folder.Text, textBox_folder.Text.Remove(ind + 1) + textBox_name.Text);

                    }
                }
                else
                {
                    MessageBox.Show("Файл с таким именем уже существует!");
                }
                textBox_name.Clear();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (radioButton_folder.Checked)
                try
                {
                    Directory.Delete(textBox_folder.Text, true);
                }
                catch
                {
                    MessageBox.Show("Выберите папку!");
                }

            if (radioButton_file.Checked)
                try
                {
                    File.Delete(textBox_folder.Text);
                }
                catch
                {
                    MessageBox.Show("Выберите файл!");
                }
        }

        private void button_direct_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox_direct.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button_Сopy_Click(object sender, EventArgs e)
        {
            if (radioButton_folder.Checked)
            {
                bool exists = Directory.Exists(textBox_folder.Text);
                if (exists)
                {
                    int ind = textBox_folder.Text.LastIndexOf("\\");

                    foreach (string dirPath in Directory.GetDirectories(textBox_folder.Text, "*", SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirPath.Replace(textBox_folder.Text, textBox_direct.Text + "\\" + textBox_folder.Text.Substring(ind + 1)));

                    foreach (string newPath in Directory.GetFiles(textBox_folder.Text, "*", SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(textBox_folder.Text, textBox_direct.Text + "\\" + textBox_folder.Text.Substring(ind + 1)), true);
                }
                else
                {
                    MessageBox.Show("Уже существует");
                }
            }

            if (radioButton_file.Checked)
            {
                int ind = textBox_folder.Text.LastIndexOf("\\");
                File.Copy(textBox_folder.Text, textBox_direct.Text + "\\" + textBox_folder.Text.Substring(ind + 1), true);
            }
        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void button_select_file_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
                textBox_folder.Text = ofd.FileName;
        }


        private void button_createrinfo_Click(object sender, EventArgs e)
        {
            string result = (string)mth.Invoke(cls, new object[] { });
            MessageBox.Show(result);
        }
    }

}
