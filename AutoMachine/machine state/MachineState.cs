

namespace AutoMachine
{
    public abstract class MachineState
    {
        public StateManager StateManager { get; set; }
        public abstract void ResetButtons(Mechine form);
        public abstract void PerformCurrentStateActions(Mechine form);

    }
}
