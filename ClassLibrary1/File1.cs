using System;

public partial class Product
{
    private int _productID;

    public int ProductID
    {
        set
        {
            _productID = value;
        }
        get
        {
            return _productID;
        }
    }

    partial void GetTax();

}