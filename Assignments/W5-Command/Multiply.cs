namespace W5_Command
{
    public class Multiply : ICallback
    {
        private Receiver _receiver;
        private int _a;
        private int _b;

        public Multiply(Receiver receiver, int a, int b)
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