using System.Windows.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Реализация интерфейса <see cref="ICommand"/>, 
    /// позволяющая связать действия UI с методами в ViewModel.
    /// </summary>
    public class RelayCommand : ICommand
    {
        #region Поля

        /// <summary>
        /// Делегат, представляющий метод для выполнения.
        /// </summary>
        private readonly Action<object> _execute;

        /// <summary>
        /// Делегат, представляющий метод для проверки 
        /// возможности выполнения команды.
        /// </summary>
        private readonly Predicate<object> _canExecute;

        /// <summary>
        /// Событие, возникающее при изменении
        /// возможности выполнения команды.
        /// </summary>
        private event EventHandler _canExecuteChanged;

        #endregion

        #region Конструктор

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="RelayCommand"/>.
        /// </summary>
        /// <param name="execute">Делегат, представляющий метод для выполнения.</param>
        /// <param name="canExecute">Делегат, представляющий метод для проверки
        /// возможности выполнения команды (необязательный).</param>
        /// <exception cref="ArgumentNullException">Выбрасывается, если <paramref name="execute"/> 
        /// равен null.</exception>
        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        #endregion

        #region Методы ICommand

        /// <summary>
        /// Определяет, может ли команда выполняться в текущем состоянии.
        /// </summary>
        /// <param name="parameter">Данные, используемые командой.
        /// Этот параметр можно использовать для передачи
        /// информации в метод <see cref="_canExecute"/>.</param>
        /// <returns>true, если команда может быть выполнена, 
        /// иначе false.</returns>
        public bool CanExecute(object? parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        /// <summary>
        /// Выполняет команду.
        /// </summary>
        /// <param name="parameter">Данные, используемые командой.</param>
        public void Execute(object? parameter)
        {
            _execute(parameter);
        }

        #endregion

        #region Событие CanExecuteChanged

        /// <summary>
        /// Возникает при изменении условий, влияющих на возможность выполнения команды.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add
            {
                _canExecuteChanged += value; CommandManager.RequerySuggested += value;
            }
            remove
            {
                _canExecuteChanged -= value; CommandManager.RequerySuggested -= value;
            }
        }

        #endregion
    }
}