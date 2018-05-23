using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IDataHandler
    {
        DataTable SelectSpecies();

        DataTable SelectFarmer();

        int InsertFarmer(ArrayList FarmerToInsert);

        int InsertSpecies(ArrayList toWrite);

        int InsertFarm(ArrayList toWrite);

        int InsertLocation(ArrayList toWrite);

        int InsertAnimals(ArrayList animalToWrite);

        int CountNumAnimals(ArrayList FarmerDetails);

        DataTable GetFarmSize(ArrayList FarmerDetails);
    }
}
