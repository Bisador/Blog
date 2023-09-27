using Domain.Primitives;
using System;

namespace Domain.Entities.Store;

public sealed class CartItem : Entity
{
    private CartItem(Guid id, Cart cart, Stuff stuff, decimal count) : base(id)
    {
        Cart = cart;
        Stuff = stuff;
        Count = count;
    }

    public Cart Cart { get; private set; }
    public Stuff Stuff { get; private set; }
    public decimal Count { get; private set; }

    public static CartItem Create(Guid id, Cart cart, Stuff stuff, decimal count)
    {
        var cartItem = new CartItem(id, cart, stuff, count);
        return cartItem;
    }

}
