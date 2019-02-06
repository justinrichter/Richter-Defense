using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richter_Defense
{
    class Invader
{
    private readonly Path _path;
    private int _pathStep = 0;

    //public MapLocation GetLocation() //Getter for _location
    //{
    //    return _location;
    //}

    //public void SetLocation(MapLocation value) //Setter for _location
    //{
    //    _location = value;           
    //}

    public MapLocation Location => _path.GetLocationAt(_pathStep); //Getter

    //public MapLocation Location (get; set;)   //Auto-property for Getter/Setter

    public int Health { get; private set; } = 2; //Invader's Health

    // True if the invader has reached the end of the path
    public bool HasScored { get { return _pathStep >= _path.Length; } }

    public bool IsNeutralized => Health <= 0; //Determine if the invader is dead

    public bool IsActive => !(IsNeutralized || HasScored);

    public Invader(Path path)
    {
        _path = path; //Ensure the invader starts at the beginning of the path
    }

    public void Move() => _pathStep += 1; //Update invader's new location

    public void DecreaseHealth(int factor)
    {
        Health -= factor;
    }
}
}