/* This program reverses a message
and count the letter 'o' and print this on console
*/
string str = "The quick brown fox jumps over the lazy dog.";

char[] message = str.ToCharArray();
Array.Reverse(message);

int x = 0;

foreach (char i in message) {
    if (i == 'o') {
        x++; 
    }
}

string new_message = new String(message);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");