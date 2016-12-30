Public Interface ICheckOut
    Function AddCart(ByVal product As Product) As Cart
    Function RemoveFromcart(ByVal cartItem As CartItem) As Cart
    Function ViewCart() As Cart

End Interface
