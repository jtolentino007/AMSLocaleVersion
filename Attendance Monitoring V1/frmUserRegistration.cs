using AMS.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AMS
{
    public partial class frmUserRegistration : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string Password;
        string ImagePath, AppPath, ImageName;
        public frmUserRegistration()
        {
            InitializeComponent();
        }

        private void barBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Utilities.FMode == "Add")
            {
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
            else
            {
                this.Hide();
            }
        }

        private void ClearFields()
        {
            txtChurchID.Text = null;
            txtConfirmPassword.Text = null;
            txtFirstname.Text = null;
            txtLastname.Text = null;
            txtMiddleName.Text = null;
            txtPassword.Text = null;
            cboPrivilege.SelectedIndex = -1;
            lueLocale.EditValue = null;
            txtChurchID.Focus();
        }

        private void barBtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utilities.SQLConnectionOpen();
            if (IsValid())
            {
                if (Utilities.FMode == "Add")
                {
                    using (var cmdInsert = new SqlCommand("INSERT_USER", Utilities.con))
                    {
                        cmdInsert.CommandType = CommandType.StoredProcedure;
                        cmdInsert.Parameters.AddWithValue("@churchid", txtChurchID.Text);
                        cmdInsert.Parameters.AddWithValue("@password", txtPassword.Text);
                        cmdInsert.Parameters.AddWithValue("@fname", txtFirstname.Text);
                        cmdInsert.Parameters.AddWithValue("@mname", txtMiddleName.Text);
                        cmdInsert.Parameters.AddWithValue("@lname", txtLastname.Text);
                        cmdInsert.Parameters.AddWithValue("@privilege", cboPrivilege.EditValue);
                        cmdInsert.Parameters.AddWithValue("@locale_id", lueLocale.EditValue);
                        cmdInsert.Parameters.AddWithValue("@user_img_path", "");
                        cmdInsert.ExecuteNonQuery();
                        Utilities.SuccessMessage("You have successfully registered!, Please wait for the administrators approval.");
                        Utilities.GenerateSystemLog("User " + txtFirstname.Text + " " + txtLastname.Text + " Registered", "User Management", 1);
                        ClearFields();
                        Instances.login.Show();
                        this.Hide();
                    }
                }
                else if (Utilities.FMode == "Edit")
                {
                    if (IsPasswordValid())
                    {
                        using (var cmdUpdate = new SqlCommand("UPDATE_USER", Utilities.con))
                        {
                            cmdUpdate.CommandType = CommandType.StoredProcedure;
                            cmdUpdate.Parameters.AddWithValue("@user_id", frmLogin.User_id);
                            cmdUpdate.Parameters.AddWithValue("@churchid", txtChurchID.Text);
                            cmdUpdate.Parameters.AddWithValue("@password", txtPassword.Text);
                            cmdUpdate.Parameters.AddWithValue("@fname", txtFirstname.Text);
                            cmdUpdate.Parameters.AddWithValue("@mname", txtMiddleName.Text);
                            cmdUpdate.Parameters.AddWithValue("@lname", txtLastname.Text);
                            cmdUpdate.Parameters.AddWithValue("@privilege", cboPrivilege.EditValue);
                            cmdUpdate.Parameters.AddWithValue("@locale_id", lueLocale.EditValue);
                            cmdUpdate.Parameters.AddWithValue("@user_img_path", ImagePath);
                            cmdUpdate.ExecuteNonQuery();
                            Utilities.SuccessMessage("You have successfully updated your profile!, Thanks be to God!");
                            Utilities.GenerateSystemLog("User " + txtFirstname.Text + " " + txtLastname.Text + " Edited His/Her Profile", "User Management", 1);
                            ClearFields();
                            this.Close();
                        }
                    }
                    else
                    {
                        Utilities.ErrorMessage("Wrong Password Entered...");
                        Utilities.GenerateSystemLog("Wrong Password Entered...", "User Management", 3);
                    }
                }
            }
        }

        private bool IsPasswordValid()
        {
            if (txtPassword.Text == Password) return true;
            else return false;
        }

        private bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(txtChurchID.Text))
            {
                Utilities.ErrorMessage("Church ID is Required");
                txtChurchID.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                Utilities.ErrorMessage("Password is Required");
                txtPassword.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                Utilities.ErrorMessage("Confirm Password is Required");
                txtConfirmPassword.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtFirstname.Text))
            {
                Utilities.ErrorMessage("First name is Required");
                txtFirstname.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtLastname.Text))
            {
                Utilities.ErrorMessage("Last name is Required");
                txtLastname.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(cboPrivilege.Text))
            {
                Utilities.ErrorMessage("Privilege is required");
                cboPrivilege.Focus();
                return false;
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                Utilities.ErrorMessage("Password and Confirm Password Does not match");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void frmUserRegistration_Load(object sender, EventArgs e)
        {
            Utilities.FillLookUpEdit(lueLocale, "GET_LOCALE", "locale", "locale_id");
            if (Utilities.FMode == "Edit")
            {
                lblInfo.Visible = false;
                panelInfo.Visible = false;
                using (var cmd = new SqlCommand("SELECT * FROM Users WHERE user_id = '"+ frmLogin.User_id +"'", Utilities.con))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtChurchID.Text = dr["church_id"].ToString();
                        txtFirstname.Text = dr["fname"].ToString();
                        txtMiddleName.Text = dr["mname"].ToString();
                        txtLastname.Text = dr["lname"].ToString();
                        lueLocale.EditValue = dr["locale_id"];

                        ImagePath = dr["user_img_path"].ToString();
                        if (!string.IsNullOrWhiteSpace(ImagePath))
                        {
                            if (Directory.Exists(ImagePath))
                            {
                                peUser.Image = Image.FromFile(ImagePath);
                            }
                        }
                        else
                            peUser.Image = null;

                        cboPrivilege.SelectedIndex = Convert.ToInt16(dr["privilege"]) - 1;
                        Password = dr["password"].ToString();
                    }
                }
            }
            else
            {
                lblInfo.Visible = true;
                panelInfo.Visible = true;
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open User Image...";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                ImagePath = dlg.FileName;
                AppPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Users\";

                if (Directory.Exists(AppPath) == false)
                    Directory.CreateDirectory(AppPath);

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (Directory.Exists(AppPath + dlg.SafeFileName) || File.Exists(AppPath + dlg.SafeFileName))
                    {
                        ImageName = Guid.NewGuid()+ dlg.SafeFileName;
                        peUser.Image = new Bitmap(dlg.OpenFile());
                        ImagePath = AppPath + ImageName;
                        
                        string filepath = dlg.FileName;
                        File.Copy(filepath, ImagePath);
                    }
                    else
                    {
                        ImageName = dlg.SafeFileName;
                        peUser.Image = new Bitmap(dlg.OpenFile());
                        ImagePath = AppPath + ImageName;
                        
                        string filepath = dlg.FileName;
                        File.Copy(filepath, ImagePath);
                    }
                }

                dlg.Dispose();
            }
        }
    }
}
