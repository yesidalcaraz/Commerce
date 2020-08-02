namespace Commerce.ViewModels
{
    using Commerce.Common.Models;
    using System.Collections.ObjectModel;
    using Services;
    using Xamarin.Forms;
    using System.Collections.Generic;

    public class ProductsViewModel:BaseViewModel
    {
        private Apiservice apiService;
        private ObservableCollection<Product> products;
        public ObservableCollection<Product> Products
        {
            get { return this.products; }
            set { this.SetValue(ref this.products, value); }
        }
        public ProductsViewModel()
        {
            this.apiService = new Apiservice();
            this.LoadProducts();
        }

        private async void LoadProducts()
        {
            var response = await this.apiService.GetList<Product>("https://salespiservices.azurewebsites.net", "/api", "/Products");
            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert("Error", response.Message, "Accept");
                return;
            }

            var list = (List<Product>)response.Result;
                this.Products = new ObservableCollection<Product>(list);
        }

    }
}
