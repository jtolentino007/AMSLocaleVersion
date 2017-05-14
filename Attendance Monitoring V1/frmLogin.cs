using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMS.Classes;
using System.Data.SqlClient;
using DevExpress.XtraSplashScreen;
using System.Threading;
using System.IO;

namespace AMS
{
    public partial class frmLogin : Form
    {
        public static string Locale = "", Username = "", User_Image_Path = "";
        public static int User_id = 0;
        frmMain main = new frmMain();
        frmUserRegistration userRegistration = new frmUserRegistration();

        public frmLogin()
        {
            InitializeComponent();
            Utilities.SQLConnectionOpen();
            lblStatus.Text = Utilities.SQLConnectionStatus();
        }

        public void ClearLogin()
        {
            lueChurchID.EditValue = null;
            txtPassword.Text = string.Empty;
            Username = string.Empty;
            lueChurchID.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Utilities.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (Utilities.IsUserAuthenticated(lueChurchID.Text, txtPassword.Text))
                {
                    using (var cmd = new SqlCommand("GET_USER_INFO", Utilities.con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ChurchID", lueChurchID.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            Username = dr["fname"].ToString() + " " + dr["lname"].ToString();
                            frmMain.userPrivilege = Convert.ToInt32(dr["privilege"].ToString());
                            Locale = dr["locale"].ToString();
                            User_id = Convert.ToInt16(dr["user_id"].ToString());
                            User_Image_Path = dr["user_img_path"].ToString();
                        }
                    }

                    main.dashboardViewer1.ReloadData();

                    if (Directory.Exists(User_Image_Path) || File.Exists(User_Image_Path) && !string.IsNullOrEmpty(User_Image_Path))
                        main.peUserImage.Image = Image.FromFile(User_Image_Path);
                    else
                        main.peUserImage.Image = Properties.Resources.default_user_image;
                    

                    Utilities.GenerateSystemLog("Logged in", "Login", 1);
                    main.lblWelcomeMessage.Text = "Hi!\n" + Username + "\n" + Locale;
                    main.Privilege();
                    frmMain mainMenu = new frmMain();
                    mainMenu.Show();
                    this.Hide();
                }
                else
                {
                    Utilities.GenerateSystemLog("Church or Password is incorrect", "Login", 2);
                    Utilities.ErrorMessage("Church ID or Password is incorrect");
                }
            }
        }

        private void txtChurchID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Select();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }

        private void txtPassword_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void lueChurchID_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Utilities.FillLookUpEdit(lueChurchID, "GET_USERS","church_id","");
            Utilities.con.Close();
            Utilities.SQLConnectionOpen();
        }

        private void hlRegistration_Click(object sender, EventArgs e)
        {
            Utilities.FMode = "Add";
            userRegistration.Show();
            this.Hide();
        }

        private bool IsValid()
        {
            if (lueChurchID.Text == "")
            {
                Utilities.ErrorMessage("Church ID is Required");
                lueChurchID.Select();
                return false;
            }

            if (txtPassword.Text == "")
            {
                Utilities.ErrorMessage("Password is Required");
                txtPassword.Select();
                return false;
            }

            return true;
        }
    }
}
