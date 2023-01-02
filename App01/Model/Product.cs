namespace App01.Model;

public class Product
{
    //Field
    private int tag;


    //prop tab
    //Property
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }


    //propfull tab

    private int rate;

    public int Rate
    {
        get { return rate; }
        set { rate = value; }
    }

    public Product()
    {
        Id = new Random().Next();
    }

    public Product(string Name, int Price) : this()
    {
        //Id = new Random().Next(); 🐞
        this.Name = Name;
        this.Price = Price;
    }

    public Product(string Name): this(Name, 500)
    {
        //Id = new Random().Next(); 🐞
        //this.Name = Name;
        //this.Price = 500;
    }
}