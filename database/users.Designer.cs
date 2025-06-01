namespace database
{
    partial class users
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(users));
            pdelete = new Button();
            pedit = new Button();
            psave = new Button();
            pregistertime = new TextBox();
            label9 = new Label();
            pname = new TextBox();
            label8 = new Label();
            pid = new TextBox();
            label7 = new Label();
            pset = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            panel6 = new Panel();
            label5 = new Label();
            label6 = new Label();
            panel5 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            label10 = new Label();
            plevel = new TextBox();
            label2 = new Label();
            presset = new Button();
            ppassword = new TextBox();
            label = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pset).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pdelete
            // 
            pdelete.BackColor = Color.SpringGreen;
            pdelete.Font = new Font("楷体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            pdelete.Location = new Point(863, 268);
            pdelete.Name = "pdelete";
            pdelete.Size = new Size(153, 60);
            pdelete.TabIndex = 46;
            pdelete.Text = "删除";
            pdelete.UseVisualStyleBackColor = false;
            pdelete.Click += pdelete_Click;
            // 
            // pedit
            // 
            pedit.BackColor = Color.SpringGreen;
            pedit.Font = new Font("楷体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            pedit.Location = new Point(598, 268);
            pedit.Name = "pedit";
            pedit.Size = new Size(153, 60);
            pedit.TabIndex = 45;
            pedit.Text = "编辑";
            pedit.UseVisualStyleBackColor = false;
            pedit.Click += pedit_Click;
            // 
            // psave
            // 
            psave.BackColor = Color.SpringGreen;
            psave.Font = new Font("楷体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            psave.Location = new Point(339, 268);
            psave.Name = "psave";
            psave.Size = new Size(153, 60);
            psave.TabIndex = 44;
            psave.Text = "保存";
            psave.UseVisualStyleBackColor = false;
            psave.Click += psave_Click;
            // 
            // pregistertime
            // 
            pregistertime.Location = new Point(1272, 217);
            pregistertime.Name = "pregistertime";
            pregistertime.Size = new Size(215, 30);
            pregistertime.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(1272, 186);
            label9.Name = "label9";
            label9.Size = new Size(128, 28);
            label9.TabIndex = 42;
            label9.Text = "注册时间";
            // 
            // pname
            // 
            pname.Location = new Point(461, 217);
            pname.Name = "pname";
            pname.Size = new Size(215, 30);
            pname.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(461, 186);
            label8.Name = "label8";
            label8.Size = new Size(70, 28);
            label8.TabIndex = 40;
            label8.Text = "昵称";
            // 
            // pid
            // 
            pid.Location = new Point(198, 217);
            pid.Name = "pid";
            pid.Size = new Size(215, 30);
            pid.TabIndex = 39;
            pid.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(198, 186);
            label7.Name = "label7";
            label7.Size = new Size(100, 28);
            label7.TabIndex = 38;
            label7.Text = "玩家ID";
            // 
            // pset
            // 
            pset.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pset.BackgroundColor = Color.White;
            pset.BorderStyle = BorderStyle.None;
            pset.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            pset.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pset.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            pset.Location = new Point(192, 477);
            pset.Name = "pset";
            pset.ReadOnly = true;
            pset.RowHeadersVisible = false;
            pset.RowHeadersWidth = 62;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Cyan;
            dataGridViewCellStyle1.Font = new Font("楷体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            pset.RowsDefaultCellStyle = dataGridViewCellStyle1;
            pset.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pset.Size = new Size(1296, 372);
            pset.TabIndex = 36;
            pset.CellContentClick += pset_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "pid";
            Column1.HeaderText = "玩家ID";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "pname";
            Column2.HeaderText = "昵称";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "plevel";
            Column3.HeaderText = "等级";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "password";
            Column4.HeaderText = "密码";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "register_time";
            Column5.HeaderText = "注册时间";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(127, 36);
            label1.TabIndex = 0;
            label1.Text = "武将管理";
            label1.Click += label1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Cyan;
            panel4.Controls.Add(label3);
            panel4.Location = new Point(20, 280);
            panel4.Name = "panel4";
            panel4.Size = new Size(153, 59);
            panel4.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.Location = new Point(12, 12);
            label3.Name = "label3";
            label3.Size = new Size(127, 36);
            label3.TabIndex = 0;
            label3.Text = "技能管理";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cyan;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(18, 170);
            panel2.Name = "panel2";
            panel2.Size = new Size(153, 59);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.Location = new Point(37, 14);
            label4.Name = "label4";
            label4.Size = new Size(71, 36);
            label4.TabIndex = 0;
            label4.Text = "退出";
            label4.Click += label4_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Crimson;
            panel6.Controls.Add(label5);
            panel6.Location = new Point(20, 505);
            panel6.Name = "panel6";
            panel6.Size = new Size(153, 59);
            panel6.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label5.Location = new Point(12, 12);
            label5.Name = "label5";
            label5.Size = new Size(127, 36);
            label5.TabIndex = 0;
            label5.Text = "用户管理";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(727, 423);
            label6.Name = "label6";
            label6.Size = new Size(128, 28);
            label6.TabIndex = 37;
            label6.Text = "玩家列表";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Cyan;
            panel5.Controls.Add(label4);
            panel5.Location = new Point(18, 635);
            panel5.Name = "panel5";
            panel5.Size = new Size(153, 59);
            panel5.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 851);
            panel1.TabIndex = 34;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Cyan;
            panel3.Controls.Add(label10);
            panel3.Location = new Point(20, 392);
            panel3.Name = "panel3";
            panel3.Size = new Size(153, 59);
            panel3.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label10.Location = new Point(12, 12);
            label10.Name = "label10";
            label10.Size = new Size(127, 36);
            label10.TabIndex = 0;
            label10.Text = "活动管理";
            label10.Click += label10_Click;
            // 
            // plevel
            // 
            plevel.Location = new Point(731, 217);
            plevel.Name = "plevel";
            plevel.Size = new Size(215, 30);
            plevel.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(731, 186);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 47;
            label2.Text = "玩家等级";
            // 
            // presset
            // 
            presset.BackColor = Color.SpringGreen;
            presset.Font = new Font("楷体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            presset.Location = new Point(1121, 268);
            presset.Name = "presset";
            presset.Size = new Size(153, 60);
            presset.TabIndex = 49;
            presset.Text = "重置";
            presset.UseVisualStyleBackColor = false;
            presset.Click += presset_Click;
            // 
            // ppassword
            // 
            ppassword.Location = new Point(1012, 217);
            ppassword.Name = "ppassword";
            ppassword.Size = new Size(215, 30);
            ppassword.TabIndex = 51;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label.ForeColor = SystemColors.ControlText;
            label.Location = new Point(1012, 186);
            label.Name = "label";
            label.Size = new Size(70, 28);
            label.TabIndex = 50;
            label.Text = "密码";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1486, 851);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // users
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1490, 851);
            Controls.Add(ppassword);
            Controls.Add(label);
            Controls.Add(presset);
            Controls.Add(plevel);
            Controls.Add(label2);
            Controls.Add(pdelete);
            Controls.Add(pedit);
            Controls.Add(psave);
            Controls.Add(pregistertime);
            Controls.Add(label9);
            Controls.Add(pname);
            Controls.Add(label8);
            Controls.Add(pid);
            Controls.Add(label7);
            Controls.Add(pset);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "users";
            Load += users_Load;
            ((System.ComponentModel.ISupportInitialize)pset).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button pdelete;
        private Button pedit;
        private Button psave;
        private TextBox pregistertime;
        private Label label9;
        private TextBox pname;
        private Label label8;
        private TextBox pid;
        private Label label7;
        private DataGridView pset;
        private Label label1;
        private Panel panel4;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private Panel panel6;
        private Label label5;
        private Label label6;
        private Panel panel5;
        private Panel panel1;
        private TextBox plevel;
        private Label label2;
        private Panel panel3;
        private Label label10;
        private Button presset;
        private TextBox ppassword;
        private Label label;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private PictureBox pictureBox1;
    }
}