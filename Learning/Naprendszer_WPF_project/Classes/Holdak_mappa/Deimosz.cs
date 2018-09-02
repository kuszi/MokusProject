using Naprendszer_WPF_project.Interfaces.Planéták;
using System;

namespace Naprendszer_WPF_project.Classes.Holdak
{
    class Deimosz : IHold
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
            return "Deimosz";
        }
        public override string ToString()
        {
            return "Deimosz";
        }
    }
}