
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;
	private global::Gtk.Entry entry1;
	private global::Gtk.Entry entry2;
	private global::Gtk.Entry entry3;
	private global::Gtk.Entry entry5;
	private global::Gtk.Entry entry4;
	private global::Gtk.Entry entry6;
	private global::Gtk.Label subtotal;
	private global::Gtk.Label producto3;
	private global::Gtk.Label producto2;
	private global::Gtk.Label producto1;
	private global::Gtk.Label total;
	private global::Gtk.Label iva;
	private global::Gtk.Button aceptar;
	private global::Gtk.Button limpiar;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry1 = new global::Gtk.Entry ();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '●';
		this.fixed1.Add (this.entry1);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entry1]));
		w1.X = 168;
		w1.Y = 29;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry2 = new global::Gtk.Entry ();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = true;
		this.entry2.InvisibleChar = '●';
		this.fixed1.Add (this.entry2);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entry2]));
		w2.X = 168;
		w2.Y = 78;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry3 = new global::Gtk.Entry ();
		this.entry3.CanFocus = true;
		this.entry3.Name = "entry3";
		this.entry3.IsEditable = true;
		this.entry3.InvisibleChar = '●';
		this.fixed1.Add (this.entry3);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entry3]));
		w3.X = 168;
		w3.Y = 125;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry5 = new global::Gtk.Entry ();
		this.entry5.CanFocus = true;
		this.entry5.Name = "entry5";
		this.entry5.IsEditable = true;
		this.entry5.InvisibleChar = '●';
		this.fixed1.Add (this.entry5);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entry5]));
		w4.X = 169;
		w4.Y = 223;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry4 = new global::Gtk.Entry ();
		this.entry4.CanFocus = true;
		this.entry4.Name = "entry4";
		this.entry4.IsEditable = true;
		this.entry4.InvisibleChar = '●';
		this.fixed1.Add (this.entry4);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entry4]));
		w5.X = 166;
		w5.Y = 174;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry6 = new global::Gtk.Entry ();
		this.entry6.CanFocus = true;
		this.entry6.Name = "entry6";
		this.entry6.IsEditable = true;
		this.entry6.InvisibleChar = '●';
		this.fixed1.Add (this.entry6);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entry6]));
		w6.X = 168;
		w6.Y = 268;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.subtotal = new global::Gtk.Label ();
		this.subtotal.Name = "subtotal";
		this.subtotal.LabelProp = global::Mono.Unix.Catalog.GetString ("subtotal");
		this.fixed1.Add (this.subtotal);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.subtotal]));
		w7.X = 97;
		w7.Y = 181;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.producto3 = new global::Gtk.Label ();
		this.producto3.Name = "producto3";
		this.producto3.LabelProp = global::Mono.Unix.Catalog.GetString ("producto3");
		this.fixed1.Add (this.producto3);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.producto3]));
		w8.X = 98;
		w8.Y = 131;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.producto2 = new global::Gtk.Label ();
		this.producto2.Name = "producto2";
		this.producto2.LabelProp = global::Mono.Unix.Catalog.GetString ("producto2");
		this.fixed1.Add (this.producto2);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.producto2]));
		w9.X = 98;
		w9.Y = 84;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.producto1 = new global::Gtk.Label ();
		this.producto1.Name = "producto1";
		this.producto1.LabelProp = global::Mono.Unix.Catalog.GetString ("producto1");
		this.fixed1.Add (this.producto1);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.producto1]));
		w10.X = 100;
		w10.Y = 35;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.total = new global::Gtk.Label ();
		this.total.Name = "total";
		this.total.LabelProp = global::Mono.Unix.Catalog.GetString ("total");
		this.fixed1.Add (this.total);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.total]));
		w11.X = 98;
		w11.Y = 276;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.iva = new global::Gtk.Label ();
		this.iva.Name = "iva";
		this.iva.LabelProp = global::Mono.Unix.Catalog.GetString ("iva");
		this.fixed1.Add (this.iva);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.iva]));
		w12.X = 98;
		w12.Y = 224;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.aceptar = new global::Gtk.Button ();
		this.aceptar.CanFocus = true;
		this.aceptar.Name = "aceptar";
		this.aceptar.UseUnderline = true;
		this.aceptar.Label = global::Mono.Unix.Catalog.GetString ("aceptar");
		this.fixed1.Add (this.aceptar);
		global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.aceptar]));
		w13.X = 228;
		w13.Y = 334;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.limpiar = new global::Gtk.Button ();
		this.limpiar.CanFocus = true;
		this.limpiar.Name = "limpiar";
		this.limpiar.UseUnderline = true;
		this.limpiar.Label = global::Mono.Unix.Catalog.GetString ("limpiar");
		this.fixed1.Add (this.limpiar);
		global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.limpiar]));
		w14.X = 312;
		w14.Y = 335;
		this.Add (this.fixed1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 581;
		this.DefaultHeight = 458;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.aceptar.Clicked += new global::System.EventHandler (this.OnAceptarClicked);
		this.limpiar.Clicked += new global::System.EventHandler (this.OnLimpiarClicked);
	}
}
