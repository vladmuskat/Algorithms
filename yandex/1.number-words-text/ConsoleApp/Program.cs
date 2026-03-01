string input = "She sells sea shells on the sea shore;\r\nThe shells that she sells are sea shells I'm sure.\r\nSo if she sells sea shells on the sea shore,\r\nI'm sure that the shells are sea shore shells.\r\n";

/// Реализация через Linq
var words = input
    .Split(new string[] { "\r\n", "\n", " ", ",", "." },
            StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
    .ToHashSet();

Console.WriteLine(words.Count);

/// Обычная реализация
string[] split = input.Split(new string[] { "\r\n", "\n", " ", ",", "." }, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
var words2 = new HashSet<string>();
foreach (var word in split)
{
    words2.Add(word);
}

Console.WriteLine(words2.Count);


/// Реализация через словарь
var seen = new Dictionary<string, int>();

Console.WriteLine(CountOfWords(ref seen, split));

static int CountOfWords(ref Dictionary<string, int> collection, string[] values)
{
    foreach (var word in values)
    {
        if (collection.ContainsKey(word))
        {
            collection[word]++;
        }
        else
        {

            collection[word] = 1;
        }

    }

    return collection.Count;
}