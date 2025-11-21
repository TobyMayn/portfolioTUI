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

    public partial class ContactPageView : View {
        
        
        private Label label;
        private Label name;
        private Label email;
        private Label message;
        private TextField nameInput;
        private TextField emailInput;
        private TextField messageInput;
        private Button submitButton;
        
        private bool visible = true;    

        public void InitializeComponent() {
            
            this.X = 0;
            this.Y = 0;
            this.Width = Dim.Fill();
            this.Height = Dim.Fill();

            this.label = new Label();
            this.label.Width = Dim.Auto();
            this.label.Height = Dim.Auto();
            this.label.X = Pos.Center();
            this.label.Y = Pos.Center()-10;
            this.label.Visible = visible;
            this.label.Arrangement = Terminal.Gui.ViewBase.ViewArrangement.Fixed;
            this.label.CanFocus = false;
            this.label.ShadowStyle = Terminal.Gui.ViewBase.ShadowStyle.None;
            this.label.Data = "label";
            this.label.Text = "Contact Me";
            this.label.TextAlignment = Terminal.Gui.ViewBase.Alignment.Start;
            this.name = new Label 
            { 
                Text = "Name: ",
                X = Pos.Left(this.label)-10,
                Y = Pos.Bottom(this.label) + 1, 
            };
            this.nameInput = new TextField 
            {
                X = Pos.Right(this.name) + 1,
                Y = Pos.Bottom(this.label) + 1,
                Width = Dim.Fill()-30, 
            };

            this.email = new Label
            { 
                Text = "Email: ",
                X = Pos.Left(this.name),
                Y = Pos.Bottom(this.name) +1
            };
            this.emailInput = new TextField
            {
                X = Pos.Right(this.email) + 1,
                Y = Pos.Bottom(this.name) + 1,
                Width = Dim.Fill() - 30, 
            };

            this.message = new Label
            { 
                Text = "Message: ",
                X = Pos.Left(this.email),
                Y = Pos.Bottom(this.email) + 1 
            };
            this.messageInput = new TextField
            {
                X = Pos.Right(this.message) + 1,
                Y = Pos.Bottom(this.email) + 1,
                Width = Dim.Fill() - 30,
            };

            this.submitButton = new Button
            {
                Text = "Submit",
                Y = Pos.Bottom (this.message) + 1,

                // center the login button horizontally
                X = Pos.Center (),
                IsDefault = true
            };

            this.submitButton.Accepting += (s, e) =>
            {
                // Handle the submit button click event
                string name = this.nameInput.Text.ToString();
                string email = this.emailInput.Text.ToString();
                string message = this.messageInput.Text.ToString();

                // For demonstration, just show a message box
                MessageBox.Query(50, 7, "Submitted", $"Name: {name}\nEmail: {email}\nMessage: {message}", "OK");
            };

            this.Add (
                this.label, this.name, this.nameInput, 
                this.email, this.emailInput, this.messageInput, 
                this.message, this.submitButton
            );
            
        }
    }
}
