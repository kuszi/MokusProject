﻿using ChessGames.MVVMBase;
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

        public Bastya(string babuNev, bool babuSzin, string babuPozício)
        {
            BabuNev = babuNev;
            BabuSzine = babuSzin;
            BabuPozicio = babuPozício;
        }
    }
}
