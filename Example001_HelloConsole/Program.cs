// The task about two friends and their dog from lesson #1 of course "Intro in Programming"
Console.Clear();

Console.WriteLine("Условие задачи:");
Console.WriteLine("Два друга находятся на каком-то расстоянии друг от друга и идут навстречу по дороге");
Console.WriteLine("В момент начала движения, от первого друга ко второму выбегает собака,");
Console.WriteLine("Достигнув второго друга собака разворачивается и бежит обратно, к первому другу");
Console.WriteLine("Собака бегает между ними до тех пор, пока они не встретятся.");
Console.WriteLine("Требуется вычислить сколько раз собака сбегает от одного друга к другому до момента их встречи.");

Console.Write("Готовы вводить данные? (y/n)");

string condition = Console.ReadLine();

if (condition.ToLower() == "y")
{
    Console.WriteLine("Здорово! Приступим.");

    Console.WriteLine("Введите скорость движения первого друга (м/сек)");
    double first_friend_speed = Convert.ToDouble (Console.ReadLine());

    Console.WriteLine("Введите скорость движения второго друга (м/сек)");
    double second_friend_speed = Convert.ToDouble (Console.ReadLine());

    Console.WriteLine("Введите скорость движения их собаки (м/сек)");
    double dog_speed = Convert.ToDouble (Console.ReadLine());

    Console.WriteLine("Введите расстояние между друзьями в начале движения (м)");
    double distance = Convert.ToDouble (Console.ReadLine());

    Console.WriteLine("Введите расстояние между друзьями при их встрече (м)");
    double distance_min = Convert.ToDouble (Console.ReadLine());

double overall_speed_dog_first_friend = first_friend_speed + dog_speed;

double overall_speed_dog_second_friend = second_friend_speed + dog_speed;

double count = 0;

while (distance > distance_min)
{
    if (count % 2 != 0)
    {
        distance = distance - (first_friend_speed + second_friend_speed) * (distance / overall_speed_dog_first_friend);
    }

    else
    {
        distance = distance - (first_friend_speed + second_friend_speed) * (distance / overall_speed_dog_second_friend);
    }

    count++;

}
Console.WriteLine($"Ответ: собака сбегала от одного друга ко второму  {count} раз");
}

else
{
    Console.WriteLine("Завершаю работу.");
}