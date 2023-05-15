using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMachine.machine_state
{
    public class StateManager
    {
        public MachineState MachineState { get; set; }
        public ProductType ProductType { get; set; }
        public Stock Stock { get; set; }
        public StateManager(MachineState machineState, ProductType productType, Stock stock)
        {
            this.MachineState = machineState;
            MachineState.StateManager = this;
            this.ProductType = productType;
            this.Stock = stock;
        }
        public void ResetButtons() 
        {
            this.MachineState.ResetButtons();
        }
        public void PerformCurrentStateActions()
        {
            this.MachineState.PerformCurrentStateActions();
        }
        public void ChangeState(MachineState nextState)
        {
            this.MachineState = nextState;
        }


    }
}
