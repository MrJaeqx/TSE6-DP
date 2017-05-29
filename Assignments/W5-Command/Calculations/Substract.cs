namespace W5_Command
{
    public class Substract : ICallback
    {
        private Receiver _receiver;
        private int _a;
        private int _b;

        public Substract(Receiver receiver, int a, int b)
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