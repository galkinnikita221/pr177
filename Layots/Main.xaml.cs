using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Pizza_Galkin.Layots
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public Main()
        {
            InitializeComponent();
        }
        public void CreatePizza()
        {
            for (int i = 0; i < dishs.Count; i++)
            {
                var bc = new BrushConverter();
                Grid global = new Grid();
                global.Height = 100;
                global.Background = (Brush)bc.ConvertFrom("#FFECECEC");
                if (i > 0) global.Margin = new Thickness(0, 10, 0, 0);
                Image logo = new Image();
                if (File.Exists(mainWindow.localPath + @"\Img\dish\" + dishs[i].img + @".png"))
                    logo.Source = new BitmapImage(new Uri(mainWindow.localPath + @"\Img\dish\" + ".png"));
                else
                    logo.Source = new BitmapImage(new Uri(mainWindow.localPath + @"\Img\icon.png"));
            }
        }
    }
}
