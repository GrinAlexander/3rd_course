using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace KP_WPF
{
    public static class Theme
    {
        public static Brush background = Brushes.White;

        public static Brush ChangeTheme(int index)
        {

            switch (index)
            {
                case 0:
                    {
                        background = Brushes.DarkGray;
                        break;
                    }
                case 1:
                    {
                        background = Brushes.White;
                        break;
                    }
                case 2:
                    {
                        background = Brushes.LightBlue;
                        break;
                    }
                default:
                    break;
            }
            return background;
        }
    }
}