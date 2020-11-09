namespace Opperman_A_Mathlist
{
    partial class Mathlist
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
            this.pathBox = new System.Windows.Forms.TextBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MathBox = new System.Windows.Forms.ListBox();
            this.helpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(80, 28);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(491, 20);
            this.pathBox.TabIndex = 0;
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(577, 26);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 1;
            this.loadBtn.Text = "Load File";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Location:";
            // 
            // MathBox
            // 
            this.MathBox.FormattingEnabled = true;
            this.MathBox.HorizontalScrollbar = true;
            this.MathBox.Location = new System.Drawing.Point(80, 65);
            this.MathBox.Name = "MathBox";
            this.MathBox.Size = new System.Drawing.Size(653, 303);
            this.MathBox.TabIndex = 3;
            // 
            // helpBtn
            // 
            this.helpBtn.Location = new System.Drawing.Point(658, 26);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(75, 23);
            this.helpBtn.TabIndex = 4;
            this.helpBtn.Text = "Help";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // Mathlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 425);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.MathBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.pathBox);
            this.Name = "Mathlist";
            this.Text = "Mathlist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox MathBox;
        private System.Windows.Forms.Button helpBtn;
    }
}

