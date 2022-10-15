// Консоль


int x = 0;
int y = 0;
string player = "@";
bool isPlaying = true;

while(isPlaying)
{
    Console.Clear();
    Console.SetCursorPosition(x,y);
    Console.Write(player);
    ConsoleKeyInfo keyInfo = Console.ReadKey();
    Console.CursorVisible = false;
    if (keyInfo.Key == ConsoleKey.DownArrow)
    {
        y++;
    }
    if (keyInfo.Key == ConsoleKey.UpArrow)
    {
        y--;
    }
    if (keyInfo.Key == ConsoleKey.RightArrow)
    {
        x++;
    }
    if (keyInfo.Key == ConsoleKey.LeftArrow)
    {
        x--;
    }
    if (keyInfo.Key == ConsoleKey.E)
    {
        isPlaying = false;
    }
    //Console.WriteLine(keyInfo.Key);
    //Console.ReadKey();
}

Console.Clear();
Console.CursorVisible = true;
Console.SetCursorPosition(0,0);
Console.WriteLine("Игра окончена!");