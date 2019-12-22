using ChessGames.MVVMBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGames
{
    class Gyalogos : NotifyBase, IBabu
    {
        private string _babuNev;
        public string BabuNev
        {
            get { return _babuNev; }
            set { _babuNev = value; OnPropertyChanged(); }
        }

        private string _babuPozicio;
        public string BabuPozicio
        {
            get
            {
                return _babuPozicio;
            }

            set
            {
                _babuPozicio = value; OnPropertyChanged();
            }
        }

        private bool _babuSzine;
        public bool BabuSzine
        {
            get
            {
                return _babuSzine;
            }

            set
            {
                _babuSzine = value; OnPropertyChanged();
            }
        }

        public void BabuMozgas()
        {
            throw new NotImplementedException();
        }

        public void BabuUtes()
        {
            throw new NotImplementedException();
        }

        public bool Lephete(string start, string cel)
        {
            // fehér csak felfele mehet 
            //ha fekete csak lefele mehet
            if (BabuSzine == true)
            {
                var y = cel[1] - start[1];
                if (y == 1 && start[0] == cel[0])
                    return true;

                if (y == 2 && start[0] == cel[0] && start[1] == '2')
                    return true;
            }
            else
            {
                var y = cel[1] - start[1];
                if (y == -1 && start[0] == cel[0])
                    return true;

                if (y == -2 && start[0] == cel[0] && start[1] == '7')
                    return true;
            }


            //első lépés lehet egy vagy 2

            //léphet átlósan elősre egyet ha azona cél pozición van már bábu
            return false;
        }

        public Gyalogos(string babuNev, bool babuSzin, string babuPozicio)
        {
            BabuNev = babuNev;
            BabuSzine = babuSzin;
            BabuPozicio = babuPozicio;
        }
    }
}
