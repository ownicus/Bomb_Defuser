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

        #region Simple Wire Solver
        //Shows correct amount of text boxes for how many wires are selected
        private void updateSimpleWiresTextBox(int numWires)
        {
            if (numWires == 3)
            {
                this.textBoxWire4.Visible = false;
                this.textBoxWire5.Visible = false;
                this.textBoxWire6.Visible = false;
                this.labelWire4.Visible = false;
                this.labelWire5.Visible = false;
                this.labelWire6.Visible = false;
            }
            else if (numWires == 4)
            {
                this.textBoxWire4.Visible = true;
                this.textBoxWire5.Visible = false;
                this.textBoxWire6.Visible = false;
                this.labelWire4.Visible = true;
                this.labelWire5.Visible = false;
                this.labelWire6.Visible = false;
            }
            else if (numWires == 5)
            {
                this.textBoxWire4.Visible = true;
                this.textBoxWire5.Visible = true;
                this.textBoxWire6.Visible = false;
                this.labelWire4.Visible = true;
                this.labelWire5.Visible = true;
                this.labelWire6.Visible = false;
            }
            else
            {
                this.textBoxWire4.Visible = true;
                this.textBoxWire5.Visible = true;
                this.textBoxWire6.Visible = true;
                this.labelWire4.Visible = true;
                this.labelWire5.Visible = true;
                this.labelWire6.Visible = true;
            }
        }
        #region Solver
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
            string wireCode;

            generateWireCode(out wireCode, numWires);

            //only solve if we have valid entries
            if(wireCode.Length != numWires)
            {
                this.labelSoln.Text = "";
                return;
            }

            //Wire cases
            if (numWires == 3)
            {
                threeWireSolver(wireCode);
            }
            else if (numWires == 4)
            {
                fourWireSolver(wireCode);
            }
            else if (numWires == 5)
            {
                fiveWireSolver(wireCode);

            }
            else //6 wires
            {
                sixWireSolver(wireCode);
            }
        }

        //Gets the wire code from the appropriate text boxes
        private void generateWireCode(out string wireCode, int numWires)
        {
            wireCode = this.textBoxWire1.Text.ToUpper() + this.textBoxWire2.Text.ToUpper() + this.textBoxWire3.Text.ToUpper();
            switch (numWires)
            {
                case 6:
                    wireCode += this.textBoxWire4.Text.ToUpper() + this.textBoxWire5.Text.ToUpper() + this.textBoxWire6.Text.ToUpper();
                    break;
                case 5:
                    wireCode += this.textBoxWire4.Text.ToUpper() + this.textBoxWire5.Text.ToUpper();
                    break;
                case 4:
                    wireCode += this.textBoxWire4.Text.ToUpper() + this.textBoxWire5.Text.ToUpper();
                    break;
                case 3:
                    break;
                default:
                    wireCode = "";
                    break;
            }
        }
        #region Wire Solver Logic
        /// <summary>
        /// Solves a given puzzle based on the wire code.
        /// Outputs the result to the solution field
        /// </summary>
        /// <param name="wireCode"></param>
        private void threeWireSolver(string wireCode)
        {
            //If there are no red wires, cut the second wire
            if (wireCode.Contains("R") == false)
            {
                this.labelSoln.Text = "2";
            }
            //If the last wire is white
            else if (wireCode[2] != 'W')
            {
                //cut last wire
                this.labelSoln.Text = "3";
            }
            //if more than 1 blue wire
            else if (wireCode.Count(x => x == 'B') >= 2)
            {
                //cut last blue wire
                this.labelSoln.Text = (wireCode.LastIndexOf('B') + 1).ToString();
            }
            //otherwise cut the last wire
            else
            {
                this.labelSoln.Text = "3";
            }
        }

        /// <summary>
        /// Solves a given puzzle based on the wire code.
        /// Outputs the result to the solution field
        /// </summary>
        /// <param name="wireCode"></param>
        private void fourWireSolver(string wireCode)
        {
            //if more than 1 red and last serial digit is odd
            if ((wireCode.Count(x => x == 'R') >= 2) &&
                this.radioButtonSerialOdd.Checked)
            {
                //cut last red wire
                this.labelSoln.Text = (wireCode.LastIndexOf('R') + 1).ToString();
            }

            //or if last wire is yellow and there are no red wires
            else if ((wireCode[3] == 'Y') &&
                    !wireCode.Contains('R'))
            {
                //cut first wire
                this.labelSoln.Text = "1";
            }

            //if there is exactly one blue wire
            else if (wireCode.Count(x => x == 'B') == 1)
            {
                //cut first wire
                this.labelSoln.Text = "1";
            }

            //if there is more than one yellow wire
            else if (wireCode.Count(x => x == 'Y') >= 2)
            {
                //cut last wire
                this.labelSoln.Text = "4";
            }

            //cut the second wire
            else
            {
                this.labelSoln.Text = "2";
            }
        }

        /// <summary>
        /// Solves a given puzzle based on the wire code.
        /// Outputs the result to the solution field
        /// </summary>
        /// <param name="wireCode"></param>
        private void fiveWireSolver(string wireCode)
        {
            //last wire is black and last serial digit is odd
            if ( (wireCode[4] == 'K') &&
                this.radioButtonSerialOdd.Checked )
            {
                //cut last red wire
                this.labelSoln.Text = "4";
            }

            //one red wire and move than one yellow
            else if( (wireCode.Count(x => x == 'R') == 1) &&
                (wireCode.Count(x => x == 'Y') >= 2))
            {
                //cut the first wire
                this.labelSoln.Text = "1";
            }

            //no black wires
            else if(!wireCode.Contains("K"))
            {
                //cut the second wire
                this.labelSoln.Text = "2";
            }

            else
            {
                //cut the first wire
                this.labelSoln.Text = "1";
            }
        }

        /// <summary>
        /// Solves a given puzzle based on the wire code.
        /// Outputs the result to the solution field
        /// </summary>
        /// <param name="wireCode"></param>
        private void sixWireSolver(string wireCode)
        {
            //no yellow wires and last serial digit is odd
            if ( (!wireCode.Contains("Y")) &&
                 this.radioButtonSerialOdd.Checked)
            {
                //cut third wire
                this.labelSoln.Text = "3";
            }

            else if( (wireCode.Count(x => x == 'Y') == 1) &&
                     (wireCode.Count(x => x == 'W') >= 2))
            {
                //cut fourth wire
                this.labelSoln.Text = "4";
            }

            else if (!wireCode.Contains("R"))
            {
                //cut last wire
                this.labelSoln.Text = "6";
            }

            else
            {
                //cut fourth wire
                this.labelSoln.Text = "4";
            }
        }
        #endregion

        #endregion //Solver
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        #region Field Changes State Events
        /// <summary>
        /// When a radio button is clicked, update the text boxes and the solution
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //radioButton3Wires
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3Wires.Checked)
            {
                updateSimpleWiresTextBox(3);
                solve();
            }
        }
        private void radioButton4Wires_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4Wires.Checked)
            {
                updateSimpleWiresTextBox(4);
                solve();
            }
        }

        private void radioButton5Wires_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5Wires.Checked)
            {
                updateSimpleWiresTextBox(5);
                solve();
            }
        }

        private void radioButton6Wires_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6Wires.Checked)
            {
                updateSimpleWiresTextBox(6);
                solve();
            }
        }

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

        //If a serial button is clicked
        private void radioButtonSerialEven_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonSerialEven.Checked)
            {
                solve();
            }
        }

        private void radioButtonSerialOdd_CheckedChanged_1(object sender, EventArgs e)
        {
            if (this.radioButtonSerialOdd.Checked)
            {
                solve();
            }
        }
        #endregion

        #endregion

    }
}

