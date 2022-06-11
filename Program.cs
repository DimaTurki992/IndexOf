using System;

namespace IndexOf
{
    class Program
    {
        static void Main()
        {
            string text;
            string subText;

            Console.WriteLine("Type text, and then press Enter");
            text = Console.ReadLine();

            Console.WriteLine("Type subtext, and then press Enter");
            subText = Console.ReadLine();

            Console.WriteLine("Index is " + GetIndexOf(text, subText));
            Console.WriteLine("************");
        }

        private static int GetIndexOf(string text, string subText, int startingIndex = 0)
        {
            int index = -1;
            if (subText.Length > text.Length) return -1;
            if (text.Length == subText.Length)
            {
                if (subText == text) return 0; else return -1;
            }

            int maxIndex = text.Length - subText.Length;
            for (int i = 0; i <= maxIndex; i++)
            {
                for (int j = 0; j < subText.Length; j++)
                {
                    if (text[i + j] != subText[j])
                    {
                        index = -1;
                        break;
                    }
                    else if (j == 0) index = i;

                    if (j == subText.Length - 1)
                    {
                        return index;
                    }
                }
            }
            return index;
        }
    }
}
