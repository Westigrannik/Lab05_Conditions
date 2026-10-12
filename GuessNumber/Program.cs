Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number > 0) {
    Console.WriteLine("Число положительное.");
}
else if (number < 0) {
    Console.WriteLine("Число отрицательное.");
}
else {
    Console.WriteLine("Число равно нулю.");
}

Console.Write("Введите балл (0-100): ");
int score = int.Parse(Console.ReadLine());
if (score >= 91){
    Console.WriteLine("Оценка: Отлично (5)");
}
else if (score >= 71){
    Console.WriteLine("Оценка: Хорошо (4)");
}
else if (score >= 51){
    Console.WriteLine("Оценка: Удовлетворительно (3)");
}
else{
    Console.WriteLine("Оценка: Неудовлетворительно (2)");
}