// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Inserisci la base del rettangolo in cm.");
int myRectangleBase = int.Parse(Console.ReadLine());
Console.WriteLine($"La tua base è di {myRectangleBase} cm");

Console.WriteLine("Inserisci l'altezza del rettangolo in cm.");
int myRectangleHeight = int.Parse(Console.ReadLine());
Console.WriteLine($"La tua altezza è di {myRectangleHeight} cm");

myRectangle rectangle1 = new myRectangle(myRectangleBase, myRectangleHeight);




int finalResultArea = rectangle1.AreaCalc(myRectangleBase, myRectangleHeight);
int finalResultPerimeter = rectangle1.PerimeterCalc(myRectangleBase, myRectangleHeight);


Console.WriteLine($"L'area del tuo rettangolo è di {finalResultArea} cm2");
Console.WriteLine($"Il perimetro del tuo rettangolo è di {finalResultPerimeter} cm.");

rectangle1.PrintRectangle(myRectangleBase, myRectangleHeight);



