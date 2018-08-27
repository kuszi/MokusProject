using Naprendszer_WPF_project.Interfaces.Planéták;

namespace Naprendszer_WPF_project.Classes.Csillag
{
    class Nap : ICsillag
    {
        public override string ToString()
        {
            return "Nap";
        }
        public int Homerseklet
        {
            get
            {
                return 6000;
            }
        }

        public int Sugarmerete
        {
            get
            {
                return 100000;
            }
        }
    }
}