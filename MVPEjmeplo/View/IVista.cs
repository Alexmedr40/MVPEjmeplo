using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPEjmeplo.View
{
    public interface IVista
    {
        event EventHandler ButtonClick;
        void SetMessage(string message);
    }
}
