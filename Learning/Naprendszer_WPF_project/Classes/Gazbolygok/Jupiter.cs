using Naprendszer_WPF_project.Interfaces.Planéták.Bolgyók;
using System;

namespace Naprendszer_WPF_project.Classes.Gazbolygok
{
    class Jupiter : IGazbolygo
    {
        public override string ToString()
        {
            return "Jupiter";
        }
        public int NapotolValoTavolsag
        {
            get
            {
                return 50000;
            }
        }

        public int Sugarmerete
        {
            get
            {
                return 5000;
            }
        }

        public bool VaneNekiGyuruje()
        {
            return false;
        }
    }
}