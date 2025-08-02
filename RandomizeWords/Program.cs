string[] words = Console.ReadLine().Split();

Random random = new Random();

for (int i = 0; i < words.Length; i++)
{
    int randomIndex = random.Next(0, words.Length);
    Swap(i, randomIndex, words);
    //string temp = words[i];
    //words[i] = words[randomIndex];
    //words[randomIndex] = temp;
}

foreach (string word in words)
{
    Console.WriteLine(word);
}

static void Swap(int firstIndex, int secondIndex, string[] array)
{
    string temp = array[firstIndex];
    array[firstIndex] = array[secondIndex];
    array[secondIndex] = temp;
}