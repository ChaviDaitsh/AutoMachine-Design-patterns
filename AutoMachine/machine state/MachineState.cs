using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMachine.machine_state
{
    public abstract class MachineState
    {
        public StateManager StateManager { get; set; }
        public abstract void ResetButtons();
        public abstract void PerformCurrentStateActions();
    }
}
