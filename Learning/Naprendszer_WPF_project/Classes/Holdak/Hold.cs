﻿using Naprendszer_WPF_project.Interfaces.Planéták;
using System;

namespace Naprendszer_WPF_project.Classes.Holdak
{
    class Hold : IHold
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
            return "Hold";
        }
        public override string ToString()
        {
            return "Hold";
        }
    }
}