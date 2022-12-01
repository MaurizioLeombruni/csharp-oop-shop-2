using CSharpOOPShop2;

BottledWater bottigliaTest = new("Acqua Liquida", "I can't believe it's water!(?)", 20.5f, 1.5f, 2, "Vesuvio", true);

bottigliaTest.PrintProductDetails();
bottigliaTest.Drink(2.0f);
Console.WriteLine("Litri adesso: " + bottigliaTest.GetLiters());
bottigliaTest.Refill(20.0f);
bottigliaTest.Empty();
bottigliaTest.Drink(0.5f);
bottigliaTest.Deflate();