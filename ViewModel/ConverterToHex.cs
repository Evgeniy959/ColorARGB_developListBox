using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorARGB
{
    public class ConverterToHex
    {
        public string ConvertToHEX(MyColor selectedColor)
        {
            return $"{Convert.ToInt32(selectedColor.Alpha).ToString("X")}{Convert.ToInt32(selectedColor.Red).ToString("X")}{Convert.ToInt32(selectedColor.Green).ToString("X")}{Convert.ToInt32(selectedColor.Blue).ToString("X")}";
        }
    }
}
