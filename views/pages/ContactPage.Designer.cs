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
            var name = new Label 
            { 
                Text = "Name: ",
                X = Pos.Left(this.label)-10,
                Y = Pos.Bottom(this.label) + 1, 
            };
            var nameInput = new TextField 
            {
                X = Pos.Right(name) + 1,
                Y = Pos.Bottom(this.label) + 1,
                Width = Dim.Fill()-30, 
            };

            var email = new Label
            { 
                Text = "Email: ",
                X = Pos.Left(name),
                Y = Pos.Bottom(name) +1
            };
            var emailInput = new TextField
            {
                X = Pos.Right(email) + 1,
                Y = Pos.Bottom(name) + 1,
                Width = Dim.Fill() - 30, 
            };

            var message = new Label
            { 
                Text = "Message: ",
                X = Pos.Left(email),
                Y = Pos.Bottom(email) + 1 
            };

            var messageInput = new TextField
            {
                X = Pos.Right(message) + 1,
                Y = Pos.Bottom(email) + 1,
                Width = Dim.Fill() - 30,
            };

            var submitButton = new Button
            {
                Text = "Submit",
                Y = Pos.Bottom (message) + 1,

                // center the login button horizontally
                X = Pos.Center (),
                IsDefault = true
            };

            submitButton.Accepting += (s, e) =>
            {
                // Handle the submit button click event
                string name = nameInput.Text.ToString();
                string email = emailInput.Text.ToString();
                string message = messageInput.Text.ToString();

                // For demonstration, just show a message box
                MessageBox.Query(50, 10, "Submitted", $"Name: {name}\nEmail: {email}\nMessage: {message}", "OK");
            };

            this.Add (
                this.label, name, nameInput, 
                email, emailInput, messageInput, 
                message, submitButton
            );
            this.CanFocus = true;
            
        }
    }
}
