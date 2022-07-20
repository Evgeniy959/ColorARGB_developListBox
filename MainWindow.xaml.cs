using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ColorARGB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public delegate void ButtonAddPressedHandler();
    //public delegate void ButtonDeletePressedHandler(string str);
    public delegate void ButtonDeletePressedHandler();
    public delegate void IsButtonEnabledHandler();
    public delegate void NotButtonEnabledHandler();
    public partial class MainWindow : Window
    {
        //public static ButtonAddPressedHandler ButtonPressed;
        public static IsButtonEnabledHandler IsButtonEnabled;
        public static NotButtonEnabledHandler NotButtonEnabled;
        //public event ButtonDeletePressedHandler ButtonDeletePressed;
        //public static ObservableCollection<Grid> Colors { set; get; }
        //public static Dictionary<string, MyColor> colors { set; get; }
        //private MyColor color { get; set; }
        public MyColor color { get; set; }
        //private Grid _ColorCol { get; set; }
        private ConverterToHex _Converter { get; set; }
        private ListBox _ListColor { get; set; }
        private TextBlock _BlockColor { get; set; }
        //private ViewColor _ColorViewOperations { get; set; }
        //public ViewModels _ColorViewOperations { get; set; }

        //public MainWindow(Grid colorCol, ListBox listColor, TextBox blockColor, ConverterToHex converter)
        public MainWindow()
        {
            InitializeComponent();
            _Converter = new ConverterToHex();
            //_Converter = converter;
            _BlockColor = BlockColor;
            _ListColor = ListColor;
            //_ColorCol = new Grid();
            //DataContext = new ViewModels();
            this.DataContext = new ViewModels(_ListColor, _BlockColor);
            //this.DataContext = new ViewModels();
            IsButtonEnabled += IsEnable;
            NotButtonEnabled += NotEnable;
            //Colors = new ObservableCollection<Grid>();
            //colors = new Dictionary<string, MyColor>();
            //_ColorCol = new Grid();
            //ListColor.ItemsSource = Colors;
            //var _Converter = new ConverterToHex();
            //ListColor.ColorCol.
            MyColor color = new MyColor();
            //ButtonDeletePressed += DeleteCol;
            //_ColorViewOperations = new ViewColor(/*_ColorCol,*/ _ListColor, _BlockColor, _Converter);
            //_ColorViewOperations = new ViewModels(_ListColor, _BlockColor);
            //ButtonPressed += _ColorViewOperations.AddColorToScreen;

        }

        //private void AddButton_Click(object sender, RoutedEventArgs e)
        //{
        //    //ButtonPressed?.Invoke();
        //    _ColorViewOperations.AddColorToScreen();
        //    /*_ColorCol = new Grid();
        //    _ColorCol.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(100) });
        //    _ColorCol.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(350) });
        //    _ColorCol.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(100) });
        //    for (int i = 0; i < 3; i++)
        //    {
        //        var info = new StackPanel();
        //        info.Orientation = Orientation.Horizontal;
        //        Grid.SetColumn(info, i);
        //        if (i == 0) info.Children.Add(new Label { Margin = new Thickness(10, 10, 10, 10), MinWidth = 80, Content = "#X567F" });
        //        if (i == 1) info.Children.Add(new TextBlock { Margin = new Thickness(10, 10, 10, 10), MinWidth = 330, MinHeight = 30, Background = BlockColor.Background });
        //        if (i == 2) info.Children.Add(new Button { Margin = new Thickness(10, 10, 10, 10), MinWidth = 80, MinHeight = 30, Content = "Delete", Name = "Del",  /*$"b_{_Converter.ConvertToHEX(color)}_b"*/ /* });
        //        _ColorCol.Children.Add(info);
        //        /*foreach (var item in info.Children)
        //        {
        //            if (item is Button)
        //            {
        //                (item as Button).Click += DeleteButton_Click;
        //            }
        //        }

        //    }
        //    Colors.Add(_ColorCol);*/

        //}
        /*private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //ButtonDeletePressed?.Invoke((sender as Button).Name);
            ButtonDeletePressed?.Invoke();
            //ListColor.Items.Clear();
            /*var selected = (sender as ListBox).SelectedItem as string;
            selected.Contains("");*/
            /*if (selected is ListBoxItem)
            {
                var msg = (selected as ListBoxItem).Content;
                msg.Clear();
            }
        }*/
        //public void DeleteCol(string str)
        
        private void IsEnable()
        {
            Add.IsEnabled = true;
        }
        private void NotEnable()
        {
            Add.IsEnabled = false;
        }
        private Grid Clone()
        {
            return new Grid(); 
        }


    }
}
