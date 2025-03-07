using System.Windows.Input;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Представляет команду для сохранения контактной информации в файл.
    /// </summary>
    public class SaveCommand : ICommand
    {
        /// <summary>
        /// Сервис для сериализации и десериализации контактной информации.
        /// </summary>
        private readonly ContactSerializer _serializer;

        /// <summary>
        /// <c>ViewModel</c>, с которой связана команда.
        /// </summary>
        private readonly MainVM _viewModel;

        /// <summary>
        /// Возникает, когда изменяются условия,
        /// влияющие на возможность выполнения команды.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="SaveCommand"/>.
        /// </summary>
        /// <param name="serializer">Сервис для сериализации контактов.</param>
        /// <param name="viewModel"><c>ViewModel</c>, с которой связана команда.</param>
        public SaveCommand(ContactSerializer serializer, MainVM viewModel)
        {
            _serializer = serializer;
            _viewModel = viewModel;
        }

        /// <summary>
        /// Определяет, может ли команда быть выполнена в текущем состоянии.
        /// </summary>
        /// <param name="parameter">Данные, используемые командой. 
        /// Этот параметр игнорируется.</param>
        /// <returns>Всегда возвращает <c>true</c>, 
        /// так как команда всегда доступна для выполнения.</returns>
        public bool CanExecute(object parameter) => true;

        /// <summary>
        /// Выполняет команду сохранения контактной информации.
        /// </summary>
        /// <param name="parameter">Данные, используемые командой. 
        /// Этот параметр игнорируется.</param>
        public void Execute(object parameter)
        {
            _serializer.SaveContact(_viewModel.Contact);
        }
    }
}
