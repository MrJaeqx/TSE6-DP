namespace W5_Command
{
    public class Substract : ICallback
    {
        private Receiver _receiver;
        private double _a;
        private double _b;

        public Substract(Receiver receiver, double a, double b)
        {
            _receiver = receiver;
            _a = a;
            _b = b;
        }
        public void execute()
        {
            _receiver.Substract(_a, _b);
        }
    }
}