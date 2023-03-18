using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Task2_number40
{
    public partial class Form1 : Form
    {   
        
        
        private String file1path;
        private String file2path;
        
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private SaveFileDialog saveFileDialog = new SaveFileDialog();
        


        public Form1()
        {
            InitializeComponent();
        }

        private void ReadFile1Button_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                file1path = openFileDialog.FileName;
                File1TextBox.Clear();
                File1TextBox.Text = File.ReadAllText(file1path);
            }
        }

        private void ReadFile2Button_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                file2path = openFileDialog.FileName;
                File2TextBox.Clear();
                File2TextBox.Text = File.ReadAllText(file2path);
            }
        }

        private void SaveNewFileButton_Click(object sender, EventArgs e)
        {
            
            

            // открываем окно сохранения
            saveFileDialog.ShowDialog();

            // присваниваем строке путь из открытого нами окна
            string path = saveFileDialog.FileName;

            try
            {
                // создаем файл используя конструкцию using

                using (FileStream fs = File.Create(path))
                {

                    // создаем переменную типа массива байтов
                    // и присваиваем ей метод перевода текста в байты
                    byte[] info = new UTF8Encoding(true).GetBytes(File1TextBox.Text + "\t" + File2TextBox.Text);
                    // производим запись байтов в файл
                    fs.Write(info, 0, info.Length);


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }


        }


       



        private void concatFile()
        {

        }

   

        private void blokWrite()
        {

        }



    }
}