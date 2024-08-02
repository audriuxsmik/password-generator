using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {

        private static readonly Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            trackbar.Minimum = 5;
            trackbar.Maximum = 50;
            trackbar.Value = 10;
            pswsize.Text = "Password Length: 10";
    }
    private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void specialcheckbox_CheckedChanged(object sender, EventArgs e) //don`t need this mf 
        {

        }

        private void numberscheckbox_CheckedChanged(object sender, EventArgs e) //don`t need this mf 
        {

        }

        private void trackbar_Scroll(object sender, ScrollEventArgs e)
        {
            pswsize.Text = $"Password Length: {trackbar.Value}";
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e) //don`t need this mf 
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)  //don`t need this mf 
        {

        }

        private async void generatebutton_Click(object sender, EventArgs e)
        {
            await AnimatePasswordGeneration();
            pass.Text = GeneratePassword();
            copy.Visible = true; //copy label
        }
        private async Task Copylabel()
        {
            copylabel.Visible = true;
            await Task.Delay(2500);
            copylabel.Visible = false;
        }

        private string GeneratePassword()
        {
            int length = trackbar.Value;
            bool includeNumbers = numberscheckbox.Checked;
            bool includeSpecialCharacters = specialcheckbox.Checked;
            bool includeCapitalLetters = capitalcheckbox.Checked;
            const string alphabet = "wzsdxyiqfpolbtuevghcnjrmak";
            const string numbers = "702914580326485769301238574692";
            const string specialCharacters = "+)&~%*^(@^#(*&_!$)&~%*^(@^#("; 
            const string capitalLetters = "QYUZDABHWRPMKXJSOEFGIVNLTC";

            StringBuilder characters = new StringBuilder(alphabet);

            if (includeNumbers)
            {
                characters.Append(numbers);
            }

            if (includeSpecialCharacters)
            {
                characters.Append(specialCharacters);
            }
            if (includeCapitalLetters)
            {
                characters.Append(capitalLetters);
            }

            StringBuilder password = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                password.Append(characters[random.Next(characters.Length)]); //definitely best and safest way to generate it : D
            }

            return password.ToString();
        }

        private async Task AnimatePasswordGeneration()
        {
            const string animationCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$~%^&*()_+";
            int length = trackbar.Value; 
            StringBuilder animatedText = new StringBuilder();

            for (int i = 0; i < length; i++) //fr no cap bro
            {
                animatedText.Append(animationCharacters[random.Next(animationCharacters.Length)]); 
            }

            for (int i = 0; i < 7; i++) //anim length
            {
                for (int j = 0; j < length; j++)
                {
                    animatedText[j] = animationCharacters[random.Next(animationCharacters.Length)];
                }
                pass.Text = animatedText.ToString();
                await Task.Delay(35); //anim speed
            }
        }
        
        private async void copy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pass.Text))
            {
                Clipboard.SetText(pass.Text);
                await Copylabel();
            }
            else
            {
                MessageBox.Show("No password to copy!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e) 
        {
            string url = "https://github.com/audriuxsmik/password-generator";
            Process.Start(url);
        }
    }
}
