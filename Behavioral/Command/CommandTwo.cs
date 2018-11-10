namespace Command
{
    /// <summary>
    /// A Concrete Command Class
    /// </summary>
    public class CommandTwo : ICommand
    {
        private readonly Receiver receiver;

        public CommandTwo(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.ActionTwo();
        }
    }
}