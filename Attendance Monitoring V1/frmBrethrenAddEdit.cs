using System;
using System.Data;
using AMS.Classes;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace AMS
{
    public partial class frmBrethrenAddEdit : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string  ImagePath, 
                AppPath, 
                ImageName,
                BrethrenImagePath,
                BrethrenAppPath,
                BrethrenImageName;

        public DataTable dtBrethren { get; set; }
        public DataRow drBrethren { get; set; }
        public frmBrethrenAddEdit()
        {
            InitializeComponent();
        }

        private void frmBrethrenAddEdit_Load(object sender, EventArgs e)
        {
            FillLocale();
            FillCommittee();
            FillGroup();
            if (Utilities.FMode == "Add")
            {
                Clear();
            }
            else if (Utilities.FMode == "Edit")
            {
                SetDetails();
            }
        }

        private void SetDetails()
        {
            txtChurchID.Text = drBrethren["Church_Id"].ToString();
            lueGroup.EditValue = Convert.ToInt32(drBrethren["Group_Id"].ToString());
            txtFname.Text = drBrethren["Firstname"].ToString();
            txtMName.Text = drBrethren["Middlename"].ToString();
            txtLName.Text = drBrethren["Lastname"].ToString();
            dtBaptism.EditValue = drBrethren["Date_Baptism"].ToString();
            dtBirth.EditValue = drBrethren["Date_Birth"].ToString();
            cmbGender.EditValue = drBrethren["Gender"].ToString();
            cmbCivilStatus.EditValue = drBrethren["Civil_Status"].ToString();
            txtStreet.Text = drBrethren["Street"].ToString();
            txtBrgy.Text = drBrethren["Brgy"].ToString();
            txtCity.Text = drBrethren["City_Town"].ToString();
            txtProvince.Text = drBrethren["Province"].ToString();
            txtRegion.Text = drBrethren["Region"].ToString();
            txtEmployment.Text = drBrethren["Employment"].ToString();
            txtContactNo.Text = drBrethren["Phone_no"].ToString();
            BrethrenImagePath = drBrethren["Image_Path"].ToString();
            ImagePath = drBrethren["Sketch_Path"].ToString();

            if (!string.IsNullOrWhiteSpace(BrethrenImagePath))
                peBrethren.Image = Image.FromFile(drBrethren["Image_Path"].ToString());
            else
                peBrethren.Image = null;

            if (!string.IsNullOrWhiteSpace(ImagePath))
                peSketch.Image = Image.FromFile(drBrethren["Sketch_Path"].ToString());
            else
                peSketch.Image = null;

            txtContactPerson.Text = drBrethren["Contact_Person"].ToString();
            txtContactPersonNumber.Text = drBrethren["Contact_Person_no"].ToString();
            cmbStatus.EditValue = drBrethren["Status"].ToString();

            if (drBrethren["locale_id"].ToString() == "")
                lueLocale.EditValue = 0;
            else
                lueLocale.EditValue = Convert.ToInt32(drBrethren["locale_id"].ToString());

            txtBaptizer.Text = drBrethren["Baptizer"].ToString();
            checkedComboBoxEdit1.SetEditValue(drBrethren["Committee_Names"].ToString());
            txtChurchID.Focus();
        }

        private void mnuBtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            Utilities.FMode = "Add";
            Instances.groupAdd.ShowDialog();
        }

        private bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(txtChurchID.Text))
            {
                txtChurchID.Focus();
                Utilities.ErrorMessage("Church ID is required");
                return false;
            }
            
            if (string.IsNullOrWhiteSpace(txtFname.Text))
            {
                txtFname.Focus();
                Utilities.ErrorMessage("First name is required");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLName.Text))
            {
                txtLName.Focus();
                Utilities.ErrorMessage("Last name is required");
                return false;
            }

            if (string.IsNullOrWhiteSpace(dtBaptism.Text))
            {
                dtBaptism.Focus();
                Utilities.ErrorMessage("Date of Baptism is required");
                return false;
            }

            if (string.IsNullOrWhiteSpace(dtBirth.Text))
            {
                dtBirth.Focus();
                Utilities.ErrorMessage("Date of Birth is required");
                return false;
            }

            if (string.IsNullOrWhiteSpace(lueLocale.Text))
            {
                lueLocale.Focus();
                Utilities.ErrorMessage("Locale is required");
                return false;
            }

            return true;
        }


        private void Clear()
        {
            txtChurchID.Text = string.Empty;
            txtFname.Text = string.Empty;
            txtMName.Text = string.Empty;
            txtLName.Text = string.Empty;
            dtBaptism.Text = string.Empty;
            dtBirth.Text = string.Empty;
            cmbGender.Text = string.Empty;
            cmbCivilStatus.SelectedIndex = -1;
            txtStreet.Text = string.Empty;
            txtBrgy.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtProvince.Text = string.Empty;
            txtRegion.Text = string.Empty;
            txtEmployment.Text = string.Empty;
            txtContactNo.Text = string.Empty;
            txtContactPerson.Text = string.Empty;
            txtContactPersonNumber.Text = string.Empty;
            cmbStatus.SelectedIndex = -1;
            lueGroup.Reset();
            lueLocale.EditValue = null;
            checkedComboBoxEdit1.EditValue = null;
            checkedComboBoxEdit1.Text = string.Empty;
            txtBaptizer.Text = string.Empty;
            peSketch.Image = null;
            peBrethren.Image = null;
            txtChurchID.Select();
        }

        private int ContactPersonMember()
        {
            if (chkMember.Checked)
                return 1;
            else
                return 0;
        }

        public string BrethrenID()
        {
            string BrethrenID = Utilities.GetLastCodeFromTable("brethren_id", "Brethren");

            if (BrethrenID == null)
                return "B-0001";
            else
                return "B-" + (Convert.ToInt16(BrethrenID.Replace("B-", "")) + 1);
        }

        private void UpdateBrethren()
        {
            using (var cmd = new SqlCommand("UPDATE_BRETHREN", Utilities.con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BrethrenID", drBrethren["brethren_id"].ToString());
                cmd.Parameters.AddWithValue("@ChurchID", txtChurchID.Text);
                cmd.Parameters.AddWithValue("@Firstname", txtFname.Text);
                cmd.Parameters.AddWithValue("@Middlename", txtMName.Text);
                cmd.Parameters.AddWithValue("@Lastname", txtLName.Text);
                cmd.Parameters.AddWithValue("@Image_Path", BrethrenImagePath);
                cmd.Parameters.AddWithValue("@Sketch_Path", ImagePath);
                cmd.Parameters.AddWithValue("@GroupID", Convert.ToInt32(lueGroup.EditValue));
                cmd.Parameters.AddWithValue("@DateOfBaptism", dtBaptism.EditValue);
                cmd.Parameters.AddWithValue("@DateOfBirth", dtBirth.EditValue);
                cmd.Parameters.AddWithValue("@Gender", cmbGender.EditValue);
                cmd.Parameters.AddWithValue("@CivilStatus", cmbCivilStatus.EditValue);
                cmd.Parameters.AddWithValue("@Street", txtStreet.Text);
                cmd.Parameters.AddWithValue("@Brgy", txtBrgy.Text);
                cmd.Parameters.AddWithValue("@CityTown", txtCity.Text);
                cmd.Parameters.AddWithValue("@Province", txtProvince.Text);
                cmd.Parameters.AddWithValue("@Region", txtRegion.Text);
                cmd.Parameters.AddWithValue("@Employment", txtEmployment.Text);
                cmd.Parameters.AddWithValue("@PhoneNo", txtContactNo.Text);
                cmd.Parameters.AddWithValue("@ContactPerson", txtContactPerson.Text);
                cmd.Parameters.AddWithValue("@ContactPersonNo", txtContactPersonNumber.Text);
                cmd.Parameters.AddWithValue("@Committee_Names", checkedComboBoxEdit1.Text);
                cmd.Parameters.AddWithValue("@Status", cmbStatus.EditValue);
                cmd.Parameters.AddWithValue("@Remarks", "");
                cmd.Parameters.AddWithValue("@locale_id", Convert.ToInt16(lueLocale.EditValue));
                cmd.Parameters.AddWithValue("@Baptizer", txtBaptizer.Text);
                cmd.Parameters.AddWithValue("@is_contact_person_member", ContactPersonMember());
                cmd.ExecuteNonQuery();

                drBrethren["Church_Id"] = txtChurchID.Text;
                drBrethren["Firstname"] = txtFname.Text;
                drBrethren["Middlename"] = txtMName.Text;
                drBrethren["Lastname"] = txtLName.Text;
                drBrethren["Date_Baptism"] = dtBaptism.EditValue;
                drBrethren["Date_Birth"] = dtBirth.EditValue;
                drBrethren["Gender"] = cmbGender.EditValue;
                drBrethren["Civil_Status"] = cmbCivilStatus.EditValue;
                drBrethren["Street"] = txtStreet.Text;
                drBrethren["Brgy"] = txtBrgy.Text;
                drBrethren["City_Town"] = txtCity.Text;
                drBrethren["Province"] = txtProvince.Text;
                drBrethren["Region"] = txtRegion.Text;
                drBrethren["Employment"] = txtEmployment.Text;
                drBrethren["Phone_no"] = txtContactNo.Text;
                drBrethren["Contact_Person"] = txtContactPerson.Text;
                drBrethren["Contact_Person_no"] = txtContactPersonNumber.Text;
                drBrethren["Status"] = cmbStatus.EditValue;
                drBrethren["Remarks"] = "";
                drBrethren["Group_ID"] = lueGroup.EditValue;
                drBrethren["Image_Path"] = BrethrenImagePath;
                drBrethren["Sketch_Path"] = ImagePath;
                drBrethren["Group_name"] = lueGroup.Text;
                drBrethren["Committee_Names"] = checkedComboBoxEdit1.Text;
                drBrethren["locale_id"] = lueLocale.EditValue;
                drBrethren["locale"] = lueLocale.Text;
                drBrethren["Baptizer"] = txtBaptizer.Text;
                drBrethren["is_contact_person_member"] = ContactPersonMember();

                drBrethren.AcceptChanges();
                Utilities.SuccessMessage("Brethren Successfully Updated");
                Utilities.GenerateSystemLog("Edits " + txtFname.Text + " " + txtLName.Text + " Information", "Brethren Management", 1);
                Clear();
                this.Close();
            }
        }
        private void InsertBrethren()
        {
            using (var cmd = new SqlCommand("INSERT_BRETHREN", Utilities.con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BrethrenID", BrethrenID());
                cmd.Parameters.AddWithValue("@ChurchID", txtChurchID.Text);
                cmd.Parameters.AddWithValue("@Firstname", txtFname.Text);
                cmd.Parameters.AddWithValue("@Middlename", txtMName.Text);
                cmd.Parameters.AddWithValue("@Lastname", txtLName.Text);
                cmd.Parameters.AddWithValue("@Image_Path", BrethrenImagePath);
                cmd.Parameters.AddWithValue("@Sketch_Path", ImagePath);
                cmd.Parameters.AddWithValue("@GroupID", Convert.ToInt32(lueGroup.EditValue));
                cmd.Parameters.AddWithValue("@DateOfBaptism", Convert.ToDateTime(dtBaptism.EditValue));
                cmd.Parameters.AddWithValue("@DateOfBirth", Convert.ToDateTime(dtBirth.EditValue));
                cmd.Parameters.AddWithValue("@Gender", cmbGender.EditValue);
                cmd.Parameters.AddWithValue("@CivilStatus", cmbCivilStatus.EditValue);
                cmd.Parameters.AddWithValue("@Street", txtStreet.Text);
                cmd.Parameters.AddWithValue("@Brgy", txtBrgy.Text);
                cmd.Parameters.AddWithValue("@CityTown", txtCity.Text);
                cmd.Parameters.AddWithValue("@Province", txtProvince.Text);
                cmd.Parameters.AddWithValue("@Region", txtRegion.Text);
                cmd.Parameters.AddWithValue("@Employment", txtEmployment.Text);
                cmd.Parameters.AddWithValue("@PhoneNo", txtContactNo.Text);
                cmd.Parameters.AddWithValue("@ContactPerson", txtContactPerson.Text);
                cmd.Parameters.AddWithValue("@ContactPersonNo", txtContactPersonNumber.Text);
                cmd.Parameters.AddWithValue("@Committee_Names", checkedComboBoxEdit1.Text);
                cmd.Parameters.AddWithValue("@Status", cmbStatus.EditValue);
                cmd.Parameters.AddWithValue("@Remarks", "");
                cmd.Parameters.AddWithValue("@locale_id", Convert.ToInt32(lueLocale.EditValue));
                cmd.Parameters.AddWithValue("@Baptizer", txtBaptizer.Text);
                cmd.Parameters.AddWithValue("@is_contact_person_member", ContactPersonMember());
                cmd.ExecuteNonQuery();
                DataRow dr = dtBrethren.NewRow();

                dr["brethren_id"] = BrethrenID();
                dr["Church_Id"] = txtChurchID.Text;
                dr["Firstname"] = txtFname.Text;
                dr["Middlename"] = txtMName.Text;
                dr["Lastname"] = txtLName.Text;
                dr["Date_Baptism"] = Convert.ToDateTime(dtBaptism.EditValue);
                dr["Date_Birth"] = Convert.ToDateTime(dtBirth.EditValue);
                dr["Gender"] = cmbGender.EditValue;
                dr["Civil_Status"] = cmbCivilStatus.EditValue;
                dr["Street"] = txtStreet.Text;
                dr["Brgy"] = txtBrgy.Text;
                dr["City_Town"] = txtCity.Text;
                dr["Province"] = txtProvince.Text;
                dr["Region"] = txtRegion.Text;
                dr["Employment"] = txtEmployment.Text;
                dr["Phone_no"] = txtContactNo.Text;
                dr["Contact_Person"] = txtContactPerson.Text;
                dr["Contact_Person_no"] = txtContactPersonNumber.Text;
                dr["Status"] = cmbStatus.EditValue;
                dr["Image_Path"] = BrethrenImagePath;
                dr["Sketch_Path"] = ImagePath;
                dr["Remarks"] = "";
                dr["Group_ID"] = lueGroup.EditValue;
                dr["Group_name"] = lueGroup.Text;
                dr["Committee_Names"] = checkedComboBoxEdit1.Text;
                dr["locale_id"] = lueLocale.EditValue;
                dr["locale"] = lueLocale.Text;
                dr["Baptizer"] = txtBaptizer.Text;
                dr["is_contact_person_member"] = ContactPersonMember();

                dtBrethren.Rows.Add(dr);
                dtBrethren.AcceptChanges();

                Utilities.SuccessMessage("Brethren Successfully Saved");
                Utilities.GenerateSystemLog("Added " + txtFname.Text + " " + txtLName.Text, "Brethren Management", 1);
                Clear();
                this.Close();
            }
        }
        public void FillCommittee()
        {
            var dtCommittee = new DataTable();
            using (var adaptCommittee = new SqlDataAdapter("GET_COMMITTEE", Utilities.con))
            {
                adaptCommittee.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtCommittee.Clear();
                adaptCommittee.Fill(dtCommittee);
                checkedComboBoxEdit1.Properties.DataSource = dtCommittee;
                checkedComboBoxEdit1.Properties.DisplayMember = "committee_name";
                checkedComboBoxEdit1.Properties.ValueMember = "committee_name";
            }
        }
        public void FillLocale()
        {
            var dtLocale = new DataTable();
            using (var adaptLocale = new SqlDataAdapter("GET_LOCALE", Utilities.con))
            {
                adaptLocale.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtLocale.Clear();
                adaptLocale.Fill(dtLocale);
                lueLocale.Properties.DataSource = dtLocale;
                lueLocale.Properties.DisplayMember = "locale";
                lueLocale.Properties.ValueMember = "locale_id";
            }
        }

        public void FillGroup()
        {
            var dtGroupings = new DataTable();
            using (var adaptGroupings = new SqlDataAdapter("GET_GROUPINGS", Utilities.con))
            {
                adaptGroupings.SelectCommand.CommandType = CommandType.StoredProcedure;
                dtGroupings.Clear();
                adaptGroupings.Fill(dtGroupings);
                lueGroup.Properties.DataSource = dtGroupings;
                lueGroup.Properties.ValueMember = "Group_Id";
                lueGroup.Properties.DisplayMember = "Group_name";
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog bdlg = new OpenFileDialog())
            {
                bdlg.Title = "Open Brethren Image...";
                bdlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                BrethrenImagePath = bdlg.FileName;
                BrethrenAppPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Brethren\";
                if (Directory.Exists(BrethrenAppPath) == false)
                    Directory.CreateDirectory(BrethrenAppPath);

                if (bdlg.ShowDialog() == DialogResult.OK)
                {
                    if (Directory.Exists(BrethrenAppPath + bdlg.SafeFileName) || File.Exists(BrethrenAppPath + bdlg.SafeFileName))
                    {
                        ImageName = Guid.NewGuid() + bdlg.SafeFileName;
                        peBrethren.Image = new Bitmap(bdlg.OpenFile());
                        BrethrenImagePath = BrethrenAppPath + ImageName;

                        string filepath = bdlg.FileName;
                        File.Copy(filepath, BrethrenImagePath);
                    }
                    else
                    {
                        ImageName = bdlg.SafeFileName;
                        peBrethren.Image = new Bitmap(bdlg.OpenFile());
                        BrethrenImagePath = BrethrenAppPath + ImageName;

                        string filepath = bdlg.FileName;
                        File.Copy(filepath, BrethrenImagePath);
                    }
                }

                bdlg.Dispose();
            }
        }

        private void mnuBtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (IsValid())
            {
                if (Utilities.FMode == "Add")
                {
                    InsertBrethren();
                }
                else if (Utilities.FMode == "Edit")
                {
                    UpdateBrethren();
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Sketch Image...";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                ImagePath = dlg.FileName;
                AppPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Sketches\";
                if (Directory.Exists(AppPath) == false)
                    Directory.CreateDirectory(AppPath);

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (Directory.Exists(AppPath + dlg.SafeFileName) || File.Exists(AppPath + dlg.SafeFileName))
                    {
                        ImageName = Guid.NewGuid() + dlg.SafeFileName;
                        peSketch.Image = new Bitmap(dlg.OpenFile());
                        ImagePath = AppPath + ImageName;

                        string filepath = dlg.FileName;
                        File.Copy(filepath, ImagePath);
                    }
                    else
                    {
                        ImageName = dlg.SafeFileName;
                        peSketch.Image = new Bitmap(dlg.OpenFile());
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
