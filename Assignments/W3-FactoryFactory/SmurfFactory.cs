namespace W3_FactoryFactory
{
    public class SmurfFactory : IFactory
    {
        public IFigure createMaleFigure()
        {
            return new Smurf();
        }

        public IFigure createFemaleFigure()
        {
            return new Smurfin();
        }

        public IFigure createSportFigure()
        {
            return new SportSmurf();
        }

        public IHouse createHouse()
        {
            return new Paddo();
        }

        public IPhone createPhone()
        {
            return new SmurfBerry();
        }

        public IGadget createGadget()
        {
            return new SmurfGadget();
        }
    }
}
