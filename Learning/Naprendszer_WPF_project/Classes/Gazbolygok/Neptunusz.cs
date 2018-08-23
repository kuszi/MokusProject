using Naprendszer_WPF_project.Interfaces.Planéták.Bolgyók;

namespace Naprendszer_WPF_project.Classes.Gazbolygok
{
    class Neptunusz : IGazbolygo
    {
        public int NapotolValoTavolsag
        {
            get
            {
                return 80000;
            }
        }

        public int Sugarmerete
        {
            get
            {
                return 1500;
            }
        }

        public bool VaneNekiGyuruje()
        {
            return true;
        }
    }
}
