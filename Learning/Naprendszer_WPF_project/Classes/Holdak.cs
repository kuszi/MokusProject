using Naprendszer_WPF_project.Interfaces.Planéták;
using System;

namespace Naprendszer_WPF_project.Classes
{
    class Holdak : IHold
    {
        private string v;

        public Holdak(string v)
        {
            this.v = v;
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
