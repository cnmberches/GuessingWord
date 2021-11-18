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
        private int ticks = 65;
        private int score;
        private StringBuilder inputWord = new StringBuilder();
        private ArrayList word = new ArrayList();
        private ArrayList alreadyAddedWords = new ArrayList();

        public Form1()
        {
            /**
             * CREATED BY:
             * LASCONIA, GABRIELLE IRA
             * DICHON, KEVYNN
             * BAUTISTA, RAMIL
             * BERCHES, CHARLES NICHOLAS 
             * 
             * BSIT504
             * 
             */
            InitializeComponent();
            timer1.Start();

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
            textBox.Enabled = false;
            MessageBox.Show("You have 60 seconds to guess a word, guess a word as many as you can! goodluck"); 
        }
        private int countColor = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks--;
            time.Text = ticks.ToString();
            if (ticks == 0)
            {
                time.Text = "0";
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
                MessageBox.Show("Game over!" + Environment.NewLine + "Your total Score is: "+ score);
            }
            time.Left = (panel.Width - time.Width) / 2;
            labelLetters.Left = (panel.Width - labelLetters.Width) / 2;
        }

        private void buttonClick(Button btn, String letter)
        {
            textBox.Text += letter;
            inputWord.Append(letter);
            btn.Enabled = false;
        }

        private void enableLetterBtns()
        {
            Button[] buttons = { buttonD, buttonA, buttonN, buttonG, buttonE, buttonR };

            foreach (Button button in buttons)
            {
                button.Enabled = true;
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonClick(buttonD, "D");
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonClick(buttonA, "A");
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            buttonClick(buttonN, "N");
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            buttonClick(buttonG, "G");
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            buttonClick(buttonE, "E");
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            buttonClick(buttonR, "R");
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            score = Convert.ToInt32(ScoreLBL.Text);
            String userWord = inputWord.ToString().ToLower();

            if (word.Contains(userWord))
            {
                alreadyAddedWords.Add(userWord);
                word.Remove(userWord);
                score += 1;
                ScoreLBL.Text = Convert.ToString(score);
                textBox.Text = String.Empty;
            }
            else if(alreadyAddedWords.Contains(userWord))
            {
                textBox.Text = String.Empty;
                MessageBox.Show("This word is already added!");
            }
            else
            {
                textBox.Text = String.Empty;
                MessageBox.Show("This word doesn't exist");
            }
            inputWord.Clear();
            enableLetterBtns();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox.Text = String.Empty;
            enableLetterBtns();
        }

        private void buttonShuffle_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            labelLetters.Text = String.Empty;
            char[] letter = { 'A', 'G', 'N', 'D', 'E', 'R' };
            letter = letter.OrderBy(y => rand.Next()).ToArray();
            foreach (char letters in letter)
            {
                labelLetters.Text += letters + " ";
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you really want to stop playing?", "Quit game", MessageBoxButtons.YesNo);
            if(exit == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
        }

    }


}
