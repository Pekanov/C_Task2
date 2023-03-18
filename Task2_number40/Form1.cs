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
            
            

            // ��������� ���� ����������
            saveFileDialog.ShowDialog();

            // ������������ ������ ���� �� ��������� ���� ����
            string path = saveFileDialog.FileName;

            try
            {
                // ������� ���� ��������� ����������� using

                using (FileStream fs = File.Create(path))
                {

                    // ������� ���������� ���� ������� ������
                    // � ����������� �� ����� �������� ������ � �����
                    byte[] info = new UTF8Encoding(true).GetBytes(File1TextBox.Text + "\t" + File2TextBox.Text);
                    // ���������� ������ ������ � ����
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