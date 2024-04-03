Console.Clear();
 
Console.WriteLine("\n >>>SOLETRANDO<<< \n");

Console.Write("Escreva o texto a ser soletrado: ");
 
string texto = Console.ReadLine();
 
Console.WriteLine("\nSoletrando esta palavra ficará...\n");
 
Console.WriteLine(

String.Join("-", texto.ToUpper().ToCharArray())

);
 
Console.WriteLine();