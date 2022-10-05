using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.Defaults;

namespace Livechart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class ViewModel
    {
        public ISeries[] Series { get; set; } =
        {
        new LineSeries<ObservablePoint>
        {
            Values = ObservablePoint[]
            {
              
            }
        }
    };
    }
    public partial class MainWindow : Window
    {
        public IList<ObservablePoint> Lista = new List<ObservablePoint>();

        public ISeries[] Series { get; set; } =
        {
        new LineSeries<ObservablePoint>
        {
            Values = Lista
            {
                
            }
        }
            };

        public double Vazao(double valor)
        {
            double resultado = 0;
            resultado = -0.0871 * Math.Pow(valor, 2) - 0.7096 * valor + 12.306;
            return resultado;
        }
        public MainWindow()
        {
            var viewModel = new ViewModel();

            for (int x = 0; x < 10; x++)
            {
                var ponto = new ObservablePoint(x, Vazao(x));

                Lista.Add(ponto);
            }

            InitializeComponent();
            DataContext = viewModel;
        }
    }
}



// BC 91 1/6cv{
//                new ObservablePoint(0.91, 11.57),
//                new ObservablePoint(1.16, 11.38),
//                new ObservablePoint(1.45, 11.05),
//                new ObservablePoint(1.68, 10.86),
//                new ObservablePoint(1.89, 10.67)
//                new ObservablePoint(2.09, 10.47)
//                new ObservablePoint(2.33, 10.21)
//                new ObservablePoint(2.55, 9.95)
//                new ObservablePoint(2.81, 9.63)
//                new ObservablePoint(3.08, 9.31)
//                new ObservablePoint(3.33, 8.98)
//                new ObservablePoint(3.61, 8.60)
//                new ObservablePoint(3.85, 8.27)
//                new ObservablePoint(4.05, 8.02)
//                new ObservablePoint(4.32, 7.56)
//                new ObservablePoint(4.54, 7.30)
//                new ObservablePoint(4.79, 6.92)
//                new ObservablePoint(5.06, 6.46)
//                new ObservablePoint(5.31, 6.08)
//                new ObservablePoint(5.58, 5.62)
//                new ObservablePoint(5.83, 5.24)
//                new ObservablePoint(6.11, 4.72)
//                new ObservablePoint(6.38, 4.20)
//                new ObservablePoint(6.61, 3.81)
//                new ObservablePoint(6.85, 3.36)
//                new ObservablePoint(7.09, 2.91)
//                new ObservablePoint(7.29, 2.52)
//                new ObservablePoint(7.54, 2.00)



//new ObservablePoint(0.94    14.03)
//new ObservablePoint(1.19    13.83)
//new ObservablePoint(1.46    13.64)
//new ObservablePoint(1.73    13.38)
//new ObservablePoint(2.03    13.12)
//new ObservablePoint(2.33    12.80)
//new ObservablePoint(2.62    12.48)
//new ObservablePoint(2.92    12.15)
//new ObservablePoint(3.25    11.76)
//new ObservablePoint(3.61    11.31)
//new ObservablePoint(3.90    10.86)
//new ObservablePoint(4.20    10.47)
//new ObservablePoint(4.49    10.02)
//new ObservablePoint(4.79    9.50)
//new ObservablePoint(5.12    8.98)
//new ObservablePoint(5.45    8.40)
//new ObservablePoint(5.75    7.89)
//new ObservablePoint(6.02    7.37)
//new ObservablePoint(6.24    6.92)
//new ObservablePoint(6.47    6.46)
//new ObservablePoint(6.77    5.82)
//new ObservablePoint(7.02    5.30)
//new ObservablePoint(7.26    4.78)
//new ObservablePoint(7.49    4.27)
//new ObservablePoint(7.75    3.68)
//new ObservablePoint(8.00    3.10)
//new ObservablePoint(8.20    2.59)
//new ObservablePoint(8.47,1.94)
