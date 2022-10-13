using System.Windows.Media;
using System.ComponentModel;
namespace WpfApp10_02_ViewModel
{
    public class ViewModelRGB : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public RGBModel model;
        public ViewModelRGB()
        {
            model = new RGBModel { R = 0, G = 0, B = 0, A = 255, color = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0)) };
        }
        public int _R
        {
            get { return model.R; }
            set
            {
                model.R = value;
                OnPropertyChanged("_R");
                _SetColor();
            }
        }
        public int _G
        {
            get { return model.G; }
            set
            {
                model.G = value;
                OnPropertyChanged("_G");
                _SetColor();
            }
        }
        public int _B
        {
            get { return model.B; }
            set
            {
                model.B = value;
                OnPropertyChanged("_B");
                _SetColor();
            }
        }
        public int _A
        {
            get { return model.A; }
            set
            {
                model.A = value;
                OnPropertyChanged("_A");
                _SetColor();
            }
        }
        public SolidColorBrush _Color
        {
            get { return model.color; }
            set
            {
                model.color = value;
                OnPropertyChanged("_Color");
            }
        }
        public void _SetColor()
        {
            _Color = new SolidColorBrush(Color.FromArgb((byte)model.A, (byte)model.R, (byte)model.G, (byte)model.B));
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                this.PropertyChanged(this, e);
            }
        }
    }
}
