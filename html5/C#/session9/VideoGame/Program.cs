using System;
using System.Collections.Generic;

namespace VideoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Martian martian = new Martian();
            Venusian venusian = new Venusian();
            Plutonian plutonian = new Plutonian();
            SpaceShip spaceShip = new SpaceShip();
            LaserBeam laserBeam = new LaserBeam();
            Mercurian mercurian = new Mercurian();

            List<SpaceObject> Space = new List<SpaceObject>() {martian,venusian,plutonian,spaceShip,laserBeam,mercurian};

            foreach(SpaceObject game in Space)
            {
               Console.WriteLine(game.Draw());
            }
        }
    }
}
