using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGames.MVVMBase
{
    class ViewModel : NotifyBase
    {
        #region Collection
        //32 db bábu kell
        //kell converter ami "átváltja" a atring pozíciót
        private ObservableCollection<IBabu> _babuk;
        public ObservableCollection<IBabu> Babuk
        {
            get { return _babuk; }
            set
            {
                _babuk = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public ViewModel()
        {
            //32 kell, később egysezrűsítunk while ciklussal
            Babuk = new ObservableCollection<IBabu>();
            //fehér
            Babuk.Add(new Gyalogos("Gyalog",true, "a2"));
            Babuk.Add(new Gyalogos("Gyalog",true, "b2"));
            Babuk.Add(new Gyalogos("Gyalog",true, "c2"));
            Babuk.Add(new Gyalogos("Gyalog",true, "d2"));
            Babuk.Add(new Gyalogos("Gyalog",true, "e2"));
            Babuk.Add(new Gyalogos("Gyalog",true, "f2"));
            Babuk.Add(new Gyalogos("Gyalog",true, "g2"));
            Babuk.Add(new Gyalogos("Gyalog",true, "h2"));

            //fekete
            Babuk.Add(new Gyalogos());
            Babuk.Add(new Gyalogos());
            Babuk.Add(new Gyalogos());
            Babuk.Add(new Gyalogos());
            Babuk.Add(new Gyalogos());
            Babuk.Add(new Gyalogos());
            Babuk.Add(new Gyalogos());
            Babuk.Add(new Gyalogos());
            //fehér
            Babuk.Add(new Bastya());
            Babuk.Add(new Bastya());
            Babuk.Add(new Huszar());
            Babuk.Add(new Huszar());
            Babuk.Add(new Futo());
            Babuk.Add(new Futo());
            Babuk.Add(new Vezer());
            Babuk.Add(new Kiraly());
            //fekete
            Babuk.Add(new Bastya());
            Babuk.Add(new Bastya());
            Babuk.Add(new Huszar());
            Babuk.Add(new Huszar());
            Babuk.Add(new Futo());
            Babuk.Add(new Futo());
            Babuk.Add(new Vezer());
            Babuk.Add(new Kiraly());




        }
    }
}
