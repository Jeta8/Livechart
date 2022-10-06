﻿using System;
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

namespace Livechart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public static ObservablePoint[] Lista;
        public static ChartValues<ObservablePoint> List1Points = new ChartValues<ObservablePoint>(), List2Points = new ChartValues<ObservablePoint>();
        public ISeries[] Series { get; set; } =
        {
        new LineSeries<ObservablePoint>
        {
            Values = List1Points,
            Fill = null,
            GeometryFill = null,
            GeometryStroke = null
        },
         new LineSeries<ObservablePoint>
        {
            Values = List2Points,
            Fill = null,
            GeometryFill = null,
            GeometryStroke = null
        }
        };




        public MainWindow()
        {
            for (double x = 0; x < 10; x += 0.001)
            {
                var ponto = new ObservablePoint(x, RFormula(1, 6, x));

                List1Points.Add(ponto);
            }
            for (double y = 0; y < 10; y += 0.001)
            {
                double valor = Constante(3, 2, 3 + y, 32, 0.5, 40);

                var ponto2 = new ObservablePoint(y, valor);

                List2Points.Add(ponto2);


            }
            double inter = 0;

            for (int x = 0; x < List1Points.Count; x++)
            {
                double r = (List1Points[x].Y.Value - List2Points[x].Y.Value);

                if (r < 0)
                    r = -(r);

                if (r < 0.01)
                   inter = List2Points[x].X.Value;
            }


            InitializeComponent();
            DataContext = this;
        }



        public static double Constante(double N1, double N2, double Vazao, double N4, double Recalque, double Succao)
        {
            double Resultado = N1 + N2 + Math.Pow(8.69, 6) * Math.Pow(Vazao * 3.6, 1.75) * Math.Pow(N4, -4.75) * Recalque + Math.Pow(8.69, 6) * Math.Pow(Vazao * 3.6, 1.75) * Math.Pow(Succao, -4.75);

            return Resultado;
            // N3 = vazão
            // N5 = altura de recalque
        }







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

            return Math.Round(Resultado, 2);
        }
    }
}
