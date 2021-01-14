using System;

class MainClass {
  public static void Main (string[] args) {
   // Products sınıfını oluşturduk ve urunleri tanımladık.
    Products product1 = new Products();
    product1.PriceofProduct = "550";
    product1.ColourofProduct = "red";
    product1.SizeofProduct = "Small";
    product1.BrandofProduct = "Adidas";

    Products product2 = new Products();
    product2.PriceofProduct = "450";
    product2.ColourofProduct = "blue";
    product2.SizeofProduct = "medium";
    product2.BrandofProduct = "nike";

    Products product3 = new Products();
    product3.PriceofProduct = "350";
    product3.ColourofProduct = "orange";
    product3.SizeofProduct = "large";
    product3.BrandofProduct = "gucci";

    Products product4 = new Products();
    product4.PriceofProduct = "950";
    product4.ColourofProduct = "pink";
    product4.SizeofProduct = "xsmall";
    product4.BrandofProduct = "channel";

    Products[] urunler = new Products[] {product1, product2,product3,product4};

    //write on the screen with foreach 
    foreach (var a in urunler)
    {
      Console.WriteLine("Price : " + a.PriceofProduct + " colour : " + a.ColourofProduct + " size : " + a.SizeofProduct + " Brand : " + a.BrandofProduct);
    }
    Console.WriteLine("foreach döngüsünün sonu");

    // write on the screen wit for loop
    for ( int i = 0; i < urunler.Length ; i++)
    {
      Console.WriteLine ("Price : " + urunler[i].PriceofProduct + " Colour : " + urunler[i].ColourofProduct + " Size : " + urunler[i].SizeofProduct + " Brand : " + urunler[i].BrandofProduct);
    }
    Console.WriteLine("for dongusunun sonu");

    // write on the screen with while loop
    int c=0;
      while (c < urunler.Length)
      {
        Console.WriteLine("Price : " + urunler[c].PriceofProduct + " Colour : " + urunler[c].ColourofProduct + " Size : " + urunler[c].SizeofProduct + " Brand : " + urunler[c].BrandofProduct);
        c++;
      }
    Console.WriteLine ("While dongusunun sonu");
  }

  class Products
  {
  public string PriceofProduct {get; set;}
  public string ColourofProduct {get; set;}
  public string SizeofProduct {get; set;}
  public string BrandofProduct {get; set;}
  }
}
