using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.Defaults;
using LiveCharts;
using System.Windows.Media.Animation;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using LiveCharts.Configurations;
using LiveChartsCore.Geo;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using LiveChartsCore.Kernel.Sketches;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Media.Imaging;

namespace Livechart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public class PontosGrafico : INotifyPropertyChanged
    {
        public string label { get => _label; set { _label = value; OnPropertyChanged(); } }
        private string _label = "";

        public double X { get => _X; set { _X = value; OnPropertyChanged(); } }
        private double _X;

        public double Y { get => _Y; set { _Y = value; OnPropertyChanged(); } }
        private double _Y;
        public double PCritico { get => _PCritico; set { _PCritico = value; OnPropertyChanged(); } }
        private double _PCritico;
        public double PontoVazao { get => _PontoVazao; set { _PontoVazao = value; OnPropertyChanged(); } }
        private double _PontoVazao;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

    

    public partial class MainWindow : Window
    {

        public static double RFormula(int ID, int IDModelo, double VazaoProjeto = 0)
        {
            double Resultado = 0;

            // Globals iGlobals = Globals.GetInstance;

            // if (VazaoProjeto == 0)
            // VazaoProjeto = iGlobals.iRecalque.VazaoProjeto;

            switch (ID)
            {
                case 1: // BC-91 Schneider
                    if (IDModelo == 1) // 1/6CV  
                        Resultado = -0.0871 * Math.Pow(VazaoProjeto, 2) - 0.7096 * VazaoProjeto + 12.306;
                    else if (IDModelo == 2) // 1/4CV  
                        Resultado = -0.1194 * Math.Pow(VazaoProjeto, 2) - 0.4821 * VazaoProjeto + 14.582;
                    else if (IDModelo == 3) // 1/3CV  
                        Resultado = -0.1157 * Math.Pow(VazaoProjeto, 2) - 0.6036 * VazaoProjeto + 17.626;
                    else if (IDModelo == 4) // 1/2CV
                        Resultado = -0.2458 * Math.Pow(VazaoProjeto, 2) - 0.573 * VazaoProjeto + 21.386;
                    else if (IDModelo == 5) // 3/4CV
                        Resultado = -0.2874 * Math.Pow(VazaoProjeto, 2) - 0.518 * VazaoProjeto + 25.114;
                    else if (IDModelo == 6) // 1CV
                        Resultado = 0.0022 * Math.Pow(VazaoProjeto, 3) - 0.3034 * Math.Pow(VazaoProjeto, 2) - 0.5011 * VazaoProjeto + 27.536;
                    break;

                case 2: // BC-92 Schneider
                    if (IDModelo == 1) // 3/4CV A
                        Resultado = -0.0478 * Math.Pow(VazaoProjeto, 4) + 0.4798 * Math.Pow(VazaoProjeto, 3) - 1.7161 * Math.Pow(VazaoProjeto, 2) + 1.4419 * VazaoProjeto + 25.587;
                    else if (IDModelo == 2) // 1CV A
                        Resultado = -0.0607 * Math.Pow(VazaoProjeto, 4) + 0.6574 * Math.Pow(VazaoProjeto, 3) - 2.6641 * Math.Pow(VazaoProjeto, 2) + 3.5992 * VazaoProjeto + 28.818;
                    else if (IDModelo == 3) // 1,5CV A
                        Resultado = -0.0622 * Math.Pow(VazaoProjeto, 4) + 0.6218 * Math.Pow(VazaoProjeto, 3) - 2.2914 * Math.Pow(VazaoProjeto, 2) + 2.5336 * VazaoProjeto + 37.144;
                    else if (IDModelo == 4) // 1CV B
                        Resultado = -0.0146 * Math.Pow(VazaoProjeto, 2) - 0.3721 * VazaoProjeto + 19.95;
                    else if (IDModelo == 5) // 1,5CV B
                        Resultado = -0.0146 * Math.Pow(VazaoProjeto, 2) - 0.3954 * VazaoProjeto + 25.009;
                    else if (IDModelo == 6) // 2CV B 127mm
                        Resultado = -0.0147 * Math.Pow(VazaoProjeto, 2) - 0.4219 * VazaoProjeto + 29.776;
                    else if (IDModelo == 7) // 2CV B 137mm
                        Resultado = 0.0183 * Math.Pow(VazaoProjeto, 2) - 0.421 * VazaoProjeto + 34.203;
                    else if (IDModelo == 8) // 3CV B 143mm
                        Resultado = -0.017 * Math.Pow(VazaoProjeto, 2) - 0.4717 * VazaoProjeto + 37.591;
                    else if (IDModelo == 9) // 3CV B 155mm
                        Resultado = 0.0008 * Math.Pow(VazaoProjeto, 3) - 0.0392 * Math.Pow(VazaoProjeto, 2) - 0.3798 * VazaoProjeto + 44.356;
                    else if (IDModelo == 10) // 3/4CV C
                        Resultado = 0.0004 * Math.Pow(VazaoProjeto, 4) - 0.0131 * Math.Pow(VazaoProjeto, 3) + 0.0838 * Math.Pow(VazaoProjeto, 2) - 1.1788 * VazaoProjeto + 26.119;
                    else if (IDModelo == 11) // 1CV C 
                        Resultado = -0.0794 * Math.Pow(VazaoProjeto, 2) - 0.3633 * VazaoProjeto + 30.757;
                    else if (IDModelo == 12) // 1,5CV C
                        Resultado = -0.0991 * Math.Pow(VazaoProjeto, 2) - 0.2523 * VazaoProjeto + 34.831;
                    else if (IDModelo == 13) // 2CV C
                        Resultado = -0.1311 * Math.Pow(VazaoProjeto, 2) - 0.0244 * VazaoProjeto + 43.056;
                    else if (IDModelo == 14) // 3CV C
                        Resultado = -0.0589 * Math.Pow(VazaoProjeto, 2) * VazaoProjeto + 46.1;
                    else if (IDModelo == 15) // 1CV RF
                        Resultado = 5E-05 * Math.Pow(VazaoProjeto, 3) - 0.0117 * Math.Pow(VazaoProjeto, 2) - 0.1707 * VazaoProjeto + 14.262;
                    else if (IDModelo == 16) // 1,5CV RF
                        Resultado = -0.0094 * Math.Pow(VazaoProjeto, 2) - 0.2104 * VazaoProjeto + 19.056;
                    else if (IDModelo == 17) // 2CV RF
                        Resultado = -0.0092 * Math.Pow(VazaoProjeto, 2) - 0.2298 * VazaoProjeto + 23.259;
                    else if (IDModelo == 18) // 3CV RF
                        Resultado = -0.0091 * Math.Pow(VazaoProjeto, 2) - 0.2463 * VazaoProjeto + 28.266;
                    break;

                case 3: // BC-98 Schneider
                    if (IDModelo == 1) // 1/3CV
                        Resultado = -0.8308 * Math.Pow(VazaoProjeto, 2) + 0.1758 * VazaoProjeto + 17.955;
                    else if (IDModelo == 2) // 1/2CV
                        Resultado = 0.007 * Math.Pow(VazaoProjeto, 4) - 0.099 * Math.Pow(VazaoProjeto, 3) - 0.1553 * Math.Pow(VazaoProjeto, 2) - 0.5656 * VazaoProjeto + 20.048;
                    break;

                case 4: // BCS 255-355
                    if (IDModelo == 1) // 1/2CV
                        Resultado = -0.0015 * Math.Pow(VazaoProjeto, 2) - 0.227 * VazaoProjeto + 6.8725;
                    else if (IDModelo == 2) // 1CV
                        Resultado = -0.0015 * Math.Pow(VazaoProjeto, 2) - 0.0896 * VazaoProjeto + 9.4298;
                    else if (IDModelo == 3) // 2CV
                        Resultado = -0.0021 * Math.Pow(VazaoProjeto, 2) - 0.0598 * VazaoProjeto + 13.356;
                    else if (IDModelo == 4) // 3CV
                        Resultado = -0.0026 * Math.Pow(VazaoProjeto, 2) - 0.0341 * VazaoProjeto + 15.96;
                    break;
                case 5: // Brava
                    if (IDModelo == 1) // 1/3CV 
                        Resultado = -0.0014 * Math.Pow(VazaoProjeto, 3) - 0.0008 * Math.Pow(VazaoProjeto, 2) - 0.4501 * VazaoProjeto + 11.038;
                    else if (IDModelo == 2) // 1/5CV 
                        Resultado = -0.0373 * Math.Pow(VazaoProjeto, 2) - 0.3012 * VazaoProjeto + 15.072;
                    else if (IDModelo == 3) // 1CV
                        Resultado = -0.0033 * Math.Pow(VazaoProjeto, 2) + 0.0455 * Math.Pow(VazaoProjeto, 2) - 0.805 * VazaoProjeto + 18.077;
                    else if (IDModelo == 4) // 1,5CV
                        Resultado = -0.0061 * Math.Pow(VazaoProjeto, 2) - 0.1393 * VazaoProjeto + 19.934;
                    else if (IDModelo == 5) // 2CV
                        Resultado = -0.0071 * Math.Pow(VazaoProjeto, 2) - 0.1304 * VazaoProjeto + 25.691;
                    else if (IDModelo == 6) // 4CV
                        Resultado = -0.007 * Math.Pow(VazaoProjeto, 2) - 0.1484 * VazaoProjeto + 30.372;
                    break;
            }

            return Resultado > 0 ? Math.Round(Resultado, 2) : 0;
        }


        public static ObservablePoint[] Lista;
        public static ChartValues<PontosGrafico> List1Points = new ChartValues<PontosGrafico>(), List2Points = new ChartValues<PontosGrafico>(), List3Points = new ChartValues<PontosGrafico>(), PontoDeVazao = new ChartValues<PontosGrafico>();
        public ISeries[] Series { get; set; } =
        {

        new LineSeries<PontosGrafico>
        {
            Name = "Bomba",
            Values = List1Points,
            GeometryFill=null,
            GeometryStroke=null,
            Fill = null,
            ScalesYAt = 0,
            Stroke= new SolidColorPaint(new SKColor(0,0,139),4),
            Mapping = (city, point) =>
        {
            point.PrimaryValue = city.Y;
            point.SecondaryValue = city.X;
        }
        },
         new LineSeries<PontosGrafico>
        {
            Name = "Sistema",
            Fill = null,
            GeometryFill=null,
            GeometryStroke=null,
            ScalesYAt= 0,
            Stroke= new SolidColorPaint(new SKColor(230, 129, 0),4),
            Values = List2Points,
               Mapping = (city, point) =>
        {
            point.PrimaryValue = city.Y;
            point.SecondaryValue = city.X;
            point.TertiaryValue = city.PCritico;
        }
        },
           new LineSeries<PontosGrafico>
        {   Name = "Ponto de Interseção",
            Fill = null,
            GeometrySize=10,
            GeometryStroke=new SolidColorPaint(new SKColor(0,0,0),3),
            Values = List3Points,
               Mapping = (city, point) =>
        {
            point.PrimaryValue = city.Y;
            point.SecondaryValue = city.X;
        }
        },
             new LineSeries<PontosGrafico>
        {
            Name = "Vazão Projeto",
            Fill = null,
            GeometrySize=10,
            GeometryStroke=new SolidColorPaint(new SKColor(0, 0, 0),3),
            Values = PontoDeVazao,
               Mapping = (city, point) =>
        {
            point.PrimaryValue = city.Y;
            point.SecondaryValue = city.X;
        }
        },
        };
        public ICartesianAxis[] YAxes { get; set; } =
        {
                new Axis
        {
            Name = "Altura Manométrica",
            NameTextSize = 14,
            NamePaint = new SolidColorPaint(new SKColor(0,0,0)),
            TextSize = 12,
            ShowSeparatorLines = true,
            Position= 0

        },
       };
        public ICartesianAxis[] XAxes { get; set; } =
  {
               new Axis
        {
            Name = "Vazão (m³/h)",
            NameTextSize = 14,
            NamePaint = new SolidColorPaint(new SKColor(0,0,0)),
            TextSize = 12,
            ShowSeparatorLines = true,

        }
    };

        public class ModeloBombas : INotifyPropertyChanged
        {
            public int ID;
            public int IDModelo;
            public string modelo;
            public string potencia;
            public BitmapImage Imagem;
            public double Formula { get => RFormula(ID, IDModelo); }
            public double vazaoTrabalho;
            public event PropertyChangedEventHandler PropertyChanged;

            public double VazaoTrabalho
            {
                get => vazaoTrabalho;
                set
                {
                    if (vazaoTrabalho != value)
                    {
                        vazaoTrabalho = value;
                        NotifyPropertyChanged();
                    }
                }
            }
            public string Potencia
            {
                get => potencia;
                set
                {
                    if (potencia != value)
                    {
                        potencia = value;
                        NotifyPropertyChanged();
                    }
                }
            }
            public string Modelo
            {
                get => modelo;
                set
                {
                    if (modelo != value)
                    {
                        modelo = value;
                        NotifyPropertyChanged();
                    }
                }
            }
            public void NotifyPropertyChanged([CallerMemberName] string propName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
            }
        }

        public ObservableCollection<ModeloBombas> bombas { get; set; }
        public MainWindow()
        {
            

           

            var ponto3 = new PontosGrafico() { X = 2, Y = Constante(3, 2, 3 + 2, 32, 0.5, 40), label = "" };
            PontoDeVazao.Add(ponto3);


            for (double x = 0; x < 10; x += 0.001)
            {
                var ponto = new PontosGrafico() { X = x, Y = RFormula(1, 6, x), label = "" };
                if (ponto.Y > 0)
                    List1Points.Add(ponto);
            }
            for (double y = 0; y < 10; y += 0.001)
            {
                double valor = Constante(3, 2, 3 + y, 32, 0.5, 40);

                var ponto2 = new PontosGrafico() { X = y, Y = valor, label = "" };

                List2Points.Add(ponto2);
            }

            double inter = 0;

            for (int x = 0; x < List1Points.Count; x++)
            {
                double r = (List1Points[x].Y - List2Points[x].Y);

                if (r < 0)
                    r = -(r);

                if (r < 0.01)
                {
                    inter = List2Points[x].X;
                    List2Points[x].PCritico = inter;
                    List3Points.Add(List2Points[x]);
                    List3Points.First().X = inter;
                    break;

                }
            }


            InitializeComponent();
            DataContext = this;
            bombas = new ObservableCollection<ModeloBombas>();
            bombas.Add(new ModeloBombas { ID = 1, IDModelo = 6, Modelo = "BC91", Potencia = "1cv", Imagem = new BitmapImage(new Uri(@"/Resources/BC91_imagem.bmp", UriKind.RelativeOrAbsolute)), VazaoTrabalho = 0 });
            bombas.Add(new ModeloBombas { ID = 2, IDModelo = 2, Modelo = "BC92", Potencia = "1cv", Imagem = new BitmapImage(new Uri(@"/Resources/BC92_imagem.bmp", UriKind.RelativeOrAbsolute)), VazaoTrabalho = 0 });

        }



        public static double Constante(double N1, double N2, double Vazao, double N4, double Recalque, double Succao)
        {
            double Resultado = N1 + N2 + Math.Pow(8.69, 6) * Math.Pow(Vazao * 3.6, 1.75) * Math.Pow(N4, -4.75) * Recalque + Math.Pow(8.69, 6) * Math.Pow(Vazao * 3.6, 1.75) * Math.Pow(Succao, -4.75);

            return Math.Round(Resultado, 2);

        }


    }
}
