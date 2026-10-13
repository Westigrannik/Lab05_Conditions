// 1

// Console.WriteLine("Введите пароль");
// string password = Console.ReadLine();
// Console.WriteLine("Повторите пароль");
// string password1 = Console.ReadLine();
// string yesorno = (password == password1) ? "Пароль принят" : "Пароль не принят";
// Console.WriteLine(yesorno);

// 2

// Console.Write("Введите ваш возраст: ");
// int vozr = int.Parse(Console.ReadLine());
// string yesorno = (vozr >= 18) ? "Доступ разрешён" : "Доступ запрещён";
// Console.WriteLine(yesorno);

// 3

// Console.WriteLine("Напишите 2 цифры и операцию");
// int num = int.Parse(Console.ReadLine());
// int num1 = int.Parse(Console.ReadLine());
// string oper = Console.ReadLine();
// switch(oper){
//     case "+":
//     Console.WriteLine(num+num1);
//         break;
//     case "-":
//     Console.WriteLine(num-num1);
//         break;
//     case "*":
//     Console.WriteLine(num*num1);
//         break;
//     case "/":
//     Console.WriteLine(num/num1);
//         break;
//     default:
//         Console.WriteLine("Нету такой операции");
//         break;
// }

// 4

// int sum = 0;
// Console.WriteLine("Напишите 3 числа");
// int num1 = int.Parse(Console.ReadLine());
// int num2 = int.Parse(Console.ReadLine());
// int num3 = int.Parse(Console.ReadLine());
// if (num1 > 0){
//     sum += num1;
// }
// if (num2 > 0){
//     sum += num2;
// }
// if (num3 > 0){
//     sum += num3;
// }
// Console.WriteLine(sum);

// 5

Console.WriteLine("Выберите путь:");
Console.WriteLine("Путь А");
Console.WriteLine("Путь В");
string choice = Console.ReadLine();
switch (choice)
{
    case "A":
    Console.WriteLine("Ответьте на загадку");
    Console.WriteLine("Кто не дышит, но живёт; хоть не нужно — много пьёт; и вжизни, и в смерти тело как лёд");
    string choice1 = Console.ReadLine();
    
    switch (choice1)
    {
        case "рыба":
        Console.WriteLine("Вы проходите дальше");
        break;
        default:
        Console.WriteLine("Вы были съедены");
        break;
    }
    break;
    case "B":
    Console.WriteLine("Выберите дверь: ");
    Console.WriteLine("Дверь 1");
    Console.WriteLine("Дверь 2");
    string choice2 = Console.ReadLine();
    switch (choice2)
    {
        case "1":
        Console.WriteLine("Вы нашли скрытые сокровища!");
        break;
        case "2":
        Console.WriteLine("Вы попали в ловушку!");
        break;
        default:
        Console.WriteLine("НЕТУ ТАКОЙ ДВЕРИ");
        break;
    }
    break;
    default:
    Console.WriteLine("НЕТУ ТАКОГО ПУТИ");
    break;
}