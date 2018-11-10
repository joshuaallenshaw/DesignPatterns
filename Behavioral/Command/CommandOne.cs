namespace Command
{
    /// <summary>
    /// A Concrete Command Class
    /// </summary>
    public class CommandOne : ICommand
    {
        private readonly Receiver receiver;

        public CommandOne(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.ActionOne();
        }
    }
}