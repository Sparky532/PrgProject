using System.Collections;
using System.Data;

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

        int UpdateFarmer(ArrayList toUpdate);

        int UpdateFarm(ArrayList toUpdate);
        int InsertAnimal(ArrayList toUpdate);
        int DeleteAnimal(int animalID);
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
