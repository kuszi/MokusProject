using Naprendszer_WPF_project.Interfaces.Planéták.Bolgyók;
using System;

namespace Naprendszer_WPF_project.Classes.Gazbolygok
{
    class Szaturnusz : IGazbolygo
    {
        public int NapotolValoTavolsag
        {
            get
            {
                return 60000;
            }
        }

        public int Sugarmerete
        {
            get
            {
                return 3000;
            }
        }

        public bool VaneNekiGyuruje()
        {
            return true;
        }
    }
}
