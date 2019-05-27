namespace Calculator_BMI2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textNIM = new System.Windows.Forms.TextBox();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.textNama2 = new System.Windows.Forms.TextBox();
            this.textNIM2 = new System.Windows.Forms.TextBox();
            this.textYourBMI = new System.Windows.Forms.TextBox();
            this.textBMICategories = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Result";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(428, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textName
            // 
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(137, 108);
            this.textName.Multiline = true;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(127, 19);
            this.textName.TabIndex = 3;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // textNIM
            // 
            this.textNIM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNIM.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNIM.Location = new System.Drawing.Point(137, 143);
            this.textNIM.Multiline = true;
            this.textNIM.Name = "textNIM";
            this.textNIM.Size = new System.Drawing.Size(127, 19);
            this.textNIM.TabIndex = 4;
            this.textNIM.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textHeight
            // 
            this.textHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textHeight.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHeight.Location = new System.Drawing.Point(137, 179);
            this.textHeight.Multiline = true;
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(127, 19);
            this.textHeight.TabIndex = 5;
            this.textHeight.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textWeight
            // 
            this.textWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textWeight.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textWeight.Location = new System.Drawing.Point(137, 211);
            this.textWeight.Multiline = true;
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(127, 19);
            this.textWeight.TabIndex = 6;
            // 
            // textNama2
            // 
            this.textNama2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNama2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNama2.Location = new System.Drawing.Point(313, 135);
            this.textNama2.Multiline = true;
            this.textNama2.Name = "textNama2";
            this.textNama2.Size = new System.Drawing.Size(177, 14);
            this.textNama2.TabIndex = 7;
            this.textNama2.TextChanged += new System.EventHandler(this.textNama2_TextChanged);
            // 
            // textNIM2
            // 
            this.textNIM2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNIM2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNIM2.Location = new System.Drawing.Point(313, 174);
            this.textNIM2.Multiline = true;
            this.textNIM2.Name = "textNIM2";
            this.textNIM2.Size = new System.Drawing.Size(177, 14);
            this.textNIM2.TabIndex = 8;
            this.textNIM2.TextChanged += new System.EventHandler(this.NIM2_TextChanged);
            // 
            // textYourBMI
            // 
            this.textYourBMI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textYourBMI.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textYourBMI.Location = new System.Drawing.Point(313, 237);
            this.textYourBMI.Multiline = true;
            this.textYourBMI.Name = "textYourBMI";
            this.textYourBMI.Size = new System.Drawing.Size(177, 41);
            this.textYourBMI.TabIndex = 9;
            this.textYourBMI.TextChanged += new System.EventHandler(this.textYourBMI_TextChanged);
            // 
            // textBMICategories
            // 
            this.textBMICategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBMICategories.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBMICategories.Location = new System.Drawing.Point(313, 329);
            this.textBMICategories.Multiline = true;
            this.textBMICategories.Name = "textBMICategories";
            this.textBMICategories.Size = new System.Drawing.Size(177, 18);
            this.textBMICategories.TabIndex = 10;
            this.textBMICategories.TextChanged += new System.EventHandler(this.textBMICategories_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(533, 399);
            this.Controls.Add(this.textBMICategories);
            this.Controls.Add(this.textYourBMI);
            this.Controls.Add(this.textNIM2);
            this.Controls.Add(this.textNama2);
            this.Controls.Add(this.textWeight);
            this.Controls.Add(this.textHeight);
            this.Controls.Add(this.textNIM);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textNIM;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.TextBox textWeight;
        private System.Windows.Forms.TextBox textNama2;
        private System.Windows.Forms.TextBox textNIM2;
        private System.Windows.Forms.TextBox textYourBMI;
        private System.Windows.Forms.TextBox textBMICategories;
    }
}

