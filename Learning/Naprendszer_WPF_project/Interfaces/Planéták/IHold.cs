using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naprendszer_WPF_project.Interfaces.Planéták
{
   public interface IHold:INaprendszer
    {//ez még nem bizti lehet hogy inkább void, gondold át!!
        string HoldNeve();
    }
}
