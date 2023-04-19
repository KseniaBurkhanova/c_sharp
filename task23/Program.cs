Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Cubes(int n){
    for (int i = 1; i <= n; i++){
        Console.WriteLine($"{i} | {Math.Pow(i, 3)}");
    }
}

Cubes(number);