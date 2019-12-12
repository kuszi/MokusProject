using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChessGames.MVVMBase
{
    class ViewModel : NotifyBase
    {
        private string _aktualisBabu;                                                      //amit kikötök a ui-ra
        public string AktualisBabu { get { return _aktualisBabu; } set { _aktualisBabu = value; OnPropertyChanged(); } }

        private string _melyikBabu;                                                                                    //típusa
        public string MelyikBabu { get { return _melyikBabu; } set { _melyikBabu = value; OnPropertyChanged(); } }

        private string _milyenBabu;                                                                                              //színe
        public string MilyenBabu { get { return _milyenBabu; } set { _milyenBabu = value; OnPropertyChanged(); } }

        private string _holaBabu;                                                                                              //pozíció
        public string HolaBabu { get { return _holaBabu; } set { _holaBabu = value; OnPropertyChanged(); } }

        private string _input;
        public string Input { get { return _input; } set { _input = value; OnPropertyChanged(); } }

        private ICommand _stepCommnad;
        public ICommand StepCommand { get { return _stepCommnad; } set { _stepCommnad = value; OnPropertyChanged(); } }


        #region Collection
        //32 db bábu kell
        //kell converter ami "átváltja" a string pozíciót
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
                    if (SelectedBabuk.BabuSzine == true)
                    {
                        MilyenBabu = "fehér";
                        MelyikBabu = "gyalogos";
                        HolaBabu = SelectedBabuk.BabuPozicio;
                    }
                    else
                    {
                        MilyenBabu = "fekete";
                        MelyikBabu = "gyalogos";
                        HolaBabu = SelectedBabuk.BabuPozicio;
                    }
                }
                var bastya = SelectedBabuk as Bastya;
                if (bastya != null)
                {
                    if (SelectedBabuk.BabuSzine == true)
                    {
                        MilyenBabu = "fehér";
                        MelyikBabu = "bástya";
                        HolaBabu = SelectedBabuk.BabuPozicio;
                    }
                    else
                    {
                        MilyenBabu = "fekete";
                        MelyikBabu = "bástya";
                        HolaBabu = SelectedBabuk.BabuPozicio;
                    }
                }
                var futo = SelectedBabuk as Futo;
                if (futo != null)
                {
                    if (SelectedBabuk.BabuSzine == true)
                    {
                        MilyenBabu = "fehér";
                        MelyikBabu = "futó";
                        HolaBabu = SelectedBabuk.BabuPozicio;
                    }
                    else
                    {
                        MilyenBabu = "fekete";
                        MelyikBabu = "futó";
                        HolaBabu = SelectedBabuk.BabuPozicio;
                    }
                }
                var huszar = SelectedBabuk as Huszar;
                if (huszar != null)
                {
                    if (SelectedBabuk.BabuSzine == true)
                    {
                        MilyenBabu = "fehér";
                        MelyikBabu = "huszár";
                        HolaBabu = SelectedBabuk.BabuPozicio;
                    }
                    else
                    {
                        MilyenBabu = "fekete";
                        MelyikBabu = "huszár";
                        HolaBabu = SelectedBabuk.BabuPozicio;
                    }
                }
                var vezer = SelectedBabuk as Vezer;
                if (vezer != null)
                {
                    if (SelectedBabuk.BabuSzine == true)
                    {
                        MilyenBabu = "fehér";
                        MelyikBabu = "kiralynő";
                        HolaBabu = SelectedBabuk.BabuPozicio;
                    }
                    else
                    {
                        MilyenBabu = "fekete";
                        MelyikBabu = "kiralynő";
                        HolaBabu = SelectedBabuk.BabuPozicio;
                    }
                }
                var kiraly = SelectedBabuk as Kiraly;
                if (kiraly != null)
                {
                    if (SelectedBabuk.BabuSzine == true)
                    {
                        MilyenBabu = "fehér";
                        MelyikBabu = "király";
                        HolaBabu = SelectedBabuk.BabuPozicio;
                    }
                    else
                    {
                        MilyenBabu = "fekete";
                        MelyikBabu = "király";
                        HolaBabu = SelectedBabuk.BabuPozicio;
                    }
                }

                AktualisBabu = $"{MilyenBabu} {MelyikBabu} {HolaBabu}";
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

            CreateCommand();
        }

        private void CreateCommand()
        {
            StepCommand = new SimpleCommand(ExecuteStepCommand);
        }

        private void ExecuteStepCommand()
        {


            if (Input != null && Input.Length == 4)
            {
                string FeketeVagyFeher = "";
                string FeketeVagyFeher2 = "";
                var first = Input[0].ToString() + Input[1].ToString();
                var last = Input[2].ToString() + Input[3].ToString();
                var elsoFel = Babuk.FirstOrDefault(x => x.BabuPozicio == first);
                var masodikFel = Babuk.FirstOrDefault(p => p.BabuPozicio == last);

                FeketeVagyFeher = elsoFel.BabuSzine ? "Fehér " : "Fekete";
                FeketeVagyFeher2 = masodikFel.BabuSzine ? "Fehér " : "Fekete";
               
                Input = $"{FeketeVagyFeher}{elsoFel.BabuNev} {FeketeVagyFeher2}{masodikFel.BabuNev} ";


            }
            else
            {
                Input = "Invalid input érték.";
            }

        }
    }
}
