using appAdminManage.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace appAdminManage.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}