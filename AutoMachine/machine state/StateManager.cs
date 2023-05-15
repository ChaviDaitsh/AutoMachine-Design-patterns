

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
        public void ResetButtons(Mechine form) 
        {
            this.MachineState.ResetButtons(form);
        }
        public void PerformCurrentStateActions(Mechine form)
        {
            this.MachineState.PerformCurrentStateActions(form);
        }
        public void ChangeState(MachineState nextState)
        {
            this.MachineState = nextState;
        }


    }
}
