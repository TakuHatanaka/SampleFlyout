using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SampleFlyout
{
    public partial class FlyoutPage : ContentPage
    {
        public FlyoutPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var listViewList = new List<ItemModel>
            {
                new ItemModel
                {
                    Text = "テスト１"
                },
                new ItemModel
                {
                    Text = "テスト２"
                }
            };


            var vm = new FlyoutPageViewModel
            {
                Items = listViewList
            };

            this.BindingContext = vm;
        }
    }
}
