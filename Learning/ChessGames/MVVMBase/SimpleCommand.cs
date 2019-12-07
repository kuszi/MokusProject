using ChessGames.MVVMBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChessGames
{
    /// <summary>
    /// Commandok lekezelésére.
    /// </summary>
    public class SimpleCommand : NotifyBase, ICommand
    {
        private Predicate<Key> _keyFilter;
        /// <summary>
        /// Több gomb esetén meghívandó függvény, ami Igazzal tér vissza, ha a lenyomott gomb megfelelő.
        /// </summary>
        public Predicate<Key> KeyFilter
        {
            get { return _keyFilter; }
            set { _keyFilter = value; OnPropertyChanged("KeyFilter"); }
        }


        private ModifierKeys _gestureModifier;
        /// <summary>
        /// Megadja a használandó Modifier-t.
        /// </summary>
        /// <remarks>
        /// Ha szükséges pl. a Ctrl gomb figyelése: <code>ModifiersKeys.Control</code>
        /// </remarks>
        public ModifierKeys GestureModifier
        {
            get { return _gestureModifier; }
            set { _gestureModifier = value; OnPropertyChanged("GestureModifier"); }
        }

        private Key _gestureKey;
        /// <summary>
        /// Megadja, hogy melyik gombhoz van a command rendelve.
        /// </summary>
        public Key GestureKey
        {
            get { return _gestureKey; }
            set { _gestureKey = value; OnPropertyChanged("GestureKey"); }
        }


        bool _isEnabled = true;
        /// <summary>
        /// Engedélyezett-e a command.
        /// </summary>
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                _isEnabled = value;
                OnPropertyChanged("IsEnabled");
            }
        }


        private readonly Action _executeMethod;
        private readonly Action<object> _parametrizedMethod;

        /// <summary>
        /// Event, ami jelzi ha a command aktív vagy sem.
        /// </summary>
        public event EventHandler CanExecuteChanged;
        private void OnCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
                CanExecuteChanged(this, new EventArgs());
        }

        /// <summary>
        /// Egyszerű command.
        /// </summary>
        /// <param name="action">Az a metódus ami a command meghívásakor lefut.</param>
        public SimpleCommand(Action action)
        {
            _executeMethod = action;
        }

        /// <summary>
        /// Paraméteres command.
        /// </summary>
        /// <param name="action">Az a paraméteres metódus ami a command meghívásakor lefut.</param>
        public SimpleCommand(Action<object> action)
        {
            _parametrizedMethod = action;
        }

        /// <summary>
        /// Engedélyezett-e a command.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return IsEnabled;
        }

        /// <summary>
        /// Végrehajtja a commandot.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            if (_executeMethod != null)
            {
                // press F11
                _executeMethod.Invoke();
            }

            if (_parametrizedMethod != null)
                _parametrizedMethod.Invoke(parameter);
        }


        /// <summary>
        /// Forces button UI update. Must run in UIThread
        /// </summary>
        public void UpdateVisual()
        {
            OnCanExecuteChanged();
        }
    }
}
