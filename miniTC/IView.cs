using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTC
{
    interface IView
    {
        IPanel LeftPanel { get; }
        IPanel RightPanel { get; }

        event Action Copy;

    }
}
