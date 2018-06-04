using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    [Serializable]
    public struct AnimalsSelected
    {
        private int animalAmount;
        private Species animaal;
        

        public Species Animaal
        {
            get { return animaal; }
            set { animaal = value; }
        }
        public int AnimalAmount
        {
            get { return animalAmount; }
            set { animalAmount = value; }
        }
        public override string ToString()
        {
            return this.Animaal.AnimalName + " " + this.AnimalAmount;
        }
        public List<Species> getAnimalName()
        {
            List<Species> animalSpecies = new List<Species>();
            DataHandler handler = new DataHandler();
            DataTable rawData = handler.SelectSpecies();
            foreach (DataRow item in rawData.Rows)
            {
                Species spec = new Species();
                spec.AnimalName = item["AnimalName"].ToString();
                spec.Animaltype = item["AnimalType"].ToString();
                spec.Space = double.Parse(item["AnimalSpaceTaken"].ToString());
                spec.Speed = double.Parse(item["AnimalBaseSpeed"].ToString());
                animalSpecies.Add(spec);
            }
            return animalSpecies;
        }

        public double eatingTime()
        {
            //Determine the eating time based on the type of animal
            Random rnd = new Random();
            double eatTIME = animaal.AnimalName == "Lion" ? 4 : animaal.AnimalName == "Cow" ? 2 : animaal.AnimalName == "Sheep" ? 2:animaal.AnimalName == "Horse" ? 1:animaal.AnimalName == "Tiger" ? 3 : rnd.Next(1,6);
            return eatTIME;
        }
        public void NullReferenceExpetion(string toWrite)
        {
            FileHandler handler = new FileHandler();
            handler.WriteData("No user file exception was caught at: " + DateTime.UtcNow.ToShortDateString() + " " + DateTime.UtcNow.ToShortTimeString());
        }
    }
}
