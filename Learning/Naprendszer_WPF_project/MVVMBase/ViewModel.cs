using Naprendszer_WPF_project.Classes;
using Naprendszer_WPF_project.Classes.Csillag;
using Naprendszer_WPF_project.Classes.Gazbolygok;
using Naprendszer_WPF_project.Classes.Holdak;
using Naprendszer_WPF_project.Classes.Kozetbolygok;
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


        public ViewModel()
        {
            Naprendszer = new ObservableCollection<INaprendszer>();
            Naprendszer.Add(new Csillag());
            Naprendszer.Add(new Kozetbolyok());
            Naprendszer.Add(new Gazbolygok());
            Naprendszer.Add(new Holdak());
           


            //Naprendszer.Add(new Merkur());
            //Naprendszer.Add(new Venusz());
            //Naprendszer.Add(new Fold());
            //Naprendszer.Add(new Mars());
            //Naprendszer.Add(new Jupiter());
            //Naprendszer.Add(new Szaturnusz());
            //Naprendszer.Add(new Neptunusz());
            //Naprendszer.Add(new Hold());
            //Naprendszer.Add(new Phobosz());
            //Naprendszer.Add(new Deimosz());
            //Naprendszer.Add(new Io());
            //Naprendszer.Add(new Europe());
            //Naprendszer.Add(new Kalliszto());
            //Naprendszer.Add(new Pandora());
            //Naprendszer.Add(new Titan());
            //Naprendszer.Add(new Phoebe());
            SelectedNaprendszer = Naprendszer[0];

        }
    }
}