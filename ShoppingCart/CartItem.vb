Public Class CartItem
    Property CartItemID As Guid
    Property Product As Product
    Property Quantity As Integer

    Private _totalCost As Decimal
    Public ReadOnly Property TotalCost() As Decimal
        Get
            'set up total cost based on no promotion
            _totalCost = Product.Price * Quantity

            Select Case Product.Promotion

                Case Promotion.BOGOFF
                    If Quantity >= 2 Then

                        If Quantity Mod 2 = 0 Then
                            'if we have an exact bogoff
                            _totalCost = (Product.Price * Quantity) / 2
                        Else
                            _totalCost = ((Product.Price * (Quantity - 1)) / 2) + Product.Price
                        End If
                    End If

                Case Promotion.TenPercentOffIf3OrMore
                    If Quantity >= 3 Then
                        _totalCost = (Product.Price * Quantity) * 0.9
                    End If
                Case Else

            End Select
            Return _totalCost
        End Get

    End Property


End Class
