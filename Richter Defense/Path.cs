using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richter_Defense
{
    class Path
{
    private readonly MapLocation[] _path;

    public int Length => _path.Length;

    public Path(MapLocation[] path)
    {
        _path = path;
    }

    public MapLocation GetLocationAt(int pathStep)
    {
        return (pathStep < _path.Length) ? _path[pathStep] : null;
        //return _path[pathStep] or null based on Ternary If decision
    }
}
}