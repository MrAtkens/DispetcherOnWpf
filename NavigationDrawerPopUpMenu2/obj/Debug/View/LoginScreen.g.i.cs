#pragma checksum "..\..\..\View\LoginScreen.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E139B93A10D6D2FA55A356549A39C95C45B81637"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;

namespace NavigationDrawerPopUpMenu2
{
	/// <summary>
	/// LoginScreen
	/// </summary>
	public partial class LoginScreen : System.Windows.Window, System.Windows.Markup.IComponentConnector
	{


#line 37 "..\..\..\View\LoginScreen.xaml"
		[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal System.Windows.Controls.Button LoginButton;

#line default
#line hidden

		private bool _contentLoaded;

		/// <summary>
		/// InitializeComponent
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			if (_contentLoaded)
			{
				return;
			}
			_contentLoaded = true;
			System.Uri resourceLocater = new System.Uri("/NavigationDrawerPopUpMenu2;component/view/loginscreen.xaml", System.UriKind.Relative);

#line 1 "..\..\..\View\LoginScreen.xaml"
			System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
		}

		[System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
		[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
				case 1:
					this.LoginButton = ((System.Windows.Controls.Button)(target));

#line 37 "..\..\..\View\LoginScreen.xaml"
					this.LoginButton.Click += new System.Windows.RoutedEventHandler(this.LoginButton_Click);

#line default
#line hidden
					return;
			}
			this._contentLoaded = true;
		}
	}
}