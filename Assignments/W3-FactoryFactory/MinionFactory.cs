using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W3_FactoryFactory
{
    class MinionFactory : IFactory
    {
        public IFigure createMaleFigure()
        {
            return new Minion();
        }

        public IFigure createFemaleFigure()
        {
            return new Miniette();
        }

        public IFigure createSportFigure()
        {
            return new SportMinion();
        }

        public IHouse createHouse()
        {
            return new MinionHouse();
        }

        public IPhone createPhone()
        {
            return new BananaPhone();
        }

        public IGadget createGadget()
        {
            return new MinionGadget();
        }
    }
}
