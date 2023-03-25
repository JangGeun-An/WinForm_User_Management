namespace User_Management
{
    partial class Admin
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
            this.dg_UserInfo = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Sel_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Sel_Add = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Sel_Tel = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Sel_Birth = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Sel_Sex = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Sel_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Sel_PW = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.box_Operate = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_UserInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.box_Operate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_UserInfo
            // 
            this.dg_UserInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dg_UserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_UserInfo.Location = new System.Drawing.Point(12, 225);
            this.dg_UserInfo.Name = "dg_UserInfo";
            this.dg_UserInfo.RowTemplate.Height = 23;
            this.dg_UserInfo.Size = new System.Drawing.Size(776, 213);
            this.dg_UserInfo.TabIndex = 0;
            this.dg_UserInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_UserInfo_CellClick);
            this.dg_UserInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_UserInfo_CellContentClick);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Refresh.Location = new System.Drawing.Point(5, 119);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(90, 33);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "새로고침";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Del.Location = new System.Drawing.Point(5, 83);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(90, 33);
            this.btn_Del.TabIndex = 2;
            this.btn_Del.Text = "삭제";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Add.Location = new System.Drawing.Point(5, 11);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(90, 33);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "추가";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Update.Location = new System.Drawing.Point(5, 47);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(90, 33);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "변경";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Logout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_Logout.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Black;
            this.btn_Logout.Location = new System.Drawing.Point(11, 92);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(72, 24);
            this.btn_Logout.TabIndex = 6;
            this.btn_Logout.Text = "로그아웃";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 67);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(217, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "현재 접속자 : Admin(관리자)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(12, 199);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "회 원 정 보";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(776, 56);
            this.label3.TabIndex = 9;
            this.label3.Text = "장근 시스템 - 관리자 모드";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Sel_ID
            // 
            this.txt_Sel_ID.Location = new System.Drawing.Point(51, 19);
            this.txt_Sel_ID.Name = "txt_Sel_ID";
            this.txt_Sel_ID.Size = new System.Drawing.Size(100, 21);
            this.txt_Sel_ID.TabIndex = 10;
            this.txt_Sel_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(30, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Sel_Add);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_Sel_Tel);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_Sel_Birth);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_Sel_Sex);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_Sel_Name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Sel_PW);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Sel_ID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(132, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 106);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "선택된 회원";
            // 
            // txt_Sel_Add
            // 
            this.txt_Sel_Add.Location = new System.Drawing.Point(76, 74);
            this.txt_Sel_Add.Name = "txt_Sel_Add";
            this.txt_Sel_Add.Size = new System.Drawing.Size(451, 21);
            this.txt_Sel_Add.TabIndex = 22;
            this.txt_Sel_Add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(5, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 12);
            this.label11.TabIndex = 23;
            this.label11.Text = "ADDRESS";
            // 
            // txt_Sel_Tel
            // 
            this.txt_Sel_Tel.Location = new System.Drawing.Point(427, 47);
            this.txt_Sel_Tel.Name = "txt_Sel_Tel";
            this.txt_Sel_Tel.Size = new System.Drawing.Size(100, 21);
            this.txt_Sel_Tel.TabIndex = 20;
            this.txt_Sel_Tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(393, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "TEL";
            // 
            // txt_Sel_Birth
            // 
            this.txt_Sel_Birth.Location = new System.Drawing.Point(224, 47);
            this.txt_Sel_Birth.Name = "txt_Sel_Birth";
            this.txt_Sel_Birth.Size = new System.Drawing.Size(100, 21);
            this.txt_Sel_Birth.TabIndex = 18;
            this.txt_Sel_Birth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(176, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "BIRTH";
            // 
            // txt_Sel_Sex
            // 
            this.txt_Sel_Sex.Location = new System.Drawing.Point(51, 47);
            this.txt_Sel_Sex.Name = "txt_Sel_Sex";
            this.txt_Sel_Sex.Size = new System.Drawing.Size(100, 21);
            this.txt_Sel_Sex.TabIndex = 16;
            this.txt_Sel_Sex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(16, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "SEX";
            // 
            // txt_Sel_Name
            // 
            this.txt_Sel_Name.Location = new System.Drawing.Point(427, 19);
            this.txt_Sel_Name.Name = "txt_Sel_Name";
            this.txt_Sel_Name.Size = new System.Drawing.Size(100, 21);
            this.txt_Sel_Name.TabIndex = 14;
            this.txt_Sel_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(379, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "NAME";
            // 
            // txt_Sel_PW
            // 
            this.txt_Sel_PW.Location = new System.Drawing.Point(224, 19);
            this.txt_Sel_PW.Name = "txt_Sel_PW";
            this.txt_Sel_PW.Size = new System.Drawing.Size(100, 21);
            this.txt_Sel_PW.TabIndex = 12;
            this.txt_Sel_PW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(196, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "PW";
            // 
            // box_Operate
            // 
            this.box_Operate.BackColor = System.Drawing.Color.White;
            this.box_Operate.Controls.Add(this.btn_Add);
            this.box_Operate.Controls.Add(this.btn_Refresh);
            this.box_Operate.Controls.Add(this.btn_Del);
            this.box_Operate.Controls.Add(this.btn_Update);
            this.box_Operate.Location = new System.Drawing.Point(689, 66);
            this.box_Operate.Margin = new System.Windows.Forms.Padding(0);
            this.box_Operate.Name = "box_Operate";
            this.box_Operate.Padding = new System.Windows.Forms.Padding(0);
            this.box_Operate.Size = new System.Drawing.Size(99, 158);
            this.box_Operate.TabIndex = 13;
            this.box_Operate.TabStop = false;
            this.box_Operate.Text = "메뉴";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.box_Operate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.dg_UserInfo);
            this.Name = "Admin";
            this.Text = "장근 시스템_관리자";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_UserInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.box_Operate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_UserInfo;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Sel_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Sel_PW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox box_Operate;
        private System.Windows.Forms.TextBox txt_Sel_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Sel_Tel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Sel_Birth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Sel_Sex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Sel_Add;
        private System.Windows.Forms.Label label11;
    }
}