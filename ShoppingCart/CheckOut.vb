Public Class CheckOut
    Implements ICheckOut
    Property cart As Cart


    Public Function AddCart(product As Product) As Cart Implements ICheckOut.AddCart

        Dim cartItem As CartItem
        'check if product exists in cart
        cartItem = cart.CartItems.Find(Function(x) x.Product.ProductKEY = product.ProductKEY)

        If IsNothing(cartItem) Then
            'product not in cart
            cartItem = New CartItem
            With cartItem
                .Product = product
                .Quantity = 1
            End With
            cart.CartItems.Add(cartItem)
        Else
            'product exists so increase quanity
            cartItem.Quantity += 1

        End If
    End Function

    Public Function RemoveFromcart(cartItem As CartItem) As Cart Implements ICheckOut.RemoveFromcart
        cart.CartItems.Remove(cartItem)
    End Function

    Public Function ViewCart() As Cart Implements ICheckOut.ViewCart
        Return cart
    End Function

    Public Sub New()
        cart = New Cart
    End Sub
End Class
