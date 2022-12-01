﻿using CSharpOOPShop2;

string[] fruitForBasket = { "banana", "banana", "mela", "mandarino", "mandarino", "arancia" };

BottledWater bottigliaTest = new("Acqua Liquida", "I can't believe it's water!(?)", 20.5f, 5, 2, "Vesuvio", true);
FruitBasket fruttaTest = new("Cestelloh", "E' un cestello di frutta.", 8.5f, fruitForBasket);
Appliance aggeggioTest = new("Fornello", "Non sembra veramente un fornello.", 525.75f, 200.0f, 750);

bottigliaTest.PrintProductDetails();
bottigliaTest.Drink(2.0f);
Console.WriteLine("Litri adesso: " + bottigliaTest.GetLiters());
bottigliaTest.Refill(20.0f);
bottigliaTest.Empty();
bottigliaTest.Drink(0.5f);
bottigliaTest.Deflate();


fruttaTest.PrintProductDetails();
fruttaTest.Eat();
fruttaTest.AddFruitToBasket("pera");
fruttaTest.GetFruitInBasket();

aggeggioTest.PrintProductDetails();
aggeggioTest.Move(20.0f);
aggeggioTest.Move(200.0f);
aggeggioTest.Install(1000);
aggeggioTest.TurnOn();
aggeggioTest.TurnOff();