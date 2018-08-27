using Naprendszer_WPF_project.Interfaces.Planéták.Bolgyók;

namespace Naprendszer_WPF_project.Classes.Gazbolygok
{
    class Uranusz : IGazbolygo
    {
        public override string ToString()
        {
            return "Uranusz";
        }
        public int NapotolValoTavolsag
        {
            get
            {
                return 70000;
            }
        }

        public int Sugarmerete
        {
            get
            {
                return 2000;
            }
        }

        public bool VaneNekiGyuruje()
        {
            return true;
        }
    }
}