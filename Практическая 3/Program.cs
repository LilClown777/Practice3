// See https://aka.ms/new-console-template for more information
Console.WriteLine("Демонстрирую, одну секунд...");
Console.WriteLine("Я запустился");
start();

static void start()
{
    int[] a = new int[] { 2616, 2772, 2937, 3111, 3296, 3492, 3700, 3920, 4153, 4400, 4662, 4939 };
    int[] b = new int[] { 5233, 5544, 5873, 6223, 6593, 6985, 7400, 7840, 8306, 8800, 9323, 9878 };
    int[] c = new int[] { 10470, 11090, 11750, 12450, 13190, 1397, 14800, 15680, 16610, 17600, 18650, 19760 };
    int[] d = new int[] { 20930, 22170, 23490, 24890, 26370, 27940, 29600, 31360, 33220, 35200, 37290, 39610 };
    bool abc = true;
    while (abc)

    { 
    Console.WriteLine("Меню октав:\n1. Большая октава (F1)\n2. Маленькая октава (F2) \n3. Правая октава (F3) \n4. Левая октава (F4)\n5. Выход из октавы (F5)\n6. Выход из программы (F6)");

    ConsoleKeyInfo oper = Console.ReadKey();
    if (oper.Key == ConsoleKey.F6)
    {
         Console.WriteLine("Выхожу из программы, заглядывайте ещё :)");
         abc = false;
    }
    if (oper.Key == ConsoleKey.F1)
    {
        Console.WriteLine("Вы выбрали 'Большую октаву'");
        octav(a);
    }
    if (oper.Key == ConsoleKey.F2)
    {
        Console.WriteLine("Вы выбрали 'Маленькую октаву'");
        octav(b);
    }
    if (oper.Key == ConsoleKey.F3)
    {
        Console.WriteLine("Вы выбрали 'Правую октаву'");
        octav(c);
    }
        if (oper.Key == ConsoleKey.F4)
        {
            Console.WriteLine("Вы выбрали 'Левую октаву'");
            octav(d);
        }
        else
        {
            continue;
            Console.Clear();
        }
  }
}

static void octav(int[] sound_list)
{

    while (true)
    {
        ConsoleKeyInfo octav1 = Console.ReadKey(true);
        if (octav1.Key == ConsoleKey.Q)
        {
            Console.Beep((sound_list[0] / 10), 300);
        }

        if (octav1.Key == ConsoleKey.W)
        {
            Console.Beep((sound_list[1] / 10), 300);
        }

        if (octav1.Key == ConsoleKey.E)
        {
            Console.Beep((sound_list[2] / 10), 300);
        }

        if (octav1.Key == ConsoleKey.R)
        {
            Console.Beep((sound_list[3] / 10), 300);
        }

        if (octav1.Key == ConsoleKey.T)
        {
            Console.Beep((sound_list[4] / 10), 300);
        }

        if (octav1.Key == ConsoleKey.Y)
        {
            Console.Beep((sound_list[5] / 10), 300);
        }

        if (octav1.Key == ConsoleKey.U)
        {
            Console.Beep((sound_list[6] / 10), 300);
        }

        if (octav1.Key == ConsoleKey.I)
        {
            Console.Beep((sound_list[7] / 10), 300);
        }

        if (octav1.Key == ConsoleKey.O)
        {
            Console.Beep((sound_list[8] / 10), 300);
        }

        if (octav1.Key == ConsoleKey.P)
        {
            Console.Beep((sound_list[9] / 10), 300);
        }

        if (octav1.Key == ConsoleKey.A)
        {
            Console.Beep((sound_list[10] / 10), 300);
        }

        if (octav1.Key == ConsoleKey.S)
        {
            Console.Beep((sound_list[11] / 10), 300);
        }

        if (octav1.Key == ConsoleKey.F5)
        {
            Console.Clear();
            Console.WriteLine("Выхожу из октавы, выбирай другую :)");
            break;
        }
        else
        {
            continue;
        }
    }
}