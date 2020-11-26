namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            this.dices = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.currentPlayer = new System.Windows.Forms.Label();
            this.sssstart = new System.Windows.Forms.Label();
            this.scoreInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.end = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(213, 550);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(0, 17);
            this.score.TabIndex = 3;
            // 
            // dices
            // 
            this.dices.AutoSize = true;
            this.dices.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dices.Location = new System.Drawing.Point(298, 455);
            this.dices.Name = "dices";
            this.dices.Size = new System.Drawing.Size(0, 27);
            this.dices.TabIndex = 4;
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Arial", 13.8F);
            this.start.Location = new System.Drawing.Point(534, 584);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(128, 42);
            this.start.TabIndex = 5;
            this.start.Text = "Старт";
            this.start.UseVisualStyleBackColor = true;
            this.start.Visible = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // currentPlayer
            // 
            this.currentPlayer.AutoSize = true;
            this.currentPlayer.Font = new System.Drawing.Font("Arial", 13.8F);
            this.currentPlayer.Location = new System.Drawing.Point(201, 509);
            this.currentPlayer.Name = "currentPlayer";
            this.currentPlayer.Size = new System.Drawing.Size(0, 27);
            this.currentPlayer.TabIndex = 6;
            this.currentPlayer.Visible = false;
            // 
            // sssstart
            // 
            this.sssstart.AutoSize = true;
            this.sssstart.Font = new System.Drawing.Font("Arial", 13.8F);
            this.sssstart.Image = global::WindowsFormsApp1.Properties.Resources.monopolyField;
            this.sssstart.Location = new System.Drawing.Point(158, 133);
            this.sssstart.Name = "sssstart";
            this.sssstart.Size = new System.Drawing.Size(504, 27);
            this.sssstart.TabIndex = 8;
            this.sssstart.Text = "Нажмите на любую точку чтобы начать игру";
            // 
            // scoreInfo
            // 
            this.scoreInfo.AllowDrop = true;
            this.scoreInfo.BackColor = System.Drawing.Color.White;
            this.scoreInfo.CausesValidation = false;
            this.scoreInfo.Font = new System.Drawing.Font("Arial", 10F);
            this.scoreInfo.Image = global::WindowsFormsApp1.Properties.Resources.monopolyField;
            this.scoreInfo.Location = new System.Drawing.Point(163, 270);
            this.scoreInfo.Name = "scoreInfo";
            this.scoreInfo.Size = new System.Drawing.Size(135, 202);
            this.scoreInfo.TabIndex = 7;
            this.scoreInfo.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.cubik;
            this.button1.Location = new System.Drawing.Point(359, 357);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 82);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.monopolyField;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 796);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // end
            // 
            this.end.Font = new System.Drawing.Font("Arial", 10F);
            this.end.Location = new System.Drawing.Point(501, 646);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(161, 31);
            this.end.TabIndex = 9;
            this.end.Text = "Выйти из игры";
            this.end.UseVisualStyleBackColor = true;
            this.end.Visible = false;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(802, 796);
            this.Controls.Add(this.end);
            this.Controls.Add(this.sssstart);
            this.Controls.Add(this.scoreInfo);
            this.Controls.Add(this.currentPlayer);
            this.Controls.Add(this.start);
            this.Controls.Add(this.dices);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(820, 843);
            this.MinimumSize = new System.Drawing.Size(820, 843);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label dices;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label currentPlayer;
        private System.Windows.Forms.Label scoreInfo;
        private System.Windows.Forms.Label sssstart;
        private System.Windows.Forms.Button end;
    }
}

