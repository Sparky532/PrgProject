using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    partial interface IDataHandler
    {
        int InsertLocation(ArrayList toWrite);

        int InsertAnimals(ArrayList animalToWrite);

        int CountNumAnimals(ArrayList FarmerDetails);

        int InsertFarmer(ArrayList FarmerToInsert);

        int InsertSpecies(ArrayList toWrite);

        int InsertFarm(ArrayList toWrite);

        int DeleteFarmer(int FarmerID, int StyleId);
    }

    partial interface IDataHandler
    {       
        DataTable SelectSpecies();

        DataTable SelectFarmer();

        DataTable GetFarmSize(ArrayList FarmerDetails);

        DataTable SelectFarmOrLocationOrAnimal(int id, string storedProcedureName);

        DataTable SelectNewestFarmer();       
    }
}
