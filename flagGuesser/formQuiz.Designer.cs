namespace flagGuesser
{
    partial class formQuiz
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.option1 = new System.Windows.Forms.Button();
            this.option2 = new System.Windows.Forms.Button();
            this.option3 = new System.Windows.Forms.Button();
            this.option4 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(87, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 193);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProgress.Location = new System.Drawing.Point(296, 678);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 20);
            this.lblProgress.TabIndex = 1;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.Location = new System.Drawing.Point(296, 13);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 20);
            this.lblScore.TabIndex = 1;
            // 
            // option1
            // 
            this.option1.Location = new System.Drawing.Point(87, 282);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(465, 48);
            this.option1.TabIndex = 2;
            this.option1.UseVisualStyleBackColor = true;
            this.option1.Click += new System.EventHandler(this.option_Click);
            // 
            // option2
            // 
            this.option2.Location = new System.Drawing.Point(87, 347);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(465, 48);
            this.option2.TabIndex = 2;
            this.option2.UseVisualStyleBackColor = true;
            this.option2.Click += new System.EventHandler(this.option_Click);
            // 
            // option3
            // 
            this.option3.Location = new System.Drawing.Point(87, 412);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(465, 48);
            this.option3.TabIndex = 2;
            this.option3.UseVisualStyleBackColor = true;
            this.option3.Click += new System.EventHandler(this.option_Click);
            // 
            // option4
            // 
            this.option4.Location = new System.Drawing.Point(87, 477);
            this.option4.Name = "option4";
            this.option4.Size = new System.Drawing.Size(465, 48);
            this.option4.TabIndex = 2;
            this.option4.UseVisualStyleBackColor = true;
            this.option4.Click += new System.EventHandler(this.option_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(87, 576);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(465, 48);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // formQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(652, 739);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.option4);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formQuiz";
            this.Text = "Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button option1;
        private System.Windows.Forms.Button option2;
        private System.Windows.Forms.Button option3;
        private System.Windows.Forms.Button option4;
        private System.Windows.Forms.Button btnNext;
    }
}