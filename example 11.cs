string sentence = "C# programming is fun and challenging";

string[] words = sentence.Split(' ');

foreach (var word in words)
{
    char[] characters = word.ToCharArray();
    Array.Reverse(characters);
    string result = String.Join("", characters);
    Console.WriteLine(result);
}
