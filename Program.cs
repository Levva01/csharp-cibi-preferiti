// See https://aka.ms/new-console-template for more information

string[] favouriteFoods = new string[] {
                "Pizza",
                "Sushi",
                "Gelato",
                "Torta",
                "Pasta"
};

int i = 0;

int lunghezzaArray = favouriteFoods.Length;

Console.WriteLine($"Lunghezza della classifica {lunghezzaArray}");

favouriteFoods[1] = "Gelato";
favouriteFoods[2] = "Torta";
favouriteFoods[3] = "Pasta";
favouriteFoods[4] = "Sushi";

Console.WriteLine("");
Console.WriteLine("Classifica: ");

for(i = 0; i < favouriteFoods.Length; i++)
{
    Console.WriteLine($"{i+1}. {favouriteFoods[i]}");
}

Console.WriteLine("");
Console.WriteLine($"Cibo preferito: {favouriteFoods[0]}");
Console.WriteLine($"Ultimo cibo preferito: {favouriteFoods[4]}");

int mediana = 0;

if ((lunghezzaArray / 2) % 2 == 0)
{
    mediana = lunghezzaArray / 2;
} else
{
    mediana = lunghezzaArray / 2 - 1;
}

Console.WriteLine($"Mediana: {favouriteFoods[mediana]}");