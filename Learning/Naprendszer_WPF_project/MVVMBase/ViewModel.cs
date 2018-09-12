using Naprendszer_WPF_project.Classes;
using Naprendszer_WPF_project.Interfaces;
using Naprendszer_WPF_project.Interfaces.Planéták;
using System.Collections.ObjectModel;

namespace Naprendszer_WPF_project.MVVMBase
{
    class ViewModel : NotifyBase
    {
        #region Milyen planéta
        private string _planeta;
        public string Planeta
        {
            get { return _planeta; }
            set
            {
                _planeta = value;
                OnPropertyChanged();
            }
        }

        private int _sugarmerete;
        public int Sugarmerete
        {
            get { return _sugarmerete; }
            set
            {
                _sugarmerete = value;
                OnPropertyChanged();
            }
        }
       



        #endregion

        #region Collection
        private ObservableCollection<INaprendszer> _naprendszer;
        public ObservableCollection<INaprendszer> Naprendszer
        {
            get { return _naprendszer; }
            set
            {
                _naprendszer = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<ICsillag> _csillag;
        public ObservableCollection<ICsillag> Csillag
        {
            get { return _csillag; }
            set
            {
                _csillag = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Selected Naprednszer
        private INaprendszer _selectedNaprendszer;
        public INaprendszer SelectedNaprendszer
        {
            get { return _selectedNaprendszer; }
            set
            {
                _selectedNaprendszer = value;
                OnPropertyChanged();
                var kiscsillag = SelectedNaprendszer as ICsillag;
                if (kiscsillag != null)
                {
                    Planeta = "csillag";
                }
                var kisbolygo = SelectedNaprendszer as IBolygo;
                if (kisbolygo != null)
                {
                    Planeta = "bolygó";
                }
                var kishold = SelectedNaprendszer as IHold;
                if (kishold != null)
                {
                    Planeta = "hold";
                }

            }
        }
        #endregion
        #region Selected Naprednszer
        private ICsillag _selectedCsillag;
        public ICsillag SelectedCsillag
        {
            get { return _selectedCsillag; }
            set
            {
                _selectedNaprendszer = value;
                OnPropertyChanged();
                

            }
        }
        #endregion


        public ViewModel()
        {
            Naprendszer = new ObservableCollection<INaprendszer>();
            Naprendszer.Add(new Csillag("Nap", 6000, 100000));
            Naprendszer.Add(new Kozetbolyok("Jupiter", 50000, 5000));
            Naprendszer.Add(new Kozetbolyok("Neptunusz", 80000, 1500));
            Naprendszer.Add(new Kozetbolyok("Szaturnusz", 60000, 3000));
            Naprendszer.Add(new Kozetbolyok("Uránusz", 70000, 2000));
            Naprendszer.Add(new Gazbolygok("Fold", 30000, 1500));
            Naprendszer.Add(new Gazbolygok("Mars", 40000, 600));
            Naprendszer.Add(new Gazbolygok("Merkur", 10000, 500));
            Naprendszer.Add(new Gazbolygok("Venusz", 20000,1000));
            Naprendszer.Add(new Holdak("Deimosz"));
            Naprendszer.Add(new Holdak("Europe"));
            Naprendszer.Add(new Holdak("Hold"));
            Naprendszer.Add(new Holdak("Io"));
            Naprendszer.Add(new Holdak("Kalliszto"));
            Naprendszer.Add(new Holdak("Pandora"));
            Naprendszer.Add(new Holdak("Phobosz"));
            Naprendszer.Add(new Holdak("Phoebe"));
            Naprendszer.Add(new Holdak("Titan"));
            SelectedNaprendszer = Naprendszer[0];


            Csillag = new ObservableCollection<ICsillag>();
            Csillag.Add(new Csillag());


           
        }
    }
}