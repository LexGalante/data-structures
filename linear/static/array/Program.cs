// opções para inicializa o array
string[] languages = ["dotnet", "golang", "python"];

languages = new string[] {"dotnet", "golang", "python"};

void PrintValues(string name, object[] items)
{
    Console.WriteLine($"print all value for collection: {name}");
    foreach (var item in items)
        Console.WriteLine($"value: {item}");    
}

PrintValues("array with language names", languages);

// acessar um valor pelo indice do array
var numbers = new int[6] { 5, 8, 99, 441, 3, 1112125 };

PrintValues("array with integer values", numbers.Select(x => x.ToString()).ToArray());

// busca pelo indice
Console.WriteLine($"numbers[2] = {numbers[2]}");

// busca binária de um elemento
Console.WriteLine($"bynary search number 3 in array [5, 8, 99, 441, 3, 1112125] = {Array.BinarySearch(numbers, 441)}");

// array's bidimensionais
int[,] array2DInitialization =  
{
    { 1, 2 },
    { 3, 4 }, 
    { 5, 6 },
    { 7, 8 }
};

int[,,] array3D = new int[,,] 
{
    { 
        { 1, 2, 3 }, 
        { 4,   5,  6 } 
    },
    {
        { 7, 8, 9 },
        { 10, 11, 12 } 
    } 
};

