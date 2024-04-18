using Novella.Model;
using Novella.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Novella.ViewModel
{
    public class Novella3ViewModel : INotifyPropertyChanged
    {
        private GameModel _gameModel;

        public Novella3ViewModel(Window window)
        {
            _gameModel = new GameModel(); // Инициализация GameModel
            _gameModel.Texts.Add("Текст для Novella3"); // Пример добавления текста
            _gameModel.CurrentTextIndex = 0; // Установка индекса текущего текста
        }

        public ICommand NextCommand { get; private set; }

        

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}