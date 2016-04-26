namespace GradePredictionApplication.Views
{
    partial class StartPage
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.courseLabel = new System.Windows.Forms.Label();
            this.courseBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(177, 191);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(180, 20);
            this.nameBox.TabIndex = 0;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Crimson;
            this.startButton.Location = new System.Drawing.Point(177, 282);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(180, 33);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grade Prediction Application";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameLabel.Location = new System.Drawing.Point(173, 168);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(182, 20);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Please enter your name*";
            this.nameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.courseLabel.Location = new System.Drawing.Point(173, 225);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(190, 20);
            this.courseLabel.TabIndex = 4;
            this.courseLabel.Text = "Please enter your course*";
            this.courseLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // courseBox
            // 
            this.courseBox.Location = new System.Drawing.Point(177, 248);
            this.courseBox.Name = "courseBox";
            this.courseBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.courseBox.Size = new System.Drawing.Size(180, 20);
            this.courseBox.TabIndex = 1;
            this.courseBox.TextChanged += new System.EventHandler(this.courseBoxChanged);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(539, 517);
            this.Controls.Add(this.courseBox);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.nameBox);
            this.Name = "StartPage";
            this.Text = "StartPage";
            this.Load += new System.EventHandler(this.StartPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.TextBox courseBox;
    }
}