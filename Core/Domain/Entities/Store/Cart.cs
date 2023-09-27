using Domain.Entities.CMS;
using Domain.Primitives;
using System;
using System.Collections.Generic;

namespace Domain.Entities.Store;

public sealed class Cart : Entity
{
    private Cart(Guid id, Customer customer, DateTime createdDateTime) : base(id)
    {
        Customer = customer;
        CreatedDateTime = createdDateTime;
    }
    private readonly List<CartItem> _cartItems = new();

    public Customer Customer { get; private set; }
    public DateTime CreatedDateTime { get; private set; }
    public IReadOnlyCollection<CartItem> CartItems => _cartItems;

    public static Cart Create(Guid id, Customer customer, DateTime createdDateTime)
    {
        var cart = new Cart(id, customer, createdDateTime);
        return cart;
    }

    public CartItem AddItem(Guid id, Stuff stuff, decimal count)
    {
        var cartItem = CartItem.Create(id, this, stuff, count);
        _cartItems.Add(cartItem);
        return cartItem;
    }

}
