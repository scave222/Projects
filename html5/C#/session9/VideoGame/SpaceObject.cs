namespace VideoGame
{
    abstract public class SpaceObject
    {
        public SpaceObject()
        {

        }
        public abstract string Draw();
        
    }

    public class Martian : SpaceObject
    {
        public Martian()
        {

        }

        public override string Draw()
        {
            return "Features of Martian: Red,Green eyes and antennae";
        }
    }

    public class Venusian : SpaceObject
    {
        public Venusian()
        {

        }

        public override string Draw()
        {
            return "Features of Venusian: Bright silver flying saucer.";
        }
    }

    public class Plutonian : SpaceObject
    {
         public Plutonian()
        {

        }

        public override string Draw()
        {
            return "Features of Plutonian: Red,Green eyes and antennae";
        }
    }

    public class SpaceShip : SpaceObject
    {
         public SpaceShip()
        {

        }

        public override string Draw()
        {
            return "Features of SpaceShip: Bright silver flying saucer.";
        }
    }

    public class LaserBeam : SpaceObject
    {
         public LaserBeam()
        {

        }

        public override string Draw()
        {
            return "Features of Laser Beam: Bright red beam across the screen.";
        }
    }

     public class Mercurian : SpaceObject
    {
         public Mercurian()
        {

        }

        public override string Draw()
        {
            return "Features of Mercurian: Bright red beam across the screen.";
        }
    }

    
}