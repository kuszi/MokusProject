﻿using ChessGames.MVVMBase;
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

        public string BabuPozicio
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool BabuSzine
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
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

        public Futo(string babuNev, bool babuszin, string babuPozicio)
        {
            BabuNev = babuNev;
            BabuSzine = babuszin;
            BabuPozicio = babuPozicio;
        }
    }
}
