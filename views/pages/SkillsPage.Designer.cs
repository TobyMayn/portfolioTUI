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
    
    
    public partial class SkillsPageView : View {
        
        
        private Terminal.Gui.Views.Label label;
        
        private bool visible = true;    

        public void InitializeComponent() {

            this.X = 0;
            this.Y = 0;
            this.Width = Dim.Auto();
            this.Height = Dim.Auto();

            this.label = new Terminal.Gui.Views.Label();
            this.label.Width = Dim.Auto();
            this.label.Height = Dim.Auto();
            this.label.X = Pos.Center();
            this.label.Y = Pos.Center();
            this.label.Visible = visible;
            this.label.Arrangement = Terminal.Gui.ViewBase.ViewArrangement.Fixed;
            this.label.CanFocus = false;
            this.label.ShadowStyle = Terminal.Gui.ViewBase.ShadowStyle.None;
            this.label.Data = "label";
            this.label.Text = "Hello there, this is the skills page";
            this.KeyBindings.Clear();
            this.label.TextAlignment = Terminal.Gui.ViewBase.Alignment.Start;
            this.Add(this.label);
            
        }
    }
}
