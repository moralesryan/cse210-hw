using System;
class  Order
{
    private List<Product> _products = new List<Product>();

    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public double _calcTotalCost()
    {
        double sum = 0;
        foreach (Product p in _products)
        {
            sum += p.TotalCost();
        }
        
        double shippingCost;
        
        if (_customer.InUsa())
        {
            shippingCost = 5;
        }

        else
        {
            shippingCost = 35;
        }
        
        return sum + shippingCost;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public string _displayPackingLabel()
    {
        string label = $"Packing list: \n";
        foreach (Product p in _products)
        {
            label += p.GetPackingInfo();
        }
        return label;
    }

    public string _displayShippingLabel()
    {
        return $"Ship to: {_customer.GetName()}\n{_customer.GetAddress()}";
    }



}
