using System.Collections.Generic;

namespace Command
{
    /// <summary>
    /// The Invoker Class
    /// </summary>
    public class Invoker
    {
        private readonly IList<ICommand> commandHistory = new List<ICommand>();

        public void InvokeCommand(ICommand command)
        {
            command.Execute();
            commandHistory.Add(command);
        }
    }
}