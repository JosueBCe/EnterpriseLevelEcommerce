﻿namespace eShopOnContainers.Views;

public partial class OrderDetailView : ContentPageBase
{
    public OrderDetailView(OrderDetailViewModel viewModel)
    {
        BindingContext = viewModel;
        InitializeComponent();
    }
}
