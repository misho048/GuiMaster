using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui_Master
{
    public partial class Form1 : Form
    {
        private int _font = 10;
        private int counter = 0;
        public Form1()
        {
            InitializeComponent();
            comboBoxColor.SelectedIndex = 0;
            radioButtonNone.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(txtText.Text.Length);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            txtText.Font = new Font("Comic Sans MS", _font);
        }

        private void radioButtonMSSerif_CheckedChanged(object sender, EventArgs e)
        {
            txtText.Font = new Font("Microsoft Sans Serif", _font);
        }

        private void radioButtonArial_CheckedChanged(object sender, EventArgs e)
        {
            txtText.Font = new Font("Arial", _font);
        }

        private void textBoxFontSize_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxFontSize.Text, out int fontsize))
            {
                if (fontsize >= 1)
                {
                    _font = fontsize;
                    txtText.Font = new Font(Font.Name, _font);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtText.ForeColor = Color.FromName(comboBoxColor.SelectedItem.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtText.ReadOnly = (checkBoxReadOnly.Checked) ? true : false;

        }

        private void radioButtonLeft_CheckedChanged(object sender, EventArgs e)
        {
            txtText.Dock = DockStyle.Left;
        }

        private void radioButtonTop_CheckedChanged(object sender, EventArgs e)
        {
            txtText.Dock = DockStyle.Top;
        }

        private void radioButtonRight_CheckedChanged(object sender, EventArgs e)
        {
            txtText.Dock = DockStyle.Right;
        }

        private void radioButtonBottom_CheckedChanged(object sender, EventArgs e)
        {
            txtText.Dock = DockStyle.Bottom;
        }

        private void radioButtonNone_CheckedChanged(object sender, EventArgs e)
        {
            txtText.Dock = DockStyle.None;
        }

        private void checkBoxEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEnabled.Checked)
            {
                foreach (Control control in Controls)
                {
                    if (control != checkBoxEnabled)
                        control.Enabled = false;
                }

            }
            else
            {
                foreach (Control control in Controls)
                {
                    if (control != checkBoxEnabled)
                        control.Enabled = true;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int choice = counter % 4;
            switch (choice)
            {
                case 0:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\transformer1\source\repos\GuiMaster\Gui Master\Gui Master\bin\Debug\1.jpg");
                        break;
                    }
                case 1:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\transformer1\source\repos\GuiMaster\Gui Master\Gui Master\bin\Debug\2.jpg");
                        break;
                    }
                case 2:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\transformer1\source\repos\GuiMaster\Gui Master\Gui Master\bin\Debug\3.jpg");
                        break;
                    }
                case 3:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\transformer1\source\repos\GuiMaster\Gui Master\Gui Master\bin\Debug\4.jpg");
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            counter++;

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
            }
            else
            {
                progressBar1.Value = 0;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            labelMousePointer.Text = $"{Cursor.Position.X},{Cursor.Position.Y}";
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            labelMousePointer.Text = "";
        }

        private void buttonListBox_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(txtText.Text.Split(' '));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelListBox.Text = listBox1.SelectedItem.ToString();
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            labelMousePointer.Text = $"{Cursor.Position.X},{Cursor.Position.Y}";
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            labelMousePointer.Text = $"{Cursor.Position.X},{Cursor.Position.Y}";
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
