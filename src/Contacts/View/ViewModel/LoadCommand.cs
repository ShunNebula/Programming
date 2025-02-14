using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model.Services;

namespace View.ViewModel
{
    public class LoadCommand : ICommand
    {
        private readonly ContactSerializer _serializer;
        private readonly MainVM _viewModel;

        public event EventHandler CanExecuteChanged;

        public LoadCommand(ContactSerializer serializer, MainVM viewModel)
        {
            _serializer = serializer;
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            _viewModel.Contact = _serializer.LoadContact();

            _viewModel.OnPropertyChanged(nameof(_viewModel.Name));
            _viewModel.OnPropertyChanged(nameof(_viewModel.PhoneNumber));
            _viewModel.OnPropertyChanged(nameof(_viewModel.Email));
        }
    }
}
