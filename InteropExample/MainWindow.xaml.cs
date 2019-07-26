using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace InteropExample
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		[DllImport("Backend.dll")]
		static extern int Computation1();

		[DllImport("Backend.dll")]
		static extern int Computation2();

		public MainWindow()
		{
			InitializeComponent();
		}

		private void btn1_Click(object sender, RoutedEventArgs e)
		{
			Console.WriteLine(Computation1());
		}
		private void btn2_Click(object sender, RoutedEventArgs e)
		{
			Console.WriteLine(Computation2());
		}
	}
}
