﻿namespace eShopOnContainers.Models.Basket;

public class CustomerBasket
{
    public string BuyerId { get; set; }
    public List<BasketItem> Items { get; set; }
}