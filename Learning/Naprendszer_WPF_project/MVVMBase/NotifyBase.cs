using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Naprendszer_WPF_project.MVVMBase
{
    class NotifyBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
