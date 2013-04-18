using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnAceptarClicked (object sender, EventArgs e)
	{
		float a = float.Parse(this.entry1.Text);
		float b = float.Parse(this.entry2.Text);
		float c = float.Parse(this.entry3.Text);


		float sub = a+b+c;
		this.entry4.Text=sub.ToString();
	    

		double iv = sub*.16;
		this.entry5.Text=iv.ToString();
		double tot= sub+iv;
		this.entry6.Text=tot.ToString();
	}

	protected void OnLimpiarClicked (object sender, EventArgs e)
	{
		this.entry1.Text="";
		this.entry2.Text="";
		this.entry3.Text="";
		this.entry4.Text="";
		this.entry5.Text="";
		this.entry6.Text="";
	}
}
