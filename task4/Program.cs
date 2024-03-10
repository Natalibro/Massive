// Задайте произвольную строку. Выясните, является ли она палиндромом.

string pal = "кок";
string time = "Да";
for(int i = 0; i < pal.Length/2; i++)
{
    if(pal[i]!=pal[pal.Length-1-i])
    {
        time = "Нет";
    }
    Console.Write(time);

}
