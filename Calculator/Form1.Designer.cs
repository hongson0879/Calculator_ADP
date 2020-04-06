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
            this.b7 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.bMul = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.bSub = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bEq = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bCE = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b7.Location = new System.Drawing.Point(54, 107);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(73, 66);
            this.b7.TabIndex = 0;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.NumEvent);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtResult.Location = new System.Drawing.Point(69, 49);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(391, 43);
            this.txtResult.TabIndex = 1;
            this.txtResult.Text = "0";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbResult.Location = new System.Drawing.Point(66, 56);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 18);
            this.lbResult.TabIndex = 2;
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b8.Location = new System.Drawing.Point(133, 107);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(73, 66);
            this.b8.TabIndex = 0;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.NumEvent);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b9.Location = new System.Drawing.Point(215, 107);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(73, 66);
            this.b9.TabIndex = 0;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.NumEvent);
            // 
            // bDiv
            // 
            this.bDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bDiv.Location = new System.Drawing.Point(306, 107);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(73, 66);
            this.bDiv.TabIndex = 0;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = true;
            this.bDiv.Click += new System.EventHandler(this.OperandEvent);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b4.Location = new System.Drawing.Point(54, 179);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(73, 66);
            this.b4.TabIndex = 0;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.NumEvent);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b5.Location = new System.Drawing.Point(133, 179);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(73, 66);
            this.b5.TabIndex = 0;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.NumEvent);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b6.Location = new System.Drawing.Point(212, 179);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(73, 66);
            this.b6.TabIndex = 0;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.NumEvent);
            // 
            // bMul
            // 
            this.bMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bMul.Location = new System.Drawing.Point(306, 179);
            this.bMul.Name = "bMul";
            this.bMul.Size = new System.Drawing.Size(73, 66);
            this.bMul.TabIndex = 0;
            this.bMul.Text = "*";
            this.bMul.UseVisualStyleBackColor = true;
            this.bMul.Click += new System.EventHandler(this.OperandEvent);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b1.Location = new System.Drawing.Point(37, 251);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(73, 66);
            this.b1.TabIndex = 0;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.NumEvent);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b2.Location = new System.Drawing.Point(126, 251);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(73, 66);
            this.b2.TabIndex = 0;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.NumEvent);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b3.Location = new System.Drawing.Point(215, 251);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(73, 66);
            this.b3.TabIndex = 0;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.NumEvent);
            // 
            // bSub
            // 
            this.bSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSub.Location = new System.Drawing.Point(306, 251);
            this.bSub.Name = "bSub";
            this.bSub.Size = new System.Drawing.Size(73, 66);
            this.bSub.TabIndex = 0;
            this.bSub.Text = "-";
            this.bSub.UseVisualStyleBackColor = true;
            this.bSub.Click += new System.EventHandler(this.OperandEvent);
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b0.Location = new System.Drawing.Point(69, 323);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(73, 66);
            this.b0.TabIndex = 0;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.NumEvent);
            // 
            // bEq
            // 
            this.bEq.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bEq.Location = new System.Drawing.Point(387, 251);
            this.bEq.Name = "bEq";
            this.bEq.Size = new System.Drawing.Size(73, 138);
            this.bEq.TabIndex = 0;
            this.bEq.Text = "=";
            this.bEq.UseVisualStyleBackColor = true;
            this.bEq.Click += new System.EventHandler(this.bEq_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button15.Location = new System.Drawing.Point(227, 323);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(73, 66);
            this.button15.TabIndex = 0;
            this.button15.Text = ",";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bAdd.Location = new System.Drawing.Point(306, 323);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(73, 66);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "+";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.OperandEvent);
            // 
            // bCE
            // 
            this.bCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bCE.Location = new System.Drawing.Point(387, 107);
            this.bCE.Name = "bCE";
            this.bCE.Size = new System.Drawing.Size(73, 66);
            this.bCE.TabIndex = 0;
            this.bCE.Text = "CE";
            this.bCE.UseVisualStyleBackColor = true;
            this.bCE.Click += new System.EventHandler(this.bCE_Click);
            // 
            // bC
            // 
            this.bC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bC.Location = new System.Drawing.Point(387, 179);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(73, 66);
            this.bC.TabIndex = 0;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 487);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bSub);
            this.Controls.Add(this.bMul);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.bCE);
            this.Controls.Add(this.bEq);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button bMul;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button bSub;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bEq;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bCE;
        private System.Windows.Forms.Button bC;
    }
}