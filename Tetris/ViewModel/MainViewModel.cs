using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using System.Windows.Threading;
using Tetris.Helpers;
using Tetris.Views;

namespace Tetris.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private int _blockTimeSpan = 1;
        private DispatcherTimer _mainTimer;

        private object _waitingView;
        private object _playingView;

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                if (_currentView != value)
                {
                    _currentView = value;
                    OnPropertyChanged("CurrentView");
                }
            }
        }

        public DelegateCommand KeyDownCommand { get; private set; }

        public MainViewModel()
        {
            _waitingView = new WaitingView();
            _playingView = new PlayingView();
            _mainTimer = new DispatcherTimer();

            KeyDownCommand = new DelegateCommand(KeyDown);
            CurrentView = _waitingView;
        }

        // 게임을 시작한다.
        private void GameStart()
        {
            CurrentView = _playingView;

            // 블럭을 생성한다.
            CreateBlock();

            // 타이머를 시작한다.
            StartTimer();
        }

        private void StartTimer()
        {
            _mainTimer.Interval = TimeSpan.FromSeconds(_blockTimeSpan);
            _mainTimer.Tick += MoveBlock;
            _mainTimer.Start();
        }

        private void MoveBlock(object sender, EventArgs e)
        {

        }

        private void CreateBlock()
        {

        }

        private void KeyDown(object parameter)
        {
            if (CheckKeyDown().Any())
                GameStart();
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

        #region [ Helpers ]

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}