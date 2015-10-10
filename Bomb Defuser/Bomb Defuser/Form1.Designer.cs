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
            // 
            // textBoxWire2
            // 
            this.textBoxWire2.Location = new System.Drawing.Point(182, 74);
            this.textBoxWire2.Name = "textBoxWire2";
            this.textBoxWire2.Size = new System.Drawing.Size(100, 20);
            this.textBoxWire2.TabIndex = 7;
            // 
            // textBoxWire3
            // 
            this.textBoxWire3.Location = new System.Drawing.Point(182, 101);
            this.textBoxWire3.Name = "textBoxWire3";
            this.textBoxWire3.Size = new System.Drawing.Size(100, 20);
            this.textBoxWire3.TabIndex = 8;
            // 
            // textBoxWire4
            // 
            this.textBoxWire4.Location = new System.Drawing.Point(182, 128);
            this.textBoxWire4.Name = "textBoxWire4";
            this.textBoxWire4.Size = new System.Drawing.Size(100, 20);
            this.textBoxWire4.TabIndex = 9;
            // 
            // textBoxWire5
            // 
            this.textBoxWire5.Location = new System.Drawing.Point(182, 157);
            this.textBoxWire5.Name = "textBoxWire5";
            this.textBoxWire5.Size = new System.Drawing.Size(100, 20);
            this.textBoxWire5.TabIndex = 10;
            // 
            // textBoxWire6
            // 
            this.textBoxWire6.Location = new System.Drawing.Point(182, 184);
            this.textBoxWire6.Name = "textBoxWire6";
            this.textBoxWire6.Size = new System.Drawing.Size(100, 20);
            this.textBoxWire6.TabIndex = 11;
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
    }
}

