using Domain.Entities.Store.Errors;
using Domain.Primitives;
using Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Entities.Store;

public sealed class Cart : AggregateRoot
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

    public Result<CartItem> AddItem(Guid id, Stuff stuff, decimal count)
    {
        if (stuff is null)
        {
            return Result.Failure<CartItem>(DomainErrors.CantInsertNullStuffIntoTheCart);
        }
        if (count <= 0)
        {
            return Result.Failure<CartItem>(DomainErrors.InvalidCount);
        }
        if (CartItems.Any(p => p.Stuff.Id == stuff.Id))
        {
            return Result.Failure<CartItem>(DomainErrors.StuffIsAlreadyExistsInCartError);
        }

        var cartItem = CartItem.Create(id, this, stuff, count);
        _cartItems.Add(cartItem);
        return cartItem;
    }
}
