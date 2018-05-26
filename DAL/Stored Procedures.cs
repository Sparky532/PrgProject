using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Stored_Procedures
    {
        /*CREATE PROCEDURE selectSpecies
        AS
        BEGIN
        SELECT * FROM AnimalSpecies
        END*/


        /*CREATE PROCEDURE [dbo].[insertSpecies]
            @name varchar(50),
            @type varchar(50),
            @speed int,
            @space int
        AS
            INSERT INTO AnimalSpecies (AnimalName,AnimalType,AnimalBaseSpeed,AnimalSpaceTaken) VALUES (@name,@type,@speed,@space)
        */

        /*
         CREATE PROCEDURE InsertFarmer
        @outfitType varchar(8),
        @skinColour varchar(5),
        @eyeColour varchar(5),
        @hairColour varchar(5),
        @farmerName varchar(20),
        @farmerGender varchar(6),
        @farmerAge int
        AS
        BEGIN
        INSERT INTO Style
        (OutfitType,SkinColour,EyeColour,HairColour)
        VALUES
        (@outfitType,@skinColour,@eyeColour,@hairColour)


        INSERT INTO Farmer
        (FarmerName,FarmerGender,FarmerAge,StyleId)
        VALUES
        (@farmerName,@farmerGender,@farmerAge,(SELECT Top 1 StyleId from Style
                                       ORDER BY StyleId DESC))
        END
         */

        /*
         CREATE PROCEDURE SelectFarmer
        AS
        BEGIN
        SELECT Farmer.FarmerId, Farmer.FarmerName,Farmer.FarmerGender,Farmer.FarmerAge,Farmer.StyleId,Style.EyeColour,Style.HairColour,Style.OutfitType,Style.SkinColour
        FROM Farmer
        INNER JOIN Style ON Farmer.StyleId = Style.StyleId
        END 
         */


        /*
         CREATE PROCEDURE [dbo].[InsertFarm]
        @name varchar(50),
        @size decimal(18,2)
        AS
        INSERT INTO Farm
        (FarmerId,FarmName,FarmSize)
        VALUES
        ((SELECT TOP 1 FarmerId FROM Farmer ORDER BY FarmerId DESC),@name,@size)

         */




        /*
         CREATE PROCEDURE [dbo].[InsertLocation]
        @type varchar(50),
        @xCoord int,
        @yCoord int,
        @size int,
        @length int,
        @width int,
        @gateXCoord int,
        @gateYCoord int
        AS
        INSERT INTO Location
        (FarmId,LocationType,[X-Coordinates],[Y-Coordinates],size,LocationLength,LocationWidth,[LocationGate_X-Coordinate],[LocationGate_Y-Coordinate])
        VALUES
        ((SELECT TOP 1 FarmId FROM Farm ORDER BY FarmId DESC),@type,@xCoord,@yCoord,@size,@length,@width,@gateXCoord,@gateYCoord)

         */

        /* CREATE PROCEDURE[dbo].[InsertAnimals]
         @animalName varchar(15),
        @animalGender varchar(6),
        @animalMateState varchar(10),
        @animalAge int,
        @eatingTime decimal (18,2)
        AS
        BEGIN

        INSERT INTO Animal
        (AnimalName, AnimalGender, AnimalMateStae, AnimalAge, EatingTime, LocationId)

        VALUES(@animalName, @animalGender, @animalMateState, @animalAge, @eatingTime, (SELECT TOP 1 LocationId
                                                                               FROM Location
                                                                               ORDER BY LocationId DESC))
        END

        */

        /*
         CREATE PROCEDURE GetFarmSizeForFarmer
        @farmerName varchar(20),
        @farmerGender varchar(6),
        @farmerAge int
        AS
        BEGIN
        SELECT FarmSize FROM Farm
        WHERE FarmerId = (SELECT FarmerId FROM Farmer
                      WHERE FarmerName = @farmerName AND FarmerGender = @farmerGender AND FarmerAge = @farmerAge)
        END*/

        /*
         CREATE PROCEDURE SelectNoAnimals
	@farmerName varchar(20),
	@farmerGender varchar(6),
	@farmerAge int
AS
BEGIN
	SELECT COUNT(*) from Animal
	WHERE LocationId in (SELECT LocationId FROM Location
						WHERE FarmId = (Select FarmId FROM Farm
										WHERE FarmerId = (SELECT FarmerId FROM Farmer
														  WHERE FarmerName = @farmerName AND FarmerGender = @farmerGender AND FarmerAge = @farmerAge)))
END 
         */




        /* NEW PROCEDURES TO PULL OUT ANIMALS, LOCATIONS AND FARM
         * 
         * 
         * 
         CREATE PROCEDURE SelectAnimals
@farmerID int
AS
BEGIN
SELECT * from Animal INNER JOIN AnimalSpecies ON Animal.AnimalName = AnimalSpecies.AnimalName
WHERE LocationId in (SELECT LocationId FROM Location
WHERE FarmId = (Select FarmId FROM Farm
WHERE FarmerId = @farmerID))
END


CREATE PROCEDURE SelectLocations
@farmerID int
AS
BEGIN
SELECT * from Location
WHERE FarmId = (Select FarmId FROM Farm
WHERE FarmerId = @farmerID)
END


CREATE PROCEDURE SelectFarm
@farmerID int
AS
BEGIN
SELECT * from Farm
WHERE FarmId = @farmerID
END
         * 
         * 
         * 
         * 
         */

        /*
         CREATE PROCEDURE [dbo].[SelectNewestFarmer]
AS
BEGIN
SELECT top 1 FarmerId from Farmer
ORDER BY FarmerId DESC
END
         */

        /*
         CREATE PROCEDURE DeleteFarmer
	@FarmerId int
AS
BEGIN
	DELETE FROM Animal
	WHERE LocationId in (SELECT LocationId from Location
						WHERE FarmId = (SELECT FarmId FROM Farm
										WHERE FarmerId = @FarmerId))

    DELETE FROM Location 
	WHERE FarmId = (SELECT FarmId FROM Farm
										WHERE FarmerId = @FarmerId)

    DELETE FROM Farm
    WHERE FarmerId = @FarmerId

	DELETE FROM Style
	WHERE StyleId = (SELECT StyleId FROM Farmer
					 WHERE FarmerId = @FarmerId)

    DELETE FROM Farmer
	WHERE FarmerId = @FarmerId
END
         */






    }
}
