using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тесты
{
    public partial class Form1 : Form
    {
        public List<Question> questions = new List<Question>();
        public Form1()
        {
            InitializeComponent();
        }
        public Question quest = new Question(1);
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var i in questions)
                i.Hide();
            quest = new Question(1);
            questions.Add(quest);
            Controls.Add(quest);
            if (questions.Count != 0 && !listBox1.Items.Contains($"Вопрос {questions.Count}"))
            { 
                listBox1.Items.Add(questions);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            foreach (var i in questions)
                i.Hide();
            quest = new Question(2);
            questions.Add(quest);
            Controls.Add(quest);
            if (questions.Count != 0 && !listBox1.Items.Contains($"Вопрос {questions.Count}"))
            {
                listBox1.Items.Add(questions);
            }
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            if (questions.Count != 0)
            {
                string test = "";
                foreach (var i in questions)
                    test+= i.GetInfo()+"\n";
                File.WriteAllText("test.txt", test);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            { 
                foreach (var i in questions)
                    i.Hide();
                questions[listBox1.SelectedIndex].Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                questions[listBox1.SelectedIndex].Dispose();
                questions.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (var i in questions)
                i.Hide();
            quest = new Question(3);
            questions.Add(quest);
            Controls.Add(quest);
            if (questions.Count != 0 && !listBox1.Items.Contains($"Вопрос {questions.Count}"))
            {
                listBox1.Items.Add(questions);
            }
        }
    }
}
