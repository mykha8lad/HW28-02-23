

#region 1
/*
string firstStr = "А роза упала на лапу Азора";
string secondStr = firstStr.ToLower().Replace(" ", ""); // Удаляем все пробелы и уменьшаем капс
string reverseStr = new string(secondStr.ToCharArray().Reverse().ToArray()); // Переворачиваем строку

if (secondStr == reverseStr)
    Console.WriteLine($"Строка \"{firstStr}\" является палиндромом");
else
    Console.WriteLine($"Строка \"{firstStr}\" не является палиндромом");
*/
#endregion

#region 2
using System.Linq;

int countLettersInOffer = 0;
int countVowelsInOffer = 0;
int countConsonantsInOffer = 0;
char[] vowelsLetters = { 'а', 'и', 'о', 'у', 'ы', 'я', 'э', 'ю', 'е', 'ё' };

string offer = "Это...\nНу ты короче\nв общем это\nтак-то ничего, то есть\nя хочу сказать ну шо ты\nв целом, там ну глаза,\nволосы, я конечно\nне поэт, зато ты\nпрям стих\nёлы палы";
Console.WriteLine(offer);

string[] words = offer.Replace('\n', ' ').Replace(",", "").Replace(".", "").Replace("-", "").Split(" ");
foreach (string item in words)
{
    Console.Write($"{item} ");
}

foreach (string word in words)
{
    countLettersInOffer += word.Length;
    foreach (char letter in word)
    {
        if (vowelsLetters.Contains(letter))
            countVowelsInOffer++;
        else
            countConsonantsInOffer++;
    }
}

Console.WriteLine($"\nВсего символов: {offer.Length}");
Console.WriteLine($"Из них {words.Length} слов(а)");
Console.WriteLine($"{countLettersInOffer} букв: {countVowelsInOffer} гласных и {countConsonantsInOffer} согласных");
#endregion