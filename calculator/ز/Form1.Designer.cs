namespace ز
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GetNum1 = new System.Windows.Forms.NumericUpDown();
            this.GetNum2 = new System.Windows.Forms.NumericUpDown();
            this.plus = new System.Windows.Forms.Button();
            this.minuse = new System.Windows.Forms.Button();
            this.multiple = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GetNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetNum2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "عدد اول را وارد کنید";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(115, 37);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "عدد دوم را وارد کنید";
            // 
            // GetNum1
            // 
            this.GetNum1.Location = new System.Drawing.Point(20, 9);
            this.GetNum1.Name = "GetNum1";
            this.GetNum1.Size = new System.Drawing.Size(89, 20);
            this.GetNum1.TabIndex = 1;
            // 
            // GetNum2
            // 
            this.GetNum2.Location = new System.Drawing.Point(20, 37);
            this.GetNum2.Name = "GetNum2";
            this.GetNum2.Size = new System.Drawing.Size(89, 20);
            this.GetNum2.TabIndex = 2;
            this.GetNum2.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.plus.Location = new System.Drawing.Point(20, 63);
            this.plus.Name = "plus";
            this.plus.Padding = new System.Windows.Forms.Padding(3);
            this.plus.Size = new System.Drawing.Size(37, 48);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minuse
            // 
            this.minuse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.minuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.minuse.Location = new System.Drawing.Point(63, 63);
            this.minuse.Name = "minuse";
            this.minuse.Padding = new System.Windows.Forms.Padding(3);
            this.minuse.Size = new System.Drawing.Size(32, 48);
            this.minuse.TabIndex = 3;
            this.minuse.Text = "-";
            this.minuse.UseVisualStyleBackColor = false;
            this.minuse.Click += new System.EventHandler(this.minuse_Click);
            // 
            // multiple
            // 
            this.multiple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.multiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.multiple.Location = new System.Drawing.Point(20, 117);
            this.multiple.Name = "multiple";
            this.multiple.Padding = new System.Windows.Forms.Padding(3);
            this.multiple.Size = new System.Drawing.Size(37, 48);
            this.multiple.TabIndex = 3;
            this.multiple.Text = "*";
            this.multiple.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.multiple.UseVisualStyleBackColor = false;
            this.multiple.Click += new System.EventHandler(this.multiple_Click);
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Divide.Location = new System.Drawing.Point(63, 117);
            this.Divide.Name = "Divide";
            this.Divide.Padding = new System.Windows.Forms.Padding(3);
            this.Divide.Size = new System.Drawing.Size(32, 48);
            this.Divide.TabIndex = 3;
            this.Divide.Text = "/";
            this.Divide.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.answer.Location = new System.Drawing.Point(148, 98);
            this.answer.Name = "answer";
            this.answer.Padding = new System.Windows.Forms.Padding(3);
            this.answer.Size = new System.Drawing.Size(6, 19);
            this.answer.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 175);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.minuse);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.multiple);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.GetNum2);
            this.Controls.Add(this.GetNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ماشین حساب";
            ((System.ComponentModel.ISupportInitialize)(this.GetNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetNum2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown GetNum1;
        private System.Windows.Forms.NumericUpDown GetNum2;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minuse;
        private System.Windows.Forms.Button multiple;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Label answer;
    }
}

