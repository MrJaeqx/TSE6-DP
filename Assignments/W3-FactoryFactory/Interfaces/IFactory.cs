namespace W3_FactoryFactory
{
    public interface IFactory
    {
        IFigure createMaleFigure();
        IFigure createFemaleFigure();
        IFigure createSportFigure();
        IHouse createHouse();
        IPhone createPhone();
        IGadget createGadget();
    }
}
