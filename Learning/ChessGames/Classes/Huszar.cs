using ChessGames.MVVMBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGames
{
    public class Huszar : NotifyBase, IBabu
    {
        private string _babuNev;
        public string BabuNev
        {
            get
            {
                return _babuNev;
            }

            set
            {
                _babuNev = value; OnPropertyChanged();
            }
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
            //ha elso karakter 1t valtozkik akkor a masodiknak 2 kell ha az elso 2t valtozik akkor a masodiknak 1et kell
            var x = Math.Abs(start[0] - cel[0]);
            var y = Math.Abs(start[1] - cel[1]);

            if (x == 1 && y == 2)
                return true;

            if (x == 2 && y == 1)
                return true;

            return false;
        }

        public Huszar(string babuNev, bool babusSzin, string babuPozicio)
        {
            BabuNev = babuNev;
            BabuSzine = babusSzin;
            BabuPozicio = babuPozicio;
        }
    }
}
