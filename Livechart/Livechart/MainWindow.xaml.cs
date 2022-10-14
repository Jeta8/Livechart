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
using System.Windows.Controls;

namespace Livechart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public sealed class Bombas
    {
        private static readonly Bombas _instance = new Bombas();
        public static Bombas GetInstance
        {
            get
            {
                return _instance;
            }
        }
        IList<cBombas> BombasDisponiveis = new List<cBombas>();
        private Bombas()
        {
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BC-91", ID = 1, IDModelo = 1, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BC-91.bmp", UriKind.Absolute)) } });
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BC-91", ID = 1, IDModelo = 2, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BC-91.bmp", UriKind.Absolute)) } });
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BC-91", ID = 1, IDModelo = 3, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BC-91.bmp", UriKind.Absolute)) } });
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BC-91", ID = 1, IDModelo = 4, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BC-91.bmp", UriKind.Absolute)) } });
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BC-91", ID = 1, IDModelo = 5, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BC-91.bmp", UriKind.Absolute)) } });
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BC-91", ID = 1, IDModelo = 6, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BC-91.bmp", UriKind.Absolute)) } });

            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BC-92", ID = 2, IDModelo = 1, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BC-92.bmp", UriKind.Absolute)) } });
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BC-92", ID = 2, IDModelo = 2, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BC-92.bmp", UriKind.Absolute)) } });
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BC-92", ID = 2, IDModelo = 3, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BC-92.bmp", UriKind.Absolute)) } });
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BC-92", ID = 2, IDModelo = 4, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BC-92.bmp", UriKind.Absolute)) } });
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BC-92", ID = 2, IDModelo = 5, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BC-92.bmp", UriKind.Absolute)) } });
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BC-92", ID = 2, IDModelo = 6, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BC-92.bmp", UriKind.Absolute)) } });
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BC-92", ID = 2, IDModelo = 7, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BC-92.bmp", UriKind.Absolute)) } });
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BC-92", ID = 2, IDModelo = 8, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BC-92.bmp", UriKind.Absolute)) } });
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BC-92", ID = 2, IDModelo = 9, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BC-92.bmp", UriKind.Absolute)) } });
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BC-92", ID = 2, IDModelo = 10, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BC-92.bmp", UriKind.Absolute)) } });
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BC-92", ID = 2, IDModelo = 11, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BC-92.bmp", UriKind.Absolute)) } });
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BC-92", ID = 2, IDModelo = 12, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BC-92.bmp", UriKind.Absolute)) } });
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BC-92", ID = 2, IDModelo = 13, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BC-92.bmp", UriKind.Absolute)) } });
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BC-92", ID = 2, IDModelo = 14, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BC-92.bmp", UriKind.Absolute)) } });
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BC-92", ID = 2, IDModelo = 15, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BC-92.bmp", UriKind.Absolute)) } });
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BC-92", ID = 2, IDModelo = 16, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BC-92.bmp", UriKind.Absolute)) } });
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BC-92", ID = 2, IDModelo = 17, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BC-92.bmp", UriKind.Absolute)) } });
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BC-92", ID = 2, IDModelo = 18, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BC-92.bmp", UriKind.Absolute)) } });

            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BC-98", ID = 3, IDModelo = 1, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BC-98.bmp", UriKind.Absolute)) } });
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BC-98", ID = 3, IDModelo = 2, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BC-98.bmp", UriKind.Absolute)) } });
          
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BCS-255-355", ID = 4,Submersivel = true, IDModelo = 1, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BCS-255-355.bmp", UriKind.Absolute)) } });
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BCS-255-355", ID = 4, Submersivel = true, IDModelo = 2, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BCS-255-355.bmp", UriKind.Absolute)) } });
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BCS-255-355", ID = 4, Submersivel = true, IDModelo = 3, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BCS-255-355.bmp", UriKind.Absolute)) } });
            BombasDisponiveis.Add(new cBombas { NomeMarca = "Schneider", Bomba = new ModelosBombas { Modelo = "BCS-255-355", ID = 4, Submersivel = true, IDModelo = 4, ImagemBomba = new BitmapImage(new Uri("pack://application:,,,/UnMEP;component/Resources/Bombas/BCS-255-355.bmp", UriKind.Absolute)) } });


        }
        public static double RFormula(int ID, int IDModelo, double VazaoProjeto = 0)
        {
            double Resultado = 0;
            //Formulas para as bombas
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

                case 4: // Schneider BCS 255-355
                    if (IDModelo == 1) // 1/2CV
                        Resultado = -0.0015 * Math.Pow(VazaoProjeto, 2) - 0.227 * VazaoProjeto + 6.8725;
                    else if (IDModelo == 2) // 1CV
                        Resultado = -0.0015 * Math.Pow(VazaoProjeto, 2) - 0.0896 * VazaoProjeto + 9.4298;
                    else if (IDModelo == 3) // 2CV
                        Resultado = -0.0021 * Math.Pow(VazaoProjeto, 2) - 0.0598 * VazaoProjeto + 13.356;
                    else if (IDModelo == 4) // 3CV
                        Resultado = -0.0026 * Math.Pow(VazaoProjeto, 2) - 0.0341 * VazaoProjeto + 15.96;
                    break;

                case 5: // Schneider Brava
                    if (IDModelo == 1) // 1/3CV 
                        Resultado = -0.0014 * Math.Pow(VazaoProjeto, 3) - 0.0008 * Math.Pow(VazaoProjeto, 2) - 0.4501 * VazaoProjeto + 11.038;
                    else if (IDModelo == 2) // 1/2CV 
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

                case 6: // Ebara B-10
                    if (IDModelo == 1) // 1/4CV 
                        Resultado = -0.0095 * Math.Pow(VazaoProjeto, 4) - 0.0748 * Math.Pow(VazaoProjeto, 3) - 0.3394 * Math.Pow(VazaoProjeto, 2) - 0.6889 * VazaoProjeto + 14.231;
                    else if (IDModelo == 2) // 1/3CV
                        Resultado = -0.0158 * Math.Pow(VazaoProjeto, 3) - 0.041 * Math.Pow(VazaoProjeto, 2) - 1.2417 * VazaoProjeto + 18.138;
                    else if (IDModelo == 3) // 1/2CV
                        Resultado = -0.0186 * Math.Pow(VazaoProjeto, 3) - 0.037 * Math.Pow(VazaoProjeto, 2) - 1.5674 * VazaoProjeto + 20.962;
                    break;

                case 7: // Ebara B-13 
                    if (IDModelo == 1) // 3/4CV
                        Resultado = 0.0088 * Math.Pow(VazaoProjeto, 4) - 0.1811 * Math.Pow(VazaoProjeto, 3) + 0.8314 * Math.Pow(VazaoProjeto, 2) - 2.2344 * VazaoProjeto + 24.821;
                    else if (IDModelo == 2) // 1CV
                        Resultado = -0.0429 * Math.Pow(VazaoProjeto, 3) + 0.2338 * Math.Pow(VazaoProjeto, 2) - 1.472 * VazaoProjeto + 28.653;
                    break;

                case 8: // Ebara B-15
                    if (IDModelo == 1) // 1,5CV
                        Resultado = 0.0025 * Math.Pow(VazaoProjeto, 4) - 0.0791 * Math.Pow(VazaoProjeto, 3) + 0.2989 * Math.Pow(VazaoProjeto, 2) - 0.572 * VazaoProjeto + 34.955;
                    else if (IDModelo == 2) // 2CV
                        Resultado = -0.0101 * Math.Pow(VazaoProjeto, 3) - 0.2099 * Math.Pow(VazaoProjeto, 2) + 0.3216 * VazaoProjeto + 40.382;
                    break;

                case 9: // Famac FGN 0-1
                    if (IDModelo == 1) // 1/3CV
                        Resultado = -0.0224 * Math.Pow(VazaoProjeto, 4) + 0.2685 * Math.Pow(VazaoProjeto, 3) - 1.3235 * Math.Pow(VazaoProjeto, 2) + 0.7391 * VazaoProjeto + 24.314;
                    else if (IDModelo == 2) // 1/2CV
                        Resultado = -0.078 * Math.Pow(VazaoProjeto, 3) + 0.3605 * Math.Pow(VazaoProjeto, 2) - 2.1879 * VazaoProjeto + 29.84;
                    else if (IDModelo == 3) // 3/4CV
                        Resultado = -0.0181 * Math.Pow(VazaoProjeto, 6) + 0.6052 * Math.Pow(VazaoProjeto, 5) - 8.0277 * Math.Pow(VazaoProjeto, 4) + 53.961 * Math.Pow(VazaoProjeto, 3) - 194 * Math.Pow(VazaoProjeto, 2) + 352.54 * VazaoProjeto - 224.94;
                    else if (IDModelo == 4) // 1CV
                        Resultado = -0.0169 * Math.Pow(VazaoProjeto, 6) + 0.5455 * Math.Pow(VazaoProjeto, 5) - 6.9522 * Math.Pow(VazaoProjeto, 4) + 44.596 * Math.Pow(VazaoProjeto, 3) - 151.99 * Math.Pow(VazaoProjeto, 2) + 259.54 * VazaoProjeto - 140.55;
                    else if (IDModelo == 5) // 1,5CV
                        Resultado = -0.0385 * Math.Pow(VazaoProjeto, 6) + 1.2034 * Math.Pow(VazaoProjeto, 5) - 14.982 * Math.Pow(VazaoProjeto, 4) + 94.866 * Math.Pow(VazaoProjeto, 3) - 323.02 * Math.Pow(VazaoProjeto, 2) + 561.51 * VazaoProjeto - 350.15;
                    break;

                case 10: // Famac FGN 2
                    if (IDModelo == 1) // 3/4CV
                        Resultado = -8E-05 * Math.Pow(VazaoProjeto, 5) + 0.005 * Math.Pow(VazaoProjeto, 4) - 0.1102 * Math.Pow(VazaoProjeto, 3) + 1.0943 * Math.Pow(VazaoProjeto, 2) - 5.6241 * VazaoProjeto + 30.725;
                    else if (IDModelo == 2) // 1CV
                        Resultado = -0.0003 * Math.Pow(VazaoProjeto, 4) + 0.0161 * Math.Pow(VazaoProjeto, 3) - 0.3378 * Math.Pow(VazaoProjeto, 2) + 1.8688 * VazaoProjeto + 20.601;
                    else if (IDModelo == 3) // 1,5CV
                        Resultado = -0.0024 * Math.Pow(VazaoProjeto, 3) - 0.0174 * Math.Pow(VazaoProjeto, 2) - 0.357 * VazaoProjeto + 36.122;
                    else if (IDModelo == 4) // 2CV
                        Resultado = -0.0004 * Math.Pow(VazaoProjeto, 4) + 0.016 * Math.Pow(VazaoProjeto, 3) - 0.3174 * Math.Pow(VazaoProjeto, 2) + 1.3109 * VazaoProjeto + 38.793;
                    else if (IDModelo == 5) // 3CV
                        Resultado = -0.0019 * Math.Pow(VazaoProjeto, 4) + 0.088 * Math.Pow(VazaoProjeto, 3) - 1.5567 * Math.Pow(VazaoProjeto, 2) + 10.501 * VazaoProjeto + 21.974;
                    else if (IDModelo == 6) // 4CV
                        Resultado = -6E-05 * Math.Pow(VazaoProjeto, 6) + 0.0045 * Math.Pow(VazaoProjeto, 5) - 0.1302 * Math.Pow(VazaoProjeto, 4) + 1.9242 * Math.Pow(VazaoProjeto, 3) - 15.37 * Math.Pow(VazaoProjeto, 2) + 61.792 * VazaoProjeto - 46.917;
                    break;

                case 11: // Famac FGN 3
                    if (IDModelo == 1) // 3/4CV
                        Resultado = -0.0951 * Math.Pow(VazaoProjeto, 2) - 0.4401 * VazaoProjeto + 29.252;
                    else if (IDModelo == 2) // 1CV
                        Resultado = 0.0004 * Math.Pow(VazaoProjeto, 3) - 0.0993 * Math.Pow(VazaoProjeto, 2) - 0.5413 * VazaoProjeto + 32.009;
                    else if (IDModelo == 3) // 1,5CV
                        Resultado = 3E-05 * Math.Pow(VazaoProjeto, 6) - 0.0015 * Math.Pow(VazaoProjeto, 5) + 0.0325 * Math.Pow(VazaoProjeto, 4) - 0.3611 * Math.Pow(VazaoProjeto, 3) + 2.0335 * Math.Pow(VazaoProjeto, 2) - 7.0812 * VazaoProjeto + 46.657;
                    else if (IDModelo == 4) // 2CV
                        Resultado = 0.0016 * Math.Pow(VazaoProjeto, 3) - 0.1385 * Math.Pow(VazaoProjeto, 2) - 0.3098 * VazaoProjeto + 43.505;
                    break;

                case 12: // Famac FGN 4-5
                    if (IDModelo == 1) // 1CV
                        Resultado = -0.0014 * Math.Pow(VazaoProjeto, 3) - 0.024 * Math.Pow(VazaoProjeto, 2) - 0.2929 * VazaoProjeto + 22.852;
                    else if (IDModelo == 2) // 1,5CV
                        Resultado = -0.064 * Math.Pow(VazaoProjeto, 2) + 0.2181 * VazaoProjeto + 27.644;
                    else if (IDModelo == 3) // 2CV
                        Resultado = -0.0001 * Math.Pow(VazaoProjeto, 4) + 0.0065 * Math.Pow(VazaoProjeto, 3) - 0.1748 * Math.Pow(VazaoProjeto, 2) + 1.1062 * VazaoProjeto + 27.802;
                    else if (IDModelo == 4) // 3CV
                        Resultado = -6E-05 * Math.Pow(VazaoProjeto, 6) + 0.0049 * Math.Pow(VazaoProjeto, 5) - 0.1613 * Math.Pow(VazaoProjeto, 4) + 2.7553 * Math.Pow(VazaoProjeto, 3) - 25.675 * Math.Pow(VazaoProjeto, 2) + 122.66 * VazaoProjeto - 194.45;
                    else if (IDModelo == 5) // FGN 5 3CV
                        Resultado = 0.0001 * Math.Pow(VazaoProjeto, 4) - 0.0073 * Math.Pow(VazaoProjeto, 3) + 0.1017 * Math.Pow(VazaoProjeto, 2) - 1.0479 * VazaoProjeto + 35.393;
                    else if (IDModelo == 6) // FGN 5 4CV
                        Resultado = 5E-05 * Math.Pow(VazaoProjeto, 4) - 0.0031 * Math.Pow(VazaoProjeto, 3) + 0.019 * Math.Pow(VazaoProjeto, 2) - 0.2745 * VazaoProjeto + 40.767;
                    break;

                case 13: // Dancor CAM-W4C
                    if (IDModelo == 1) // 1/4CV
                        Resultado = -0.0012 * Math.Pow(VazaoProjeto, 5) + 0.0184 * Math.Pow(VazaoProjeto, 4) - 0.0915 * Math.Pow(VazaoProjeto, 3) + 0.0503 * Math.Pow(VazaoProjeto, 2) - 1.0132 * VazaoProjeto + 16.072;
                    else if (IDModelo == 2) // 1/3CV
                        Resultado = -0.1598 * Math.Pow(VazaoProjeto, 2) - 0.8167 * VazaoProjeto + 17.955;
                    else if (IDModelo == 3) // 1/2CV
                        Resultado = -0.1465 * Math.Pow(VazaoProjeto, 2) - 0.7552 * VazaoProjeto + 20.35;
                    break;

                case 14: // Dancor CAM-W6C
                    if (IDModelo == 1) // 3/4CV
                        Resultado = -0.0457 * Math.Pow(VazaoProjeto, 3) + 0.4582 * Math.Pow(VazaoProjeto, 2) - 2.9269 * VazaoProjeto + 31.852;
                    else if (IDModelo == 2) // 1CV
                        Resultado = -0.0352 * Math.Pow(VazaoProjeto, 3) + 0.2508 * Math.Pow(VazaoProjeto, 2) - 2.1437 * VazaoProjeto + 34.245;
                    else if (IDModelo == 3) // 1,5CV
                        Resultado = -0.0133 * Math.Pow(VazaoProjeto, 3) - 0.0169 * Math.Pow(VazaoProjeto, 2) - 2.0975 * VazaoProjeto + 41.107;
                    else if (IDModelo == 4) // 2CV
                        Resultado = 0.0026 * Math.Pow(VazaoProjeto, 4) - 0.0649 * Math.Pow(VazaoProjeto, 3) + 0.184 * Math.Pow(VazaoProjeto, 2) - 2.9203 * VazaoProjeto + 47.045;
                    break;

                case 15: // Dancor DS-9
                    if (IDModelo == 1) // 1/2CV
                        Resultado = -9E-05 * Math.Pow(VazaoProjeto, 5) + 0.0021 * Math.Pow(VazaoProjeto, 4) - 0.0183 * Math.Pow(VazaoProjeto, 3) + 0.0822 * Math.Pow(VazaoProjeto, 2) - 1.0007 * VazaoProjeto + 10.024;
                    break;

                case 16: // Dancor 56-40
                    if (IDModelo == 1) // 2CV
                        Resultado = -0.0028 * Math.Pow(VazaoProjeto, 2) - 0.0617 * VazaoProjeto + 14.971;
                    else if (IDModelo == 2) // 3CV
                        Resultado = -0.0045 * Math.Pow(VazaoProjeto, 2) - 0.025 * VazaoProjeto + 19.191;
                    else if (IDModelo == 3) // 4CV
                        Resultado = -2E-09 * Math.Pow(VazaoProjeto, 6) + 3E-07 * Math.Pow(VazaoProjeto, 5) - 2E-05 * Math.Pow(VazaoProjeto, 4) + 0.0008 * Math.Pow(VazaoProjeto, 3) - 0.0121 * Math.Pow(VazaoProjeto, 2) - 0.052 * VazaoProjeto + 23.038;
                    break;

                case 17: // Dancor 76-50
                    if (IDModelo == 1) // 1/2CV
                        Resultado = 6E-07 * Math.Pow(VazaoProjeto, 4) - 6E-05 * Math.Pow(VazaoProjeto, 3) + 0.0022 * Math.Pow(VazaoProjeto, 2) - 0.1277 * VazaoProjeto + 6.0035;
                    else if (IDModelo == 2) // 1CV
                        Resultado = -7E-10 * Math.Pow(VazaoProjeto, 6) + 1E-07 * Math.Pow(VazaoProjeto, 5) - 9E-06 * Math.Pow(VazaoProjeto, 4) + 0.0002 * Math.Pow(VazaoProjeto, 3) - 0.0026 * Math.Pow(VazaoProjeto, 2) - 0.0879 * VazaoProjeto + 9.7333;
                    else if (IDModelo == 3) // 2CV
                        Resultado = -1E-05 * Math.Pow(VazaoProjeto, 3) + 0.0003 * Math.Pow(VazaoProjeto, 2) - 0.09 * VazaoProjeto + 10.933;
                    else if (IDModelo == 4) // 3CV
                        Resultado = 8E-09 * Math.Pow(VazaoProjeto, 5) - 1E-06 * Math.Pow(VazaoProjeto, 4) + 6E-05 * Math.Pow(VazaoProjeto, 3) - 0.0013 * Math.Pow(VazaoProjeto, 2) - 0.0854 * VazaoProjeto + 11.943;
                    break;

                case 18: // Dancor SDE
                    if (IDModelo == 1) // 1/2CV
                        Resultado = -0.0041 * Math.Pow(VazaoProjeto, 2) - 0.384 * VazaoProjeto + 11.416;
                    else if (IDModelo == 2) // 1CV
                        Resultado = -2E-05 * Math.Pow(VazaoProjeto, 4) + 0.0007 * Math.Pow(VazaoProjeto, 3) - 0.0142 * Math.Pow(VazaoProjeto, 2) - 0.402 * VazaoProjeto + 17.655;
                    else if (IDModelo == 3) // 2CV 125mm
                        Resultado = -1E-05 * Math.Pow(VazaoProjeto, 4) + 0.0005 * Math.Pow(VazaoProjeto, 3) - 0.0154 * Math.Pow(VazaoProjeto, 2) - 0.2771 * VazaoProjeto + 22.982;
                    else if (IDModelo == 4) // 2CV 144mm
                        Resultado = -1E-05 * Math.Pow(VazaoProjeto, 5) + 0.0007 * Math.Pow(VazaoProjeto, 4) - 0.0152 * Math.Pow(VazaoProjeto, 3) + 0.1378 * Math.Pow(VazaoProjeto, 2) - 1.2255 * VazaoProjeto + 32.081;
                    else if (IDModelo == 5) // 3CV
                        Resultado = -9E-08 * Math.Pow(VazaoProjeto, 6) + 9E-06 * Math.Pow(VazaoProjeto, 5) - 0.0004 * Math.Pow(VazaoProjeto, 4) + 0.0065 * Math.Pow(VazaoProjeto, 3) - 0.0512 * Math.Pow(VazaoProjeto, 2) - 0.4122 * VazaoProjeto + 31.202;
                    break;

                case 19: // Lorenzetti BPL 35
                    if (IDModelo == 1) // 1/2CV
                        Resultado = -0.0003 * Math.Pow(VazaoProjeto, 3) - 0.011 * Math.Pow(VazaoProjeto, 2) - 0.076 * VazaoProjeto + 29.871;
                    break;
                case 20: // Lorenzetti BPL 50
                    if (IDModelo == 1) // 1CV
                        Resultado = -3E-06 * Math.Pow(VazaoProjeto, 4) + 2E-07 * Math.Pow(VazaoProjeto, 3) - 0.011 * Math.Pow(VazaoProjeto, 2) - 0.0876 * VazaoProjeto + 55.306;
                    break;

                case 21: // ROWA Inteligente 20
                    if (IDModelo == 1) // 1/2CV
                        Resultado = -0.045 * Math.Pow(VazaoProjeto, 4) + 0.2099 * Math.Pow(VazaoProjeto, 3) - 0.3231 * Math.Pow(VazaoProjeto, 2) - 3.9403 * VazaoProjeto + 18.534;
                    break;

                case 22: // ROWA Inteligente 20
                    if (IDModelo == 1) // 1/2CV
                        Resultado = -0.018 * Math.Pow(VazaoProjeto, 3) - 0.2876 * Math.Pow(VazaoProjeto, 2) - 1.7804 * VazaoProjeto + 22.085;
                    break;

                case 23: // Darka CAE
                    if (IDModelo == 1) // 1/3CV
                        Resultado = -0.3704 * Math.Pow(VazaoProjeto, 3) + 4.908 * Math.Pow(VazaoProjeto, 2) - 23.397 * VazaoProjeto + 56.567;
                    if (IDModelo == 2) // 1/2CV
                        Resultado = -0.1626 * Math.Pow(VazaoProjeto, 3) + 2.5153 * Math.Pow(VazaoProjeto, 2) - 14.399 * VazaoProjeto + 45.958;
                    if (IDModelo == 3) // 3/4CV
                        Resultado = 0.0516 * Math.Pow(VazaoProjeto, 4) - 1.4612 * Math.Pow(VazaoProjeto, 3) + 14.782 * Math.Pow(VazaoProjeto, 2) - 65.232 * VazaoProjeto + 126.73;
                    if (IDModelo == 4) // 1CV
                        Resultado = -0.1415 * Math.Pow(VazaoProjeto, 3) + 2.3839 * Math.Pow(VazaoProjeto, 2) - 14.324 * VazaoProjeto + 52.208;
                    if (IDModelo == 5) // 1,5CV
                        Resultado = -0.051 * Math.Pow(VazaoProjeto, 3) + 0.8174 * Math.Pow(VazaoProjeto, 2) - 5.3193 * VazaoProjeto + 44.99;
                    if (IDModelo == 6) // 2CV
                        Resultado = -0.0657 * Math.Pow(VazaoProjeto, 3) + 1.1586 * Math.Pow(VazaoProjeto, 2) - 7.5528 * VazaoProjeto + 54.006;
                    if (IDModelo == 7) // 3CV
                        Resultado = -0.0453 * Math.Pow(VazaoProjeto, 3) + 0.6934 * Math.Pow(VazaoProjeto, 2) - 3.8173 * VazaoProjeto + 52.649;
                    break;

                case 24: // Darka CH
                    if (IDModelo == 1) // 1/3CV
                        Resultado = -0.0252 * Math.Pow(VazaoProjeto, 3) + 0.1817 * Math.Pow(VazaoProjeto, 2) - 1.0059 * VazaoProjeto + 15.463;
                    if (IDModelo == 2) // 1/2CV
                        Resultado = -0.0342 * Math.Pow(VazaoProjeto, 3) + 0.3281 * Math.Pow(VazaoProjeto, 2) - 1.6145 * VazaoProjeto + 19.621;
                    if (IDModelo == 3) // 3/4CV
                        Resultado = -0.0938 * Math.Pow(VazaoProjeto, 3) + 1.54 * Math.Pow(VazaoProjeto, 2) - 9.1781 * VazaoProjeto + 41.098;
                    if (IDModelo == 4) // 1CV
                        Resultado = -0.0004 * Math.Pow(VazaoProjeto, 6) + 0.0119 * Math.Pow(VazaoProjeto, 5) - 0.157 * Math.Pow(VazaoProjeto, 4) + 1.0498 * Math.Pow(VazaoProjeto, 3) - 3.7381 * Math.Pow(VazaoProjeto, 2) + 5.5989 * VazaoProjeto + 27.588;
                    if (IDModelo == 5) // 1,5CV
                        Resultado = -0.0074 * Math.Pow(VazaoProjeto, 4) + 0.2466 * Math.Pow(VazaoProjeto, 3) - 3.0901 * Math.Pow(VazaoProjeto, 2) + 15.82 * VazaoProjeto + 1.949;
                    if (IDModelo == 6) // 2CV
                        Resultado = -0.0313 * Math.Pow(VazaoProjeto, 3) + 0.681 * Math.Pow(VazaoProjeto, 2) - 5.7886 * VazaoProjeto + 49.267;
                    if (IDModelo == 7) // 3CV
                        Resultado = -0.0122 * Math.Pow(VazaoProjeto, 3) + 0.2469 * Math.Pow(VazaoProjeto, 2) - 2.0721 * VazaoProjeto + 41.855;
                    if (IDModelo == 8) // 4CV
                        Resultado = -0.0068 * Math.Pow(VazaoProjeto, 4) + 0.291 * Math.Pow(VazaoProjeto, 3) - 4.5652 * Math.Pow(VazaoProjeto, 2) + 30.054 * VazaoProjeto - 25.024;
                    if (IDModelo == 9) // 5CV
                        Resultado = -2E-05 * Math.Pow(VazaoProjeto, 5) + 0.0009 * Math.Pow(VazaoProjeto, 4) - 0.0206 * Math.Pow(VazaoProjeto, 3) + 0.195 * Math.Pow(VazaoProjeto, 2) - 1.2413 * VazaoProjeto + 56.853;
                    break;

                case 25: // Darka CW
                    if (IDModelo == 1) // 1/3CV
                        Resultado = -0.1488 * Math.Pow(VazaoProjeto, 3) + 1.139 * Math.Pow(VazaoProjeto, 2) - 3.2957 * VazaoProjeto + 19.198;
                    if (IDModelo == 2) // 1/3CV
                        Resultado = -0.1558 * Math.Pow(VazaoProjeto, 3) + 1.3807 * Math.Pow(VazaoProjeto, 2) - 4.2 * VazaoProjeto + 21.859;
                    if (IDModelo == 3) // 1/3CV
                        Resultado = -0.0013 * Math.Pow(VazaoProjeto, 4) + 0.0341 * Math.Pow(VazaoProjeto, 3) - 0.3382 * Math.Pow(VazaoProjeto, 2) + 0.4011 * VazaoProjeto + 18.322;
                    if (IDModelo == 4) // 1/3CV
                        Resultado = -0.0011 * Math.Pow(VazaoProjeto, 4) + 0.0329 * Math.Pow(VazaoProjeto, 3) - 0.3846 * Math.Pow(VazaoProjeto, 2) + 0.9575 * VazaoProjeto + 21.518;
                    if (IDModelo == 5) // 1/3CV
                        Resultado = -0.238 * Math.Pow(VazaoProjeto, 3) + 4.7524 * Math.Pow(VazaoProjeto, 2) - 30.278 * VazaoProjeto + 89.526;
                    if (IDModelo == 6) // 1/3CV
                        Resultado = -0.1454 * Math.Pow(VazaoProjeto, 3) + 2.8837 * Math.Pow(VazaoProjeto, 2) - 18.75 * VazaoProjeto + 74.262;
                    if (IDModelo == 7) // 1/3CV
                        Resultado = -0.0996 * Math.Pow(VazaoProjeto, 3) + 1.6731 * Math.Pow(VazaoProjeto, 2) - 8.3961 * VazaoProjeto + 55.766;
                    break;

            }

            return Resultado > 0 ? Math.Round(Resultado, 2) : 0;
        }

        public class ModelosBombas
        {
            public int ID { get => _ID; set { _ID = value; } }
            private int _ID;

            public int IDModelo { get => _IDModelo; set { _IDModelo = value; } }
            private int _IDModelo;

            public double VazaoTrabalho { get => _VazaoTrabalho; set { _VazaoTrabalho = value; } }
            private double _VazaoTrabalho;

            public double Potencia { get => RFormula(ID, IDModelo); }

            public string Modelo { get => _Modelo; set { _Modelo = value; } }
            private string _Modelo;

            public BitmapImage ImagemBomba { get => _ImagemBomba; set { _ImagemBomba = value; } }
            private BitmapImage _ImagemBomba;

            public bool Submersivel { get; set; }
        }
        public class cBombas
        {
            public string NomeMarca { get => _NomeMarca; set { _NomeMarca = value; } }
            private string _NomeMarca;

            public ModelosBombas Bomba;
        }
    }

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
        public static ObservablePoint[] Lista;
        public static ChartValues<PontosGrafico> PontosX = new ChartValues<PontosGrafico>(), PontosY = new ChartValues<PontosGrafico>(), PontoInter = new ChartValues<PontosGrafico>(), PontoDeVazao = new ChartValues<PontosGrafico>();
        public ISeries[] Series { get; set; } =
        {

        new LineSeries<PontosGrafico>
        {
            Name = "Bomba",
            Values = PontosX,
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
            Values = PontosY,
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
            Values = PontoInter,
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

        public void FuncaoCalculoCurvaGrafico(int IDBomba, int ModeloBomba)
        {
            PontoDeVazao.Clear();
            PontosX.Clear();
            PontosY.Clear();
            PontoInter.Clear();
            var ponto3 = new PontosGrafico() { X = 2, Y = Constante(3, 2, 3 + 2, 32, 0.5, 40), label = "" };
            PontoDeVazao.Add(ponto3);

            for (double x = 0; x < 10; x += 0.001)
            {
                var ponto = new PontosGrafico() { X = x, Y = RFormula(IDBomba, ModeloBomba, x), label = "" };
                if (ponto.Y > 0)
                    PontosX.Add(ponto);
            }
            for (double y = 0; y < 10; y += 0.001)
            {
                double valor = Constante(3, 2, 3 + y, 32, 0.5, 40);
                var ponto2 = new PontosGrafico() { X = y, Y = valor, label = "" };
                PontosY.Add(ponto2);
            }

            double inter = 0;

            for (int x = 0; x < PontosX.Count; x++)
            {
                double r = (PontosX[x].Y - PontosY[x].Y);
                if (r < 0)
                    r = -(r);

                if (r < 0.01)
                {
                    inter = PontosY[x].X;
                    PontosY[x].PCritico = inter;
                    PontoInter.Add(PontosY[x]);
                    PontoInter.First().X = inter;
                    break;
                }
            }
        }
       

        private void btnCurvaVazao_Click(object sender, RoutedEventArgs e)
        {
            if (BombaSelecionada != null)
            {
                try
                {
                    FuncaoCalculoCurvaGrafico(BombaSelecionada.ID, BombaSelecionada.IDModelo);
                    this.Width = 1120;
                    GridCurva.Visibility = Visibility.Visible;
                }
                catch (Exception)
                {
                }
            }
        }

        private void ListView_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (sender != null)
            {
                dynamic context = sender;
                BombaSelecionada = context.DataContext;
            }
        }

        private void Exibir_Click(object sender, RoutedEventArgs e)
        {
            GridBotao.Visibility = Visibility.Hidden;
            GridBombas.Visibility = Visibility.Visible;
        }

        private void btnSelecionarBomba_Click(object sender, RoutedEventArgs e)
        {
            this.Width = 600;
            GridCurva.Visibility = Visibility.Hidden;
            GridBotao.Visibility = Visibility.Visible;
            GridBombas.Visibility = Visibility.Hidden;
        }
        public ObservableCollection<ModeloBombas> bombas { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            bombas = new ObservableCollection<ModeloBombas>();
            bombas.Add(new ModeloBombas { ID = 1, IDModelo = 6, Modelo = "Schneider BC-91", Potencia = "1cv", Imagem = new BitmapImage(new Uri(@"C:\Users\PC 01\Documents\GitHub\Livechart\Livechart\Livechart\Resources\BC91_imagem.bmp", UriKind.RelativeOrAbsolute)), VazaoTrabalho = 0 });
            bombas.Add(new ModeloBombas { ID = 2, IDModelo = 2, Modelo = "Schneider BC-92", Potencia = "1cv", Imagem = new BitmapImage(new Uri(@"C:\Users\PC 01\Documents\GitHub\Livechart\Livechart\Livechart\Resources\BC92_imagem.bmp", UriKind.RelativeOrAbsolute)), VazaoTrabalho = 0 });
        }

        public static double Constante(double N1, double N2, double Vazao, double N4, double Recalque, double Succao)
        {
            double Resultado = N1 + N2 + Math.Pow(8.69, 6) * Math.Pow(Vazao * 3.6, 1.75) * Math.Pow(N4, -4.75) * Recalque + Math.Pow(8.69, 6) * Math.Pow(Vazao * 3.6, 1.75) * Math.Pow(Succao, -4.75);
            return Math.Round(Resultado, 2);
        }
    }
}
