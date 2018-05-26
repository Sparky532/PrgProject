using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections;

namespace DAL
{
    public class DataHandler : IDataHandler
    {
        private String Connectionstring;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataTable datatable;
        private DataSet dataSet;

        public DataHandler(string connnectionstringParam = "default")
        {
            this.Connectionstring = ConfigurationManager.ConnectionStrings[connnectionstringParam].ConnectionString;
            connection = new SqlConnection(Connectionstring);
        }

        public DataTable SelectSpecies()
        {
            string storedProcedureName = "selectSpecies";
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(storedProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;

                adapter = new SqlDataAdapter(command);
                datatable = new DataTable();
                adapter.Fill(datatable);
            }
            catch (SqlException)
            {
                //If its network related, change the connectionString to that of your computer
                throw;
            }
            catch (Exception)
            {
                //If its network related, change the connectionString to that of your computer
                throw;
            }
            finally
            {
                connection.Close();
            }

            return datatable;
        }

        public DataTable SelectFarmer()
        {
            string storedProcedureName = "SelectFarmer";
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(storedProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;

                adapter = new SqlDataAdapter(command);
                datatable = new DataTable();
                adapter.Fill(datatable);
            }
            catch (SqlException)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }

            return datatable;
        }

        public int InsertSpecies(ArrayList toWrite)
        {
            int success = 0;
            string storedProcedureName = "insertSpecies";
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(storedProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@name", toWrite[0]));
                command.Parameters.Add(new SqlParameter("@type", toWrite[1]));
                command.Parameters.Add(new SqlParameter("@speed", toWrite[2]));
                command.Parameters.Add(new SqlParameter("@space", toWrite[3]));

                success = command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                //If its network related, change the connectionString to that of your computer
                throw;
            }
            finally
            {
                connection.Close();
            }
            return success;
        }

        public int InsertFarmer(ArrayList FarmerToInsert)
        {
            int Success = 0;
            string storedProcedureName = "InsertFarmer";
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(storedProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@outfitType", FarmerToInsert[0]));
                command.Parameters.Add(new SqlParameter("@skinColour", FarmerToInsert[1]));
                command.Parameters.Add(new SqlParameter("@eyeColour", FarmerToInsert[2]));
                command.Parameters.Add(new SqlParameter("@hairColour", FarmerToInsert[3]));
                command.Parameters.Add(new SqlParameter("@farmerName", FarmerToInsert[4]));
                command.Parameters.Add(new SqlParameter("@farmerGender", FarmerToInsert[5]));
                command.Parameters.Add(new SqlParameter("@farmerAge", FarmerToInsert[6]));

                Success = command.ExecuteNonQuery();

            }
            catch (SqlException)
            {
                //If its network related, change the connectionString to that of your computer.
                throw;
            }
            finally
            {
                connection.Close();
            }

            return Success;

        }

        public int InsertFarm(ArrayList toWrite)
        {
            int result = 0;
            try
            {
                string storedProcedureName = "InsertFarm";
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(storedProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@name", toWrite[0]));
                command.Parameters.Add(new SqlParameter("@size", toWrite[1]));
                result = command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                //If its network related, change the connectionString to that of your computer.
                throw;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public int InsertLocation(ArrayList toWrite)
        {
            int result = 0;
            try
            {
                string storedProcedureName = "InsertLocation";
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(storedProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@type", toWrite[0]));
                command.Parameters.Add(new SqlParameter("@xCoord", toWrite[1]));
                command.Parameters.Add(new SqlParameter("@yCoord", toWrite[2]));
                command.Parameters.Add(new SqlParameter("@size", toWrite[3]));
                command.Parameters.Add(new SqlParameter("@length", toWrite[4]));
                command.Parameters.Add(new SqlParameter("@width", toWrite[5]));
                command.Parameters.Add(new SqlParameter("@gateXCoord", toWrite[6]));
                command.Parameters.Add(new SqlParameter("@gateYCoord", toWrite[7]));
                result = command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                //If its network related, change the connectionString to that of your computer
                throw;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }

        public int InsertAnimals(ArrayList animalToWrite)
        {
            int success = 0;
            string storedProcedureName = "InsertAnimals";

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(storedProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@animalName",animalToWrite[0]));
                command.Parameters.Add(new SqlParameter("@animalGender", animalToWrite[1]));
                command.Parameters.Add(new SqlParameter("@animalMateState", animalToWrite[2]));
                command.Parameters.Add(new SqlParameter("@animalAge", animalToWrite[3]));
                command.Parameters.Add(new SqlParameter("@eatingTime", animalToWrite[4]));

                success = command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return success;
        }

        public int CountNumAnimals(ArrayList FarmerDetails)
        {
            Int32 numAnimals;
            string storedProcedureName = "SelectNoAnimals";

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(storedProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@farmerName", FarmerDetails[0]));
                command.Parameters.Add(new SqlParameter("@farmerGender", FarmerDetails[1]));
                command.Parameters.Add(new SqlParameter("@farmerAge", FarmerDetails[2]));

                numAnimals = (Int32)command.ExecuteScalar();
                //adapter = new SqlDataAdapter(command);
                //datatable = new DataTable();
                //adapter.Fill(datatable);
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return numAnimals;
        }

        public DataTable GetFarmSize(ArrayList FarmerDetails)
        {
            string storedProcedureName = "GetFarmSizeForFarmer";
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(storedProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@farmerName", FarmerDetails[0]));
                command.Parameters.Add(new SqlParameter("@farmerGender", FarmerDetails[1]));
                command.Parameters.Add(new SqlParameter("@farmerAge", FarmerDetails[2]));

                adapter = new SqlDataAdapter(command);
                datatable = new DataTable();
                adapter.Fill(datatable);
            }
            catch (SqlException)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }

            return datatable;
        }


        public DataTable SelectFarmOrLocationOrAnimal(int id,string storedProcedureName)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand(storedProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@farmerID",id));

                adapter = new SqlDataAdapter(command);
                datatable = new DataTable();
                adapter.Fill(datatable);
            }
            catch (SqlException)
            {
                //If its network related, change the connectionString to that of your computer
                throw;
            }
            finally
            {
                connection.Close();
            }

            return datatable;
        }

        public DataTable SelectNewestFarmer()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                command = new SqlCommand("SelectNewestFarmer", connection);
                command.CommandType = CommandType.StoredProcedure;
                

                adapter = new SqlDataAdapter(command);
                datatable = new DataTable();
                adapter.Fill(datatable);
            }
            catch (SqlException)
            {
                //If its network related, change the connectionString to that of your computer
                throw;
            }
            finally
            {
                connection.Close();
            }

            return datatable;
        }

        public int DeleteFarmer(int FarmerID,int StyleId)
        {
            int success;
            string storedProcedureName = "DeleteFarmer";

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command = new SqlCommand(storedProcedureName, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@FarmerId", FarmerID));
                command.Parameters.Add(new SqlParameter("@StyleID", StyleId));


                success = command.ExecuteNonQuery();
               
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return success;
        }
    }
}
