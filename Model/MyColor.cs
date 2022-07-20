using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using static ColorARGB.MainWindow;

namespace ColorARGB
{
    public class MyColor : ObservableObject
    {
        private Brush brush;
        private byte alpha;
        private byte red;
        private byte green;
        private byte blue;

        public Brush Brush
        {
            get { return brush; }
            set
            {
                if (brush != value)
                {
                    brush = value;
                    OnPropertyChanged(nameof(Brush));
                }
            }
        }
        public MyColor()
        {
            this.PropertyChanged += MyColor_PropertyChanged;
        }

        private void MyColor_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Alpha" || e.PropertyName == "Red" || e.PropertyName == "Blue" || e.PropertyName == "Green")
                Brush = new SolidColorBrush(Color.FromArgb(Alpha, Red, Green, Blue));
        }
        public byte Alpha
        {
            get { return alpha; }
            set
            {
                if (alpha != value)
                {
                    alpha = value;
                    OnPropertyChanged(nameof(Alpha));
                }
            }
        }
        public byte Red
        { 
            get { return red; }
            set
            {
                if (red != value)
                {
                    red = value;
                    OnPropertyChanged(nameof(Red));
                }
            }
        }
        public byte Green
        {
            get { return green; }
            set
            {
                if (green != value)
                {
                    green = value;
                    OnPropertyChanged(nameof(Green));
                }
            }
        }
        public byte Blue
        {
            get { return blue; }
            set
            {
                if (blue != value)
                {
                    blue = value;
                    OnPropertyChanged(nameof(Blue));
                }
            }
        }
        public MyColor Clone()
        {
            return new MyColor { Red = this.Red, Green = this.Green, Blue = this.Blue, Alpha = this.Alpha, Brush = this.Brush.Clone() };
        }
    }
}
