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
    
    
    public partial class ProjectsPageView : View {
        
        
        private Terminal.Gui.Views.Label label;
        private Terminal.Gui.Views.Label projectTitle;
        
        private bool visible = true;    
        private string graphiti = @"__________                   __               __          
\______   \_______  ____    |__| ____   _____/  |_  ______
 |     ___/\_  __ \/  _ \   |  |/ __ \_/ ___\   __\/  ___/
 |    |     |  | \(  <_> )  |  \  ___/\  \___|  |  \___ \ 
 |____|     |__|   \____/\__|  |\___  >\___  >__| /____  >
                        \______|    \/     \/          \/ 
______________________________________
______________________________________";

        public void InitializeComponent() {

            this.X = 0;
            this.Y = 0;
            this.Width = Dim.Auto();
            this.Height = Dim.Auto();
            this.projectTitle = new Terminal.Gui.Views.Label();
            this.projectTitle.Width = Dim.Auto();
            this.projectTitle.Height = Dim.Auto();
            this.projectTitle.X = Pos.Align(Alignment.Start);
            this.projectTitle.Y = Pos.Align(Alignment.Start);
            this.projectTitle.Data = "title";
            this.projectTitle.Text = graphiti;
            this.projectTitle.Visible = visible;
            this.projectTitle.Arrangement = Terminal.Gui.ViewBase.ViewArrangement.Fixed;
            this.projectTitle.CanFocus = false;
            this.projectTitle.ShadowStyle = Terminal.Gui.ViewBase.ShadowStyle.None;
            this.projectTitle.TextAlignment = Terminal.Gui.ViewBase.Alignment.Start;
            this.Add(this.projectTitle);

            // this.label = new Terminal.Gui.Views.Label();
            // this.label.Width = Dim.Auto();
            // this.label.Height = Dim.Auto();
            // this.label.X = Pos.Center();
            // this.label.Y = Pos.Center();
            // this.label.Visible = visible;
            // this.label.Arrangement = Terminal.Gui.ViewBase.ViewArrangement.Fixed;
            // this.label.CanFocus = false;
            // this.label.ShadowStyle = Terminal.Gui.ViewBase.ShadowStyle.None;
            // this.label.Data = "label";
            // this.label.Text = "Hello there, This is the projects page";
            // this.KeyBindings.Clear();
            // this.label.TextAlignment = Terminal.Gui.ViewBase.Alignment.Start;
            // this.Add(this.label);
            
        }
    }
}
