using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naprendszer_WPF_project.Interfaces.Planéták
{
   public interface IBolygo:INaprendszer
    {
        int NapotolValoTavolsag { get; }
    }
}
