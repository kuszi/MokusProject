using Naprendszer_WPF_project.Interfaces.Planéták.Bolgyók;

namespace Naprendszer_WPF_project.Classes.Kozetbolygok
{
    class Merkur : IKozetbolygo
    {
        public int NapotolValoTavolsag
        {
            get
            {
                return 10000;
            }
        }

        public int Sugarmerete
        {
            get
            {
                return 500;
            }
        }

        public bool VaneRajtaVizVagyNincs()
        {
            return false;
        }
    }
}
