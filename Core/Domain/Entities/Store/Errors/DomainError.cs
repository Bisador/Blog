

using Domain.Shared;

namespace Domain.Entities.Store.Errors
{
    public static class DomainErrors
    {
        public static readonly Error StuffIsAlreadyExistsInCartError = new(
            code: "Cart.DuplicateStuff",
            message: "Stuff is already exists in cart.");
        public static readonly Error CantInsertNullStuffIntoTheCart = new(
            code: "Cart.NullStuff",
            message: "Can't insert null stuff into the cart.");
        public static readonly Error InvalidCount= new(
            code: "Cart.InvalidCount",
            message: "Invalid count.");
    }
}
