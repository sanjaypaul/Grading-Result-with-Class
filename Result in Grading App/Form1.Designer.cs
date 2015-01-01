namespace Result_in_Grading_App
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
            this.chemistrytextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mathtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gradetextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.avgtextBox = new System.Windows.Forms.TextBox();
            this.physicstextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chemistrytextBox
            // 
            this.chemistrytextBox.Location = new System.Drawing.Point(142, 71);
            this.chemistrytextBox.Name = "chemistrytextBox";
            this.chemistrytextBox.Size = new System.Drawing.Size(100, 20);
            this.chemistrytextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Physics";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Math";
            // 
            // mathtextBox
            // 
            this.mathtextBox.Location = new System.Drawing.Point(142, 112);
            this.mathtextBox.Name = "mathtextBox";
            this.mathtextBox.Size = new System.Drawing.Size(100, 20);
            this.mathtextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Grade";
            // 
            // gradetextBox
            // 
            this.gradetextBox.Location = new System.Drawing.Point(142, 256);
            this.gradetextBox.Name = "gradetextBox";
            this.gradetextBox.Size = new System.Drawing.Size(100, 20);
            this.gradetextBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chemistry";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Avarage";
            // 
            // avgtextBox
            // 
            this.avgtextBox.Location = new System.Drawing.Point(142, 202);
            this.avgtextBox.Name = "avgtextBox";
            this.avgtextBox.Size = new System.Drawing.Size(100, 20);
            this.avgtextBox.TabIndex = 1;
            // 
            // physicstextBox
            // 
            this.physicstextBox.Location = new System.Drawing.Point(142, 26);
            this.physicstextBox.Name = "physicstextBox";
            this.physicstextBox.Size = new System.Drawing.Size(100, 20);
            this.physicstextBox.TabIndex = 1;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(297, 167);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 307);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.avgtextBox);
            this.Controls.Add(this.gradetextBox);
            this.Controls.Add(this.mathtextBox);
            this.Controls.Add(this.physicstextBox);
            this.Controls.Add(this.chemistrytextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox chemistrytextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mathtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gradetextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox avgtextBox;
        private System.Windows.Forms.TextBox physicstextBox;
        private System.Windows.Forms.Button showButton;

    }
}

