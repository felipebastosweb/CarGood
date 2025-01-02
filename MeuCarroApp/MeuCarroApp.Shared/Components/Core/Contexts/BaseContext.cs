using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCarroApp.Shared.Components.Core.Contexts
{
    public abstract class BaseContext<T>
    {
        public abstract Task Init();
        public abstract T GetDatabase();
    }
}
