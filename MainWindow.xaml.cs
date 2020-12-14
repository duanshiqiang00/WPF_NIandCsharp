using NationalInstruments.Net;
using NationalInstruments.Analysis;
using NationalInstruments.Analysis.Conversion;
using NationalInstruments.Analysis.Dsp;
using NationalInstruments.Analysis.Dsp.Filters;
using NationalInstruments.Analysis.Math;
using NationalInstruments.Analysis.Monitoring;
using NationalInstruments.Analysis.SignalGeneration;
using NationalInstruments.Analysis.SpectralMeasurements;
using NationalInstruments;
using NationalInstruments.NetworkVariable;
using NationalInstruments.NetworkVariable.WindowsForms;
using NationalInstruments.Tdms;
using NationalInstruments.Controls;
using NationalInstruments.Controls.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btn_Login.IsEnabled = true;
            btn_BackgroundLoad.IsEnabled = false;
            btn_swpFormEntrence.IsEnabled = false;
            btn_turFormEntrence.IsEnabled = false;
            btn_pluseFormEntrence.IsEnabled = false;

        }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            LogIn LogIn = new LogIn();
            LogIn.Owner = this;
            LogIn.ShowDialog();
        }

        private void btn_swpFormEntrence_Click(object sender, RoutedEventArgs e)
        {
            swpModel swpModel = new swpModel();
            swpModel.Owner = this;
            swpModel.ShowDialog();
        }

        private void btn_ExitSystem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult
                result = MessageBox.Show(
                "口..口\t确定退出程序？\t口..口", "提示",
                MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
