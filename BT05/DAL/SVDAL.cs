using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BT05.DAL
{
    public class SVDAL
    {
        public static SVDAL _Instance;

        public static SVDAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SVDAL();
                }
                return _Instance;
            }
            private set { }
        }

        private SVDAL() { }
        public List<string> GetLopSH()
        {
            using (TamDBDataContext db = new TamDBDataContext())
            {
                List<string> listLopSh = new List<string>();
                listLopSh.Add("All");
                listLopSh.AddRange(db.SVs.Select(sv => sv.Class).ToArray());
                return listLopSh.Distinct().ToList();
            }
        }

        public List<SV> GetAllSV()
        {
            using (TamDBDataContext db = new TamDBDataContext())
            {
                var svs = db.SVs.Select(sv => sv).ToList();
                return svs;
            }
        }

        public List<SV> GetSVByLopSH(string lopSH)
        {
            using (TamDBDataContext db = new TamDBDataContext())
            {
                var svs = db.SVs.Where(sv => sv.Class == lopSH).ToList();
                return svs;
            }
        }

        public List<SV> GetSVByName_ID(string name, string id, string lopSH)
        {
            using (TamDBDataContext db = new TamDBDataContext())
            {
                var svs = db.SVs.Where(sv => sv.Name.Contains(name) && sv.ID.Contains(id) && sv.Class.Contains(lopSH)).ToList();
                return svs;
            }
        }

        public void DeleteSVByID(List<string> listID)
        {
            using (TamDBDataContext db = new TamDBDataContext())
            {
                var listSV = db.SVs.Where(sv => listID.Contains(sv.ID));
                db.SVs.DeleteAllOnSubmit(listSV);

                db.SubmitChanges();

            }
        }

        public void AddSV(SV sv)
        {
            using (TamDBDataContext db = new TamDBDataContext())
            {
                db.SVs.InsertOnSubmit(sv);

                db.SubmitChanges();

            }
        }

        public void UpdateSV(SV sV)
        {
            using (TamDBDataContext db = new TamDBDataContext())
            {
                var svEdit = db.SVs.Where(sv => sv.ID == sV.ID).SingleOrDefault();
                svEdit.Name = sV.Name;
                svEdit.Class = sV.Class;
                svEdit.Gender = sV.Gender;
                svEdit.Dob = sV.Dob;
                svEdit.GPA = sV.GPA;
                svEdit.Picture = sV.Picture;
                svEdit.School_report = sV.School_report;
                svEdit.CCCD = sV.CCCD;

                db.SubmitChanges();

            }
        }


    }
}
