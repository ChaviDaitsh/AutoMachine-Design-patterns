

namespace AutoMachine
{
    public class StateManager
    {
        public MachineState MachineState { get; set; }
        public ProductType ProductType { get; set; }
        public Stock Stock { get; set; }
        public StateManager(MachineState machineState,  Stock stock)
        {
            this.MachineState = machineState;
            MachineState.StateManager = this;

            this.Stock = stock;
        }
        public void ResetButtons(Machine machine) 
        {
            this.MachineState.ResetButtons(machine);
        }
        public void PerformCurrentStateActions(Machine machine)
        {
            this.MachineState.PerformCurrentStateActions(machine);
        }
        public void ChangeState(MachineState nextState)
        {
            this.MachineState = nextState;
        }


    }
}
