namespace W5_Command
{
    public class Divide : ICallback
    {
        private Receiver _receiver;
        private double _a;
        private double _b;

        public Divide(Receiver receiver, double a, double b)
        {
            _receiver = receiver;
            _a = a;
            _b = b;
        }
        public void execute()
        {
            _receiver.Divide(_a, _b);
        }
    }
}