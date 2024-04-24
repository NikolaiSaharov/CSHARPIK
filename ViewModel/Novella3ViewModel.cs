using Novella.Model;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace Novella.ViewModel
{
    public class Novella3ViewModel : INotifyPropertyChanged
    {
        private GameModel _gameModel;
        private Window _window;

        public Novella3ViewModel(Window window)
        {
            _window = window;
            _gameModel = new GameModel(); 
            _gameModel.Texts.Add("Текст для Novella3"); 
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
            _gameModel.CurrentTextIndex++;
            if (_gameModel.CurrentTextIndex < _gameModel.Texts.Count)
            {
                OnPropertyChanged(nameof(CurrentText));
            }
            else
            {
                _window.Close();
            
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}