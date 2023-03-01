# Дз от 28/02/23. string 
##  **Задание 1.** Дана строка символов. Необходимо проверить, является ли эта строка палиндромом.
```cs
string firstStr = "А роза упала на лапу Азора";
string secondStr = firstStr.ToLower().Replace(" ", ""); // Удаляем все пробелы и уменьшаем капс
string reverseStr = new string(secondStr.ToCharArray().Reverse().ToArray()); // Переворачиваем строку
if (secondStr == reverseStr)
    Console.WriteLine($"Строка \"{firstStr}\" является палиндромом");
else
    Console.WriteLine($"Строка \"{firstStr}\" не является палиндромом");
```
### Результат:
<!-- ```cmd
Строка "А роза упала на лапу Азора" является палиндромом
``` -->
![result]()