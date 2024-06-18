namespace Assignment7._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "amazon";
            string output = ReverseVowels(input);

            Console.WriteLine(output);
        }


        static bool IsAVowel(char c) //is the char a vowel?
        {
            return (c == 'a' || c == 'A' || c == 'e'|| c== 'E' || c == 'i' || c == 'I'||
                    c == 'i'|| c == 'o' || c == 'O' || c == 'u' || c == 'U');
        }
        static string ReverseVowels(string input) 
        {
            string output = "";

            int i = 0;
            int j = input.Length - 1;//starts 'j' counter at the end of the string
            char[] str1 = input.ToCharArray();

            while (i < j)
            {
                if (!IsAVowel(str1[i])) 
                {
                    i++;//i reads from left to right
                    continue;
                    
                }

                if (!IsAVowel(str1[j]))
                {
                    j--;//while j reads from right to left
                    continue;

                }
                //swap vowels using a placeholder "temp"
                char temp = str1[i];
                str1[i] = str1[j];
                str1[j] = temp;

                i++;
                j--;
                
            }
            String str2 = String.Join(",", str1);
            return str2;

        }


    }
}
