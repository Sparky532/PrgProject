using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Collections;

namespace BLL
{
    public partial class Farmer
    {
        private int id;
        private string name;
        private string gender;
        private string age;
        private Style farmerStyle;

        public Style FarmerStyle {
            get { return farmerStyle; }
            set { farmerStyle = value; }
        }

        public Farmer(int idP, string nameP, string genderP, string ageP, Style farmerStyleP)
        {
            this.ID = idP;
            this.Name = nameP;
            this.Gender = genderP;
            this.Age = ageP;
            this.FarmerStyle = farmerStyleP;
        }
        public Farmer(string nameP, string genderP, string ageP, Style farmerStyleP)
        {

            this.Name = nameP;
            this.Gender = genderP;
            this.Age = ageP;
            this.FarmerStyle = farmerStyleP;
        }

        public Farmer(int idP)
        {
            this.ID = idP;
        }

        public Farmer()
        {

        }

        public string Age {
            get { return age; }
            set { age = value; }
        }
        public string Gender {
            get { return gender; }
            set { gender = value; }
        }

        public string Name {
            get { return name; }
            set { name = value; }
        }

        public int ID {
            get { return id; }
            set { id = value; }
        }

    }

    public partial class Farmer
    {
        //public override bool Equals(object obj)
        //{
        //    if (obj == null) return false;
        //    Farmer f = obj as Farmer;
        //    if ((Object)f == null) return false;
        //    return ((f.ID == this.ID) && (f.EyeColour == this.EyeColour) && (f.Gender == this.Gender) && (f.HairColour == this.HairColour) && (f.Name == this.Name) && (f.OutfitType == this.OutfitType) && (f.SkinColour == this.SkinColour));
        //}
        //public override int GetHashCode()
        //{
        //    return this.EyeColour.GetHashCode() ^ this.Gender.GetHashCode() ^ this.HairColour.GetHashCode() ^ this.ID.GetHashCode() ^ this.Name.GetHashCode() ^ this.OutfitType.GetHashCode() ^ this.SkinColour.GetHashCode();
        //}
        public override string ToString()
        {
            return this.Name + " " + this.Gender;
        }
    }

    public partial class Farmer
    {
        //Methods
        public Farmer[] FarmerSelection()
        {
            int count = 0;
            Farmer[] ListOfFarmers = new Farmer[5];
            DataHandler dbhandler = new DataHandler();
            DataTable datatable = dbhandler.SelectFarmer();

            foreach (DataRow item in datatable.Rows)
            {
                try
                {
                    if (count > 5)
                    {
                        throw new FarmerOutOfBoundException();
                    }
                    else
                    {
                        ListOfFarmers[count] = new Farmer(int.Parse(item["FarmerId"].ToString()),
                                           item["FarmerName"].ToString(),
                                           item["FarmerGender"].ToString(),
                                           item["FarmerAge"].ToString(),
                                           new Style(int.Parse(item["StyleId"].ToString()),
                                                      item["EyeColour"].ToString(),
                                                       item["HairColour"].ToString(),
                                                        item["OutfitType"].ToString(),
                                                         item["SkinColour"].ToString())
                                           );
                        count++;
                    }
                }
                catch (FarmerOutOfBoundException)
                {
                    //There are more than five farmers

                }


            }

            return ListOfFarmers;

        }

        public int InsertFarmer()
        {
            DataHandler dbhandler = new DataHandler();
            ArrayList FarmerToWrite = new ArrayList()
            {this.FarmerStyle.OutfitType,this.FarmerStyle.SkinColour,this.FarmerStyle.Eyecolour,this.FarmerStyle.HairColour,this.Name,this.Gender,this.Age };

            return dbhandler.InsertFarmer(FarmerToWrite);

        }

        public int numOfAnimals()
        {
            
            ArrayList ParametersToCountAnimals = new ArrayList();
            ParametersToCountAnimals.Add(this.Name);
            ParametersToCountAnimals.Add(this.Gender);

            ParametersToCountAnimals.Add(this.Age);

            DataHandler dbhandler = new DataHandler();
           return dbhandler.CountNumAnimals(ParametersToCountAnimals);
        }

        public int GetFarmSize()
        {
            int farmsize = 0;
            ArrayList ParametersToGetFarmSize = new ArrayList();
            ParametersToGetFarmSize.Add(this.Name);
            ParametersToGetFarmSize.Add(this.Gender);

            ParametersToGetFarmSize.Add(this.Age);

            DataHandler dbhandler = new DataHandler();
           DataTable datatable = dbhandler.GetFarmSize(ParametersToGetFarmSize);

            foreach (DataRow item in datatable.Rows)
            {
                farmsize = int.Parse(item["FarmSize"].ToString());
            }

            return farmsize;
        }

        public Farmer NewestFarmer()
        {
            DataHandler dbhandler = new DataHandler();
            DataTable datatable = dbhandler.SelectNewestFarmer();
            Farmer newestFarmer = new Farmer();
            foreach (DataRow item in datatable.Rows)
            {
                 newestFarmer = new Farmer(int.Parse(item["FarmerId"].ToString()));
            }

            return newestFarmer;
        }
    }
}
