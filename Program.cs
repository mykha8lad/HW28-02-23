using System.Linq;

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
/*
int countLettersInOffer = 0;
int countVowelsInOffer = 0;
int countConsonantsInOffer = 0;
char[] vowelsLetters = { 'а', 'и', 'о', 'у', 'ы', 'я', 'э', 'ю', 'е', 'ё' };

string offer = "Это...\nНу ты короче\nв общем это\nтак-то ничего, то есть\nя хочу сказать ну шо ты\nв целом, там ну глаза,\nволосы, я конечно\nне поэт, зато ты\nпрям стих\nёлы палы";
Console.WriteLine(offer);

string[] words = offer.Replace('\n', ' ').Replace(",", "").Replace(".", "").Replace("-", "").Split(" ");
foreach (string word in words)
{
    countLettersInOffer += word.Length;
    foreach (char letter in word.ToLower())
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
*/
#endregion

#region 3
/*
string str1 = "Аз есмь строка, живу я, мерой остр.";
string str2 = "За семь морей ростка я вижу рост!";

char[] charStr1 = str1.Replace(",", "").Replace(".", "").Replace("!", "").Replace(" ", "").ToLower().ToCharArray();
char[] charStr2 = str2.Replace(",", "").Replace(".", "").Replace("!", "").Replace(" ", "").ToLower().ToCharArray();

if (charStr1.Length != charStr2.Length)
{
    Console.WriteLine("Предложения имеют разную длину");
    return;
}

Array.Sort(charStr1);
Array.Sort(charStr2);

bool flag = true;
for (int letter = 0; letter < charStr1.Length; letter++)
{
    if (charStr1[letter] != charStr2[letter])
        flag = false;
}

if (!flag)
    Console.WriteLine($"Предложения \"{str1}\" и \"{str2}\" не являются анаграммами");
else
    Console.WriteLine($"Предложения \"{str1}\" и \"{str2}\" являются анаграммами");
*/
#endregion