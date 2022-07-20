using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using static ColorARGB.MainWindow;

namespace ColorARGB
{
    public class ViewModels : ObservableObject
    {
        private MyColor selectedColor;
        public event ButtonDeletePressedHandler ButtonDeletePressed;
        //public static ButtonAddPressedHandler ButtonPressed;
        private Grid _ColorCol { get; set; }
        public ListBox ListColor { get; set; }
        public TextBlock BlockColor { get; set; }
        private ConverterToHex _Converter { get; set; }
        public ColorDictionary showColor { get; set; }
        public static ObservableCollection<Grid> Colors { set; get; }
        //ObservableCollection<Grid> Colors;

        public ViewModels(ListBox listColor, TextBlock blockColor )
        {
            Colors = new ObservableCollection<Grid>();
            ConverterToHex converter = new ConverterToHex();
            ListColor = listColor;
            BlockColor = blockColor;
            ListColor.ItemsSource = Colors;
            _Converter = converter;
            SelectedColor = new MyColor { Alpha = 127, Red = 255, Green = 255, Blue = 0 };
            ButtonDeletePressed += DeleteCol;
            //ButtonPressed += AddColorToScreen; // При вызове делегата здесь отрабатывает так же как и при вызове в MainWindow             
        }
        public MyColor SelectedColor
        {
            get { return selectedColor; }
            set
            {
                if (selectedColor != value)
                {
                    selectedColor = value;
                    OnPropertyChanged(nameof(SelectedColor));
                }
            }
        }
        public ICommand AddButtonColor
        {
            get
            {
                return new ButtonsCommand(
              () =>
              {
                  //if (!ListColor.Items.Contains(_Converter.ConvertToHEX(SelectedColor)))                  
                   AddColorToScreen();
                  //else MainWindow.NotButtonEnabled?.Invoke();
                  //ButtonPressed?.Invoke();
              }
              );
            }
        }
        public void AddColorToScreen()
        {
            _ColorCol = new Grid();
            _ColorCol.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(100) });
            _ColorCol.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(350) });
            _ColorCol.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(100) });
            for (int i = 0; i < 3; i++)
            {
                var info = new StackPanel();
                info.Orientation = Orientation.Horizontal;
                Grid.SetColumn(info, i);
                if (i == 0) info.Children.Add(new Label { Margin = new Thickness(10, 10, 10, 10), MinWidth = 80, Name = "Del", Content = $"#{_Converter.ConvertToHEX(SelectedColor)}" });
                if (i == 1) info.Children.Add(new TextBlock { Margin = new Thickness(10, 10, 10, 10), MinWidth = 330, MinHeight = 30, Background = BlockColor.Background });
                if (i == 2) info.Children.Add(new Button { Margin = new Thickness(10, 10, 10, 10), MinWidth = 80, MinHeight = 30, Content = "Delete", /*Name = "Del"*/ Name = $"b_{_Converter.ConvertToHEX(SelectedColor)}_b" });
                _ColorCol.Children.Add(info);
                foreach (var item in info.Children)
                {
                    if (item is Button)
                    {
                        (item as Button).Click += DeleteButton_Click;
                    }
                }

            }
            //if (!Colors.Contains(_ColorCol))
            if (!_ColorCol.)
                //if (_ColorCol.Children.Contains( ))
                //if (ListColor.Items.Count<1)
                //if (ColorCol.Background!= ListColor.Items.Contains(Backgroun))
                    Colors.Add(_ColorCol);
            else MainWindow.NotButtonEnabled?.Invoke();

        }

        public void DeleteCol()
        {
            for (int i = 0; i < Colors.Count; i++)
            {
                if (ListColor.SelectedIndex+1 == i)
                Colors[i].Children.Clear();

            }
            
            /*foreach (var col in Colors) 
            {
                if(col.Name.Contains(ListColor.SelectedItem.ToString()))
                    _ColorCol.Children.Clear();
            }*/

        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            ButtonDeletePressed?.Invoke();
        }

    }
}
