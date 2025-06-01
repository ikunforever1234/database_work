namespace database
{
    partial class activity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(activity));
            label10 = new Label();
            aduration = new TextBox();
            label2 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel6 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            adelete = new Button();
            aedit = new Button();
            asave = new Button();
            aname = new TextBox();
            label8 = new Label();
            aid = new TextBox();
            label7 = new Label();
            aset = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            panel1 = new Panel();
            astarttime = new TextBox();
            label9 = new Label();
            areset = new Button();
            pictureBox2 = new PictureBox();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)aset).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            // 
            // aduration
            // 
            aduration.Location = new Point(1092, 203);
            aduration.Name = "aduration";
            aduration.Size = new Size(215, 30);
            aduration.TabIndex = 62;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(1092, 172);
            label2.Name = "label2";
            label2.Size = new Size(172, 28);
            label2.TabIndex = 61;
            label2.Text = "持续时间/月";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(728, 425);
            label6.Name = "label6";
            label6.Size = new Size(128, 28);
            label6.TabIndex = 51;
            label6.Text = "活动列表";
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
            // panel4
            // 
            panel4.BackColor = Color.Cyan;
            panel4.Controls.Add(label3);
            panel4.Location = new Point(20, 280);
            panel4.Name = "panel4";
            panel4.Size = new Size(153, 59);
            panel4.TabIndex = 2;
            // 
            // adelete
            // 
            adelete.BackColor = Color.SpringGreen;
            adelete.Font = new Font("楷体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            adelete.Location = new Point(865, 270);
            adelete.Name = "adelete";
            adelete.Size = new Size(153, 60);
            adelete.TabIndex = 60;
            adelete.Text = "删除";
            adelete.UseVisualStyleBackColor = false;
            adelete.Click += adelete_Click;
            // 
            // aedit
            // 
            aedit.BackColor = Color.SpringGreen;
            aedit.Font = new Font("楷体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            aedit.Location = new Point(599, 270);
            aedit.Name = "aedit";
            aedit.Size = new Size(153, 60);
            aedit.TabIndex = 59;
            aedit.Text = "编辑";
            aedit.UseVisualStyleBackColor = false;
            aedit.Click += aedit_Click;
            // 
            // asave
            // 
            asave.BackColor = Color.SpringGreen;
            asave.Font = new Font("楷体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            asave.Location = new Point(336, 270);
            asave.Name = "asave";
            asave.Size = new Size(153, 60);
            asave.TabIndex = 58;
            asave.Text = "保存";
            asave.UseVisualStyleBackColor = false;
            asave.Click += asave_Click;
            // 
            // aname
            // 
            aname.Location = new Point(569, 203);
            aname.Name = "aname";
            aname.Size = new Size(215, 30);
            aname.TabIndex = 55;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(569, 172);
            label8.Name = "label8";
            label8.Size = new Size(128, 28);
            label8.TabIndex = 54;
            label8.Text = "活动名称";
            // 
            // aid
            // 
            aid.Location = new Point(306, 203);
            aid.Name = "aid";
            aid.Size = new Size(215, 30);
            aid.TabIndex = 53;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(306, 172);
            label7.Name = "label7";
            label7.Size = new Size(100, 28);
            label7.TabIndex = 52;
            label7.Text = "活动ID";
            // 
            // aset
            // 
            aset.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            aset.BackgroundColor = Color.White;
            aset.BorderStyle = BorderStyle.None;
            aset.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            aset.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            aset.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            aset.Location = new Point(190, 478);
            aset.Name = "aset";
            aset.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("微软雅黑", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            aset.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            aset.RowHeadersVisible = false;
            aset.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Cyan;
            dataGridViewCellStyle2.Font = new Font("楷体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gold;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            aset.RowsDefaultCellStyle = dataGridViewCellStyle2;
            aset.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            aset.Size = new Size(1296, 372);
            aset.TabIndex = 50;
            aset.CellContentClick += aset_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "aid";
            Column1.HeaderText = "活动ID";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "aname";
            Column2.HeaderText = "名称";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "astarttime";
            Column3.HeaderText = "起始时间";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "aduration";
            Column4.HeaderText = "持续时间/月";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Crimson;
            panel3.Controls.Add(label10);
            panel3.Location = new Point(20, 392);
            panel3.Name = "panel3";
            panel3.Size = new Size(153, 59);
            panel3.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 851);
            panel1.TabIndex = 49;
            // 
            // astarttime
            // 
            astarttime.Location = new Point(838, 203);
            astarttime.Name = "astarttime";
            astarttime.Size = new Size(215, 30);
            astarttime.TabIndex = 64;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(838, 172);
            label9.Name = "label9";
            label9.Size = new Size(128, 28);
            label9.TabIndex = 63;
            label9.Text = "推出时间";
            // 
            // areset
            // 
            areset.BackColor = Color.SpringGreen;
            areset.Font = new Font("楷体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            areset.Location = new Point(1125, 270);
            areset.Name = "areset";
            areset.Size = new Size(153, 60);
            areset.TabIndex = 65;
            areset.Text = "重置";
            areset.UseVisualStyleBackColor = false;
            areset.Click += areset_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1503, 849);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 67;
            pictureBox2.TabStop = false;
            // 
            // activity
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1490, 851);
            Controls.Add(areset);
            Controls.Add(astarttime);
            Controls.Add(label9);
            Controls.Add(aduration);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(adelete);
            Controls.Add(aedit);
            Controls.Add(asave);
            Controls.Add(aname);
            Controls.Add(label8);
            Controls.Add(aid);
            Controls.Add(label7);
            Controls.Add(aset);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "activity";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "activity";
            Load += activity_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)aset).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private TextBox aduration;
        private Label label2;
        private Panel panel5;
        private Label label4;
        private Label label6;
        private Label label5;
        private Panel panel6;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Panel panel4;
        private Button adelete;
        private Button aedit;
        private Button asave;
        private TextBox aname;
        private Label label8;
        private TextBox aid;
        private Label label7;
        private DataGridView aset;
        private Panel panel3;
        private Panel panel1;
        private TextBox astarttime;
        private Label label9;
        private Button areset;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private PictureBox pictureBox2;
    }
}