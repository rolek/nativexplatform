
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;
	
	private global::Gtk.Frame groupOptions;
	
	private global::Gtk.Alignment GtkAlignment;
	
	private global::Gtk.Fixed fixed2;
	
	private global::Gtk.Label lblArchive;
	
	private global::Gtk.Entry editArchive;
	
	private global::Gtk.Button btnArchive;
	
	private global::Gtk.Label lblOutputFolder;
	
	private global::Gtk.Entry editOutputFolder;
	
	private global::Gtk.Button btnFolder;
	
	private global::Gtk.Label lblPassword;
	
	private global::Gtk.Entry editPassword;
	
	private global::Gtk.CheckButton chkIgnoreErrors;
	
	private global::Gtk.CheckButton chkDryRun;
	
	private global::Gtk.Button btnStartStop;
	
	private global::Gtk.Button btnHelp;
	
	private global::Gtk.Image btnDonate;
	
	private global::Gtk.Label lblGroupOptions;
	
	private global::Gtk.Frame groupProgress;
	
	private global::Gtk.Alignment GtkAlignment1;
	
	private global::Gtk.Fixed fixed3;
	
	private global::Gtk.ProgressBar progressbarExtraction;
	
	private global::Gtk.Label lblExtractedFile;
	
	private global::Gtk.Label lblGroupProgress;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.Resizable = false;
		this.AllowGrow = false;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.WidthRequest = 540;
		this.fixed1.HeightRequest = 320;
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.groupOptions = new global::Gtk.Frame ();
		this.groupOptions.WidthRequest = 530;
		this.groupOptions.Name = "groupOptions";
		this.groupOptions.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child groupOptions.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		this.fixed2 = new global::Gtk.Fixed ();
		this.fixed2.Name = "fixed2";
		this.fixed2.HasWindow = false;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.lblArchive = new global::Gtk.Label ();
		this.lblArchive.HeightRequest = 20;
		this.lblArchive.Name = "lblArchive";
		this.lblArchive.LabelProp = global::Mono.Unix.Catalog.GetString ("Backup archive");
		this.lblArchive.UseUnderline = true;
		this.fixed2.Add (this.lblArchive);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.lblArchive]));
		w1.X = 8;
		w1.Y = 10;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.editArchive = new global::Gtk.Entry ();
		this.editArchive.WidthRequest = 200;
		this.editArchive.CanFocus = true;
		this.editArchive.Name = "editArchive";
		this.editArchive.IsEditable = true;
		this.editArchive.InvisibleChar = '●';
		this.fixed2.Add (this.editArchive);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.editArchive]));
		w2.X = 220;
		w2.Y = 8;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.btnArchive = new global::Gtk.Button ();
		this.btnArchive.WidthRequest = 80;
		this.btnArchive.CanFocus = true;
		this.btnArchive.Name = "btnArchive";
		this.btnArchive.UseUnderline = true;
		this.btnArchive.Label = global::Mono.Unix.Catalog.GetString ("Browse");
		this.fixed2.Add (this.btnArchive);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.btnArchive]));
		w3.X = 425;
		w3.Y = 8;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.lblOutputFolder = new global::Gtk.Label ();
		this.lblOutputFolder.Name = "lblOutputFolder";
		this.lblOutputFolder.LabelProp = global::Mono.Unix.Catalog.GetString ("Output folder");
		this.lblOutputFolder.UseUnderline = true;
		this.fixed2.Add (this.lblOutputFolder);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.lblOutputFolder]));
		w4.X = 8;
		w4.Y = 44;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.editOutputFolder = new global::Gtk.Entry ();
		this.editOutputFolder.WidthRequest = 200;
		this.editOutputFolder.CanFocus = true;
		this.editOutputFolder.Name = "editOutputFolder";
		this.editOutputFolder.IsEditable = true;
		this.editOutputFolder.InvisibleChar = '●';
		this.fixed2.Add (this.editOutputFolder);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.editOutputFolder]));
		w5.X = 220;
		w5.Y = 40;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.btnFolder = new global::Gtk.Button ();
		this.btnFolder.WidthRequest = 80;
		this.btnFolder.CanFocus = true;
		this.btnFolder.Name = "btnFolder";
		this.btnFolder.UseUnderline = true;
		this.btnFolder.Label = global::Mono.Unix.Catalog.GetString ("Browse");
		this.fixed2.Add (this.btnFolder);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.btnFolder]));
		w6.X = 425;
		w6.Y = 40;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.lblPassword = new global::Gtk.Label ();
		this.lblPassword.Name = "lblPassword";
		this.lblPassword.LabelProp = global::Mono.Unix.Catalog.GetString ("Password");
		this.lblPassword.UseUnderline = true;
		this.fixed2.Add (this.lblPassword);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.lblPassword]));
		w7.X = 8;
		w7.Y = 76;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.editPassword = new global::Gtk.Entry ();
		this.editPassword.WidthRequest = 200;
		this.editPassword.CanFocus = true;
		this.editPassword.Name = "editPassword";
		this.editPassword.IsEditable = true;
		this.editPassword.Visibility = false;
		this.editPassword.InvisibleChar = '●';
		this.fixed2.Add (this.editPassword);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.editPassword]));
		w8.X = 220;
		w8.Y = 72;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.chkIgnoreErrors = new global::Gtk.CheckButton ();
		this.chkIgnoreErrors.CanFocus = true;
		this.chkIgnoreErrors.Name = "chkIgnoreErrors";
		this.chkIgnoreErrors.Label = global::Mono.Unix.Catalog.GetString ("Ignore write errors");
		this.chkIgnoreErrors.Active = true;
		this.chkIgnoreErrors.DrawIndicator = true;
		this.chkIgnoreErrors.UseUnderline = true;
		this.fixed2.Add (this.chkIgnoreErrors);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.chkIgnoreErrors]));
		w9.X = 220;
		w9.Y = 104;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.chkDryRun = new global::Gtk.CheckButton ();
		this.chkDryRun.CanFocus = true;
		this.chkDryRun.Name = "chkDryRun";
		this.chkDryRun.Label = global::Mono.Unix.Catalog.GetString ("Dry run");
		this.chkDryRun.DrawIndicator = true;
		this.chkDryRun.UseUnderline = true;
		this.fixed2.Add (this.chkDryRun);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.chkDryRun]));
		w10.X = 220;
		w10.Y = 136;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.btnStartStop = new global::Gtk.Button ();
		this.btnStartStop.WidthRequest = 200;
		this.btnStartStop.CanFocus = true;
		this.btnStartStop.Name = "btnStartStop";
		this.btnStartStop.UseUnderline = true;
		this.btnStartStop.Label = global::Mono.Unix.Catalog.GetString ("_Start");
		this.fixed2.Add (this.btnStartStop);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.btnStartStop]));
		w11.X = 220;
		w11.Y = 170;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.btnHelp = new global::Gtk.Button ();
		this.btnHelp.WidthRequest = 80;
		this.btnHelp.CanFocus = true;
		this.btnHelp.Name = "btnHelp";
		this.btnHelp.UseUnderline = true;
		this.btnHelp.Label = global::Mono.Unix.Catalog.GetString ("_Help");
		this.fixed2.Add (this.btnHelp);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.btnHelp]));
		w12.X = 425;
		w12.Y = 170;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.btnDonate = new global::Gtk.Image ();
		this.btnDonate.Name = "btnDonate";
		this.btnDonate.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("ExtractWizardGtk.blue-rect-paypal-26px.png");
		this.fixed2.Add (this.btnDonate);
		global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.btnDonate]));
		w13.X = 8;
		w13.Y = 104;
		this.GtkAlignment.Add (this.fixed2);
		this.groupOptions.Add (this.GtkAlignment);
		this.lblGroupOptions = new global::Gtk.Label ();
		this.lblGroupOptions.Name = "lblGroupOptions";
		this.lblGroupOptions.LabelProp = global::Mono.Unix.Catalog.GetString ("Extraction Options");
		this.lblGroupOptions.UseUnderline = true;
		this.groupOptions.LabelWidget = this.lblGroupOptions;
		this.fixed1.Add (this.groupOptions);
		global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.groupOptions]));
		w16.X = 4;
		w16.Y = 4;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.groupProgress = new global::Gtk.Frame ();
		this.groupProgress.WidthRequest = 530;
		this.groupProgress.HeightRequest = 80;
		this.groupProgress.Name = "groupProgress";
		this.groupProgress.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child groupProgress.Gtk.Container+ContainerChild
		this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment1.Name = "GtkAlignment1";
		this.GtkAlignment1.LeftPadding = ((uint)(12));
		// Container child GtkAlignment1.Gtk.Container+ContainerChild
		this.fixed3 = new global::Gtk.Fixed ();
		this.fixed3.Name = "fixed3";
		this.fixed3.HasWindow = false;
		// Container child fixed3.Gtk.Fixed+FixedChild
		this.progressbarExtraction = new global::Gtk.ProgressBar ();
		this.progressbarExtraction.WidthRequest = 500;
		this.progressbarExtraction.Name = "progressbarExtraction";
		this.progressbarExtraction.Text = "";
		this.progressbarExtraction.Fraction = 0.5;
		this.fixed3.Add (this.progressbarExtraction);
		global::Gtk.Fixed.FixedChild w17 = ((global::Gtk.Fixed.FixedChild)(this.fixed3 [this.progressbarExtraction]));
		w17.X = 4;
		w17.Y = 4;
		// Container child fixed3.Gtk.Fixed+FixedChild
		this.lblExtractedFile = new global::Gtk.Label ();
		this.lblExtractedFile.WidthRequest = 500;
		this.lblExtractedFile.HeightRequest = 25;
		this.lblExtractedFile.Name = "lblExtractedFile";
		this.lblExtractedFile.LabelProp = global::Mono.Unix.Catalog.GetString ("This is some very long text that should wrap around if there is not enough space in this otherwise really big label I have put on the form");
		this.fixed3.Add (this.lblExtractedFile);
		global::Gtk.Fixed.FixedChild w18 = ((global::Gtk.Fixed.FixedChild)(this.fixed3 [this.lblExtractedFile]));
		w18.X = 4;
		w18.Y = 32;
		this.GtkAlignment1.Add (this.fixed3);
		this.groupProgress.Add (this.GtkAlignment1);
		this.lblGroupProgress = new global::Gtk.Label ();
		this.lblGroupProgress.Name = "lblGroupProgress";
		this.lblGroupProgress.LabelProp = global::Mono.Unix.Catalog.GetString ("Extraction Progress");
		this.lblGroupProgress.UseUnderline = true;
		this.groupProgress.LabelWidget = this.lblGroupProgress;
		this.fixed1.Add (this.groupProgress);
		global::Gtk.Fixed.FixedChild w21 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.groupProgress]));
		w21.X = 4;
		w21.Y = 230;
		this.Add (this.fixed1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 618;
		this.DefaultHeight = 500;
		this.lblArchive.MnemonicWidget = this.editArchive;
		this.lblOutputFolder.MnemonicWidget = this.editOutputFolder;
		this.lblPassword.MnemonicWidget = this.editPassword;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.btnArchive.Clicked += new global::System.EventHandler (this.OnBtnArchiveClicked);
		this.btnFolder.Clicked += new global::System.EventHandler (this.OnBtnFolderClicked);
		this.btnStartStop.Clicked += new global::System.EventHandler (this.OnBtnStartStopClicked);
		this.btnHelp.Clicked += new global::System.EventHandler (this.OnBtnHelpClicked);
		this.btnDonate.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnBtnDonateButtonPressEvent);
	}
}
