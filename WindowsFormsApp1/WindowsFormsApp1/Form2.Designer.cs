namespace WindowsFormsApp1
{
    partial class Form2
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
            this.question = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.question.Location = new System.Drawing.Point(3, 0);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(46, 17);
            this.question.TabIndex = 0;
            this.question.Text = "label1";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(164, 308);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(75, 23);
            this.input.TabIndex = 1;
            this.input.Text = "Ввести";
            this.input.UseVisualStyleBackColor = true;
            this.input.Click += new System.EventHandler(this.button1_Click);
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(93, 280);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(223, 22);
            this.answer.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.question);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(56, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(290, 220);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.blurMonopolyField;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(402, 395);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.input);
            this.MaximumSize = new System.Drawing.Size(420, 442);
            this.MinimumSize = new System.Drawing.Size(420, 442);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Button input;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}