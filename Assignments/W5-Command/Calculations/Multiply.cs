namespace W5_Command
{
    public class Multiply : ICallback
    {
        private Receiver _receiver;
        private double _a;
        private double _b;

        public Multiply(Receiver receiver, double a, double b)
        {
            _receiver = receiver;
            _a = a;
            _b = b;
        }
        public void execute()
        {
            _receiver.Multiply(_a, _b);
        }
    }
}