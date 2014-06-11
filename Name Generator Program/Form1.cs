using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NameGenerator;

namespace NameGeneratorDemo
{
    public partial class Form1 : Form
    {
        String[] patterns = new String[] { "CVC", "CVCN", "CCVVNN", "CVN", "NCVCN" };
        String lastGeneratedName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer myTimer = new Timer();
            
            radioButton1.Select();
            comboBox1.Enabled = true;

            for (int i = 0; i < patterns.Length; i++)
            {
                comboBox1.Items.Add(patterns[i]);
            }
            comboBox2.SelectedItem = "Generated Names...";
            
            myTimer.Enabled = true;
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            
            for (int i = 0; i < textbox3.Length; i++)
            {
                if (textbox3.Text[i] == "a" | "e" | "i" | "o" | "u") {
                    textbox3.Text = "";
                }
                // Repeat for Vowels and Numbers
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false)
            {
                textBox1.Enabled = true;
                comboBox1.Enabled = false;
            }
            else
            {
                comboBox1.Enabled = true;
                textBox1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String myPattern;

            if (radioButton1.Checked == false)
            {
                myPattern = textBox1.Text;
            }
            else
            {
                myPattern = comboBox1.SelectedItem.ToString();
            }

            lastGeneratedName = MainClass.GenerateName(myPattern, textBox3.Text, textBox2.Text, textBox4.Text).ToString();
            comboBox2.Items.Add(lastGeneratedName);
            MessageBox.Show(lastGeneratedName, "Generated name");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
