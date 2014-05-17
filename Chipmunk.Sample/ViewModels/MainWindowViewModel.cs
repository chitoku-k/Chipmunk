using System.Windows.Media;

namespace Chipmunk.Sample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private bool _isMinimizeButtonEnabled = true;
        public bool IsMinimizeButtonEnabled
        {
            get { return _isMinimizeButtonEnabled; }
            set 
            { 
                _isMinimizeButtonEnabled = value;
                OnPropertyChanged("IsMinimizeButtonEnabled");
            }
        }

        private bool _isMaximizeButtonEnabled = false;
        public bool IsMaximizeButtonEnabled
        {
            get { return _isMaximizeButtonEnabled; }
            set 
            { 
                _isMaximizeButtonEnabled = value;
                OnPropertyChanged("IsMaximizeButtonEnabled");
            }
        }

        private bool _isHelpButtonEnabled = false;
        public bool IsHelpButtonEnabled
        {
            get { return _isHelpButtonEnabled; }
            set 
            { 
                _isHelpButtonEnabled = value;
                OnPropertyChanged("IsHelpButtonEnabled");
            }
        }

        private bool _isCloseButtonEnabled = true;
        public bool IsCloseButtonEnabled
        {
            get { return _isCloseButtonEnabled; }
            set 
            { 
                _isCloseButtonEnabled = value;
                OnPropertyChanged("IsCloseButtonEnabled");
            }
        }

        private bool _isControlButtonVisible = true;
        public bool IsControlButtonVisible
        {
            get { return _isControlButtonVisible; }
            set
            {
                _isControlButtonVisible = value;
                OnPropertyChanged("IsControlButtonVisible");
            }
        }

        private DwmCompositionOption _dwmComposition = new DwmCompositionOption(-1, 0, 0, 0, Colors.White);
        public DwmCompositionOption DwmComposition
        {
            get { return _dwmComposition; }
            set
            {
                _dwmComposition = value;
                OnPropertyChanged("DwmComposition");
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }

        private double _dwmMarginLeft = -1.0;
        public double DwmMarginLeft
        {
            get { return _dwmMarginLeft; }
            set
            { 
                _dwmMarginLeft = value;
                OnPropertyChanged("DwmMarginLeft");
            }
        }

        private double _dwmMarginTop = 0.0;
        public double DwmMarginTop
        {
            get { return _dwmMarginTop; }
            set 
            { 
                _dwmMarginTop = value;
                OnPropertyChanged("DwmMarginTop");
            }
        }

        private double _dwmMarginRight = 0.0;
        public double DwmMarginRight
        {
            get { return _dwmMarginRight; }
            set 
            {
                _dwmMarginRight = value;
                OnPropertyChanged("DwmMarginRight");
            }
        }

        private double _dwmMarginBottom = 0.0;
        public double DwmMarginBottom
        {
            get { return _dwmMarginBottom; }
            set 
            {
                _dwmMarginBottom = value;
                OnPropertyChanged("DwmMarginBottom");
            }
        }

        private RelayCommand _applyDwmOptionCommand;
        public RelayCommand ApplyDwmOptionCommand
        {
            get { return _applyDwmOptionCommand ?? (_applyDwmOptionCommand = new RelayCommand(ApplyDwmOption)); }
            set
            { 
                _applyDwmOptionCommand = value;
                OnPropertyChanged("ApplyDwmOptionCommand");
            }
        }
        
        private void ApplyDwmOption()
        {
            DwmComposition = new DwmCompositionOption(DwmMarginLeft, DwmMarginTop, DwmMarginRight, DwmMarginBottom, Colors.White);
        }
    }
}
