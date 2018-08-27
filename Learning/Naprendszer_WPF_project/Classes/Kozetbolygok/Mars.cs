using Naprendszer_WPF_project.Interfaces.Planéták.Bolgyók;

namespace Naprendszer_WPF_project.Classes.Kozetbolygok
{
    class Mars : IKozetbolygo
    {
        public override string ToString()
        {
            return "Mars";
        }
        public int NapotolValoTavolsag
        {
            get
            {
                return 40000;
            }
        }

        public int Sugarmerete
        {
            get
            {
                return 600;
            }
        }

        public bool VaneRajtaVizVagyNincs()
        {
            return false;
        }
    }
}