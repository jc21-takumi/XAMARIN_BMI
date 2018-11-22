using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



using Xamarin.Forms;

using Xamarin.Forms.Xaml;



namespace App2

{

    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class BmiResult : ContentPage

    {

        private float height;



        public BmiResult()

        {

            InitializeComponent();

            buttonBack.Clicked += buttonBackClicked;

        }



        public BmiResult(float result)

        {

            InitializeComponent();

            float a = result;

            labelBMI.Text = "BMI" + a;

            buttonBack.Clicked += buttonBackClicked;

        }



        private void buttonBackClicked(object sender, EventArgs e)

        {

            Navigation.PopModalAsync();

        }

    }

}