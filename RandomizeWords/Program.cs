string[] words = Console.ReadLine().Split();

Random random = new Random();

for (int i = 0; i < words.Length; i++)
{
    int randomIndex = random.Next(i, words.Length);
    string temp = words[i];
    words[i] = words[randomIndex];
    words[randomIndex] = temp;
}

foreach (string word in words)
{
    Console.WriteLine(word);
}