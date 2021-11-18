using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace GuessingWord
{
    public partial class Form1 : Form
    {
        private int ticks = 180;
        private int Score;
        public Form1()
        {

            InitializeComponent();
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text += "A";
            inpput input = new inpput();   
            input.inputWord.Append(textBox2.Text);
           //MessageBox.Show(input.inputWord.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text += "N";
            inpput input = new inpput();
            input.inputWord.Append(textBox2.Text);
           //MessageBox.Show(input.inputWord.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            char[] letter = { 'A', 'G', 'N', 'D', 'E', 'R' };
            Random rand = new Random();
            letter = letter.OrderBy(y => rand.Next()).ToArray();
            foreach (char letters in letter)
            {
                
                labelLetters.Text += letters + " ";
            }
            textBox2.Enabled = false;
            MessageBox.Show("You have 180 seconds to guess a word, guess a word as many as you can! goods luck"); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text += "R";
            inpput input = new inpput();
            input.inputWord.Append(textBox2.Text);
            //MessageBox.Show(input.inputWord.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text += "E";
            inpput input = new inpput();
            input.inputWord.Append(textBox2.Text);
          //  MessageBox.Show(input.inputWord.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text += "G";
            inpput input = new inpput();
            input.inputWord.Append(textBox2.Text);
            //MessageBox.Show(input.inputWord.ToString());
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            textBox2.Text += "D";
            inpput input = new inpput();
            input.inputWord.Append(textBox2.Text);
            //MessageBox.Show(input.inputWord.ToString());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

            textBox2.Text = String.Empty;
        }

        private void label2_Click(object sender, EventArgs e)
        {

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
             Score = Convert.ToInt32(ScoreLBL.Text);
            ArrayList word = new ArrayList();
            word.Add("danger");
            word.Add("range");
            word.Add("red");
            word.Add("age");
            word.Add("gear");
            word.Add("anger");
            word.Add("aged");
            word.Add("darn");
            word.Add("dreg");
            word.Add("gaen");
            word.Add("grad");
            word.Add("nerd");
            word.Add("read");
            word.Add("ager");
            word.Add("dean");
            word.Add("earn");
            word.Add("gane");
            word.Add("gran");
            word.Add("rage");
            word.Add("rend");
            word.Add("dang");
            word.Add("dear");
            word.Add("egad");
            word.Add("nard");
            word.Add("rand");
            word.Add("dare");
            word.Add("drag");
            word.Add("gnar");
            word.Add("near");
            word.Add("raged");
            word.Add("rang");
            word.Add("grade");
            word.Add("redan");
            word.Add("grand");
            word.Add("regna");
            word.Add("garden");
            word.Add("ranged");
            word.Add("dag");
            word.Add("ran");
            word.Add("and");
            word.Add("era");
            word.Add("are");
            word.Add("ear");
            word.Add("rag");
         //   MessageBox.Show(word.Count.ToString());
            inpput input = new inpput();

            input.inputWord.Append(textBox2.Text);
          //  MessageBox.Show(input.inputWord.ToString());
            

                if (word.Contains(input.inputWord.ToString().ToLower()))
                {

                    Score += 1;
                    ScoreLBL.Text = Convert.ToString(Score);
                    textBox2.Text = String.Empty;

                }
                else
                {
                    textBox2.Text = String.Empty;
                MessageBox.Show("Invalid Word");
                }
            

               
            
          

            //comments
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            labelLetters.Text = String.Empty;
            char[] letter = { 'A', 'G', 'N', 'D', 'E', 'R' };
            Random rand = new Random();
            letter = letter.OrderBy(y => rand.Next()).ToArray();
            foreach (char letters in letter)
            {
                
                labelLetters.Text += letters + " ";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show(DateTime.Now.ToString());
            // countofWords.Text = TimeSpan.Zero.TotalMinutes.ToString();
            ticks--;
           countofWords.Text = ticks.ToString();
            if (ticks == 0)
            {
                countofWords.Text = "0";
                timer1.Stop();
                buttonA.Enabled = false;
                buttonN.Enabled = false;
                buttonD.Enabled = false;  
                buttonE.Enabled = false;
                buttonG.Enabled = false;
                buttonR.Enabled = false;
                buttonShuffle.Enabled = false;
                buttonClear.Enabled = false;
                buttonCheck.Enabled = false;
                MessageBox.Show("Game over!" + Environment.NewLine + "Your total Score is: "+Score);
            }
        }
    }

       
        

    
}
