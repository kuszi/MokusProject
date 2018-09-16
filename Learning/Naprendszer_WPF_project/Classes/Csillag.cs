using Naprendszer_WPF_project.Interfaces.Planéták;
using System;

namespace Naprendszer_WPF_project.Classes
{
    class Csillag : ICsillag
    {
        private string name;
        private int v2;
        private int v3;

        public Csillag(string name, int v2, int v3)
        {
            this.name = name;
            this.v2 = v2;
            this.v3 = v3;
        }

        public int Homerseklet
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
    }
}
