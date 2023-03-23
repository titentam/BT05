using BT05.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT05.BLL
{
    public class SVBLL
    {
        public static SVBLL _Instance;

        public static SVBLL Instance
        {
            get
            {
                if (_Instance == null) _Instance = new SVBLL();
                return _Instance;
            }
            private set { }
        }
        private SVBLL() { }

        public List<string> GetLopSH()
        {
           return SVDAL.Instance.GetLopSH();
        }
        public List<SV> GetAllSV()
        {
           return SVDAL.Instance.GetAllSV();    
        }
        public List<SV> GetSVByLopSH(string lopSH)
        {
            return SVDAL.Instance.GetSVByLopSH(lopSH);
        }
        public List<SV> GetSVByName_ID(string name, string id, string lopSH)
        {
            return SVDAL.Instance.GetSVByName_ID(name, id, lopSH);
        } 

        public void DeleteSVByID(List<string> listID)
        {
            SVDAL.Instance.DeleteSVByID(listID);    
        }
        public void SortSV(string option, DataGridView data)
        {
            List<SV> list = null;
            if(option == "Name")
            {
                list = SVDAL.Instance.GetAllSV().OrderBy(sv => sv.Name).ToList();
            }
            else if(option == "GPA")
            {
                list = SVDAL.Instance.GetAllSV().OrderBy(sv => sv.GPA).ToList();
            }
            data.DataSource = list;
        }

        public void AddSV(SV sV)
        {
            SVDAL.Instance.AddSV(sV);
        }

        public void UpdateSV(SV sV)
        {
            SVDAL.Instance.UpdateSV(sV);
        }
    }
}
