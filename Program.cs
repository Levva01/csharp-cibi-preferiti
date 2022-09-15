// See https://aka.ms/new-console-template for more information

string[] favouriteFoods = new string[] {
                "Pizza",
                "Sushi",
                "Gelato",
                "Torta",
                "Pasta"
};

int i = 0;

for (i = 0; i < favouriteFoods.Length - 1; i++)
{
    i++;
}

Console.WriteLine($"Lunghezza della classifica {i}");