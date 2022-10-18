using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Tasc1
{
    public partial class SplittingForm : Form
    {
        private string text;
        private SplittingNumbers split = new SplittingNumbers();
        private WorkingWithAFile file = new WorkingWithAFile();


        public SplittingForm()
        {
            InitializeComponent();

            textBox1.Text = "Введите число";
        }

        // Используем кнопку для разбиения числа. И выводим результат
        private void Button1_Click(object sender, EventArgs e)
        {
            text = split.spliting(textBox1.Text);
            label1.Text = text;
        }

        // Используем наведение в поле ввода, для очистки введеных ранее данных
        private void TextBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        // Используем выбор другого действия с пустым полем ввода, для присвоения нового текста
        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == ""){
                textBox1.Text = "введите число";
            }
        }

        // Используем кнопку для сохранения результатов
        private void Button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                textBox1.Text = "введите число";
            } else { 
                text = file.saveAnEntry(textBox1.Text);
                label1.Text = text;
                textBox1.Text = "";
            }
        }

        // Используем кнопку для загрузки данных из файла
        private void Button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.InitialDirectory = "C:\\Users\\user\\Desktop";
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            WorkingWithAFile working = new WorkingWithAFile();
            working.setPath(filename);
            textBox1.Text = working.uploadAFile();
        }

    }
}
