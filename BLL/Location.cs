using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Collections;
using System.Data;

namespace BLL
{
    [Serializable]
    public partial class Location
    {
        private int id;
        private string locationType;
        private int yCoord;
        private int xCoord;
        private double size;
        private double xLength;
        private double yLength;
        private int gateXCoord;
        private int gateYCoord;
        private Cage cage;
        private Path path;
        private FeedingArea feedArea;


        public Location(int idP, string locationTypeP, int yCoordP, int xCoordP, double sizeP, double xLengthP, double yLengthP, int gateXCoordP, int gateYCoordP)
        {
            this.GateXCoord = gateXCoordP;
            this.GateYCoord = gateYCoordP;
            this.ID = idP;
            this.LocationType = locationTypeP;
            this.Size = sizeP;
            this.XCoord = xCoordP;
            this.XLength = xLengthP;
            this.YCoord = yCoordP;
            this.YLength = yLengthP;
            if (locationTypeP.Equals("Cage"))
            {
                this.Cage = new Cage();
            }
            else if (locationTypeP.Equals("Path"))
            {
                this.Path = new Path();
            }
            else if (locationTypeP.Equals("Feeding Area"))
            {
                this.FeedArea = new FeedingArea();
            }
        }
        public Location(string locationTypeP, int yCoordP, int xCoordP, double sizeP, double xLengthP, double yLengthP, int gateXCoordP, int gateYCoordP, Cage cageP, Path pathP, FeedingArea feedAreaP)
        {
            this.GateXCoord = gateXCoordP;
            this.GateYCoord = gateYCoordP;
            this.LocationType = locationTypeP;
            this.Size = sizeP;
            this.XCoord = xCoordP;
            this.XLength = xLengthP;
            this.YCoord = yCoordP;
            this.YLength = yLengthP;
            this.FeedArea = feedAreaP;
            this.Cage = cageP;
            this.Path = pathP;
        }
        public Location(string locationTypeP, int yCoordP, int xCoordP, double sizeP, double xLengthP, double yLengthP, int gateXCoordP, int gateYCoordP)
        {
            this.GateXCoord = gateXCoordP;
            this.GateYCoord = gateYCoordP;
            this.LocationType = locationTypeP;
            this.Size = sizeP;
            this.XCoord = xCoordP;
            this.XLength = xLengthP;
            this.YCoord = yCoordP;
            this.YLength = yLengthP;
        }

        public Location()
        {

        }

        public FeedingArea FeedArea
        {
            get { return feedArea; }
            set { feedArea = value; }
        }


        public Path Path
        {
            get { return path; }
            set { path = value; }
        }


        public Cage Cage
        {
            get { return cage; }
            set { cage = value; }
        }

        public int GateYCoord
        {
            get { return gateYCoord; }
            set { gateYCoord = value; }
        }


        public int GateXCoord
        {
            get { return gateXCoord; }
            set { gateXCoord = value; }
        }

        public double YLength
        {
            get { return yLength; }
            set { yLength = value; }
        }

        public double XLength
        {
            get { return xLength; }
            set { xLength = value; }
        }

        public double Size
        {
            get { return size; }
            set { size = value; }
        }

        public int XCoord
        {
            get { return xCoord; }
            set { xCoord = value; }
        }

        public int YCoord
        {
            get { return yCoord; }
            set { yCoord = value; }
        }

        public string LocationType
        {
            get { return locationType; }
            set { locationType = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

    }
    public partial class Location
    {
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Location l = obj as Location;
            if ((Object)l == null) return false;
            return ((l.Cage.Equals(this.Cage)) && (l.FeedArea.Equals(this.FeedArea)) && (l.GateXCoord == this.GateXCoord) && (l.GateYCoord == this.GateYCoord) && (l.ID == this.ID) && (l.LocationType == this.LocationType) && (l.Path.Equals(this.Path)) && (l.Size == this.Size) && (l.XCoord == this.XCoord) && (l.XLength == this.XLength) && (l.YCoord == this.YCoord) && (l.YLength == this.YLength));
        }
        public override int GetHashCode()
        {
            return this.Cage.GetHashCode() ^ this.FeedArea.GetHashCode() ^ this.GateXCoord.GetHashCode() ^ this.GateYCoord.GetHashCode() ^ this.ID.GetHashCode() ^ this.LocationType.GetHashCode() ^ this.Path.GetHashCode() ^ this.Size.GetHashCode() ^ this.XCoord.GetHashCode() ^ this.XLength.GetHashCode() ^ this.YCoord.GetHashCode() ^ this.YLength.GetHashCode();
        }
        public override string ToString()
        {
            return this.LocationType + " " + this.Size;
        }
    }

    public partial class Location
    {
        public string InsertLocation()
        {
            DataHandler handler = new DataHandler();
            ArrayList toWrite = new ArrayList() { this.LocationType, this.XCoord, this.YCoord, this.Size, this.XLength, this.YLength, this.GateXCoord, this.GateYCoord };
            int res = handler.InsertLocation(toWrite);
            string result = "Failed to insert";
            if (res >= 1)
            {
                result = "Sucessfully Added";
            }
            return result;
        }
        public List<Location> selectLocation(int id)
        {
            DataHandler handler = new DataHandler();
            List<Location> locations = new List<Location>();
            DataTable rawData = handler.SelectFarmOrLocationOrAnimal(id, "SelectLocations");
            foreach (DataRow item in rawData.Rows)
            {
                locations.Add(new Location(int.Parse(item["LocationId"].ToString()), item["LocationType"].ToString(), int.Parse(item["X-Coordinates"].ToString()), int.Parse(item["Y-Coordinates"].ToString()), double.Parse(item["size"].ToString()), double.Parse(item["LocationLength"].ToString()), double.Parse(item["LocationWidth"].ToString()), int.Parse(item["LocationGate_X-Coordinate"].ToString()), int.Parse(item["LocationGate_Y-Coordinate"].ToString())));
            }
            return locations;
        }
    }
}
