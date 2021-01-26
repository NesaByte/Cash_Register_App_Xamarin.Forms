using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            /*Slider slider = new Slider
            {
                Maximum = 50,
                Minimum = 16,
                Value = 0
                
            };

            Label displayLabel = new Label
            {
                Text = "Font Size is 0",
                //HorizontalOptions = LayoutOptions.Center,
                //VerticalOptions = LayoutOptions.CenterAndExpand
            }; 
            
            slider.ValueChanged += (sender, args) =>
            {
                //rotationLabel.Rotation = slider.Value;
                displayLabel.Text = String.Format("Font Size is {0}", args.NewValue);
            };


            Content = new StackLayout
            {
                Children =
            {
                //rotationLabel,
                displayLabel,
                slider
            }
            };
            
            Label rotationLabel = new Label
            {
                Text = "ROTATING TEXT",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Label displayLabel = new Label
            {
                Text = "(uninitialized)",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Slider slider = new Slider
            {
                Maximum = 360
            };
            slider.ValueChanged += (sender, args) =>
            {
                rotationLabel.Rotation = slider.Value;
                displayLabel.Text = String.Format("The Slider value is {0}", args.NewValue);
            };

            Title = "Basic Slider Code";
            Padding = new Thickness(10, 0);
            Content = new StackLayout
            {
                Children =
            {
                rotationLabel,
                slider,
                displayLabel
            }
            };*/
            InitializeComponent();
        }
    }
}
