using System;
using System.Collections.Generic;
using JobPortal.ViewModels;
using JobPortal.Views;
using Xamarin.Forms;

namespace JobPortal
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
