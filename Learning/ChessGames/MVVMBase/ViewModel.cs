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

        private string _melyikBabu;
        public string MelyikBabu { get { return _melyikBabu; } set { _melyikBabu = value; OnPropertyChanged(); } }
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

        private IBabu _selectedBabuk;
        public IBabu SelectedBabuk
        {
            get { return _selectedBabuk; }
            set
            {
                _selectedBabuk = value; OnPropertyChanged();

                var gyalog = SelectedBabuk as Gyalogos;
                if (gyalog != null)
                {
                    MelyikBabu = "gyalogos";
                }
                var bastya = SelectedBabuk as Bastya;
                if (bastya != null)
                {
                    MelyikBabu = "bastya";
                }
                var futo = SelectedBabuk as Futo;
                if (futo != null)
                {
                    MelyikBabu = "futo";
                }
                var huszar = SelectedBabuk as Huszar;
                if (huszar != null)
                {
                    MelyikBabu = "huszár";
                }
                var vezer = SelectedBabuk as Vezer;
                if (vezer != null)
                {
                    MelyikBabu = "kiralynő";
                }
                var kiraly = SelectedBabuk as Kiraly;
                if (kiraly != null)
                {
                    MelyikBabu = "király";
                }
            }
        }
        #endregion

        public ViewModel()
        {
            //32 kell, később egysezrűsítunk while ciklussal
            Babuk = new ObservableCollection<IBabu>();
            //fehér
            Babuk.Add(new Gyalogos("Gyalog", true, "a2"));
            Babuk.Add(new Gyalogos("Gyalog", true, "b2"));
            Babuk.Add(new Gyalogos("Gyalog", true, "c2"));
            Babuk.Add(new Gyalogos("Gyalog", true, "d2"));
            Babuk.Add(new Gyalogos("Gyalog", true, "e2"));
            Babuk.Add(new Gyalogos("Gyalog", true, "f2"));
            Babuk.Add(new Gyalogos("Gyalog", true, "g2"));
            Babuk.Add(new Gyalogos("Gyalog", true, "h2"));

            //fekete
            Babuk.Add(new Gyalogos("Gyalog", false, "a7"));
            Babuk.Add(new Gyalogos("Gyalog", false, "b7"));
            Babuk.Add(new Gyalogos("Gyalog", false, "c7"));
            Babuk.Add(new Gyalogos("Gyalog", false, "d7"));
            Babuk.Add(new Gyalogos("Gyalog", false, "e7"));
            Babuk.Add(new Gyalogos("Gyalog", false, "f7"));
            Babuk.Add(new Gyalogos("Gyalog", false, "g7"));
            Babuk.Add(new Gyalogos("Gyalog", false, "h7"));
            //fehér
            Babuk.Add(new Bastya("Bástya", true, "a1"));
            Babuk.Add(new Bastya("Bástya", true, "h1"));
            Babuk.Add(new Huszar("Huszár", true, "b1"));
            Babuk.Add(new Huszar("Huszár", true, "g1"));
            Babuk.Add(new Futo("Futo", true, "c1"));
            Babuk.Add(new Futo("Futo", true, "f1"));
            Babuk.Add(new Vezer("Királynő", true, "d1"));
            Babuk.Add(new Kiraly("Király", true, "e1"));
            //fekete
            Babuk.Add(new Bastya("Bástya", false, "a8"));
            Babuk.Add(new Bastya("Bástya", false, "h8"));
            Babuk.Add(new Huszar("Huszár", false, "b8"));
            Babuk.Add(new Huszar("Huszár", false, "g8"));
            Babuk.Add(new Futo("Futo", false, "c8"));
            Babuk.Add(new Futo("Futo", false, "f8"));
            Babuk.Add(new Vezer("Királynő", false, "d8"));
            Babuk.Add(new Kiraly("Király", false, "e8"));

            SelectedBabuk = Babuk[0];


        }
    }
}
