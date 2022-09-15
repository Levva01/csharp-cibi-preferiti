// See https://aka.ms/new-console-template for more information

string[] favouriteFoods = new string[] {
                "Pizza",
                "Sushi",
                "Gelato",
                "Torta",
                "Pasta"
};

int i = 0;

for (i = 1; i < favouriteFoods.Length-1; i++)
{
    i++;
}

Console.WriteLine($"Lunghezza della classifica {i}");

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