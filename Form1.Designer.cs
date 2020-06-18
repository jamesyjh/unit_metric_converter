namespace UnitsWindowsConverter_1
{
    partial class UnitConversionForm
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
            this.components = new System.ComponentModel.Container();
            this.clearButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.conversionTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.weightRadioButton = new System.Windows.Forms.RadioButton();
            this.timeRadioButton = new System.Windows.Forms.RadioButton();
            this.temperatureRadioButton = new System.Windows.Forms.RadioButton();
            this.lengthRadioButton = new System.Windows.Forms.RadioButton();
            this.unitTextBox1 = new System.Windows.Forms.TextBox();
            this.unitTextBox2 = new System.Windows.Forms.TextBox();
            this.unitLabel1 = new System.Windows.Forms.Label();
            this.unitLabel2 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.conversionTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(453, 218);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(60, 60);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "Clear";
            this.toolTip1.SetToolTip(this.clearButton, "Clear Input");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Clicked);
            // 
            // conversionTypeGroupBox
            // 
            this.conversionTypeGroupBox.Controls.Add(this.weightRadioButton);
            this.conversionTypeGroupBox.Controls.Add(this.timeRadioButton);
            this.conversionTypeGroupBox.Controls.Add(this.temperatureRadioButton);
            this.conversionTypeGroupBox.Controls.Add(this.lengthRadioButton);
            this.conversionTypeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.conversionTypeGroupBox.Name = "conversionTypeGroupBox";
            this.conversionTypeGroupBox.Size = new System.Drawing.Size(229, 144);
            this.conversionTypeGroupBox.TabIndex = 2;
            this.conversionTypeGroupBox.TabStop = false;
            this.conversionTypeGroupBox.Text = "Conversion Type";
            this.toolTip1.SetToolTip(this.conversionTypeGroupBox, "Select the type of units to convert between");
            // 
            // weightRadioButton
            // 
            this.weightRadioButton.AutoSize = true;
            this.weightRadioButton.Location = new System.Drawing.Point(6, 113);
            this.weightRadioButton.Name = "weightRadioButton";
            this.weightRadioButton.Size = new System.Drawing.Size(73, 21);
            this.weightRadioButton.TabIndex = 3;
            this.weightRadioButton.Text = "Weight";
            this.toolTip1.SetToolTip(this.weightRadioButton, "Select the type of units to convert between");
            this.weightRadioButton.UseVisualStyleBackColor = true;
            this.weightRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // timeRadioButton
            // 
            this.timeRadioButton.AutoSize = true;
            this.timeRadioButton.Location = new System.Drawing.Point(6, 86);
            this.timeRadioButton.Name = "timeRadioButton";
            this.timeRadioButton.Size = new System.Drawing.Size(60, 21);
            this.timeRadioButton.TabIndex = 2;
            this.timeRadioButton.Text = "Time";
            this.toolTip1.SetToolTip(this.timeRadioButton, "Select the type of units to convert between");
            this.timeRadioButton.UseVisualStyleBackColor = true;
            this.timeRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // temperatureRadioButton
            // 
            this.temperatureRadioButton.AutoSize = true;
            this.temperatureRadioButton.Location = new System.Drawing.Point(6, 59);
            this.temperatureRadioButton.Name = "temperatureRadioButton";
            this.temperatureRadioButton.Size = new System.Drawing.Size(111, 21);
            this.temperatureRadioButton.TabIndex = 1;
            this.temperatureRadioButton.Text = "Temperature";
            this.toolTip1.SetToolTip(this.temperatureRadioButton, "Select the type of units to convert between");
            this.temperatureRadioButton.UseVisualStyleBackColor = true;
            this.temperatureRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // lengthRadioButton
            // 
            this.lengthRadioButton.AutoSize = true;
            this.lengthRadioButton.Checked = true;
            this.lengthRadioButton.Location = new System.Drawing.Point(6, 32);
            this.lengthRadioButton.Name = "lengthRadioButton";
            this.lengthRadioButton.Size = new System.Drawing.Size(73, 21);
            this.lengthRadioButton.TabIndex = 0;
            this.lengthRadioButton.TabStop = true;
            this.lengthRadioButton.Text = "Length";
            this.toolTip1.SetToolTip(this.lengthRadioButton, "Select the type of units to convert between");
            this.lengthRadioButton.UseVisualStyleBackColor = true;
            this.lengthRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // unitTextBox1
            // 
            this.unitTextBox1.Location = new System.Drawing.Point(18, 195);
            this.unitTextBox1.Name = "unitTextBox1";
            this.unitTextBox1.Size = new System.Drawing.Size(223, 22);
            this.unitTextBox1.TabIndex = 15;
            this.toolTip1.SetToolTip(this.unitTextBox1, "Type in a value and it will automatically be converted");
            this.unitTextBox1.TextChanged += new System.EventHandler(this.unitTextBox_TextChanged);
            this.unitTextBox1.Enter += new System.EventHandler(this.textBox_Enter);
            this.unitTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.unitTextBoxRestrictInput_KeyDown);
            // 
            // unitTextBox2
            // 
            this.unitTextBox2.Location = new System.Drawing.Point(18, 252);
            this.unitTextBox2.Name = "unitTextBox2";
            this.unitTextBox2.Size = new System.Drawing.Size(223, 22);
            this.unitTextBox2.TabIndex = 16;
            this.toolTip1.SetToolTip(this.unitTextBox2, "Type in a value and it will automatically be converted");
            this.unitTextBox2.TextChanged += new System.EventHandler(this.unitTextBox_TextChanged);
            this.unitTextBox2.Enter += new System.EventHandler(this.textBox_Enter);
            this.unitTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.unitTextBoxRestrictInput_KeyDown);
            // 
            // unitLabel1
            // 
            this.unitLabel1.AutoSize = true;
            this.unitLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.unitLabel1.Location = new System.Drawing.Point(13, 167);
            this.unitLabel1.Name = "unitLabel1";
            this.unitLabel1.Size = new System.Drawing.Size(51, 25);
            this.unitLabel1.TabIndex = 17;
            this.unitLabel1.Text = "Feet";
            this.toolTip1.SetToolTip(this.unitLabel1, "Type in a value and it will automatically be converted");
            // 
            // unitLabel2
            // 
            this.unitLabel2.AutoSize = true;
            this.unitLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.unitLabel2.Location = new System.Drawing.Point(13, 223);
            this.unitLabel2.Name = "unitLabel2";
            this.unitLabel2.Size = new System.Drawing.Size(72, 25);
            this.unitLabel2.TabIndex = 18;
            this.unitLabel2.Text = "Meters";
            this.toolTip1.SetToolTip(this.unitLabel2, "Type in a value and it will automatically be converted");
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(519, 20);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 60);
            this.button8.TabIndex = 4;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.digitButton_Clicked);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(453, 20);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 60);
            this.button7.TabIndex = 5;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.digitButton_Clicked);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(585, 20);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 60);
            this.button9.TabIndex = 6;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.digitButton_Clicked);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(453, 86);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.TabIndex = 7;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.digitButton_Clicked);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(519, 86);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 60);
            this.button5.TabIndex = 8;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.digitButton_Clicked);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(585, 86);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 60);
            this.button6.TabIndex = 9;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.digitButton_Clicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 10;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.digitButton_Clicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(519, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 11;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.digitButton_Clicked);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(585, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 12;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.digitButton_Clicked);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(519, 218);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(60, 60);
            this.button0.TabIndex = 13;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.digitButton_Clicked);
            // 
            // decimalButton
            // 
            this.decimalButton.Location = new System.Drawing.Point(585, 218);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(60, 60);
            this.decimalButton.TabIndex = 14;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.digitButton_Clicked);
            // 
            // UnitConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 391);
            this.Controls.Add(this.unitLabel2);
            this.Controls.Add(this.unitLabel1);
            this.Controls.Add(this.unitTextBox2);
            this.Controls.Add(this.unitTextBox1);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.conversionTypeGroupBox);
            this.Controls.Add(this.clearButton);
            this.Name = "UnitConversionForm";
            this.Text = "Unit Conversion Application";
            this.conversionTypeGroupBox.ResumeLayout(false);
            this.conversionTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox conversionTypeGroupBox;
        private System.Windows.Forms.RadioButton lengthRadioButton;
        private System.Windows.Forms.RadioButton weightRadioButton;
        private System.Windows.Forms.RadioButton timeRadioButton;
        private System.Windows.Forms.RadioButton temperatureRadioButton;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.TextBox unitTextBox1;
        private System.Windows.Forms.TextBox unitTextBox2;
        private System.Windows.Forms.Label unitLabel1;
        private System.Windows.Forms.Label unitLabel2;
    }
}

