using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richter_Defense
{
    class MapLocation : Point //Inherits 'Point' class methods
{
    public MapLocation(int x, int y, Map map) : base(x, y)  //Constructor to pass coord. to parent 'Point' Class for exception
    {
        if (!map.OnMap(this))
        {
            throw new OutOfBoundsException(x + "," + y + " is outside the boundaries of the map.");
        }
    }

    public bool InRangeOf(MapLocation location, int range)
    {
        return DistanceTo(location) <= range;
    }
}
}