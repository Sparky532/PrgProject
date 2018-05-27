using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    //Fields, constructor and propeties
    public partial class Animal
    {
        private int id;
        private Species species;
        private string gender;
        private string mateState;
        private double eatingTime;
        private int daysGrowing;


        public Animal(int idP, string genderP, string mateStateP, double eatingTimeP, Species speciesP, int daysGrowingP)
        {
            this.ID = idP;
            this.Gender = genderP;
            this.MateState = mateStateP;
            this.EatingTime = eatingTimeP;
            this.Species = speciesP;
            this.DaysGrowing = daysGrowingP;
        }

        public Animal(string genderP, string mateStateP, double eatingTimeP, Species speciesP, int daysGrowingP)
        {
            this.Gender = genderP;
            this.MateState = mateStateP;
            this.EatingTime = eatingTimeP;
            this.Species = speciesP;
            this.DaysGrowing = daysGrowingP;
        }

        public Animal()
        {

        }

        public Species Species {
            get { return species; }
            set { species = value; }
        }

        public int DaysGrowing {
            get { return daysGrowing; }
            set { daysGrowing = value; }
        }

        public double EatingTime {
            get { return eatingTime; }
            set { eatingTime = value; }
        }

        public string MateState {
            get { return mateState; }
            set { mateState = value; }
        }

        public string Gender {
            get { return gender; }
            set { gender = value; }
        }

        public int ID {
            get { return id; }
            set { id = value; }
        }

    }

    //Overrides
    public partial class Animal
    {
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Animal a = obj as Animal;
            if ((Object)a == null) return false;
            return ((a.DaysGrowing == this.DaysGrowing) && (a.EatingTime == this.EatingTime) && (a.Gender == this.Gender) && (a.ID == this.ID) && (a.MateState == this.MateState) && (a.Species.Equals(this.species)));
        }
        public override int GetHashCode()
        {
            return this.DaysGrowing.GetHashCode() ^ this.EatingTime.GetHashCode() ^ this.Gender.GetHashCode() ^ this.ID.GetHashCode() ^ this.MateState.GetHashCode() ^ this.Species.GetHashCode();
        }
        public override string ToString()
        {
            return this.Species.AnimalName + " " + this.MateState + " " + this.Gender + " " + this.EatingTime;
        }
    }

    //Methods
    public partial class Animal
    {
        public void AddAnimal(List<AnimalsSelected> ListOfAnimals)
        {
            foreach (AnimalsSelected item in ListOfAnimals)
            {
                double animalsDecimal = ((double)item.AnimalAmount) / 10;
                int numCages = (int)Math.Ceiling(animalsDecimal);
                int timesToRun = numCages * 10;
                int toAdd = 0;
                
                for (int i = 0; i < timesToRun; i += 10)
                {
                    //Generate Location
                    Location l = new Location
                    {
                        LocationType = "Cage",
                        Cage = new Cage(),
                        XCoord = 0,
                        YCoord = 0
                    };

                    if ((i + 10) >= timesToRun)
                    {
                        int leftOver = 10 - (timesToRun - item.AnimalAmount);
                        l.Size = item.Animaal.Space * leftOver;
                        toAdd = leftOver;
                    }
                    else
                    {
                        l.Size = item.Animaal.Space * 10;
                        toAdd = 10;
                    }
                    l.XLength = l.YLength = Math.Sqrt(l.Size);
                    l.GateXCoord = 0;
                    l.GateYCoord = 0;
                    
                    l.InsertLocation();
                    for (int j = i; j < i + toAdd; j++)
                    {
                        ArrayList AnimalToAdd = new ArrayList();
                        AnimalToAdd.Add(item.Animaal.AnimalName);
                        
                        //Generate Gender
                        int genderChance = DetermineGender();
                        string gender = "";
                        if (genderChance <= 3)
                        {
                            gender = "Female";
                            AnimalToAdd.Add(gender);
                        }
                        else
                        {
                            gender = "Male";
                            AnimalToAdd.Add(gender);
                        }

                        int age = DetermineAnimalAge();

                        //Determine MateState
                        AnimalToAdd.Add(determineAnimalMateState(age, gender));

                        //Generate Age
                        AnimalToAdd.Add(age);

                        //Determine EatingTime
                        AnimalToAdd.Add(determineEatingTime(item.eatingTime(), age));

                        //Give Arraylist to DAL
                        DataHandler handler = new DataHandler();
                        int result = handler.InsertAnimals(AnimalToAdd);                       
                    }
                }
            }
        }

       public List<Animal> selectAnimals(int id)
        {
            List<Animal> animals = new List<Animal>();
            DataHandler handler = new DataHandler();
            DataTable rawData = handler.SelectFarmOrLocationOrAnimal(id, "SelectAnimals");
            foreach (DataRow item in rawData.Rows)
            {
                Species s = new Species();
                s.AnimalName = item["AnimalName"].ToString();
                s.Animaltype = item["AnimalType"].ToString();
                s.Space = double.Parse(item["AnimalSpaceTaken"].ToString());
                s.Speed = double.Parse(item["AnimalBaseSpeed"].ToString());
                animals.Add(new Animal(int.Parse(item["AnimalId"].ToString()), item["AnimalGender"].ToString(), item["AnimalMateStae"].ToString(), double.Parse(item["EatingTime"].ToString()),s,int.Parse(item["AnimalAge"].ToString())));
            }
            return animals;
        }
    }

    //Delegates
    public partial class Animal
    {
        //Creating a random age
        AnimalRandom DetermineAnimalAge = () =>
        {
            Random rnd = new Random();
            return rnd.Next(0, 2556);
        };
        
        //Creating a random gender
        AnimalRandom DetermineGender = () =>
        {
            Random rnd = new Random();
            return rnd.Next(0, 7);
        };

        //Creating a random mate state using age and gender
        DetermineMateState determineAnimalMateState = (animalAge, AnimalGender) =>
        {
            if ((AnimalGender.Equals("Male") || AnimalGender.Equals("Female")) && animalAge > 474)
            {
                return "Ready";
            }
            else
            {
                return "Not Ready";
            }

        };

        //Creating a different eating time depending on the age
        DetermineEatingTime determineEatingTime = (baseEatingTime, age) =>
        {
            if (age < 365 || age > 2920)
            {
                baseEatingTime += 1.5;
            }
            return baseEatingTime;
        };
    }
}
