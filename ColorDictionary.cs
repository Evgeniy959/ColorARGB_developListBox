using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ColorARGB
{
    public class ColorDictionary
    {
        private ListBox _ListColor { get; set; }
        private TextBlock _BlockColor { get; set; }
        private Grid _ColorCol { get; set; }
        private ConverterToHex _Converter { get; set; }
        //private ViewColor _ColorViewOperations { get; set; }
        private MyColor _SelectedColor { get; set; }
        public Dictionary<string, MyColor> Colors { set; get; }
        public ColorDictionary(MyColor selectedColor, Grid colorCol, ListBox listColor, TextBlock blockColor)
        {
            //ElementCounter.Counter = default;
            _BlockColor = blockColor;
            _ListColor = listColor;
            _ColorCol = colorCol;
            _SelectedColor = selectedColor;
            _Converter = new ConverterToHex();
            //_ColorViewOperations = new ViewColor(_ColorCol, _Converter);
            //_ColorViewOperations = new ViewColor(/*_ColorCol,*/ _ListColor, _BlockColor, _Converter);
            Colors = new Dictionary<string, MyColor>();
            //_ColorViewOperations.ButtonDeletePressed += DeleteColor;
        }
        /*public void AddColor()
        {
            if (!Colors.ContainsKey(_Converter.ConvertToHEX(_SelectedColor)))
            {
                var color = _SelectedColor.Clone();
                Colors.Add(_Converter.ConvertToHEX(color), color);
                _ColorViewOperations.AddColorToScreen(Colors.Count, color, Colors);
                
            }
            else MainWindow.NotButtonEnabled?.Invoke();
        }*/

        /*public void DeleteColor(string str)
        {
            var subsDel = str.Split('_');
            Colors.Remove(subsDel[1]);
            _ColorViewOperations.UpdateColorOnScreen(Colors);
        }*/
    }
}
