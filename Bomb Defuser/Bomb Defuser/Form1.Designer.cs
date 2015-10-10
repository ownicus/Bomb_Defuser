namespace Bomb_Defuser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabTasks = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabSimpleWires = new System.Windows.Forms.TabPage();
            this.radioButton3Wires = new System.Windows.Forms.RadioButton();
            this.radioButton4Wires = new System.Windows.Forms.RadioButton();
            this.radioButton5Wires = new System.Windows.Forms.RadioButton();
            this.radioButton6Wires = new System.Windows.Forms.RadioButton();
            this.labelCut = new System.Windows.Forms.Label();
            this.labelSoln = new System.Windows.Forms.Label();
            this.textBoxWire1 = new System.Windows.Forms.TextBox();
            this.textBoxWire2 = new System.Windows.Forms.TextBox();
            this.textBoxWire3 = new System.Windows.Forms.TextBox();
            this.textBoxWire4 = new System.Windows.Forms.TextBox();
            this.textBoxWire5 = new System.Windows.Forms.TextBox();
            this.textBoxWire6 = new System.Windows.Forms.TextBox();
            this.radioButtonSerialEven = new System.Windows.Forms.RadioButton();
            this.radioButtonSerialOdd = new System.Windows.Forms.RadioButton();
            this.labelSerial = new System.Windows.Forms.Label();
            this.tabTasks.SuspendLayout();
            this.tabSimpleWires.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTasks
            // 
            this.tabTasks.Controls.Add(this.tabPage1);
            this.tabTasks.Controls.Add(this.tabSimpleWires);
            this.tabTasks.Location = new System.Drawing.Point(2, 1);
            this.tabTasks.Name = "tabTasks";
            this.tabTasks.SelectedIndex = 0;
            this.tabTasks.Size = new System.Drawing.Size(835, 466);
            this.tabTasks.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(827, 440);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabSimpleWires
            // 
            this.tabSimpleWires.Controls.Add(this.labelSerial);
            this.tabSimpleWires.Controls.Add(this.radioButtonSerialOdd);
            this.tabSimpleWires.Controls.Add(this.radioButtonSerialEven);
            this.tabSimpleWires.Controls.Add(this.textBoxWire6);
            this.tabSimpleWires.Controls.Add(this.textBoxWire5);
            this.tabSimpleWires.Controls.Add(this.textBoxWire4);
            this.tabSimpleWires.Controls.Add(this.textBoxWire3);
            this.tabSimpleWires.Controls.Add(this.textBoxWire2);
            this.tabSimpleWires.Controls.Add(this.textBoxWire1);
            this.tabSimpleWires.Controls.Add(this.labelSoln);
            this.tabSimpleWires.Controls.Add(this.labelCut);
            this.tabSimpleWires.Controls.Add(this.radioButton6Wires);
            this.tabSimpleWires.Controls.Add(this.radioButton5Wires);
            this.tabSimpleWires.Controls.Add(this.radioButton4Wires);
            this.tabSimpleWires.Controls.Add(this.radioButton3Wires);
            this.tabSimpleWires.Location = new System.Drawing.Point(4, 22);
            this.tabSimpleWires.Name = "tabSimpleWires";
            this.tabSimpleWires.Padding = new System.Windows.Forms.Padding(3);
            this.tabSimpleWires.Size = new System.Drawing.Size(827, 440);
            this.tabSimpleWires.TabIndex = 1;
            this.tabSimpleWires.Text = "Simple Wires";
            this.tabSimpleWires.UseVisualStyleBackColor = true;
            // 
            // radioButton3Wires
            // 
            this.radioButton3Wires.AutoSize = true;
            this.radioButton3Wires.Location = new System.Drawing.Point(49, 47);
            this.radioButton3Wires.Name = "radioButton3Wires";
            this.radioButton3Wires.Size = new System.Drawing.Size(58, 17);
            this.radioButton3Wires.TabIndex = 0;
            this.radioButton3Wires.TabStop = true;
            this.radioButton3Wires.Text = "3 wires";
            this.radioButton3Wires.UseVisualStyleBackColor = true;
            this.radioButton3Wires.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton4Wires
            // 
            this.radioButton4Wires.AutoSize = true;
            this.radioButton4Wires.Location = new System.Drawing.Point(49, 70);
            this.radioButton4Wires.Name = "radioButton4Wires";
            this.radioButton4Wires.Size = new System.Drawing.Size(58, 17);
            this.radioButton4Wires.TabIndex = 1;
            this.radioButton4Wires.TabStop = true;
            this.radioButton4Wires.Text = "4 wires";
            this.radioButton4Wires.UseVisualStyleBackColor = true;
            this.radioButton4Wires.CheckedChanged += new System.EventHandler(this.radioButton4Wires_CheckedChanged);
            // 
            // radioButton5Wires
            // 
            this.radioButton5Wires.AutoSize = true;
            this.radioButton5Wires.Location = new System.Drawing.Point(49, 93);
            this.radioButton5Wires.Name = "radioButton5Wires";
            this.radioButton5Wires.Size = new System.Drawing.Size(58, 17);
            this.radioButton5Wires.TabIndex = 2;
            this.radioButton5Wires.TabStop = true;
            this.radioButton5Wires.Text = "5 wires";
            this.radioButton5Wires.UseVisualStyleBackColor = true;
            this.radioButton5Wires.CheckedChanged += new System.EventHandler(this.radioButton5Wires_CheckedChanged);
            // 
            // radioButton6Wires
            // 
            this.radioButton6Wires.AutoSize = true;
            this.radioButton6Wires.Location = new System.Drawing.Point(49, 116);
            this.radioButton6Wires.Name = "radioButton6Wires";
            this.radioButton6Wires.Size = new System.Drawing.Size(58, 17);
            this.radioButton6Wires.TabIndex = 3;
            this.radioButton6Wires.TabStop = true;
            this.radioButton6Wires.Text = "6 wires";
            this.radioButton6Wires.UseVisualStyleBackColor = true;
            this.radioButton6Wires.CheckedChanged += new System.EventHandler(this.radioButton6Wires_CheckedChanged);
            // 
            // labelCut
            // 
            this.labelCut.AutoSize = true;
            this.labelCut.Location = new System.Drawing.Point(46, 157);
            this.labelCut.Name = "labelCut";
            this.labelCut.Size = new System.Drawing.Size(26, 13);
            this.labelCut.TabIndex = 4;
            this.labelCut.Text = "Cut:";
            // 
            // labelSoln
            // 
            this.labelSoln.AutoSize = true;
            this.labelSoln.Location = new System.Drawing.Point(78, 157);
            this.labelSoln.Name = "labelSoln";
            this.labelSoln.Size = new System.Drawing.Size(0, 13);
            this.labelSoln.TabIndex = 5;
            // 
            // textBoxWire1
            // 
            this.textBoxWire1.Location = new System.Drawing.Point(182, 47);
            this.textBoxWire1.Name = "textBoxWire1";
            this.textBoxWire1.Size = new System.Drawing.Size(100, 20);
            this.textBoxWire1.TabIndex = 6;
            this.textBoxWire1.TextChanged += new System.EventHandler(this.textBoxWire1_TextChanged);
            // 
            // textBoxWire2
            // 
            this.textBoxWire2.Location = new System.Drawing.Point(182, 74);
            this.textBoxWire2.Name = "textBoxWire2";
            this.textBoxWire2.Size = new System.Drawing.Size(100, 20);
            this.textBoxWire2.TabIndex = 7;
            this.textBoxWire2.TextChanged += new System.EventHandler(this.textBoxWire2_TextChanged);
            // 
            // textBoxWire3
            // 
            this.textBoxWire3.Location = new System.Drawing.Point(182, 101);
            this.textBoxWire3.Name = "textBoxWire3";
            this.textBoxWire3.Size = new System.Drawing.Size(100, 20);
            this.textBoxWire3.TabIndex = 8;
            this.textBoxWire3.TextChanged += new System.EventHandler(this.textBoxWire3_TextChanged);
            // 
            // textBoxWire4
            // 
            this.textBoxWire4.Location = new System.Drawing.Point(182, 128);
            this.textBoxWire4.Name = "textBoxWire4";
            this.textBoxWire4.Size = new System.Drawing.Size(100, 20);
            this.textBoxWire4.TabIndex = 9;
            this.textBoxWire4.TextChanged += new System.EventHandler(this.textBoxWire4_TextChanged);
            // 
            // textBoxWire5
            // 
            this.textBoxWire5.Location = new System.Drawing.Point(182, 157);
            this.textBoxWire5.Name = "textBoxWire5";
            this.textBoxWire5.Size = new System.Drawing.Size(100, 20);
            this.textBoxWire5.TabIndex = 10;
            this.textBoxWire5.TextChanged += new System.EventHandler(this.textBoxWire5_TextChanged);
            // 
            // textBoxWire6
            // 
            this.textBoxWire6.Location = new System.Drawing.Point(182, 184);
            this.textBoxWire6.Name = "textBoxWire6";
            this.textBoxWire6.Size = new System.Drawing.Size(100, 20);
            this.textBoxWire6.TabIndex = 11;
            this.textBoxWire6.TextChanged += new System.EventHandler(this.textBoxWire6_TextChanged);
            // 
            // radioButtonSerialEven
            // 
            this.radioButtonSerialEven.AutoSize = true;
            this.radioButtonSerialEven.Location = new System.Drawing.Point(367, 47);
            this.radioButtonSerialEven.Name = "radioButtonSerialEven";
            this.radioButtonSerialEven.Size = new System.Drawing.Size(50, 17);
            this.radioButtonSerialEven.TabIndex = 12;
            this.radioButtonSerialEven.TabStop = true;
            this.radioButtonSerialEven.Text = "Even";
            this.radioButtonSerialEven.UseVisualStyleBackColor = true;
            // 
            // radioButtonSerialOdd
            // 
            this.radioButtonSerialOdd.AutoSize = true;
            this.radioButtonSerialOdd.Location = new System.Drawing.Point(367, 71);
            this.radioButtonSerialOdd.Name = "radioButtonSerialOdd";
            this.radioButtonSerialOdd.Size = new System.Drawing.Size(45, 17);
            this.radioButtonSerialOdd.TabIndex = 13;
            this.radioButtonSerialOdd.TabStop = true;
            this.radioButtonSerialOdd.Text = "Odd";
            this.radioButtonSerialOdd.UseVisualStyleBackColor = true;
            // 
            // labelSerial
            // 
            this.labelSerial.AutoSize = true;
            this.labelSerial.Location = new System.Drawing.Point(367, 28);
            this.labelSerial.Name = "labelSerial";
            this.labelSerial.Size = new System.Drawing.Size(139, 13);
            this.labelSerial.TabIndex = 14;
            this.labelSerial.Text = "Last digit of serial number is:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 479);
            this.Controls.Add(this.tabTasks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabTasks.ResumeLayout(false);
            this.tabSimpleWires.ResumeLayout(false);
            this.tabSimpleWires.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTasks;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabSimpleWires;
        private System.Windows.Forms.RadioButton radioButton6Wires;
        private System.Windows.Forms.RadioButton radioButton5Wires;
        private System.Windows.Forms.RadioButton radioButton4Wires;
        private System.Windows.Forms.RadioButton radioButton3Wires;
        private System.Windows.Forms.Label labelSoln;
        private System.Windows.Forms.Label labelCut;
        private System.Windows.Forms.TextBox textBoxWire6;
        private System.Windows.Forms.TextBox textBoxWire5;
        private System.Windows.Forms.TextBox textBoxWire4;
        private System.Windows.Forms.TextBox textBoxWire3;
        private System.Windows.Forms.TextBox textBoxWire2;
        private System.Windows.Forms.TextBox textBoxWire1;
        private System.Windows.Forms.Label labelSerial;
        private System.Windows.Forms.RadioButton radioButtonSerialOdd;
        private System.Windows.Forms.RadioButton radioButtonSerialEven;
    }
}

