using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Collections;
using System.Data;

namespace BLL
{
    [Serializable]
    public partial class Farm
    {
        private int id;
        private string farmName;
        private double size;

        public Farm(int id, string farmName, double size)
        {
            this.ID = id;
            this.FarmName = farmName;
            this.Size = size;
        }
        public Farm(string farmName, double size)
        {
            this.FarmName = farmName;
            this.Size = size;
        }
        public Farm()
        {
            
        }

        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string FarmName
        {
            get
            {
                return farmName;
            }

            set
            {
                farmName = value;
            }
        }

        public double Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
            }
        }
    }
    public partial class Farm
    {
        public override bool Equals(object obj)
        {
            if (obj==null) return false;
            Farm f = obj as Farm;
            if ((Object)f==null) return false;
            return ((f.FarmName==this.FarmName)&&(f.ID==this.ID)&&(f.Size==this.Size));
        }
        public override int GetHashCode()
        {
            return this.FarmName.GetHashCode()^this.ID.GetHashCode()^this.Size.GetHashCode();
        }
        public override string ToString()
        {
            return this.FarmName;
        }
    }
    public partial class Farm
    {
        public string insertFarm()
        {
            string result = "Insert Failed";
            DataHandler handler = new DataHandler();
            ArrayList toWrite = new ArrayList() {this.FarmName,this.Size};
            int res = handler.InsertFarm(toWrite);
            if (res==1)
            {
                result = "Insert Successful";
            }
            return result;
        }

        public List<Farm> selectFarm(int id)
        {
            DataHandler handler = new DataHandler();
            List<Farm> farms = new List<Farm>();
            DataTable rawData = handler.SelectFarmOrLocationOrAnimal(id,"SelectFarm");
            foreach (DataRow item in rawData.Rows)
            {
                farms.Add(new Farm(int.Parse(item["FarmId"].ToString()),item["FarmName"].ToString(),double.Parse(item["FarmSize"].ToString())));
            }
            return farms;
        }
    }
}
