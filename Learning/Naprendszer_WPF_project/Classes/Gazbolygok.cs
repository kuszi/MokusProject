using Naprendszer_WPF_project.Interfaces.Planéták.Bolgyók;
using System;

namespace Naprendszer_WPF_project.Classes
{
    class Gazbolygok : IKozetbolygo
    {
        private string v1;
        private int v2;
        private int v3;

        public Gazbolygok(string v1, int v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public int NapotolValoTavolsag
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string PlanetaNeve
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Sugarmerete
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool VaneRajtaVizVagyNincs()
        {
            throw new NotImplementedException();
        }
    }
}
