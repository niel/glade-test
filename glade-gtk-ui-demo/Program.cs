using Gtk;
using System;

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
			gui.AddFromFile("/home/niel/dev/c-sharp/glade-gtk-ui-demo/glade-gtk-ui-demo/main.glade");
			gui.Autoconnect(this);
			Gtk.Application.Run();
		}
	}
}
