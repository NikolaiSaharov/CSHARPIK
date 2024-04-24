using GalaSoft.MvvmLight.Command;
using MvvmHelpers;
using System;
using System.Windows.Input;

namespace Novella.ViewModel
{
    public class Novella2ViewModel : BaseViewModel
    {
        private int currentTextIndex = 0;
        private string[] texts = {
            "Текст мыслей автора 5",
            "Текст мыслей автора 6",
            "Текст мыслей автора 7",
            "Текст мыслей автора 8"
        };

        private string _currentText;
        public string CurrentText
        {
            get { return _currentText; }
            set { SetProperty(ref _currentText, value); }
        }

        private void SetProperty(ref string currentText, string value)
        {
            throw new NotImplementedException();
        }

        public ICommand NextCommand { get; private set; }

        public Novella2ViewModel()
        {
            CurrentText = texts[currentTextIndex];
            NextCommand = new RelayCommand(NextText);
        }

        private void NextText()
        {
            currentTextIndex++;
            if (currentTextIndex < texts.Length)
            {
                CurrentText = texts[currentTextIndex];
            }
            else
            {
                // Логика после прочтения последнего текста
                // Например, переход на следующий экран или завершение приложения
            }
        }
    }
}