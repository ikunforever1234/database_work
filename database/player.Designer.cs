namespace database
{
    partial class player
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(player));
            label1 = new Label();
            label2 = new Label();
            set = new DataGridView();
            searchcha = new Button();
            searchact = new Button();
            tuichu = new Button();
            activityname = new TextBox();
            label3 = new Label();
            join = new Button();
            exit = new Button();
            label4 = new Label();
            pid = new Label();
            pname = new Label();
            plevel = new Label();
            secrchhavejoin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)set).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(70, 184);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 56;
            label1.Text = "昵称：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(70, 248);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 58;
            label2.Text = "等级：";
            // 
            // set
            // 
            set.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            set.BackgroundColor = Color.White;
            set.BorderStyle = BorderStyle.None;
            set.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            set.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            set.ColumnHeadersVisible = false;
            set.Location = new Point(-1, 468);
            set.Name = "set";
            set.ReadOnly = true;
            set.RowHeadersVisible = false;
            set.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Cyan;
            dataGridViewCellStyle2.Font = new Font("楷体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            set.RowsDefaultCellStyle = dataGridViewCellStyle2;
            set.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            set.Size = new Size(1491, 383);
            set.TabIndex = 60;
            // 
            // searchcha
            // 
            searchcha.BackColor = Color.SpringGreen;
            searchcha.Font = new Font("楷体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            searchcha.Location = new Point(147, 339);
            searchcha.Name = "searchcha";
            searchcha.Size = new Size(228, 60);
            searchcha.TabIndex = 61;
            searchcha.Text = "查询已拥有武将";
            searchcha.UseVisualStyleBackColor = false;
            searchcha.Click += searchcha_Click;
            // 
            // searchact
            // 
            searchact.BackColor = Color.SpringGreen;
            searchact.Font = new Font("楷体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            searchact.Location = new Point(499, 339);
            searchact.Name = "searchact";
            searchact.Size = new Size(232, 60);
            searchact.TabIndex = 63;
            searchact.Text = "查询活动";
            searchact.UseVisualStyleBackColor = false;
            searchact.Click += searchact_Click;
            // 
            // tuichu
            // 
            tuichu.BackColor = Color.SpringGreen;
            tuichu.Font = new Font("楷体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            tuichu.Location = new Point(1146, 339);
            tuichu.Name = "tuichu";
            tuichu.Size = new Size(232, 60);
            tuichu.TabIndex = 64;
            tuichu.Text = "退出";
            tuichu.UseVisualStyleBackColor = false;
            tuichu.Click += tuichu_Click;
            // 
            // activityname
            // 
            activityname.Location = new Point(876, 121);
            activityname.Name = "activityname";
            activityname.Size = new Size(194, 30);
            activityname.TabIndex = 66;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(640, 123);
            label3.Name = "label3";
            label3.Size = new Size(216, 28);
            label3.TabIndex = 65;
            label3.Text = "请输入活动ID：";
            label3.Click += label3_Click;
            // 
            // join
            // 
            join.BackColor = Color.SpringGreen;
            join.Font = new Font("楷体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            join.Location = new Point(546, 216);
            join.Name = "join";
            join.Size = new Size(232, 60);
            join.TabIndex = 67;
            join.Text = "参加活动";
            join.UseVisualStyleBackColor = false;
            join.Click += join_Click;
            // 
            // exit
            // 
            exit.BackColor = Color.SpringGreen;
            exit.Font = new Font("楷体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            exit.Location = new Point(875, 216);
            exit.Name = "exit";
            exit.Size = new Size(232, 60);
            exit.TabIndex = 68;
            exit.Text = "退出活动";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(70, 123);
            label4.Name = "label4";
            label4.Size = new Size(71, 28);
            label4.TabIndex = 70;
            label4.Text = "ID：";
            // 
            // pid
            // 
            pid.AutoSize = true;
            pid.BackColor = Color.Transparent;
            pid.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            pid.ForeColor = SystemColors.ControlText;
            pid.Location = new Point(184, 123);
            pid.Name = "pid";
            pid.Size = new Size(0, 28);
            pid.TabIndex = 71;
            // 
            // pname
            // 
            pname.AutoSize = true;
            pname.BackColor = Color.Transparent;
            pname.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            pname.ForeColor = SystemColors.ControlText;
            pname.Location = new Point(184, 184);
            pname.Name = "pname";
            pname.Size = new Size(0, 28);
            pname.TabIndex = 72;
            // 
            // plevel
            // 
            plevel.AutoSize = true;
            plevel.BackColor = Color.Transparent;
            plevel.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            plevel.ForeColor = SystemColors.ControlText;
            plevel.Location = new Point(184, 248);
            plevel.Name = "plevel";
            plevel.Size = new Size(0, 28);
            plevel.TabIndex = 73;
            // 
            // secrchhavejoin
            // 
            secrchhavejoin.BackColor = Color.SpringGreen;
            secrchhavejoin.Font = new Font("楷体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            secrchhavejoin.Location = new Point(826, 339);
            secrchhavejoin.Name = "secrchhavejoin";
            secrchhavejoin.Size = new Size(232, 60);
            secrchhavejoin.TabIndex = 74;
            secrchhavejoin.Text = "查询已参加活动";
            secrchhavejoin.UseVisualStyleBackColor = false;
            secrchhavejoin.Click += secrchhavejoin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1491, 851);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 75;
            pictureBox1.TabStop = false;
            // 
            // player
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1490, 851);
            Controls.Add(secrchhavejoin);
            Controls.Add(plevel);
            Controls.Add(pname);
            Controls.Add(pid);
            Controls.Add(label4);
            Controls.Add(exit);
            Controls.Add(join);
            Controls.Add(activityname);
            Controls.Add(label3);
            Controls.Add(tuichu);
            Controls.Add(searchact);
            Controls.Add(searchcha);
            Controls.Add(set);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "player";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "player";
            Load += player_Load;
            ((System.ComponentModel.ISupportInitialize)set).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private DataGridView set;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox4;
        private Label label3;
        private Button button5;
        private Button exit;
        private Label label4;
        private Label pid;
        private Label pname;
        private Label plevel;
        private Button join;
        private TextBox activityname;
        private Button tuichu;
        private Button searchact;
        private Button searchcha;
        private Button secrchhavejoin;
        private PictureBox pictureBox1;
    }
}