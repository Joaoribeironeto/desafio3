
List<int> lista = new List<int> { 1, 5, 10, 2, 6, 11 };

int somaLista = 0;

foreach (int soma in lista)
{
    somaLista += soma;
}

Console.WriteLine($"A soma dos elementos é {somaLista}");