using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Tetris.Helpers;

namespace Tetris.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private bool _isGameStart;
        public bool IsGameStart
        {
            get { return _isGameStart; }
            set
            {
                if (_isGameStart != value)
                {
                    _isGameStart = value;
                    OnPropertyChanged("IsGameStart");
                }
            }
        }

        public DelegateCommand KeyDownCommand { get; private set; }

        public MainViewModel()
        {
            KeyDownCommand = new DelegateCommand(KeyDown);
        }

        // 게임을 시작한다.
        private void GameStart()
        {
            IsGameStart = true;
        }

        private void KeyDown(object parameter)
        {
            if (CheckKeyDown().Any())
            {
                GameStart();
            }
        }

        // 특정 어떠한 키가 눌렸음을 확인한다.
        public IEnumerable<Key> CheckKeyDown()
        {
            foreach (Key key in Enum.GetValues(typeof(Key)))
            {
                if (key == Key.None)
                    continue;

                if (Keyboard.IsKeyDown(key))
                    yield return key;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}