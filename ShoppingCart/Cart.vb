Public Class Cart
    Property cartID As Guid
    Property CartItems As List(Of CartItem)

    Public ReadOnly Property TotalCost() As Decimal
        Get
            Return CartItems.Sum(Function(x) x.TotalCost)
        End Get

    End Property

    Public Sub New()
        CartItems = New List(Of CartItem)
    End Sub
End Class
