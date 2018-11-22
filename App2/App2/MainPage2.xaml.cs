using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using Xamarin.Forms;



namespace App2

{

    public partial class MainPage2 : ContentPage

    {

        public MainPage2()

        {

            InitializeComponent();

            ButtonBMI.Clicked += ButtonClickEvent;

            ButtonBMI2.Clicked += ButtonClickEvent2;

        }



        private void ButtonClickEvent2(object sender, EventArgs e)

        {

            float height = float.Parse(EntryHeight.Text);
            float weight = int.Parse(EntryWeight.Text);
            if (height > 2.72)
            {
                float Dheight = height / 100;
                float Dresult = weight / (Dheight * Dheight);
                Navigation.PushModalAsync(new NavigationPage(new BmiResult(Dresult)));
            }
            else
            {
                float result = weight / (height * height);
                Navigation.PushModalAsync(new NavigationPage(new BmiResult(result)));
            }

            }



        private void ButtonClickEvent(object sender, EventArgs e)

        {
            
            float height = float.Parse(EntryHeight.Text);
            float weight = int.Parse(EntryWeight.Text);
            if (height > 2.72)
            {
                float Dheight = height / 100;
                LabelResult.Text = "" + (weight / (Dheight * Dheight));
            }
            else
            {
                LabelResult.Text = "" + (weight / (height * height));
            }

        }

    }

}