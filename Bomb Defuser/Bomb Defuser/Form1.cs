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

        //radioButton3Wires
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.labelSoln.Text = "click";

            //update text boxes
            updateSimpleWiresTextBox(3);

            //call solver function
        }

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4Wires_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
