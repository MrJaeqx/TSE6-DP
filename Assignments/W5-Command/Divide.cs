namespace W5_Command
{
    public class Divide : ICallback
    {
        private Receiver _receiver;
        private int _a;
        private int _b;

        public Divide(Receiver receiver, int a, int b)
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