using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
using Тесты.Properties;

namespace Тесты
{
    public class Question : Panel
    {
        TextBox questText = new TextBox();
        TextBox answer1 = new TextBox();
        TextBox answer2 = new TextBox();
        TextBox answer3 = new TextBox();
        TextBox answer4 = new TextBox();
        CheckBox one = new CheckBox();
        CheckBox two = new CheckBox();
        CheckBox three = new CheckBox();
        CheckBox four = new CheckBox();
        PictureBox picture1 = new PictureBox();
        PictureBox picture2 = new PictureBox();
        PictureBox picture3 = new PictureBox();
        PictureBox picture4 = new PictureBox();
        int type = 0;
        public Question(int type)
        {
            this.type = type;
            this.Location = new System.Drawing.Point(3, 3);
            this.Name = "QuestionType1";
            this.Size = new System.Drawing.Size(445, 300);
            this.TabIndex = 2;
            this.Visible = true;
            switch (type)
            {
                case 1:
                    {
                        //Question
                        this.questText.Location = new System.Drawing.Point(3, 3);
                        this.questText.Multiline = true;
                        this.questText.Name = "textBox1";
                        this.questText.Size = new System.Drawing.Size(365, 123);
                        this.questText.TabIndex = 1;

                        //Answer1
                        this.answer1.Location = new System.Drawing.Point(3 , 145);
                        this.answer1.Multiline = true;
                        this.answer1.Name = "textBox3";
                        this.answer1.Size = new System.Drawing.Size(180, 26);
                        this.answer1.TabIndex = 2;

                        //Answer2
                        this.answer2.Location = new System.Drawing.Point(3 , 177);
                        this.answer2.Multiline = true;
                        this.answer2.Name = "textBox3";
                        this.answer2.Size = new System.Drawing.Size(180, 26);
                        this.answer2.TabIndex = 2;

                        //Answer3
                        this.answer3.Location = new System.Drawing.Point(3 , 209);
                        this.answer3.Multiline = true;
                        this.answer3.Name = "textBox3";
                        this.answer3.Size = new System.Drawing.Size(180, 26);
                        this.answer3.TabIndex = 2;

                        //Answer4
                        this.answer4.Location = new System.Drawing.Point(3, 241);
                        this.answer4.Multiline = true;
                        this.answer4.Name = "textBox3";
                        this.answer4.Size = new System.Drawing.Size(180, 26);
                        this.answer4.TabIndex = 2;

                        //CheckBox1
                        this.one.AutoSize = true;
                        this.one.Location = new System.Drawing.Point( 215,  145);
                        this.one.Name = "checkBox1";
                        this.one.Size = new System.Drawing.Size(15, 14);
                        this.one.TabIndex = 6;
                        this.one.UseVisualStyleBackColor = true;

                        //CheckBox2
                        this.two.AutoSize = true;
                        this.two.Location = new System.Drawing.Point(215, 177);
                        this.two.Name = "checkBox2";
                        this.two.Size = new System.Drawing.Size(15, 14);
                        this.two.TabIndex = 7;
                        this.two.UseVisualStyleBackColor = true;

                        //CheckBox3
                        this.three.AutoSize = true;
                        this.three.Location = new System.Drawing.Point(215, 209);
                        this.three.Name = "checkBox3";
                        this.three.Size = new System.Drawing.Size(15, 14);
                        this.three.TabIndex = 8;
                        this.three.UseVisualStyleBackColor = true;

                        //CheckBox4
                        this.four.AutoSize = true;
                        this.four.Location = new System.Drawing.Point(215, 241);
                        this.four.Name = "checkBox4";
                        this.four.Size = new System.Drawing.Size(15, 14);
                        this.four.TabIndex = 9;
                        this.four.UseVisualStyleBackColor = true;

                        this.Controls.Add(this.questText);
                        this.Controls.Add(this.answer1);
                        this.Controls.Add(this.answer2);
                        this.Controls.Add(this.answer3);
                        this.Controls.Add(this.answer4);
                        this.Controls.Add(this.one);
                        this.Controls.Add(this.two);
                        this.Controls.Add(this.three);
                        this.Controls.Add(this.four);
                    }
                    break;
                case 2:
                    {
                        //Question
                        this.questText.Location = new System.Drawing.Point(3, 3);
                        this.questText.Multiline = true;
                        this.questText.Name = "textBox1";
                        this.questText.Size = new System.Drawing.Size(243, 249);
                        this.questText.TabIndex = 1;

                        //Answer1
                        this.answer1.Location = new System.Drawing.Point(3, 258);
                        this.answer1.Name = "textBox2";
                        this.answer1.Size = new System.Drawing.Size(243, 20);
                        this.answer1.TabIndex = 2;

                        //Picture
                        this.picture1.Location = new System.Drawing.Point(252, 3);
                        this.picture1.Name = "pictureBox1";
                        this.picture1.Size = new System.Drawing.Size(190, 249);
                        this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                        this.picture1.TabIndex = 0;
                        this.picture1.TabStop = false;
                        this.picture1.Click += new System.EventHandler(this.pictureBox1_Click);

                        this.Controls.Add(this.questText);
                        this.Controls.Add(this.answer1);
                        this.Controls.Add(this.picture1);
                    }
                    break;
                case 3:
                    {
                        //Question
                        this.questText.Location = new System.Drawing.Point(6, 3);
                        this.questText.Multiline = true;
                        this.questText.Name = "textBox1";
                        this.questText.Size = new System.Drawing.Size(436, 78);
                        this.questText.TabIndex = 6;

                        //Picture
                        this.picture1.Location = new System.Drawing.Point(242, 87);
                        this.picture1.Name = "pictureBox1";
                        this.picture1.Size = new System.Drawing.Size(200, 100);
                        this.picture1.TabIndex = 3;
                        this.picture1.TabStop = false;
                        this.picture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                        this.picture1.Image = Image.FromFile("im.png")
                        this.picture1.Click += new System.EventHandler(this.pictureBox1_Click);

                        //Picture
                        this.picture2.Location = new System.Drawing.Point(6, 87);
                        this.picture2.Name = "pictureBox2";
                        this.picture2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        this.picture2.Size = new System.Drawing.Size(200, 100);
                        this.picture2.TabIndex = 4;
                        this.picture2.TabStop = false;
                        this.picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                        this.picture2.Image = Image.FromFile("im.png")
                        this.picture2.Click += new System.EventHandler(this.pictureBox2_Click);

                        //Picture
                        this.picture3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        this.picture3.Location = new System.Drawing.Point(6, 197);
                        this.picture3.Name = "pictureBox3";
                        this.picture3.Size = new System.Drawing.Size(200, 100);
                        this.picture3.TabIndex = 2;
                        this.picture3.TabStop = false;
                        this.picture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                        this.picture3.Image = Image.FromFile("im.png")
                        this.picture3.Click += new System.EventHandler(this.pictureBox3_Click);

                        //Picture
                        this.picture4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        this.picture4.Location = new System.Drawing.Point(242, 197);
                        this.picture4.Name = "pictureBox4";
                        this.picture4.Size = new System.Drawing.Size(200, 100);
                        this.picture4.TabIndex = 5;
                        this.picture4.TabStop = false;
                        this.picture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                        this.picture4.Click += new System.EventHandler(this.pictureBox4_Click);
                        this.picture4.Image = Image.FromFile("im.png")

                        this.Controls.Add(this.questText);
                        this.Controls.Add(this.picture1);
                        this.Controls.Add(this.picture2);
                        this.Controls.Add(this.picture3);
                        this.Controls.Add(this.picture4);
                    }
                    break;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picture1.Image = Image.FromFile(openFile.FileName);
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picture2.Image = Image.FromFile(openFile.FileName);
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picture3.Image = Image.FromFile(openFile.FileName);
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picture4.Image = Image.FromFile(openFile.FileName);
            }
        }

        public string GetInfo()
        {
            if (this.type == 1)
            {
                return questText.Text+"\n"+answer1.Text+"\n"+answer2.Text+"\n" + answer3.Text + "\n" + answer4.Text;
            }
            else 
            {
                return questText.Text + "\n" + answer1.Text; 
            }
        }

    }
}
