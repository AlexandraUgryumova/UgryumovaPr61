using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zad5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Money :ContentPage
    {
        private Button myButton;
        private Button myButton2;
        private Button myButton3;
        private Button myButton4;
        private Button myButton5;
        private Button myButton6;
        private Button myButton7;
        private Button myButton8;
        private Button myButton9;
        private Picker myPicker;
        private Switch CheckBox;
        private Switch CheckBox2;
        private Switch CheckBox3;
        private RadioButton RadioButton1;
        private RadioButton RadioButton2;
        private CheckBox CheckBox4;
        private CheckBox CheckBox5;
        private string option;

        public Money(string username)
        {
            InitializeComponent();
            
            var usernameLabel = new Label
            {
                TextColor = Color.Black,
                Text = $"Добро пожаловать, {username}!",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            myButton = new Button
            {
                Text = "LARGE",
                Margin = new Thickness(5, 0, 5, 0),
                StyleId = "stylebut",
                WidthRequest = 120,
                HeightRequest = 60
            };
            myButton.Clicked += MyButton_Clicked;

            myButton2 = new Button
            {
                Text = "LARGE",
                Margin = new Thickness(0, 0, 5, 0),
                StyleId = "stylebut2",
                WidthRequest = 120,
                HeightRequest = 60
            };
            myButton2.Clicked += MyButton_Clicked;

            myButton3 = new Button
            {
                Text = "BUTTON",
                Margin = new Thickness(0, 0, 0, 0),
                StyleId = "stylebut3",
                WidthRequest = 120
            };
            myButton3.Clicked += MyButton_Clicked;

            myButton4 = new Button
            {
                Text = "NORMAL",
                Margin = new Thickness(5, 0, 5, 0),
                StyleId = "stylebut4",
                WidthRequest = 120
            };
            myButton4.Clicked += MyButton_Clicked;

            myButton5 = new Button
            {
                Text = "NORMAL",
                Margin = new Thickness(0, 0, 5, 0),
                StyleId = "stylebut5",
                WidthRequest = 120
            };
            myButton5.Clicked += MyButton_Clicked;

            myButton6 = new Button
            {
                Text = "BUTTON",
                Margin = new Thickness(0, 0, 0, 0),
                StyleId = "stylebut6",
                WidthRequest = 120
            };
            myButton6.Clicked += MyButton_Clicked;

            myButton7 = new Button
            {
                Text = "SMALL",
                Margin = new Thickness(5, 0, 5, 0),
                StyleId = "stylebut7",
                WidthRequest = 120,
                HeightRequest = 20
            };
            myButton7.Clicked += MyButton_Clicked;

            myButton8 = new Button
            {
                Text = "SMALL",
                Margin = new Thickness(0, 0, 5, 0),
                StyleId = "stylebut8",
                WidthRequest = 120,
                HeightRequest = 20
            };
            myButton8.Clicked += MyButton_Clicked;

            myButton9 = new Button
            {
                Text = "BUTTON",
                Margin = new Thickness(0, 0, 0, 0),
                StyleId = "stylebut9",
                WidthRequest = 120
            };
            myButton9.Clicked += MyButton_Clicked;


            CheckBox = new Switch
            {
                BackgroundColor = Color.White,
                OnColor = Color.Gray,
                ThumbColor = Color.LightGray

            };
            CheckBox.Toggled += (sender, e) =>
            {
                if (CheckBox.IsToggled)
                {
                    
                    CheckBox.BackgroundColor = Color.White;
                    CheckBox.ThumbColor = Color.LightGray;
                    CheckBox.OnColor = Color.Green;
                }
                else
                {
                    CheckBox.BackgroundColor = Color.White;
                    CheckBox.ThumbColor = Color.LightGray;
                    CheckBox.OnColor = Color.Gray;
                }
            };
            CheckBox2 = new Switch
            {
                BackgroundColor = Color.White,
                OnColor = Color.Gray,
                ThumbColor = Color.LightGray

            };
            CheckBox2.Toggled += (sender, e) =>
            {
                if (CheckBox2.IsToggled)
                {
                    
                    CheckBox2.BackgroundColor = Color.White;
                    CheckBox2.ThumbColor = Color.LightGray;
                    CheckBox2.OnColor = Color.Green;
                }
                else
                {
                    CheckBox2.BackgroundColor = Color.White;
                    CheckBox2.ThumbColor = Color.LightGray;
                    CheckBox2.OnColor = Color.Gray;
                }
            };
            CheckBox3 = new Switch
            {
                BackgroundColor = Color.White,
                OnColor = Color.Gray,
                ThumbColor = Color.LightGray

            };
            CheckBox3.Toggled += (sender, e) =>
            {
                if (CheckBox3.IsToggled)
                {
                    
                    CheckBox3.BackgroundColor = Color.White;
                    CheckBox3.ThumbColor = Color.LightGray;
                    CheckBox3.OnColor = Color.Green;
                }
                else
                {
                    CheckBox3.BackgroundColor = Color.White;
                    CheckBox3.ThumbColor = Color.LightGray;
                    CheckBox3.OnColor = Color.Gray;
                }
            };
            RadioButton1 = new RadioButton
            {
                StyleId = "RadioButton",
                IsChecked = true
            };
            RadioButton2 = new RadioButton
            {
                StyleId = "RadioButton",
                IsChecked = false
            };
            CheckBox4 = new CheckBox
            {
                BackgroundColor = Color.White,
                Color = Color.Green,
                IsChecked = true
            };
            CheckBox5 = new CheckBox
            {
                BackgroundColor =Color.White,
                Color = Color.Green,
                IsChecked = false
            };
            
            myPicker = new Picker
            {
                Title = "DROPDOWN",
                Margin = new Thickness(5, 0, 200, 0),
                StyleId = "Picker"
            };
            myPicker.Items.Add("Option 1");
            myPicker.Items.Add("Option 2");
            myPicker.Items.Add("Option 3");
            myPicker.SelectedIndexChanged += MyPicker_SelectedIndexChanged;

            Content = new StackLayout
            {
                BackgroundColor = Color.White,
                Padding = new Thickness(10, 40, 10, 0),
                Children =
                {
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            myButton,
                            myButton2,
                            myButton3
                        }
                    },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            myButton4,
                            myButton5,
                            myButton6
                        }
                    },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            myButton7,
                            myButton8,
                            myButton9
                        }
                    },
                    myPicker,
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        { 
                            new StackLayout
                            {
                                Orientation = StackOrientation.Vertical,
                                Children =
                                {
                                    CheckBox,
                                    CheckBox2,
                                    CheckBox3,
                                }
                            },
                            new StackLayout
                            {
                                Orientation = StackOrientation.Vertical,
                                Children=
                                {
                                   RadioButton1,
                                   RadioButton2,
                                   CheckBox4,
                                   CheckBox5
                                }
                            }
                        }
                    },
                }
            };

        }
        private void MyPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (myPicker.SelectedIndex)
            {
                case 0:
                    option = "Option 1";
                    break;
                case 1:
                    option = "Option 2";
                    break;
                case 2:
                    option = "Option 3";
                    break;
                default:
                    break;
            }
        }

        private void MyButton_Clicked(object sender, EventArgs e)
        {
            if (option != null)
            {
                var show = new Show(option);
                Navigation.PushAsync(show);
            }
            else
            {
                DisplayAlert("ошибочка","вы не выбрали опцию","ну лан");
            }
        }
    }
}