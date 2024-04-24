using Novella.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace Novella.ViewModels
{
    public class Novella2ViewModel : INotifyPropertyChanged
    {
        private GameModel _gameModel;
        private Window _window;

        public Novella2ViewModel(Window window)
        {
            _window = window;
            _gameModel = new GameModel();
            _gameModel.Texts.Add("Текст для Novella2"); 
            _gameModel.CurrentTextIndex = 0; 
            NextCommand = new RelayCommand(NextButton_Click);
        }

        public string CurrentText
        {
            get { return _gameModel.Texts[_gameModel.CurrentTextIndex]; }
        }

        public ICommand NextCommand { get; private set; }

        private void NextButton_Click()
        {
            
            var novella3 = new Novella3(); 
            novella3.Show();
            _window.Close();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}