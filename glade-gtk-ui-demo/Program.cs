using Gtk;
using System;
using System.IO;

namespace glade_gtk_ui_demo
{
	public class ShowWindow
	{
		public static void Main(string[] args)
		{
			new ShowWindow();
		}

		static void OnAppWindowDestroy(object o, EventArgs args)
		{
			
			Gtk.Application.Quit();
		}

		static void OnQuitButtonEvent(object o, ButtonReleaseEventArgs args)
		{
			Gtk.Application.Quit();
		}

		private ShowWindow()
		{
			Gtk.Application.Init();
			Builder gui = new Builder();
			Directory.SetCurrentDirectory("../../../");
			gui.AddFromFile(Path.Combine(Directory.GetCurrentDirectory(), "glade-gtk-ui-demo/main.glade"));
			gui.Autoconnect(this);
			Gtk.Application.Run();
		}
	}
}
