﻿namespace Calc_Step1
{
    partial class frmCalculator
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnDP = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnMadd = new System.Windows.Forms.Button();
            this.btnMsub = new System.Windows.Forms.Button();
            this.btnMrec = new System.Windows.Forms.Button();
            this.btnMclr = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnBksp = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.Black;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.ForeColor = System.Drawing.Color.Aquamarine;
            this.txtDisplay.Location = new System.Drawing.Point(22, 22);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(440, 38);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(219, 265);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(63, 45);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.BtnClick);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(111, 262);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(63, 45);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.BtnClick);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(22, 262);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(63, 45);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnDP
            // 
            this.btnDP.Font = new System.Drawing.Font("Webdings", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnDP.Location = new System.Drawing.Point(219, 325);
            this.btnDP.Name = "btnDP";
            this.btnDP.Size = new System.Drawing.Size(63, 45);
            this.btnDP.TabIndex = 9;
            this.btnDP.Text = "n";
            this.btnDP.UseVisualStyleBackColor = true;
            this.btnDP.Click += new System.EventHandler(this.btnDP_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(22, 326);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(152, 45);
            this.btn0.TabIndex = 7;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnMadd
            // 
            this.btnMadd.BackColor = System.Drawing.Color.PowderBlue;
            this.btnMadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMadd.Location = new System.Drawing.Point(22, 85);
            this.btnMadd.Name = "btnMadd";
            this.btnMadd.Size = new System.Drawing.Size(63, 45);
            this.btnMadd.TabIndex = 10;
            this.btnMadd.Text = "M+";
            this.btnMadd.UseVisualStyleBackColor = false;
            this.btnMadd.Click += new System.EventHandler(this.MBtnClick);
            // 
            // btnMsub
            // 
            this.btnMsub.BackColor = System.Drawing.Color.PowderBlue;
            this.btnMsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMsub.Location = new System.Drawing.Point(111, 85);
            this.btnMsub.Name = "btnMsub";
            this.btnMsub.Size = new System.Drawing.Size(63, 45);
            this.btnMsub.TabIndex = 11;
            this.btnMsub.Text = "M-";
            this.btnMsub.UseVisualStyleBackColor = false;
            this.btnMsub.Click += new System.EventHandler(this.MBtnClick);
            // 
            // btnMrec
            // 
            this.btnMrec.BackColor = System.Drawing.Color.PowderBlue;
            this.btnMrec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMrec.Location = new System.Drawing.Point(219, 85);
            this.btnMrec.Name = "btnMrec";
            this.btnMrec.Size = new System.Drawing.Size(63, 45);
            this.btnMrec.TabIndex = 12;
            this.btnMrec.Text = "MR";
            this.btnMrec.UseVisualStyleBackColor = false;
            this.btnMrec.Click += new System.EventHandler(this.MBtnClick);
            // 
            // btnMclr
            // 
            this.btnMclr.BackColor = System.Drawing.Color.PowderBlue;
            this.btnMclr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMclr.Location = new System.Drawing.Point(299, 85);
            this.btnMclr.Name = "btnMclr";
            this.btnMclr.Size = new System.Drawing.Size(63, 45);
            this.btnMclr.TabIndex = 13;
            this.btnMclr.Text = "MC";
            this.btnMclr.UseVisualStyleBackColor = false;
            this.btnMclr.Click += new System.EventHandler(this.MBtnClick);
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.Color.Khaki;
            this.btnSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.Location = new System.Drawing.Point(379, 85);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(63, 45);
            this.btnSign.TabIndex = 14;
            this.btnSign.Text = "+/-";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightCoral;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(379, 145);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(63, 45);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(299, 145);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(63, 45);
            this.btnDiv.TabIndex = 18;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.OP_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(219, 145);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(63, 45);
            this.btn9.TabIndex = 17;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.BtnClick);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(111, 144);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(63, 45);
            this.btn8.TabIndex = 16;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.BtnClick);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(22, 144);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(63, 45);
            this.btn7.TabIndex = 15;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnBksp
            // 
            this.btnBksp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBksp.Location = new System.Drawing.Point(379, 205);
            this.btnBksp.Name = "btnBksp";
            this.btnBksp.Size = new System.Drawing.Size(63, 45);
            this.btnBksp.TabIndex = 24;
            this.btnBksp.Text = "←";
            this.btnBksp.UseVisualStyleBackColor = true;
            this.btnBksp.Click += new System.EventHandler(this.btnBksp_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(299, 205);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(63, 45);
            this.btnMult.TabIndex = 23;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.OP_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(219, 205);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(63, 45);
            this.btn6.TabIndex = 22;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.BtnClick);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(111, 203);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(63, 45);
            this.btn5.TabIndex = 21;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.BtnClick);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(22, 203);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(63, 45);
            this.btn4.TabIndex = 20;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.BtnClick);
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(379, 265);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(63, 105);
            this.btnEquals.TabIndex = 27;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(299, 325);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 45);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.OP_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(299, 265);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(63, 45);
            this.btnSub.TabIndex = 25;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.OP_Click);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 396);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnBksp);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnMclr);
            this.Controls.Add(this.btnMrec);
            this.Controls.Add(this.btnMsub);
            this.Controls.Add(this.btnMadd);
            this.Controls.Add(this.btnDP);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCalculator";
            this.Text = "C# Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnDP;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnMadd;
        private System.Windows.Forms.Button btnMsub;
        private System.Windows.Forms.Button btnMrec;
        private System.Windows.Forms.Button btnMclr;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnBksp;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
    }
}

