using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Collections;
using System.Windows.Forms;


namespace BLL
{
    public struct Species
    {
        private string animalName;
        private string animalType;
        private double speed;
        private double space;

        public double Space
        {
            get { return space; }
            set { space = value; }
        }

        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public string Animaltype
        {
            get { return animalType; }
            set { animalType = value; }
        }

        public string AnimalName
        {
            get { return animalName; }
            set { animalName = value; }
        }
        public override string ToString()
        {
            return this.AnimalName;
        }

        public int writeSpecies()
        {
            DataHandler handler = new DataHandler();
            ArrayList toWrite = new ArrayList() {this.AnimalName,this.Animaltype,this.Speed,this.Space};
            return handler.InsertSpecies(toWrite);
           
        }

        public void NewSpeciesException()
        {
            FileHandler handler = new FileHandler();
            handler.WriteData("No user file exception was caught at: " + DateTime.UtcNow.ToShortDateString() + " " + DateTime.UtcNow.ToShortTimeString());
        }
    }
}
