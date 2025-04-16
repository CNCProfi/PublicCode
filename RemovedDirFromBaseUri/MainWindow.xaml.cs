using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace RemovedDirFromBaseUri {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		private static Uri cd = new Uri(Environment.CurrentDirectory, UriKind.Absolute);
		private static BitmapImage inProgressImage
			= new BitmapImage(new Uri(cd, @"data/userImages/house.png"));
		
		public MainWindow() {
			InitializeComponent();
		}
	}
}
