using System;

namespace ScriptureMemorization
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of scriptures with verses
            string[] scriptures = {
            "John 3:16 - For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.",
            "Proverbs 3:5-6 - Trust in the LORD with all your heart, and do not lean on your own understanding. In all your ways acknowledge him, and he will make straight your paths.",
            "Romans 8:28 - And we know that for those who love God all things work together for good, for those who are called according to his purpose.",
            "Psalm 23:1 - The LORD is my shepherd; I shall not want.",
            "Matthew 6:33 - But seek first the kingdom of God and his righteousness, and all these things will be added to you.",
            "Isaiah 40:31 - But they who wait for the LORD shall renew their strength; they shall mount up with wings like eagles; they shall run and not be weary; they shall walk and not faint.",
            "Philippians 4:13 - I can do all things through him who strengthens me.",
            "1 Corinthians 16:14 - Let all that you do be done in love.",
            "Ephesians 4:32 - Be kind to one another, tenderhearted, forgiving one another, as God in Christ forgave you.",
            "Colossians 3:23 - Whatever you do, work heartily, as for the Lord and not for men.",
            "Matthew 28:19-20 - Go therefore and make disciples of all nations, baptizing them in the name of the Father and of the Son and of the Holy Spirit, teaching them to observe all that I have commanded you. And behold, I am with you always, to the end of the age.",
    
            };

            // Randomly select a scripture from the array
            Random random = new Random();
            string selectedScripture = scriptures[random.Next(scriptures.Length)];

            // Create an instance of the Scripture class
            Scripture scripture = new Scripture(selectedScripture);

            // Display the complete scripture
            Console.WriteLine(scripture.GetFullScripture());

            // Prompt the user to press enter to hide words
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            while (input.ToLower() != "quit")
            {
                // Clear the console screen
                Console.Clear();

                // Hide a few random words in the scripture
                scripture.HideRandomWords();

                // Display the scripture with hidden words
                Console.WriteLine(scripture.GetPartialScripture());

                // Prompt the user to press enter or quit
                Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
                input = Console.ReadLine();
            }
        }
    }

    class Scripture
    {
        private string reference;
        private string text;
        private string[] words;
        private bool[] hiddenWords;

        public Scripture(string scripture)
        {
            string[] parts = scripture.Split('-');
            reference = parts[0].Trim();
            text = parts[1].Trim();
            words = text.Split(' ');
            hiddenWords = new bool[words.Length];
        }

        public void HideRandomWords()
        {
            Random random = new Random();
            int wordsToHide = random.Next(1, words.Length); // Hide at least one word, up to all words

            for (int i = 0; i < wordsToHide; i++)
            {
                int index = random.Next(words.Length);

                // Check if the word is already hidden or the last word
                if (!hiddenWords[index] && index != words.Length - 1)
                {
                    hiddenWords[index] = true;
                }
            }
        }

        public string GetFullScripture()
        {
            return $"{reference} - {text}";
        }

        public string GetPartialScripture()
        {
            string result = $"{reference} - ";

            for (int i = 0; i < words.Length; i++)
            {
                if (hiddenWords[i])
                {
                    result += "____ ";
                }
                else
                {
                    result += words[i] + " ";
                }
            }

            return result.Trim();
        }
    }
}
