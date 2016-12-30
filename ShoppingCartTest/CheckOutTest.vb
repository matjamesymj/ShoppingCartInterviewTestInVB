Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports ShoppingCart

<TestClass()> Public Class CheckOutTest

    <TestMethod()> Public Sub BuyOneGetOneFreeAdd2Products()
        Dim product As Product = New Product
        Dim checkout As CheckOut = New CheckOut

        With product
            .ProductKEY = "FR1"
            .Name = "Fruit tea"
            .Price = 3.11
            .Promotion = Promotion.BOGOFF
        End With


        checkout.AddCart(product)
        checkout.AddCart(product)

        Assert.IsTrue(checkout.cart.TotalCost = 3.11)
    End Sub


    <TestMethod()> Public Sub BuyOneGetOneFreeAdd1Product()
        Dim product As Product = New Product
        Dim checkout As CheckOut = New CheckOut

        With product
            .ProductKEY = "FR1"
            .Name = "Fruit tea"
            .Price = 3.11
            .Promotion = Promotion.BOGOFF
        End With


        checkout.AddCart(product)

        Assert.IsTrue(checkout.cart.TotalCost = 3.11)
    End Sub

    <TestMethod()> Public Sub TenPercentOffTestAdd3SR1OneFR1()
        Dim product As Product = New Product

        Dim product2 As Product = New Product

        Dim checkout As CheckOut = New CheckOut

        With product
            .ProductKEY = "SR1"
            .Name = "Strawberry"
            .Price = 5
            .Promotion = Promotion.TenPercentOffIf3OrMore
        End With

        With product2
            .ProductKEY = "FR1"
            .Name = "Fruit tea"
            .Price = 3.11
            .Promotion = Promotion.BOGOFF
        End With


        checkout.AddCart(product)
        checkout.AddCart(product)
        checkout.AddCart(product)
        checkout.AddCart(product2)

        Assert.IsTrue(checkout.cart.TotalCost = 16.61)
    End Sub

    <TestMethod()> Public Sub Basket1Test()
        Dim Strawberry As Product = New Product

        Dim FruitTea As Product = New Product

        Dim Coffee As Product = New Product

        Dim checkout As CheckOut = New CheckOut

        With Strawberry
            .ProductKEY = "SR1"
            .Name = "Strawberry"
            .Price = 5
            .Promotion = Promotion.TenPercentOffIf3OrMore
        End With

        With FruitTea
            .ProductKEY = "FR1"
            .Name = "Fruit tea"
            .Price = 3.11
            .Promotion = Promotion.BOGOFF
        End With

        With Coffee
            .ProductKEY = "CF1"
            .Name = "Coffe"
            .Price = 11.23
            .Promotion = Promotion.NA
        End With


        checkout.AddCart(FruitTea)
        checkout.AddCart(FruitTea)
        checkout.AddCart(FruitTea)
        checkout.AddCart(Strawberry)
        checkout.AddCart(Coffee)

        Assert.IsTrue(checkout.cart.TotalCost = 22.45)
    End Sub

End Class