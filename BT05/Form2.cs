using BT05.BLL;
using BT05.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT05
{
    public partial class Form2 : Form
    {
        public delegate void LoadForm1();
        public LoadForm1 myDel;
        private string _id;

        // add
        public Form2()
        {
            
            InitializeComponent();
            InitAdd();
        }

        // edit
        public Form2(string id)
        {
            _id = id;   
            InitializeComponent();
            InitEdit();
        }

        public void LoadCBLopSH()
        {
            List<string> list = SVBLL.Instance.GetLopSH();
            list.RemoveAt(0);
            list.Sort();
            cbLopSh.DataSource = list;  
            cbLopSh.SelectedIndex = 0;
        }

        public void InitAdd()
        {
            LoadCBLopSH();
            btnOk.Click += new System.EventHandler(this.btnOk_ClickAdd);
            txtMSSV.Enabled = true;
        }

        public void InitEdit()
        {
            LoadCBLopSH();
            btnOk.Click += new System.EventHandler(this.btnOk_ClickEdit);


            // load sv
            var sv = SVBLL.Instance.GetSVByName_ID("", _id, "")[0];
           
            txtMSSV.Text = sv.ID;
            txtName.Text = sv.Name;
            cbLopSh.SelectedIndex = cbLopSh.Items.IndexOf(sv.Class);
            dtNs.Text = sv.Dob.ToString();
            if ((bool)sv.Gender)
            {
                rbtnMale.Checked = true;
            }
            else
            {
                rbtnFemale.Checked = true;
            }
            txtDTB.Text = sv.GPA.ToString();
            checkAnh.Checked = (bool)(sv.Picture);
            checkHocBa.Checked = (bool)(sv.School_report);
            checkCCCD.Checked = (bool)sv.CCCD;
        }
        private void btnOk_ClickEdit(object sender, System.EventArgs e)
        {
            var ID = txtMSSV.Text;
            var Name = txtName.Text;
            var Dob = Convert.ToDateTime(dtNs.Value.ToShortDateString());
            float GPA;
            float.TryParse(txtDTB.Text, out GPA);

            // ktra Id co ton tai hay khong
            bool checkID = SVBLL.Instance.GetSVByName_ID("", ID, "").Count == 0;
            bool checkOK = true;

            if (Name != "")
            {
                SV sV = new SV();
                sV.ID = ID;
                sV.Name = Name;
                sV.Class = cbLopSh.SelectedItem.ToString();
                sV.Dob = Dob;
                sV.GPA = GPA;
                sV.Gender = rbtnMale.Checked;
                sV.Picture = checkAnh.Checked;
                sV.School_report = checkHocBa.Checked;
                sV.CCCD = checkCCCD.Checked;

                SVBLL.Instance.UpdateSV(sV);
            }
            else
            {
                MessageBox.Show("Thieu thong tin");
                checkOK = false;
            }    
            if (checkOK)
            {
                myDel.Invoke();
                this.Dispose();

            }
        }

        private void btnOk_ClickAdd(object sender, EventArgs e)
        {
            var ID = txtMSSV.Text;
            var Name = txtName.Text;
            var Dob = Convert.ToDateTime(dtNs.Value.ToShortDateString());
            float GPA;
            float.TryParse(txtDTB.Text, out GPA);

            // ktra Id co ton tai hay khong
            bool checkID = SVBLL.Instance.GetSVByName_ID("",ID,"").Count == 0;
            bool checkOK = true;

            if (checkID)
            {
                if (ID != "" && ID.Length <= 8 && Name != "")
                {
                    SV sV = new SV();
                    sV.ID = ID;
                    sV.Name = Name;
                    sV.Class = cbLopSh.SelectedItem.ToString();
                    sV.Dob = Dob;
                    sV.GPA = GPA;
                    sV.Gender = rbtnMale.Checked;
                    sV.Picture = checkAnh.Checked;
                    sV.School_report = checkHocBa.Checked;
                    sV.CCCD = checkCCCD.Checked;

                    SVBLL.Instance.AddSV(sV);
                }
                else
                {
                    MessageBox.Show("Thieu thong tin");
                    checkOK = false;
                }
            }
            else
            {
                checkOK = false;
                MessageBox.Show("MSSV da ton tai");
            }
            if (checkOK)
            {
                myDel.Invoke();
                this.Dispose();
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
