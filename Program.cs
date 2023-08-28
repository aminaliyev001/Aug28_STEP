string[,] suallar = new string[10, 5]
{
    { "Azerbaycanin paytaxti haradir?","Baki","Sumqayit","Gence", "Baki" },
    { "Azerbaycanin paytaxti haradir?","Baki","Sumqayit","Gence", "Baki" },
    { "Azerbaycanin paytaxti haradir?","Baki","Sumqayit","Gence", "Baki" },
    { "Azerbaycanin paytaxti haradir?","Baki","Sumqayit","Gence", "Baki" },
    { "Azerbaycanin paytaxti haradir?","Baki","Sumqayit","Gence", "Baki" },
    { "Azerbaycanin paytaxti haradir?","Baki","Sumqayit","Gence", "Baki" },
    { "Azerbaycanin paytaxti haradir?","Baki","Sumqayit","Gence", "Baki" },
    { "Azerbaycanin paytaxti haradir?","Baki","Sumqayit","Gence", "Baki" },
    { "Azerbaycanin paytaxti haradir?","Baki","Sumqayit","Gence", "Baki" },
    { "Azerbaycanin paytaxti haradir?","Baki","Sumqayit","Gence", "Baki" }
};
int user_xal = 0;
int sel = 1;
void select_sual(params string[] par)
{
    string duzgun_cavab = par[3];
    while(true)
    {
        Console.WriteLine($"Sual {par[4]} \n {par[5]} \n");
        switch(sel)
        {
            case 1:
                Console.WriteLine($"\n {par[0]} << \n {par[1]} \n {par[2]}");
                break;
            case 2:
                Console.WriteLine($"\n {par[0]}  \n {par[1]} << \n {par[2]}");
                break;
            case 3:
                Console.WriteLine($"\n {par[0]}  \n {par[1]} \n {par[2]} <<");
                break;
        }
        ConsoleKeyInfo key = Console.ReadKey();
        if(key.Key == ConsoleKey.DownArrow)
        {
            if (sel < 3)
                sel++;
        } else if(key.Key == ConsoleKey.UpArrow)
        {
            if(sel > 1) sel--;
        } else if(key.Key == ConsoleKey.Enter)
        {
            break;
        }
        Console.Clear();
    }
    if(par[sel-1] == duzgun_cavab) {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n Duzgun cavabdir! \n");
        user_xal+=10;
    } else {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n Sehv cavabdir! \n");
        if(user_xal != 0)
            user_xal -=10;
    }
    Console.ResetColor();
}
for (int i = 0; i < suallar.Length / 5; i++)
{
            select_sual(new string[]{suallar[i, 1],suallar[i,2] ,suallar[i,3],suallar[i,4],(i+1).ToString(),suallar[i,0] });
}
Console.WriteLine($"Bitdi sizin xaliniz {user_xal}");