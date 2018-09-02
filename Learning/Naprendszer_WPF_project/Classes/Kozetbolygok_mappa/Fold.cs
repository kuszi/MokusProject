using Naprendszer_WPF_project.Interfaces.Planéták.Bolgyók;
using System;

namespace Naprendszer_WPF_project.Classes.Kozetbolygok
{
    class Fold : IKozetbolygo
    {
        public override string ToString()
        {
            return "Fold";
        }
        public int NapotolValoTavolsag
        {
            get
            {
                return 30000;
            }
        }

        public int Sugarmerete
        {
            get
            {
                return 1500;
            }
        }

        public bool VaneRajtaVizVagyNincs()
        {
            return true;
        }
    }
}