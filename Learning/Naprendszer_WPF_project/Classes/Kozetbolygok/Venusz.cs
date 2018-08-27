using Naprendszer_WPF_project.Interfaces.Planéták.Bolgyók;

namespace Naprendszer_WPF_project.Classes.Kozetbolygok
{
    class Venusz : IKozetbolygo
    {
        public override string ToString()
        {
            return "Venusz";
        }
        public int NapotolValoTavolsag
        {
            get
            {
                return 20000;
            }
        }

        public int Sugarmerete
        {
            get
            {
                return 1000;
            }
        }

        public bool VaneRajtaVizVagyNincs()
        {
            return false;
        }
    }
}