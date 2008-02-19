// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MonoDevelop.SourceEditor {
    
    
    public partial class SearchAndReplaceWidget {
        
        private Gtk.HBox hbox3;
        
        private Gtk.Table table1;
        
        private Gtk.Button closeButton;
        
        private Gtk.Image image4;
        
        private Gtk.ComboBoxEntry entryReplace;
        
        private Gtk.ComboBoxEntry entrySearch;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Button buttonSearchForward;
        
        private Gtk.Button buttonSearchBackward;
        
        private Gtk.Button buttonOptions;
        
        private Gtk.HBox hbox2;
        
        private Gtk.Button buttonReplace;
        
        private Gtk.Button buttonReplaceAll;
        
        private Gtk.HBox hbox5;
        
        private Gtk.Label label4;
        
        private Gtk.ComboBox comboboxSearchAs;
        
        private Gtk.Label label2;
        
        private Gtk.Label label3;
        
        private Gtk.VBox vbox3;
        
        private Gtk.HBox hbox7;
        
        private Gtk.Fixed fixed1;
        
        private Gtk.Button buttonSearchMode;
        
        private Gtk.Arrow arrow4;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.SourceEditor.SearchAndReplaceWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.SourceEditor.SearchAndReplaceWidget";
            // Container child MonoDevelop.SourceEditor.SearchAndReplaceWidget.Gtk.Container+ContainerChild
            this.hbox3 = new Gtk.HBox();
            this.hbox3.Name = "hbox3";
            this.hbox3.Spacing = 6;
            // Container child hbox3.Gtk.Box+BoxChild
            this.table1 = new Gtk.Table(((uint)(3)), ((uint)(4)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            // Container child table1.Gtk.Table+TableChild
            this.closeButton = new Gtk.Button();
            this.closeButton.CanFocus = true;
            this.closeButton.Name = "closeButton";
            this.closeButton.Relief = ((Gtk.ReliefStyle)(2));
            // Container child closeButton.Gtk.Container+ContainerChild
            this.image4 = new Gtk.Image();
            this.image4.Name = "image4";
            this.image4.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-close", Gtk.IconSize.Menu, 16);
            this.closeButton.Add(this.image4);
            this.closeButton.Label = null;
            this.table1.Add(this.closeButton);
            Gtk.Table.TableChild w2 = ((Gtk.Table.TableChild)(this.table1[this.closeButton]));
            w2.XOptions = ((Gtk.AttachOptions)(4));
            w2.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.entryReplace = Gtk.ComboBoxEntry.NewText();
            this.entryReplace.Name = "entryReplace";
            this.table1.Add(this.entryReplace);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.table1[this.entryReplace]));
            w3.TopAttach = ((uint)(2));
            w3.BottomAttach = ((uint)(3));
            w3.LeftAttach = ((uint)(2));
            w3.RightAttach = ((uint)(3));
            w3.XOptions = ((Gtk.AttachOptions)(4));
            w3.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.entrySearch = Gtk.ComboBoxEntry.NewText();
            this.entrySearch.Name = "entrySearch";
            this.table1.Add(this.entrySearch);
            Gtk.Table.TableChild w4 = ((Gtk.Table.TableChild)(this.table1[this.entrySearch]));
            w4.LeftAttach = ((uint)(2));
            w4.RightAttach = ((uint)(3));
            w4.XOptions = ((Gtk.AttachOptions)(4));
            w4.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.buttonSearchForward = new Gtk.Button();
            this.buttonSearchForward.CanFocus = true;
            this.buttonSearchForward.Name = "buttonSearchForward";
            this.buttonSearchForward.UseUnderline = true;
            this.buttonSearchForward.Relief = ((Gtk.ReliefStyle)(2));
            // Container child buttonSearchForward.Gtk.Container+ContainerChild
            Gtk.Alignment w5 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w6 = new Gtk.HBox();
            w6.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w7 = new Gtk.Image();
            w7.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-go-forward", Gtk.IconSize.Menu, 16);
            w6.Add(w7);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w9 = new Gtk.Label();
            w9.LabelProp = Mono.Unix.Catalog.GetString("_Next");
            w9.UseUnderline = true;
            w6.Add(w9);
            w5.Add(w6);
            this.buttonSearchForward.Add(w5);
            this.hbox1.Add(this.buttonSearchForward);
            Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.hbox1[this.buttonSearchForward]));
            w13.Position = 0;
            w13.Expand = false;
            w13.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.buttonSearchBackward = new Gtk.Button();
            this.buttonSearchBackward.CanFocus = true;
            this.buttonSearchBackward.Name = "buttonSearchBackward";
            this.buttonSearchBackward.UseUnderline = true;
            this.buttonSearchBackward.Relief = ((Gtk.ReliefStyle)(2));
            // Container child buttonSearchBackward.Gtk.Container+ContainerChild
            Gtk.Alignment w14 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w15 = new Gtk.HBox();
            w15.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w16 = new Gtk.Image();
            w16.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-go-back", Gtk.IconSize.Menu, 16);
            w15.Add(w16);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w18 = new Gtk.Label();
            w18.LabelProp = Mono.Unix.Catalog.GetString("_Previous");
            w18.UseUnderline = true;
            w15.Add(w18);
            w14.Add(w15);
            this.buttonSearchBackward.Add(w14);
            this.hbox1.Add(this.buttonSearchBackward);
            Gtk.Box.BoxChild w22 = ((Gtk.Box.BoxChild)(this.hbox1[this.buttonSearchBackward]));
            w22.Position = 1;
            w22.Expand = false;
            w22.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.buttonOptions = new Gtk.Button();
            this.buttonOptions.CanFocus = true;
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.UseUnderline = true;
            this.buttonOptions.Relief = ((Gtk.ReliefStyle)(2));
            // Container child buttonOptions.Gtk.Container+ContainerChild
            Gtk.Alignment w23 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w24 = new Gtk.HBox();
            w24.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w25 = new Gtk.Image();
            w25.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-preferences", Gtk.IconSize.Menu, 16);
            w24.Add(w25);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w27 = new Gtk.Label();
            w27.LabelProp = Mono.Unix.Catalog.GetString("_Options");
            w27.UseUnderline = true;
            w24.Add(w27);
            w23.Add(w24);
            this.buttonOptions.Add(w23);
            this.hbox1.Add(this.buttonOptions);
            Gtk.Box.BoxChild w31 = ((Gtk.Box.BoxChild)(this.hbox1[this.buttonOptions]));
            w31.Position = 2;
            w31.Expand = false;
            w31.Fill = false;
            this.table1.Add(this.hbox1);
            Gtk.Table.TableChild w32 = ((Gtk.Table.TableChild)(this.table1[this.hbox1]));
            w32.LeftAttach = ((uint)(3));
            w32.RightAttach = ((uint)(4));
            w32.XOptions = ((Gtk.AttachOptions)(4));
            w32.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.hbox2 = new Gtk.HBox();
            this.hbox2.Name = "hbox2";
            this.hbox2.Spacing = 6;
            // Container child hbox2.Gtk.Box+BoxChild
            this.buttonReplace = new Gtk.Button();
            this.buttonReplace.CanFocus = true;
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.UseUnderline = true;
            this.buttonReplace.Relief = ((Gtk.ReliefStyle)(2));
            // Container child buttonReplace.Gtk.Container+ContainerChild
            Gtk.Alignment w33 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w34 = new Gtk.HBox();
            w34.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w35 = new Gtk.Image();
            w35.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-find-and-replace", Gtk.IconSize.Menu, 16);
            w34.Add(w35);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w37 = new Gtk.Label();
            w37.LabelProp = Mono.Unix.Catalog.GetString("_Replace");
            w37.UseUnderline = true;
            w34.Add(w37);
            w33.Add(w34);
            this.buttonReplace.Add(w33);
            this.hbox2.Add(this.buttonReplace);
            Gtk.Box.BoxChild w41 = ((Gtk.Box.BoxChild)(this.hbox2[this.buttonReplace]));
            w41.Position = 0;
            w41.Expand = false;
            w41.Fill = false;
            // Container child hbox2.Gtk.Box+BoxChild
            this.buttonReplaceAll = new Gtk.Button();
            this.buttonReplaceAll.CanFocus = true;
            this.buttonReplaceAll.Name = "buttonReplaceAll";
            this.buttonReplaceAll.UseUnderline = true;
            this.buttonReplaceAll.Relief = ((Gtk.ReliefStyle)(2));
            this.buttonReplaceAll.Label = Mono.Unix.Catalog.GetString("Replace _all");
            this.hbox2.Add(this.buttonReplaceAll);
            Gtk.Box.BoxChild w42 = ((Gtk.Box.BoxChild)(this.hbox2[this.buttonReplaceAll]));
            w42.Position = 1;
            w42.Expand = false;
            w42.Fill = false;
            this.table1.Add(this.hbox2);
            Gtk.Table.TableChild w43 = ((Gtk.Table.TableChild)(this.table1[this.hbox2]));
            w43.TopAttach = ((uint)(2));
            w43.BottomAttach = ((uint)(3));
            w43.LeftAttach = ((uint)(3));
            w43.RightAttach = ((uint)(4));
            w43.XOptions = ((Gtk.AttachOptions)(4));
            w43.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.hbox5 = new Gtk.HBox();
            this.hbox5.Name = "hbox5";
            this.hbox5.Spacing = 6;
            // Container child hbox5.Gtk.Box+BoxChild
            this.label4 = new Gtk.Label();
            this.label4.Name = "label4";
            this.label4.LabelProp = Mono.Unix.Catalog.GetString("as");
            this.hbox5.Add(this.label4);
            Gtk.Box.BoxChild w44 = ((Gtk.Box.BoxChild)(this.hbox5[this.label4]));
            w44.Position = 0;
            w44.Expand = false;
            w44.Fill = false;
            // Container child hbox5.Gtk.Box+BoxChild
            this.comboboxSearchAs = Gtk.ComboBox.NewText();
            this.comboboxSearchAs.Name = "comboboxSearchAs";
            this.hbox5.Add(this.comboboxSearchAs);
            Gtk.Box.BoxChild w45 = ((Gtk.Box.BoxChild)(this.hbox5[this.comboboxSearchAs]));
            w45.Position = 1;
            w45.Expand = false;
            w45.Fill = false;
            this.table1.Add(this.hbox5);
            Gtk.Table.TableChild w46 = ((Gtk.Table.TableChild)(this.table1[this.hbox5]));
            w46.TopAttach = ((uint)(1));
            w46.BottomAttach = ((uint)(2));
            w46.LeftAttach = ((uint)(2));
            w46.RightAttach = ((uint)(3));
            w46.XOptions = ((Gtk.AttachOptions)(4));
            w46.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.LabelProp = Mono.Unix.Catalog.GetString("_Search:");
            this.label2.UseUnderline = true;
            this.table1.Add(this.label2);
            Gtk.Table.TableChild w47 = ((Gtk.Table.TableChild)(this.table1[this.label2]));
            w47.LeftAttach = ((uint)(1));
            w47.RightAttach = ((uint)(2));
            w47.XOptions = ((Gtk.AttachOptions)(4));
            w47.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("R_eplace:");
            this.label3.UseUnderline = true;
            this.table1.Add(this.label3);
            Gtk.Table.TableChild w48 = ((Gtk.Table.TableChild)(this.table1[this.label3]));
            w48.TopAttach = ((uint)(2));
            w48.BottomAttach = ((uint)(3));
            w48.LeftAttach = ((uint)(1));
            w48.RightAttach = ((uint)(2));
            w48.XOptions = ((Gtk.AttachOptions)(4));
            w48.YOptions = ((Gtk.AttachOptions)(4));
            this.hbox3.Add(this.table1);
            Gtk.Box.BoxChild w49 = ((Gtk.Box.BoxChild)(this.hbox3[this.table1]));
            w49.Position = 0;
            // Container child hbox3.Gtk.Box+BoxChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            // Container child vbox3.Gtk.Box+BoxChild
            this.hbox7 = new Gtk.HBox();
            this.hbox7.Name = "hbox7";
            this.hbox7.Spacing = 6;
            // Container child hbox7.Gtk.Box+BoxChild
            this.fixed1 = new Gtk.Fixed();
            this.fixed1.Name = "fixed1";
            this.fixed1.HasWindow = false;
            this.hbox7.Add(this.fixed1);
            Gtk.Box.BoxChild w50 = ((Gtk.Box.BoxChild)(this.hbox7[this.fixed1]));
            w50.Position = 0;
            // Container child hbox7.Gtk.Box+BoxChild
            this.buttonSearchMode = new Gtk.Button();
            this.buttonSearchMode.CanFocus = true;
            this.buttonSearchMode.Name = "buttonSearchMode";
            this.buttonSearchMode.Relief = ((Gtk.ReliefStyle)(2));
            // Container child buttonSearchMode.Gtk.Container+ContainerChild
            this.arrow4 = new Gtk.Arrow(((Gtk.ArrowType)(1)), ((Gtk.ShadowType)(0)));
            this.arrow4.Name = "arrow4";
            this.buttonSearchMode.Add(this.arrow4);
            this.buttonSearchMode.Label = null;
            this.hbox7.Add(this.buttonSearchMode);
            Gtk.Box.BoxChild w52 = ((Gtk.Box.BoxChild)(this.hbox7[this.buttonSearchMode]));
            w52.Position = 1;
            w52.Expand = false;
            w52.Fill = false;
            this.vbox3.Add(this.hbox7);
            Gtk.Box.BoxChild w53 = ((Gtk.Box.BoxChild)(this.vbox3[this.hbox7]));
            w53.Position = 0;
            w53.Expand = false;
            w53.Fill = false;
            this.hbox3.Add(this.vbox3);
            Gtk.Box.BoxChild w54 = ((Gtk.Box.BoxChild)(this.hbox3[this.vbox3]));
            w54.Position = 1;
            this.Add(this.hbox3);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.Show();
        }
    }
}
