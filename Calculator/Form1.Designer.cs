namespace Calculator
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
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonPeriod = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSeven
            // 
            this.buttonSeven.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSeven.FlatAppearance.CheckedBackColor = System.Drawing.Color.MintCream;
            this.buttonSeven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeven.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSeven.Location = new System.Drawing.Point(12, 79);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(45, 45);
            this.buttonSeven.TabIndex = 0;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = false;
            this.buttonSeven.Click += new System.EventHandler(this.button_click);
            // 
            // buttonEight
            // 
            this.buttonEight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonEight.FlatAppearance.CheckedBackColor = System.Drawing.Color.MintCream;
            this.buttonEight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEight.Location = new System.Drawing.Point(63, 79);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(45, 45);
            this.buttonEight.TabIndex = 1;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = false;
            this.buttonEight.Click += new System.EventHandler(this.button_click);
            // 
            // buttonNine
            // 
            this.buttonNine.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonNine.FlatAppearance.CheckedBackColor = System.Drawing.Color.MintCream;
            this.buttonNine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonNine.Location = new System.Drawing.Point(114, 79);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(45, 45);
            this.buttonNine.TabIndex = 2;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = false;
            this.buttonNine.Click += new System.EventHandler(this.button_click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDivide.FlatAppearance.CheckedBackColor = System.Drawing.Color.MintCream;
            this.buttonDivide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivide.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDivide.Location = new System.Drawing.Point(165, 79);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(45, 45);
            this.buttonDivide.TabIndex = 3;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCE.FlatAppearance.CheckedBackColor = System.Drawing.Color.MintCream;
            this.buttonCE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCE.Location = new System.Drawing.Point(216, 79);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(50, 45);
            this.buttonCE.TabIndex = 4;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.button_clickCE);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.MintCream;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClear.Location = new System.Drawing.Point(216, 130);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(50, 45);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.button_clickC);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonMultiply.FlatAppearance.CheckedBackColor = System.Drawing.Color.MintCream;
            this.buttonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiply.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMultiply.Location = new System.Drawing.Point(165, 130);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(45, 45);
            this.buttonMultiply.TabIndex = 8;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonSix
            // 
            this.buttonSix.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSix.FlatAppearance.CheckedBackColor = System.Drawing.Color.MintCream;
            this.buttonSix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSix.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSix.Location = new System.Drawing.Point(114, 130);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(45, 45);
            this.buttonSix.TabIndex = 7;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = false;
            this.buttonSix.Click += new System.EventHandler(this.button_click);
            // 
            // buttonFive
            // 
            this.buttonFive.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonFive.FlatAppearance.CheckedBackColor = System.Drawing.Color.MintCream;
            this.buttonFive.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFive.Location = new System.Drawing.Point(63, 130);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(45, 45);
            this.buttonFive.TabIndex = 6;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = false;
            this.buttonFive.Click += new System.EventHandler(this.button_click);
            // 
            // buttonFour
            // 
            this.buttonFour.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonFour.FlatAppearance.CheckedBackColor = System.Drawing.Color.MintCream;
            this.buttonFour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFour.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFour.Location = new System.Drawing.Point(12, 130);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(45, 45);
            this.buttonFour.TabIndex = 5;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = false;
            this.buttonFour.Click += new System.EventHandler(this.button_click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonEquals.FlatAppearance.CheckedBackColor = System.Drawing.Color.MintCream;
            this.buttonEquals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEquals.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEquals.Location = new System.Drawing.Point(216, 181);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(50, 96);
            this.buttonEquals.TabIndex = 19;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = false;
            this.buttonEquals.Click += new System.EventHandler(this.Click_ButtonEquals);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPlus.FlatAppearance.CheckedBackColor = System.Drawing.Color.MintCream;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPlus.Location = new System.Drawing.Point(165, 232);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(45, 45);
            this.buttonPlus.TabIndex = 18;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonPeriod
            // 
            this.buttonPeriod.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPeriod.FlatAppearance.CheckedBackColor = System.Drawing.Color.MintCream;
            this.buttonPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPeriod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPeriod.Location = new System.Drawing.Point(114, 232);
            this.buttonPeriod.Name = "buttonPeriod";
            this.buttonPeriod.Size = new System.Drawing.Size(45, 45);
            this.buttonPeriod.TabIndex = 17;
            this.buttonPeriod.Text = ".";
            this.buttonPeriod.UseVisualStyleBackColor = false;
            this.buttonPeriod.Click += new System.EventHandler(this.button_click);
            // 
            // buttonZero
            // 
            this.buttonZero.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonZero.FlatAppearance.CheckedBackColor = System.Drawing.Color.MintCream;
            this.buttonZero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonZero.Location = new System.Drawing.Point(12, 232);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(96, 45);
            this.buttonZero.TabIndex = 15;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = false;
            this.buttonZero.Click += new System.EventHandler(this.button_click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSubtract.FlatAppearance.CheckedBackColor = System.Drawing.Color.MintCream;
            this.buttonSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubtract.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSubtract.Location = new System.Drawing.Point(165, 181);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(45, 45);
            this.buttonSubtract.TabIndex = 13;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = false;
            this.buttonSubtract.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonThree
            // 
            this.buttonThree.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonThree.FlatAppearance.CheckedBackColor = System.Drawing.Color.MintCream;
            this.buttonThree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThree.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonThree.Location = new System.Drawing.Point(114, 181);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(45, 45);
            this.buttonThree.TabIndex = 12;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = false;
            this.buttonThree.Click += new System.EventHandler(this.button_click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonTwo.FlatAppearance.CheckedBackColor = System.Drawing.Color.MintCream;
            this.buttonTwo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTwo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonTwo.Location = new System.Drawing.Point(63, 181);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(45, 45);
            this.buttonTwo.TabIndex = 11;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = false;
            this.buttonTwo.Click += new System.EventHandler(this.button_click);
            // 
            // buttonOne
            // 
            this.buttonOne.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonOne.FlatAppearance.CheckedBackColor = System.Drawing.Color.MintCream;
            this.buttonOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOne.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOne.Location = new System.Drawing.Point(12, 181);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(45, 45);
            this.buttonOne.TabIndex = 10;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.Click += new System.EventHandler(this.button_click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Result.Location = new System.Drawing.Point(12, 45);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ReadOnly = true;
            this.textBox_Result.Size = new System.Drawing.Size(254, 29);
            this.textBox_Result.TabIndex = 20;
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentOperation.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelCurrentOperation.Location = new System.Drawing.Point(12, 19);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(0, 24);
            this.labelCurrentOperation.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 390);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonPeriod);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonSeven);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonPeriod;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label labelCurrentOperation;
    }
}

