using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opperman_A_Mathlist
{
    public partial class Mathlist : Form
    {
        public Mathlist()
        {
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            MathBox.Items.Clear();
            string path = pathBox.Text;

            try { 
            using (StreamReader sr = File.OpenText(path))
            {

                string readText = File.ReadAllText(path);

                String[] TextLines = readText.Split(Environment.NewLine.ToCharArray());

                foreach (string i in TextLines)
                {
                    try
                    {
                        if (i != "")
                        {
                            string x = (i.Substring(0, 1));
                            string y = (i.Substring(2, 1));
                            string mathOperator = (i.Substring(4, 1));
                            int mathresult;

                            try
                            {

                                switch (mathOperator)
                                {
                                    case "+":
                                        mathresult = int.Parse(x) + int.Parse(y);
                                        MathBox.Items.Add((i.Substring(0, 1)) + " + " + (i.Substring(2, 1) ) + " = " + mathresult);
                                        break;
                                    case "-":
                                        mathresult = int.Parse(x) - int.Parse(y);
                                        MathBox.Items.Add((i.Substring(0, 1)) + " - " + (i.Substring(2, 1) ) + " = " + mathresult);
                                        break;
                                    case "/":
                                        mathresult = int.Parse(x) / int.Parse(y);
                                        MathBox.Items.Add((i.Substring(0, 1)) + " / " + (i.Substring(2, 1)) + " = " + mathresult);
                                        break;
                                    case "*":
                                        mathresult = int.Parse(x) * int.Parse(y);
                                        MathBox.Items.Add((i.Substring(0, 1)) + " * " + (i.Substring(2, 1)) + " = " + mathresult);
                                        break;

                                }

                            } catch (Exception error){MathBox.Items.Add("Error Occured: " + error);}
                        }
                    }
                    catch(Exception error){ MathBox.Items.Add("Error Occured: "+ error);}

                }

                Console.WriteLine(readText);
                sr.Close();
            }

            }
            catch (Exception error) { MessageBox.Show("Invalid File: " + error);}
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter a text file's path into the File Location field, The program will then read through the file and calculate each line that meets the correct format of: \n"
            + "\n x,y,operator \n" 
            + "\n 2,2,+ outputs 2 + 2 = 4");
        }

    }
}
