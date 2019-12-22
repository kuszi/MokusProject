using ChessGames.MVVMBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGames
{
    public class Bastya : NotifyBase, IBabu
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
            get { return _babuPozicio; }
            set { _babuPozicio = value; OnPropertyChanged(); }
        }

        private bool _babuSzine;
        public bool BabuSzine
        {
            get { return _babuSzine; }
            set { _babuSzine = value; OnPropertyChanged(); }
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
            //szóval ha a start és cél első karakterei megegyeznek akkor a második karaktere nem lehetnek egyformák
            
            if (start[0] == cel[0] && start[1] != cel[1])
                return true;

            //ha a start és a cél első karaktere különbözik akkor a második karakternek egyezniük kell
            if (start[0] != cel[0] && start[1] == cel[1])  
                return true;

            // ha egyik sem teljesül akkor hiba van

            return false;
        }

        public Bastya(string babuNev, bool babuSzin, string babuPozício)
        {
            BabuNev = babuNev;
            BabuSzine = babuSzin;
            BabuPozicio = babuPozício;
        }
    }
}
