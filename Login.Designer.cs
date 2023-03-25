namespace User_Management
{
    partial class Login
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_LoginPW = new System.Windows.Forms.TextBox();
            this.txt_LoginID = new System.Windows.Forms.TextBox();
            this.btn_GoSignUp = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.box_Info = new System.Windows.Forms.GroupBox();
            this.box_Menu = new System.Windows.Forms.GroupBox();
            this.box_Text = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.box_Info.SuspendLayout();
            this.box_Menu.SuspendLayout();
            this.box_Text.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Login.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Login.ForeColor = System.Drawing.Color.Black;
            this.btn_Login.Location = new System.Drawing.Point(41, 47);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(124, 32);
            this.btn_Login.TabIndex = 10;
            this.btn_Login.Text = "로그인";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(17, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "PW";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(31, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID";
            // 
            // txt_LoginPW
            // 
            this.txt_LoginPW.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_LoginPW.Location = new System.Drawing.Point(60, 140);
            this.txt_LoginPW.Name = "txt_LoginPW";
            this.txt_LoginPW.PasswordChar = '●';
            this.txt_LoginPW.Size = new System.Drawing.Size(100, 30);
            this.txt_LoginPW.TabIndex = 7;
            this.txt_LoginPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_LoginID
            // 
            this.txt_LoginID.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_LoginID.Location = new System.Drawing.Point(60, 69);
            this.txt_LoginID.Name = "txt_LoginID";
            this.txt_LoginID.Size = new System.Drawing.Size(100, 30);
            this.txt_LoginID.TabIndex = 6;
            this.txt_LoginID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_GoSignUp
            // 
            this.btn_GoSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GoSignUp.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_GoSignUp.ForeColor = System.Drawing.Color.Black;
            this.btn_GoSignUp.Location = new System.Drawing.Point(41, 104);
            this.btn_GoSignUp.Name = "btn_GoSignUp";
            this.btn_GoSignUp.Size = new System.Drawing.Size(124, 32);
            this.btn_GoSignUp.TabIndex = 12;
            this.btn_GoSignUp.Text = "회원가입";
            this.btn_GoSignUp.UseVisualStyleBackColor = false;
            this.btn_GoSignUp.Click += new System.EventHandler(this.btn_GoSignUp_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Exit.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.btn_Exit.Location = new System.Drawing.Point(41, 161);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(124, 32);
            this.btn_Exit.TabIndex = 13;
            this.btn_Exit.Text = "종료";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 56);
            this.label1.TabIndex = 14;
            this.label1.Text = "장근 시스템 - 로그인";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // box_Info
            // 
            this.box_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.box_Info.Controls.Add(this.txt_LoginPW);
            this.box_Info.Controls.Add(this.txt_LoginID);
            this.box_Info.Controls.Add(this.label4);
            this.box_Info.Controls.Add(this.label3);
            this.box_Info.Location = new System.Drawing.Point(12, 135);
            this.box_Info.Name = "box_Info";
            this.box_Info.Size = new System.Drawing.Size(186, 236);
            this.box_Info.TabIndex = 15;
            this.box_Info.TabStop = false;
            this.box_Info.Text = "회원정보 입력";
            // 
            // box_Menu
            // 
            this.box_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.box_Menu.Controls.Add(this.btn_Login);
            this.box_Menu.Controls.Add(this.btn_GoSignUp);
            this.box_Menu.Controls.Add(this.btn_Exit);
            this.box_Menu.Location = new System.Drawing.Point(218, 135);
            this.box_Menu.Name = "box_Menu";
            this.box_Menu.Size = new System.Drawing.Size(208, 236);
            this.box_Menu.TabIndex = 16;
            this.box_Menu.TabStop = false;
            this.box_Menu.Text = "메뉴";
            // 
            // box_Text
            // 
            this.box_Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.box_Text.Controls.Add(this.label2);
            this.box_Text.Location = new System.Drawing.Point(445, 135);
            this.box_Text.Name = "box_Text";
            this.box_Text.Size = new System.Drawing.Size(343, 236);
            this.box_Text.TabIndex = 17;
            this.box_Text.TabStop = false;
            this.box_Text.Text = "도움말";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 144);
            this.label2.TabIndex = 0;
            this.label2.Text = "안녕하세요. 장근 시스템입니다.\r\n\r\n회원은 회원정보 입력 후 로그인 버튼을\r\n눌러주세요.\r\n\r\n아직 회원이 아니시면 회원가입 버튼을\r\n눌러서 회" +
    "원가입을 해주세요.\r\n\r\n관리자 계정의 ID는 Admin, PW는 0000입니다.\r\n";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.box_Text);
            this.Controls.Add(this.box_Menu);
            this.Controls.Add(this.box_Info);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "장근 시스템_로그인";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.box_Info.ResumeLayout(false);
            this.box_Info.PerformLayout();
            this.box_Menu.ResumeLayout(false);
            this.box_Text.ResumeLayout(false);
            this.box_Text.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_LoginPW;
        private System.Windows.Forms.TextBox txt_LoginID;
        private System.Windows.Forms.Button btn_GoSignUp;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox box_Info;
        private System.Windows.Forms.GroupBox box_Menu;
        private System.Windows.Forms.GroupBox box_Text;
        private System.Windows.Forms.Label label2;
    }
}

