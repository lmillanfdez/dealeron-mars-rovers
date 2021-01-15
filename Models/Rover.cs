using System;

namespace DealerOnMarsRovers
{
    public class Rover
    {
        public int EastCoordinate { get; set; }
        public int NorthCoordinate { get; set; }
        public string Head { get; set; }
        public string Position 
        { 
            get { return String.Format("{0} {1} {2}", new string[]{ EastCoordinate.ToString()
                                                                , NorthCoordinate.ToString(), Head}); }
        }
    }
}