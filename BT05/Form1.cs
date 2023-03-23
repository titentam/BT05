using BT05.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadLopSH();
            LoadAllSV();
            LoadOptionSort();
        }
        public void LoadLopSH()
        {
            cbLopSH.DataSource=  SVBLL.Instance.GetLopSH();
            cbLopSH.SelectedIndex = 0;
        }
        public void LoadAllSV()
        {
            gvTable.DataSource= SVBLL.Instance.GetAllSV();
        }

        public void LoadOptionSort()
        {
            List<string> list = new List<string>();
            list.Add("Name");
            list.Add("GPA");
            cbSort.DataSource = list;   
            
        }
        private void cbLopSH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbLopSH.SelectedIndex == 0)
            {
                LoadAllSV();
            }
            else
            {
                string lopSH = cbLopSH.SelectedItem.ToString();
                gvTable.DataSource = SVBLL.Instance.GetSVByLopSH(lopSH);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = "";
            string id = "";
            string lopSH = cbLopSH.SelectedItem.ToString();
            if (lopSH == "All") lopSH = "";
            if (txtSearch.Text.Contains(','))
            {

                string[] nameAndID = txtSearch.Text.Split(',');
                // xoa bo khoang trang
                nameAndID[0] = nameAndID[0].Trim();
                nameAndID[1] = nameAndID[1].Trim();
                name = nameAndID[0];
                id = nameAndID[1];
            }
            else
            {
                name = txtSearch.Text;
            }
            gvTable.DataSource = SVBLL.Instance.GetSVByName_ID(name, id, lopSH);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn xoá không", "Xác nhận xoá", MessageBoxButtons.OKCancel);
            if(res == DialogResult.OK) 
            {
                List<string> listID = new List<string>();
                foreach (DataGridViewRow row in gvTable.SelectedRows)
                {
                    listID.Add(row.Cells["ID"].Value.ToString());
                }
                SVBLL.Instance.DeleteSVByID(listID);
                btnSearch_Click(sender, e);
            }

         
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string option = cbSort.SelectedItem.ToString();
            SVBLL.Instance.SortSV(option, gvTable);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.myDel += LoadAllSV;
            form2.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (gvTable.SelectedRows.Count == 1)
            {
                string mssv = gvTable.SelectedRows[0].Cells[0].Value.ToString();
                Form2 f2 = new Form2(mssv);
                f2.myDel += LoadAllSV;
                f2.ShowDialog();

            }
        }
    }
}
