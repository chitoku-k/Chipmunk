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
                OnPropertyChanged(nameof(IsMinimizeButtonEnabled));
            }
        }

        private bool _isMaximizeButtonEnabled = false;
        public bool IsMaximizeButtonEnabled
        {
            get { return _isMaximizeButtonEnabled; }
            set 
            { 
                _isMaximizeButtonEnabled = value;
                OnPropertyChanged(nameof(IsMaximizeButtonEnabled));
            }
        }

        private bool _isHelpButtonEnabled = false;
        public bool IsHelpButtonEnabled
        {
            get { return _isHelpButtonEnabled; }
            set 
            { 
                _isHelpButtonEnabled = value;
                OnPropertyChanged(nameof(IsHelpButtonEnabled));
            }
        }

        private bool _isCloseButtonEnabled = true;
        public bool IsCloseButtonEnabled
        {
            get { return _isCloseButtonEnabled; }
            set 
            { 
                _isCloseButtonEnabled = value;
                OnPropertyChanged(nameof(IsCloseButtonEnabled));
            }
        }

        private bool _isControlButtonVisible = true;
        public bool IsControlButtonVisible
        {
            get { return _isControlButtonVisible; }
            set
            {
                _isControlButtonVisible = value;
                OnPropertyChanged(nameof(IsControlButtonVisible));
            }
        }

        private DwmCompositionOption _dwmComposition = new DwmCompositionOption(-1, 0, 0, 0, Colors.White);
        public DwmCompositionOption DwmComposition
        {
            get { return _dwmComposition; }
            set
            {
                _dwmComposition = value;
                OnPropertyChanged(nameof(DwmComposition));
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private double _dwmMarginLeft = -1.0;
        public double DwmMarginLeft
        {
            get { return _dwmMarginLeft; }
            set
            { 
                _dwmMarginLeft = value;
                OnPropertyChanged(nameof(DwmMarginLeft));
            }
        }

        private double _dwmMarginTop = 0.0;
        public double DwmMarginTop
        {
            get { return _dwmMarginTop; }
            set 
            { 
                _dwmMarginTop = value;
                OnPropertyChanged(nameof(DwmMarginTop));
            }
        }

        private double _dwmMarginRight = 0.0;
        public double DwmMarginRight
        {
            get { return _dwmMarginRight; }
            set 
            {
                _dwmMarginRight = value;
                OnPropertyChanged(nameof(DwmMarginRight));
            }
        }

        private double _dwmMarginBottom = 0.0;
        public double DwmMarginBottom
        {
            get { return _dwmMarginBottom; }
            set 
            {
                _dwmMarginBottom = value;
                OnPropertyChanged(nameof(DwmMarginBottom));
            }
        }

        private RelayCommand _applyDwmOptionCommand;
        public RelayCommand ApplyDwmOptionCommand
        {
            get { return _applyDwmOptionCommand ?? (_applyDwmOptionCommand = new RelayCommand(ApplyDwmOption)); }
            set
            { 
                _applyDwmOptionCommand = value;
                OnPropertyChanged(nameof(ApplyDwmOptionCommand));
            }
        }
        
        private void ApplyDwmOption() => this.DwmComposition = new DwmCompositionOption(this.DwmMarginLeft, this.DwmMarginTop, this.DwmMarginRight, this.DwmMarginBottom, Colors.White);
    }
}
