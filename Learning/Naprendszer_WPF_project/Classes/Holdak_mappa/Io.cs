using Naprendszer_WPF_project.Interfaces.Planéták;
using System;

namespace Naprendszer_WPF_project.Classes.Holdak
{
    class Io : IHold
    {
        public int Sugarmerete
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string HoldNeve()
        {
            return "Io";
        }
        public override string ToString()
        {
            return "Io";
        }
    }
}