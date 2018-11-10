namespace Command
{
    /// <summary>
    /// A Concrete Command Class
    /// </summary>
    public class CommandThree : ICommand
    {
        private readonly Receiver receiver;

        public CommandThree()
        {
        }

        public CommandThree(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.ActionOne();
            receiver.ActionTwo();
        }
    }
}