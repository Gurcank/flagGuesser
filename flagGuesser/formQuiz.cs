using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flagGuesser
{
    public partial class formQuiz : Form
    {
        List<FlagData> flagList; //Creates a list named flagList using the FlagData class.

        int currentQuestion = 0;
        int score = 0;
        string correctAnswer = "";
        Random rnd = new Random();

        internal formQuiz(List<FlagData> selectedFlags)
        {
            InitializeComponent();
            flagList = selectedFlags; //The list of flags selected for the game is imported from outside.
            startQuiz();

        }
        private void startQuiz() 
        { 
           currentQuestion = 0;
            score = 0;
            loadNextFlag();
        }
        private void loadNextFlag()
        {
            if (currentQuestion >= flagList.Count)
            {
                MessageBox.Show("Your score: "+score , "Game Over!",MessageBoxButtons.OK );
                Application.Exit();
            }

            //Clear
            btnNext.Visible = false;
            resetOptions();

            //Flag data
            FlagData currentFlag = flagList[currentQuestion];
            correctAnswer = currentFlag.countryName;

            pictureBox1.Image = Image.FromFile(currentFlag.imagePath);

            //Set options
            List<string> options = new List<string> { correctAnswer };
            
            //Add random options 
            while (options.Count < 4)
            {
                var randomFlag = flagList[rnd.Next(flagList.Count)];
                if(!options.Contains(randomFlag.countryName))  //Checks if the country of the randomly selected flag (randomFlag.countryName) is in the options list.
                    options.Add(randomFlag.countryName);       //If this flag is not in the options list (!options.Contains()), it is added as a new option. This prevents the same flag from being added as an option more than once.
            }

            //Mix options and distribute to options
            options = options.OrderBy(x => rnd.Next()).ToList();
            option1.Text = options[0];
            option2.Text = options[1];
            option3.Text = options[2];
            option4.Text = options[3];

            lblProgress.Text = (currentQuestion + 1)+ "/" + (flagList.Count());
            lblScore.Text = "Score: " + score;

        }

       
        private void option_Click(object sender, EventArgs e)
        {
            Button click = (Button)sender;

            disableOptions();

            if (click.Text == correctAnswer)
            {
                click.BackColor = Color.Green;
                score++;
            }
            else
            {
                click.BackColor = Color.Red;

                //Make correct one green
                foreach (var btn in new[] { option1, option2, option3, option4 })
                {
                    if (btn.Text == correctAnswer)
                    {
                        btn.BackColor = Color.Green;
                        break;
                    }
                }
            }
            lblScore.Text = "Score: "+score;
            btnNext.Visible = true;
        }
        private void resetOptions()
        {
            foreach (var btn in new[] { option1, option2, option3, option4 })
            {
                btn.Enabled = true;
                btn.BackColor = SystemColors.Control;
            }
        }
        private void disableOptions()
        {
            foreach (var btn in new[] { option1, option2, option3, option4 })
            {
                btn.Enabled = false;
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentQuestion++;
            loadNextFlag();
        }
    }
}
