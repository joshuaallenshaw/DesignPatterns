namespace Facade
{
    /// <summary>
    /// The Facade Class
    /// </summary>
    internal class Computer
    {
        private const long BootAddress = 0;
        private readonly Cpu cpu;
        private readonly HardDrive hardDrive;
        private readonly Memory memory;

        public Computer()
        {
            cpu = new Cpu();
            memory = new Memory();
            hardDrive = new HardDrive();
        }

        public void StartComputer()
        {
            cpu.Freeze();
            memory.Load(BootAddress, hardDrive.Read(BootAddress));
            cpu.Execute();
        }
    }
}