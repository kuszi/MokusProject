using ChessGames.MVVMBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGames
{
    public class Futo : NotifyBase, IBabu
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
            //amennyit az első karaktere váltotika startból a célba annyit kell a másodiknak is
            var x = Math.Abs(cel[0] - start[0]);
            var y = Math.Abs(cel[1] - start[1]);
            if (x == y)
                return true;

            return false;
        }

        public Futo(string babuNev, bool babuszin, string babuPozicio)
        {
            BabuNev = babuNev;
            BabuSzine = babuszin;
            BabuPozicio = babuPozicio;
        }
    }
}
