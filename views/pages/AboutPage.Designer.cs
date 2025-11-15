namespace portfolioTUI {
    using System;
    using Terminal.Gui;
    using Terminal.Gui.App;
    using Terminal.Gui.Drawing;
    using Terminal.Gui.Input;
    using Terminal.Gui.ViewBase;
    using Terminal.Gui.Views;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Drawing;
    
    
    public partial class AboutPageView : View {
        
        
        private Terminal.Gui.Views.Label label;
        private Terminal.Gui.Views.Label aboutTitle;
        private string graphiti = @"   _____ ___.                  __   
  /  _  \\_ |__   ____  __ ___/  |_ 
 /  /_\  \| __ \ /  _ \|  |  \   __\
/    |    \ \_\ (  <_> )  |  /|  |  
\____|__  /___  /\____/|____/ |__|  
        \/    \/                    
______________________________________
______________________________________";
        
        private bool visible = true;    

        public void InitializeComponent() {

            this.X = 0;
            this.Y = 0;
            this.Width = Dim.Auto();
            this.Height = Dim.Auto();

            this.aboutTitle = new Terminal.Gui.Views.Label();
            this.aboutTitle.Width = Dim.Auto();
            this.aboutTitle.Height = Dim.Auto();
            this.aboutTitle.X = Pos.Align(Alignment.Start);
            this.aboutTitle.Y = Pos.Align(Alignment.Start);
            this.aboutTitle.Data = "title";
            this.aboutTitle.Text = graphiti;
            this.aboutTitle.Visible = visible;
            this.aboutTitle.Arrangement = Terminal.Gui.ViewBase.ViewArrangement.Fixed;
            this.aboutTitle.CanFocus = false;
            this.aboutTitle.ShadowStyle = Terminal.Gui.ViewBase.ShadowStyle.None;
            this.aboutTitle.TextAlignment = Terminal.Gui.ViewBase.Alignment.Start;
            this.Add(this.aboutTitle);

            this.label = new Terminal.Gui.Views.Label();
            this.label.Width = Dim.Auto();
            this.label.Height = Dim.Auto();
            this.label.X = Pos.Align(Alignment.Start) + 1;
            this.label.Y = Pos.Align(Alignment.Start) + 9;
            this.label.Visible = visible;
            this.label.Arrangement = Terminal.Gui.ViewBase.ViewArrangement.Fixed;
            this.label.CanFocus = false;
            this.label.ShadowStyle = Terminal.Gui.ViewBase.ShadowStyle.None;
            this.label.Data = "label";
            this.label.Text = "Hello there, This is the About Page!";
            this.label.TextAlignment = Terminal.Gui.ViewBase.Alignment.Start;
            this.Add(this.label);
        }
    }
}
