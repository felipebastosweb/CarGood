using OficinaApp.Data.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaApp.Data.Contexts
{
    public class WorkOrderContext
    {
        public WorkOrderState? State { get; set; }

        public WorkOrderContext(WorkOrderState? state)
        {
            State = state;
        }

        /*
        public void TransitionTo(WorkOrderState? state)
        {
            State = state;
            State.SetContext(this);
        }

        public void Request1()
        {
            State.Handle1();
        }

        public void Request2()
        {
            State.Handle2();
        }
        */
    }
}
