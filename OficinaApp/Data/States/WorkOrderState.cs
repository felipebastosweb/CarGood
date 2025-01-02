using OficinaApp.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaApp.Data.States
{
    
    public abstract class WorkOrderState
    {
        public WorkOrderContext? Context { get; set; }
        public WorkOrderState(WorkOrderContext context)
        {
            Context = context;
        }
        public abstract void Handle1();
        public abstract void Handle2();
    }
    /*
    public class WorkOrderAcceptedState :  WorkOrderState
    {
        public override void Handle1()
        {
            // executa algo e muda de status
            Context.TransitionTo();
        }

        public override void Handle2()
        {
            //
        }
    }

    public class WorkOrderInProgressState : WorkOrderState
    {
        public override void Handle1()
        {

        }

        public override void Handle2()
        {

        }
    }

    public class WorkOrderDoneState : WorkOrderState
    {
        public override void Handle1()
        {

        }

        public override void Handle2()
        {

        }
    }
    */
}
