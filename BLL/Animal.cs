﻿using System;
using System.Collections;
using System.Collections.Generic;
using DAL;
using System.Data;

namespace BLL
{
    //Fields, constructor and propeties
    [Serializable]
    public partial class Animal
    {
        private int id;
        private Species species;
        private string gender;
        private string mateState;
        private double eatingTime;
        private int daysGrowing;
        private int locationID;

        public Animal(int idP, string genderP, string mateStateP, double eatingTimeP, Species speciesP, int daysGrowingP)
        {
            this.ID = idP;
            this.Gender = genderP;
            this.MateState = mateStateP;
            this.EatingTime = eatingTimeP;
            this.Species = speciesP;
            this.DaysGrowing = daysGrowingP;
        }
        public Animal(int idP, string genderP, string mateStateP, double eatingTimeP, Species speciesP, int daysGrowingP, int locationIDP)
        {
            this.ID = idP;
            this.Gender = genderP;
            this.MateState = mateStateP;
            this.EatingTime = eatingTimeP;
            this.Species = speciesP;
            this.DaysGrowing = daysGrowingP;
            this.LocationID = locationIDP;
        }
        public Animal(string genderP, string mateStateP, double eatingTimeP, Species speciesP, int daysGrowingP, int locationIDP)
        {
            this.Gender = genderP;
            this.MateState = mateStateP;
            this.EatingTime = eatingTimeP;
            this.Species = speciesP;
            this.DaysGrowing = daysGrowingP;
            this.LocationID = locationIDP;
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
        public int LocationID
        {
            get { return locationID; }
            set { locationID = value; }
        }

        public Species Species
        {
            get { return species; }
            set { species = value; }
        }

        public int DaysGrowing
        {
            get { return daysGrowing; }
            set { daysGrowing = value; }
        }

        public double EatingTime
        {
            get { return eatingTime; }
            set { eatingTime = value; }
        }

        public string MateState
        {
            get { return mateState; }
            set { mateState = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int ID
        {
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
            return Spaces(this.Species.AnimalName, 6) + "" + Spaces(this.MateState, 10) + "" + Spaces(this.Gender, 7) + "" + Spaces(this.EatingTime + "", 3);
        }

        private string Spaces(string word, int totalLength)
        {
            string toReturn = word;
            for (int i = word.Length; i < totalLength; i++)
            {
                toReturn = toReturn + " ";
            }
            return toReturn;
        }
    }

    //Methods
    public partial class Animal
    {


        public void AddAnimal(List<AnimalsSelected> ListOfAnimals, int farmerId)
        {
            int farmSize = 0;
            #region Dictionaries
            Dictionary<int, bool> LargeFarm = new Dictionary<int, bool>();
            Dictionary<int, bool> MediumFarm = new Dictionary<int, bool>();
            Dictionary<int, bool> SmallFarm = new Dictionary<int, bool>();
            #region LargeDictionary
            LargeFarm.Add(1, false);
            LargeFarm.Add(2, false);
            LargeFarm.Add(3, false);
            LargeFarm.Add(4, false);
            LargeFarm.Add(5, false);
            LargeFarm.Add(6, false);
            LargeFarm.Add(7, false);
            LargeFarm.Add(8, false);
            LargeFarm.Add(9, false);
            LargeFarm.Add(10, false);
            LargeFarm.Add(11, false);
            LargeFarm.Add(12, false);
            LargeFarm.Add(13, false);
            LargeFarm.Add(14, false);
            LargeFarm.Add(15, false);
            LargeFarm.Add(16, false);
            #endregion
            #region MediumDictionary
            MediumFarm.Add(1, false);
            MediumFarm.Add(2, false);
            MediumFarm.Add(3, false);
            MediumFarm.Add(4, false);
            MediumFarm.Add(5, false);
            MediumFarm.Add(6, false);
            MediumFarm.Add(7, false);
            MediumFarm.Add(8, false);
            MediumFarm.Add(9, false);
            #endregion
            #region SmallDictionary
            SmallFarm.Add(1, false);
            SmallFarm.Add(2, false);
            SmallFarm.Add(3, false);
            SmallFarm.Add(4, false);

            #endregion
            #endregion
            Farm farm = new Farm();
            List<Farm> farms = farm.selectFarm(farmerId);
            foreach (Farm item in farms)
            {
                farmSize = (int)item.Size;
            }
            foreach (AnimalsSelected item in ListOfAnimals)
            {
                double animalsDecimal = ((double)item.AnimalAmount) / 10;
                int numCages = (int)Math.Ceiling(animalsDecimal);
                int timesToRun = numCages * 10;
                int toAdd = 0;
                Random rnd = new Random(DateTime.UtcNow.Millisecond);
                int predatorRandom;
                int LionCurrentCage = 0;

                for (int i = 0; i < timesToRun; i += 10)
                {
                    //Generate Location
                    Location l = new Location
                    {
                        LocationType = "Cage",
                        Cage = new Cage(),
                        YCoord = 0
                    };
                    l.XCoord = 0;

                    #region PlacingCages
                    switch (farmSize)
                    {
                        case 400:
                            int[] lionCagesSmall = { 1, 3 };
                            predatorRandom = rnd.Next(-1, 2);
                            if (item.Animaal.AnimalName == "Lion" && i == 0)
                            {
                                while (predatorRandom == -1 || predatorRandom == 2)
                                {
                                    predatorRandom = rnd.Next(-1, 2);
                                }
                                l.XCoord = lionCagesSmall[predatorRandom];
                                if (SmallFarm[lionCagesSmall[predatorRandom]] == false)
                                {
                                    SmallFarm[lionCagesSmall[predatorRandom]] = true;
                                }
                                else
                                {
                                    int tempKey = 0;
                                    bool flag = false;
                                    foreach (KeyValuePair<int, bool> SmallFarmTester in SmallFarm)
                                    {
                                        if (SmallFarmTester.Value == false && flag == false)
                                        {
                                            tempKey = SmallFarmTester.Key;
                                            l.XCoord = SmallFarmTester.Key;
                                            flag = true;
                                        }
                                    }
                                    SmallFarm[tempKey] = true;
                                }
                                Location feeding = new Location("Feeding", 0, l.XCoord + 1, 100, 10, 10, 0, 0);
                                SmallFarm[l.XCoord + 1] = true;
                                feeding.InsertLocation();
                                LionCurrentCage = l.XCoord;
                            }
                            else if (item.Animaal.AnimalName == "Lion")
                            {
                                LionCurrentCage += 1;
                                if (SmallFarm[LionCurrentCage] == true)
                                {
                                    LionCurrentCage += 1;
                                    l.XCoord = LionCurrentCage;
                                    SmallFarm[LionCurrentCage] = true;
                                }
                                else
                                {
                                    l.XCoord = LionCurrentCage;
                                    SmallFarm[LionCurrentCage] = true;
                                }
                            }

                            if (item.Animaal.AnimalName != "Lion")
                            {
                                int tempKey = 0;
                                bool flag = false;
                                foreach (KeyValuePair<int, bool> SmallFarmTester in SmallFarm)
                                {
                                    if (SmallFarmTester.Value == false && flag == false)
                                    {
                                        tempKey = SmallFarmTester.Key;
                                        l.XCoord = SmallFarmTester.Key;
                                        flag = true;
                                    }
                                }
                                SmallFarm[tempKey] = true;
                            }
                            break;
                        case 900:

                            int[] lionCagesMedium = { 1, 3, 7 };
                            predatorRandom = rnd.Next(-1, 3);
                            if (item.Animaal.AnimalName == "Lion" && i == 0)
                            {
                                while (predatorRandom == -1)
                                {
                                    predatorRandom = rnd.Next(-1, 3);
                                }
                                Location feedingmedium = new Location();

                                if (MediumFarm[lionCagesMedium[predatorRandom]] == true)
                                {
                                    int lionCage = lionCagesMedium[predatorRandom];
                                    while (MediumFarm[lionCage] == true)
                                    {
                                        lionCage++;
                                    }
                                    l.XCoord = lionCagesMedium[predatorRandom];
                                    MediumFarm[lionCagesMedium[predatorRandom]] = true;
                                    if ( predatorRandom == 1)
                                    {
                                        feedingmedium = new Location("Feeding", 0, l.XCoord - 1, 100, 10, 10, 0, 0);
                                        MediumFarm[l.XCoord - 1] = true;

                                    }
                                    else
                                    {
                                        feedingmedium = new Location("Feeding", 0, l.XCoord + 1, 100, 10, 10, 0, 0);

                                        MediumFarm[l.XCoord + 1] = true;
                                    }
                                }
                                l.XCoord = lionCagesMedium[predatorRandom];
                                MediumFarm[lionCagesMedium[predatorRandom]] = true;
                                if (predatorRandom == 1)
                                {
                                    feedingmedium = new Location("Feeding", 0, l.XCoord - 1, 100, 10, 10, 0, 0);
                                    MediumFarm[l.XCoord - 1] = true;

                                }
                                else
                                {
                                    feedingmedium = new Location("Feeding", 0, l.XCoord + 1, 100, 10, 10, 0, 0);

                                    MediumFarm[l.XCoord + 1] = true;
                                }

                                feedingmedium.InsertLocation();
                                LionCurrentCage = l.XCoord;
                            }
                            else if (item.Animaal.AnimalName == "Lion")
                            {
                                LionCurrentCage += 1;
                                if (MediumFarm[LionCurrentCage] == true)
                                {
                                    LionCurrentCage += 1;
                                    l.XCoord = LionCurrentCage;
                                    MediumFarm[LionCurrentCage] = true;
                                }
                                else
                                {
                                    l.XCoord = LionCurrentCage;
                                    MediumFarm[LionCurrentCage] = true;
                                }
                            }
                           

                            if (item.Animaal.AnimalName != "Lion")
                            {
                                int tempKey = 0;
                                bool flag = false;
                                foreach (KeyValuePair<int, bool> mediumFarmTester in MediumFarm)
                                {
                                    if (mediumFarmTester.Value == false && flag == false)
                                    {
                                        tempKey = mediumFarmTester.Key;
                                        l.XCoord = mediumFarmTester.Key;
                                        flag = true;
                                    }
                                }
                                MediumFarm[tempKey] = true;
                            }
                            break;
                        case 1600:

                            predatorRandom = rnd.Next(-1, 4);
                            int[] lionCagesLarge = { 5, 4, 13, 16 };
                            if (item.Animaal.AnimalName == "Lion" && i == 0)
                            {
                                while (predatorRandom == -1)
                                {
                                    predatorRandom = rnd.Next(-1, 4);
                                }
                                Location feeding = new Location();

                                if (LargeFarm[lionCagesLarge[predatorRandom]] == true)
                                {
                                    int lionCage = lionCagesLarge[predatorRandom];
                                    while (LargeFarm[lionCage] == true)
                                    {
                                        lionCage++;
                                    }
                                    l.XCoord = lionCagesLarge[predatorRandom];
                                    LargeFarm[lionCagesLarge[predatorRandom]] = true;
                                    if (predatorRandom == 3 || predatorRandom == 1)
                                    {
                                        feeding = new Location("Feeding", 0, l.XCoord - 1, 100, 10, 10, 0, 0);
                                        LargeFarm[l.XCoord - 1] = true;

                                    }
                                    else
                                    {
                                        feeding = new Location("Feeding", 0, l.XCoord + 1, 100, 10, 10, 0, 0);

                                        LargeFarm[l.XCoord + 1] = true;
                                    }
                                }
                                l.XCoord = lionCagesLarge[predatorRandom];
                                LargeFarm[lionCagesLarge[predatorRandom]] = true;
                                if (predatorRandom == 3 || predatorRandom == 1)
                                {
                                    feeding = new Location("Feeding", 0, l.XCoord - 1, 100, 10, 10, 0, 0);
                                    LargeFarm[l.XCoord - 1] = true;

                                }
                                else
                                {
                                    feeding = new Location("Feeding", 0, l.XCoord + 1, 100, 10, 10, 0, 0);

                                    LargeFarm[l.XCoord + 1] = true;
                                }
                              
                                feeding.InsertLocation();
                                LionCurrentCage = l.XCoord;
                            }
                            else if (item.Animaal.AnimalName == "Lion")
                            {
                                LionCurrentCage += 1;
                                if (LargeFarm[LionCurrentCage] == true)
                                {
                                    LionCurrentCage += 1;
                                    l.XCoord = LionCurrentCage;
                                    LargeFarm[LionCurrentCage] = true;
                                }
                                else
                                {
                                    l.XCoord = LionCurrentCage;
                                    LargeFarm[LionCurrentCage] = true;
                                }
                            }

                            if (item.Animaal.AnimalName != "Lion")
                            {
                                int tempKey = 0;
                                bool flag = false;
                                foreach (KeyValuePair<int, bool> largeFarmTester in LargeFarm)
                                {
                                    if (largeFarmTester.Value == false && flag == false)
                                    {
                                        tempKey = largeFarmTester.Key;
                                        l.XCoord = largeFarmTester.Key;
                                        flag = true;
                                    }
                                }
                                LargeFarm[tempKey] = true;
                            }
                            break;
                        default:
                            break;
                    }
                    #endregion

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
                animals.Add(new Animal(int.Parse(item["AnimalId"].ToString()), item["AnimalGender"].ToString(), item["AnimalMateStae"].ToString(), double.Parse(item["EatingTime"].ToString()), s, int.Parse(item["AnimalAge"].ToString()), int.Parse(item["LocationId"].ToString())));
            }
            return animals;
        }

        public int InsertAnimal()
        {

            DataHandler handler = new DataHandler();
            ArrayList AnimalToAdd = new ArrayList();
            AnimalToAdd.Add(this.Species.AnimalName);
            AnimalToAdd.Add(this.Gender);
            AnimalToAdd.Add(this.MateState);
            AnimalToAdd.Add(this.DaysGrowing);
            AnimalToAdd.Add(this.EatingTime);
            AnimalToAdd.Add(this.LocationID);
            int result = handler.InsertAnimal(AnimalToAdd);
            return result;
        }
        public int DeleteAnimal()
        {
            DataHandler handler = new DataHandler();
            int result = handler.DeleteAnimal(this.ID);
            return result;
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
