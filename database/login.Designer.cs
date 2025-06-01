namespace database
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            id = new TextBox();
            password = new TextBox();
            label2 = new Label();
            label3 = new Label();
            denglu = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(332, 69);
            label1.Name = "label1";
            label1.Size = new Size(273, 28);
            label1.TabIndex = 0;
            label1.Text = "三国杀武将管理系统";
            label1.Click += label1_Click;
            
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(903, 581);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // id
            // 
            id.BackColor = SystemColors.Window;
            id.Location = new Point(419, 280);
            id.Name = "id";
            id.Size = new Size(215, 30);
            id.TabIndex = 2;
            // 
            // password
            // 
            password.Location = new Point(419, 359);
            password.Name = "password";
            password.Size = new Size(215, 30);
            password.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(267, 280);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 4;
            label2.Text = "用户名：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("楷体", 14F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(296, 359);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 5;
            label3.Text = "密码：";
            // 
            // denglu
            // 
            denglu.Font = new Font("楷体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            denglu.Location = new Point(397, 433);
            denglu.Name = "denglu";
            denglu.Size = new Size(112, 34);
            denglu.TabIndex = 6;
            denglu.Text = "登录";
            denglu.UseVisualStyleBackColor = true;
            denglu.Click += denglu_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(901, 578);
            Controls.Add(denglu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(password);
            Controls.Add(id);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox id;
        private TextBox password;
        private Label label2;
        private Label label3;
        private Button denglu;
    }
}
