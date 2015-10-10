using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomb_Defuser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Shows correct amount of text boxes for how many wires are selected
        private void updateSimpleWiresTextBox(int numWires)
        {
            this.textBoxWire1.Visible = true;
            this.textBoxWire2.Visible = true;
            this.textBoxWire3.Visible = true;
            if (numWires == 3)
            {
                this.textBoxWire4.Visible = false;
                this.textBoxWire5.Visible = false;
                this.textBoxWire6.Visible = false;
            }
            else if (numWires == 4)
            {
                this.textBoxWire4.Visible = true;
                this.textBoxWire5.Visible = false;
                this.textBoxWire6.Visible = false;
            }
            else if (numWires == 5)
            {
                this.textBoxWire4.Visible = true;
                this.textBoxWire5.Visible = true;
                this.textBoxWire6.Visible = false;
            }
            else
            {
                this.textBoxWire4.Visible = true;
                this.textBoxWire5.Visible = true;
                this.textBoxWire6.Visible = true;
            }
        }

        //Figures out which wire to cut
        private void solve()
        {
            if (textBoxWire6.Visible)
            {
                wiresSolutionLogic(6);
            }
            else if (textBoxWire5.Visible)
            {
                wiresSolutionLogic(5);
            }
            else if (textBoxWire4.Visible)
            {
                wiresSolutionLogic(4);
            }
            else
            {
                wiresSolutionLogic(3);
            }
        }

        private void wiresSolutionLogic(int numWires)
        {
            labelSoln.Text = "";
            string wireCode = this.textBoxWire1.Text.ToUpper() + this.textBoxWire2.Text.ToUpper() + this.textBoxWire3.Text.ToUpper();
            if (numWires == 3)
            {
                //If there are no red wires, cut the second wire
                if ( wireCode.Contains("R") == false )
                {
                    this.labelSoln.Text = "2";
                }
                //If the last wire is white cut the last wire
                else if( wireCode[2] != 'W')
                {
                    this.labelSoln.Text = "3";
                }
                //if more than 1 blue wire, cut the last blue wire
                else if ( wireCode.Count(x => x == 'B') >= 2 )
                {
                    if( wireCode[2] == 'B')
                    {
                        this.labelSoln.Text = "3";
                    }
                    else
                    {
                        this.labelSoln.Text = "2";
                    }
                }
                //otherwise cut the last wire
                else
                {
                    this.labelSoln.Text = "3";
                }
            }
            else if(numWires == 4)
            {
                wireCode += this.textBoxWire4.Text;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        #region Radio Button Click
        /// <summary>
        /// When a radio button is clicked, update the text boxes and the solution
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //radioButton3Wires
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            updateSimpleWiresTextBox(3);
            solve();
        }
        private void radioButton4Wires_CheckedChanged(object sender, EventArgs e)
        {
            updateSimpleWiresTextBox(4);
            solve();
        }

        private void radioButton5Wires_CheckedChanged(object sender, EventArgs e)
        {
            updateSimpleWiresTextBox(5);
            solve();
        }

        private void radioButton6Wires_CheckedChanged(object sender, EventArgs e)
        {
            updateSimpleWiresTextBox(6);
            solve();
        }
        #endregion

        #region Text Box Updates
        /// <summary>
        /// When the user changes a text box, recalculate the answer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxWire1_TextChanged(object sender, EventArgs e)
        {
            solve();
        }

        private void textBoxWire2_TextChanged(object sender, EventArgs e)
        {
            solve();
        }

        private void textBoxWire3_TextChanged(object sender, EventArgs e)
        {
            solve();
        }

        private void textBoxWire4_TextChanged(object sender, EventArgs e)
        {
            solve();
        }

        private void textBoxWire5_TextChanged(object sender, EventArgs e)
        {
            solve();
        }

        private void textBoxWire6_TextChanged(object sender, EventArgs e)
        {
            solve();
        }
        #endregion
    }
}
