using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Win32;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using System.Net;
using Newtonsoft.Json;
using System.Text;
using System.Diagnostics;
using System.Data;

namespace NavigationDrawerPopUpMenu2
{
	internal enum AccentState
	{
		ACCENT_DISABLED = 0,
		ACCENT_ENABLE_GRADIENT = 10,
		ACCENT_ENABLE_TRANSPARENTGRADIENT = 2,
		ACCENT_ENABLE_BLURBEHIND = 3,
		ACCENT_INVALID_STATE = 4
	}

	[StructLayout(LayoutKind.Sequential)]

	internal struct AccentPolicy
	{
		public AccentState accentState;
		public int accentFlags;
		public int GradientColor;
		public int AnimationId;
	}

	[StructLayout(LayoutKind.Sequential)]

	internal struct WindowCompositionAttributeData
	{
		public WindowCompositionAttribute Attribute;
		public IntPtr Data;
		public int SizeOfData;
	}

	internal enum WindowCompositionAttribute
	{
		WCA_ACCENT_POLICY = 19
	}
	public partial class MainWindow :Window
	{
		[DllImport("user32.dll")]

		internal static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);


	

		public MainWindow()
		{
			InitializeComponent();

			var processes = Process.GetProcesses();

			ProcessTable.ItemsSource = processes;
		}

		internal void EnableBlur()
		{
			var windowHelper = new WindowInteropHelper(this);

			var accent = new AccentPolicy();
			accent.accentState = AccentState.ACCENT_ENABLE_BLURBEHIND;

			var accentStructSize = Marshal.SizeOf(accent);

			var accentPtr = Marshal.AllocHGlobal(accentStructSize);
			Marshal.StructureToPtr(accent, accentPtr, false);

			var data = new WindowCompositionAttributeData();
			data.Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY;
			data.SizeOfData = accentStructSize;
			data.Data = accentPtr;

			SetWindowCompositionAttribute(windowHelper.Handle, ref data);

			Marshal.FreeHGlobal(accentPtr);

		}






		private void Warning(string text)
		{
			Header.Background = new SolidColorBrush(Color.FromRgb(238, 85, 87));
			HeaderText.Text = text;
		}


		private void DefaultHeader()
		{
			Header.Background = new SolidColorBrush(Color.FromRgb(0, 128, 255));
			HeaderText.Text = "Security Face";
		}



		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			EnableBlur();
		}



		private void Maximaze_Click(object sender, RoutedEventArgs e)
		{
			if (WindowState == WindowState.Maximized)
			{
				WindowState = WindowState.Normal;
			}
			else {
				WindowState = WindowState.Maximized;
			}
		}



		private void Minimaze_Click(object sender, RoutedEventArgs e)
		{
		    WindowState = WindowState.Minimized;
		}



		private void Exit_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}




		private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
		{
			DragMove();
		}

		private void CloseLogin_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void LoginEnter_Click(object sender, RoutedEventArgs e)
		{

					Login.Visibility = Visibility.Collapsed;
					HeaderLogin.Visibility = Visibility.Collapsed;

					Header.Visibility = Visibility.Visible;
					GridSearch.Visibility = Visibility.Visible;
					MainGrid.Opacity = 0.8;

					AccountName.Text = LoginTextBox.Text;

			}
	

		private void LogOut_Click(object sender, RoutedEventArgs e)
		{
			Login.Visibility = Visibility.Visible;
			HeaderLogin.Visibility = Visibility.Visible;

			Header.Visibility = Visibility.Collapsed;
			GridSearch.Visibility = Visibility.Collapsed;

			DefaultHeader();

			LoginTextBox.Text = null;
			Password.Password = null;

		}

		private void ButtonDeleteClick(object sender, RoutedEventArgs e)
		{
			bool updateAcces = false;
			MessageBoxResult result = MessageBox.Show("Are you sure want to kill this process ?", "Message", MessageBoxButton.YesNo, MessageBoxImage.Question);
			if (result == MessageBoxResult.Yes)
			{
				var processes = Process.GetProcesses();
				foreach (var i in processes)
				{
					if (i.Id == (ProcessTable.SelectedItem as Process).Id)
					{
							try
							{
								i.Kill();
								updateAcces = true;
							}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, "Error");
						}
					}
				}
				if (updateAcces == true)
				{
					var updatedProcess = Process.GetProcesses();

					ProcessTable.ItemsSource = null;
					ProcessTable.ItemsSource = updatedProcess;
				}
		
			
			}
		}

	}
}


