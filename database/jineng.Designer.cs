namespace database
{
    partial class jineng
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jineng));
            jinengdelete = new Button();
            button2 = new Button();
            jinengsave = new Button();
            jinengintro = new TextBox();
            label9 = new Label();
            jinengtype = new TextBox();
            label8 = new Label();
            jinengname = new TextBox();
            label7 = new Label();
            jinengset = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            label5 = new Label();
            panel6 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            label10 = new Label();
            panel7 = new Panel();
            label2 = new Label();
            jinengchongzhi = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)jinengset).BeginInit();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // jinengdelete
            // 
            jinengdelete.BackColor = Color.SpringGreen;
            jinengdelete.Font = new Font("楷体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            jinengdelete.Location = new Point(910, 770);
            jinengdelete.Name = "jinengdelete";
            jinengdelete.Size = new Size(153, 60);
            jinengdelete.TabIndex = 33;
            jinengdelete.Text = "删除";
            jinengdelete.UseVisualStyleBackColor = false;
            jinengdelete.Click += jinengdelete_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SpringGreen;
            button2.Font = new Font("楷体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            button2.Location = new Point(652, 770);
            button2.Name = "button2";
            button2.Size = new Size(153, 60);
            button2.TabIndex = 32;
            button2.Text = "编辑";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // jinengsave
            // 
            jinengsave.BackColor = Color.SpringGreen;
            jinengsave.Font = new Font("楷体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            jinengsave.Location = new Point(388, 770);
            jinengsave.Name = "jinengsave";
            jinengsave.Size = new Size(153, 60);
            jinengsave.TabIndex = 31;
            jinengsave.Text = "保存";
            jinengsave.UseVisualStyleBackColor = false;
            jinengsave.Click += button1_Click;
            // 
            // jinengintro
            // 
            jinengintro.Location = new Point(910, 694);
            jinengintro.Name = "jinengintro";
            jinengintro.Size = new Size(215, 30);
            jinengintro.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(910, 663);
            label9.Name = "label9";
            label9.Size = new Size(128, 28);
            label9.TabIndex = 25;
            label9.Text = "技能描述";
            // 
            // jinengtype
            // 
            jinengtype.Location = new Point(649, 694);
            jinengtype.Name = "jinengtype";
            jinengtype.Size = new Size(215, 30);
            jinengtype.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(649, 663);
            label8.Name = "label8";
            label8.Size = new Size(128, 28);
            label8.TabIndex = 23;
            label8.Text = "技能类型";
            // 
            // jinengname
            // 
            jinengname.Location = new Point(386, 694);
            jinengname.Name = "jinengname";
            jinengname.Size = new Size(215, 30);
            jinengname.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(386, 663);
            label7.Name = "label7";
            label7.Size = new Size(99, 28);
            label7.TabIndex = 21;
            label7.Text = "技能名";
            // 
            // jinengset
            // 
            jinengset.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            jinengset.BackgroundColor = Color.White;
            jinengset.BorderStyle = BorderStyle.None;
            jinengset.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            jinengset.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            jinengset.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            jinengset.GridColor = SystemColors.ActiveBorder;
            jinengset.Location = new Point(193, 123);
            jinengset.Name = "jinengset";
            jinengset.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Lime;
            dataGridViewCellStyle1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            jinengset.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            jinengset.RowHeadersVisible = false;
            jinengset.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Aqua;
            dataGridViewCellStyle2.Font = new Font("楷体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.OrangeRed;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            jinengset.RowsDefaultCellStyle = dataGridViewCellStyle2;
            jinengset.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            jinengset.Size = new Size(1296, 470);
            jinengset.TabIndex = 19;
            jinengset.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "sname";
            Column1.HeaderText = "技能名";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "stype";
            Column2.HeaderText = "类型";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "sintro";
            Column3.HeaderText = "描述";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
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
            label5.Click += label5_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Cyan;
            panel6.Controls.Add(label5);
            panel6.Location = new Point(20, 505);
            panel6.Name = "panel6";
            panel6.Size = new Size(153, 59);
            panel6.TabIndex = 3;
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
            // 
            // panel4
            // 
            panel4.BackColor = Color.Crimson;
            panel4.Controls.Add(label3);
            panel4.Location = new Point(20, 280);
            panel4.Name = "panel4";
            panel4.Size = new Size(153, 59);
            panel4.TabIndex = 2;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(686, 80);
            label6.Name = "label6";
            label6.Size = new Size(128, 28);
            label6.TabIndex = 20;
            label6.Text = "技能列表\r\n";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 851);
            panel1.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Cyan;
            panel3.Controls.Add(label10);
            panel3.Location = new Point(20, 393);
            panel3.Name = "panel3";
            panel3.Size = new Size(153, 59);
            panel3.TabIndex = 35;
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
            // panel7
            // 
            panel7.BackColor = Color.Cyan;
            panel7.Controls.Add(label2);
            panel7.Location = new Point(18, 636);
            panel7.Name = "panel7";
            panel7.Size = new Size(153, 59);
            panel7.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(37, 14);
            label2.Name = "label2";
            label2.Size = new Size(71, 36);
            label2.TabIndex = 0;
            label2.Text = "退出";
            label2.Click += label2_Click;
            // 
            // jinengchongzhi
            // 
            jinengchongzhi.BackColor = Color.SpringGreen;
            jinengchongzhi.Font = new Font("楷体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            jinengchongzhi.Location = new Point(1155, 770);
            jinengchongzhi.Name = "jinengchongzhi";
            jinengchongzhi.Size = new Size(153, 60);
            jinengchongzhi.TabIndex = 34;
            jinengchongzhi.Text = "重置";
            jinengchongzhi.UseVisualStyleBackColor = false;
            jinengchongzhi.Click += jinengchongzhi_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1488, 851);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // jineng
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1490, 851);
            Controls.Add(jinengchongzhi);
            Controls.Add(jinengdelete);
            Controls.Add(button2);
            Controls.Add(jinengsave);
            Controls.Add(jinengintro);
            Controls.Add(label9);
            Controls.Add(jinengtype);
            Controls.Add(label8);
            Controls.Add(jinengname);
            Controls.Add(label7);
            Controls.Add(jinengset);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "jineng";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "jineng";
            ((System.ComponentModel.ISupportInitialize)jinengset).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button jinengdelete;
        private Button button2;
        private Button jinengsave;
        private TextBox jinengintro;
        private Label label9;
        private TextBox jinengtype;
        private Label label8;
        private TextBox jinengname;
        private Label label7;
        private DataGridView jinengset;
        private Label label5;
        private Panel panel6;
        private Label label3;
        private Panel panel4;
        private Panel panel2;
        private Label label1;
        private Label label6;
        private Panel panel1;
        private Panel panel3;
        private Label label10;
        private Panel panel7;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button jinengchongzhi;
        private PictureBox pictureBox1;
    }
}