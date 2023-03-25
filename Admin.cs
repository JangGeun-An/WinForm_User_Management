using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Management
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private DataSet GetData()
        {
            SqlConnection dbcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Zeek\\Documents\\User_Manage.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM UserManageInfo", dbcon);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            // DataSet을 가져온다
            DataSet ds = GetData();

            // DataSource 속성을 설정
            dg_UserInfo.DataSource = ds.Tables[0];
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            string ID = txt_Sel_ID.Text;
            try
            {
                SqlConnection dbcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Zeek\\Documents\\User_Manage.mdf;Integrated Security=True;Connect Timeout=30");
                dbcon.Open();
                string del = $"delete from UserManageInfo where ID = '{ID}'";
                SqlCommand cmd_del = new SqlCommand(del, dbcon); SqlDataAdapter sda = new SqlDataAdapter($"Select Count(*) from UserManageInfo where ID = '{ID}'", dbcon);
                DataTable newTable = new DataTable();
                sda.Fill(newTable);
                cmd_del.ExecuteNonQuery();
                dbcon.Close();

                if (newTable.Rows[0][0].ToString() == "0") MessageBox.Show("다시 확인해주세요.", "실패");
                else if(newTable.Rows[0][0].ToString() == "1") MessageBox.Show("회원정보 삭제 완료!", "성공");
                DataSet ds = GetData();
                dg_UserInfo.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("다시 확인해주세요.", "실패");
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // DataSet을 가져온다
            DataSet ds = GetData();

            // DataSource 속성을 설정
            dg_UserInfo.DataSource = ds.Tables[0];
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string ID = txt_Sel_ID.Text;
            string PW = txt_Sel_PW.Text;
            string NAME = txt_Sel_Name.Text;
            string SEX = txt_Sel_Sex.Text;
            string BIRTH = txt_Sel_Birth.Text;
            string ADDRESS = txt_Sel_Add.Text;
            string TEL = txt_Sel_Tel.Text;
            if (ID != "" && PW != "" && NAME != "" && BIRTH != "" && SEX!="")
            {
                try
                {
                    SqlConnection dbcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Zeek\\Documents\\User_Manage.mdf;Integrated Security=True;Connect Timeout=30");
                    dbcon.Open();
                    string add = $"insert into UserManageInfo(ID, PW, NAME, SEX, BIRTH, ADDRESS, TEL) values ('{ID}', '{PW}', '{NAME}', '{SEX}', '{BIRTH}', '{ADDRESS}', '{TEL}')";
                    SqlCommand cmd_add = new SqlCommand(add, dbcon);
                    cmd_add.ExecuteNonQuery();
                    dbcon.Close();

                    MessageBox.Show("회원정보 추가 완료!", "성공");
                    DataSet ds = GetData();
                    dg_UserInfo.DataSource = ds.Tables[0];
                }
                catch
                {
                    MessageBox.Show("ID 또는 PW를 확인하세요.", "실패");
                }
            }
            else MessageBox.Show("필수 정보를 입력해주세요.", "실패");
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string ID = txt_Sel_ID.Text;
            string PW = txt_Sel_PW.Text;
            string NAME = txt_Sel_Name.Text;
            string SEX = txt_Sel_Sex.Text;
            string BIRTH = txt_Sel_Birth.Text;
            string ADDRESS = txt_Sel_Add.Text;
            string TEL = txt_Sel_Tel.Text;

            if (ID != "" && PW != "" && NAME != "" && BIRTH != "" && SEX != "")
            {
                try
                {
                    SqlConnection dbcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Zeek\\Documents\\User_Manage.mdf;Integrated Security=True;Connect Timeout=30");
                    dbcon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter($"Select Count(*) from UserManageInfo where ID = '{ID}'", dbcon);
                    DataTable newTable = new DataTable();
                    sda.Fill(newTable);
                    string update = $"update UserManageInfo set ID = '{ID}', PW = '{PW}', NAME = '{NAME}', SEX = '{SEX}', BIRTH = '{BIRTH}', ADDRESS = '{ADDRESS}', TEL = '{TEL}' where ID = '{ID}'";
                    SqlCommand cmd_update = new SqlCommand(update, dbcon);
                    cmd_update.ExecuteNonQuery();
                    if (newTable.Rows[0][0].ToString() == "1") MessageBox.Show("회원정보 변경 완료!", "성공");
                    else MessageBox.Show("ID를 확인해주세요.", "실패");
                    dbcon.Close();
                    DataSet ds = GetData();
                    dg_UserInfo.DataSource = ds.Tables[0];
                }
                catch
                {
                    MessageBox.Show("변경실패.", "실패");
                }
            }
            else MessageBox.Show("필수 정보를 입력해주세요.", "실패");
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("로그아웃!", "성공");
            this.Visible = false;
            Login showLogin = new Login();
            showLogin.ShowDialog();
        }

        private void dg_UserInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection dbcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Zeek\\Documents\\User_Manage.mdf;Integrated Security=True;Connect Timeout=30");
            dbcon.Open();
            string ID = dg_UserInfo.CurrentRow.Cells["ID"].Value.ToString();
            string PW = dg_UserInfo.CurrentRow.Cells["PW"].Value.ToString();
            string NAME = dg_UserInfo.CurrentRow.Cells["NAME"].Value.ToString();
            string SEX = dg_UserInfo.CurrentRow.Cells["SEX"].Value.ToString();
            string BIRTH = dg_UserInfo.CurrentRow.Cells["BIRTH"].Value.ToString();
            string ADDRESS = dg_UserInfo.CurrentRow.Cells["ADDRESS"].Value.ToString();
            string TEL = dg_UserInfo.CurrentRow.Cells["TEL"].Value.ToString();
            dbcon.Close();

            txt_Sel_ID.Text = ID;
            txt_Sel_PW.Text = PW;
            txt_Sel_Name.Text = NAME;
            txt_Sel_Sex.Text = SEX;
            txt_Sel_Birth.Text = BIRTH;
            txt_Sel_Add.Text= ADDRESS;
            txt_Sel_Tel.Text = TEL;
        }

        private void dg_UserInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection dbcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Zeek\\Documents\\User_Manage.mdf;Integrated Security=True;Connect Timeout=30");
            dbcon.Open();
            string ID = dg_UserInfo.CurrentRow.Cells["ID"].Value.ToString();
            string PW = dg_UserInfo.CurrentRow.Cells["PW"].Value.ToString();
            string NAME = dg_UserInfo.CurrentRow.Cells["NAME"].Value.ToString();
            string SEX = dg_UserInfo.CurrentRow.Cells["SEX"].Value.ToString();
            string BIRTH = dg_UserInfo.CurrentRow.Cells["BIRTH"].Value.ToString();
            string ADDRESS = dg_UserInfo.CurrentRow.Cells["ADDRESS"].Value.ToString();
            string TEL = dg_UserInfo.CurrentRow.Cells["TEL"].Value.ToString();
            dbcon.Close();

            txt_Sel_ID.Text = ID;
            txt_Sel_PW.Text = PW;
            txt_Sel_Name.Text = NAME;
            txt_Sel_Sex.Text = SEX;
            txt_Sel_Birth.Text = BIRTH;
            txt_Sel_Add.Text = ADDRESS;
            txt_Sel_Tel.Text = TEL;
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
