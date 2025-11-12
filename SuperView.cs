namespace portfolioTUI {
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
    
   
    public class SuperView : Terminal.Gui.Views.Window {
        LandingPageView landingPage = new ();
        AboutPageView aboutPage = new ();
        private Bar appBar;

        Shortcut short1 = new Shortcut();
        public SuperView() {
            this.KeyBindings.Clear();
            
            this.Width = Dim.Fill(0);
            this.Height = Dim.Fill(0);
            this.X = 0;
            this.Y = 0;
            this.Visible = true;
            this.Arrangement = Terminal.Gui.ViewBase.ViewArrangement.Fixed;
            this.CanFocus = true;
            this.ShadowStyle = Terminal.Gui.ViewBase.ShadowStyle.None;
            this.Modal = false;
            this.TextAlignment = Terminal.Gui.ViewBase.Alignment.Start;
            this.Title = "Portfolio TUI";
            //this.Add(landingPage);

            this.appBar = new Bar();
            this.appBar.Width = Dim.Auto();
            this.appBar.Height = Dim.Auto();
            this.appBar.X = Pos.Center();
            this.appBar.Y = Pos.Top(this);
            this.appBar.Visible = true;
            this.appBar.Arrangement = Terminal.Gui.ViewBase.ViewArrangement.Fixed;
            this.appBar.CanFocus = true;
            this.appBar.ShadowStyle = Terminal.Gui.ViewBase.ShadowStyle.None;
            this.short1.Title = "testing";
            this.short1.Visible = true;
            this.appBar.AddShortcutAt(0,this.short1);
            this.Add(this.appBar);

            //  Toggle visibility of Label on keypress
            this.AddCommand(Command.Accept, () => 
                {
                    if (!aboutPage.IsCurrentTop)
                    {
                        this.RemoveAll();
                        this.Add(aboutPage);
                        aboutPage.HasFocus = true;
                        return true;
                    }
                    return true;
                }
            );
            this.KeyBindings.Add(Key.D1, Command.Accept);

            this.AddCommand(Command.Edit, () =>
                {
                    if (!landingPage.IsCurrentTop)
                    {
                        this.RemoveAll();
                        this.Add(landingPage);
                        this.HasFocus = true;

                        return true;
                    }
                    return true;
                }
            );
            this.KeyBindings.Add(Key.D2, Command.Edit);
        }
    }
}
