using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITGnanConsole.IQ
{
    public class WordParser
    {


        //        Console.WriteLine("Welcome to the Word Parser Coding Challenge");
        //var wordParser = new WordParser();
        //        var words = wordParser.GetWords();

        //        var distinctWordsDelimitedString = wordParser.ReturnUniqueWordsDelimited(words, delimiter: ",");
        //        Console.WriteLine("ReturnUniqueWordsDelimited returned a count of " + distinctWordsDelimitedString.Split(',').Length);

        //var duplicateWordsList = wordParser.ReturnWordsWithDuplicatesList(words);
        //        Console.WriteLine("ReturnWordsWithDuplicatesList returned a count of " + duplicateWordsList.Count);

        //var duplicatesDTOArray = wordParser.ReturnDuplicatesDTO(words);
        //        Console.WriteLine("ReturnDuplicatesDTO returned a count of " + duplicatesDTOArray.Length);

        //Console.WriteLine("This concludes the Word Parser Coding Challenge!");
        //Console.WriteLine("Thank you for participating!");

        public Dictionary<string, string> GetWords()
        {
            var words = new Dictionary<string, string>();
            words.Add("policeman", "bad_data");
            words.Add("calculation", " ");
            words.Add("thread", "bad_data");
            words.Add("despair", "bad_data");
            words.Add("reflection", "bad_data");
            words.Add("penetrate", "bad_data");
            words.Add("conference", "bad_data");
            words.Add("worry", "bad_data");
            words.Add("divide", "bad_data");
            words.Add("organ", "bad_data");
            words.Add("limited", "bad_data");
            words.Add("smile", "bad_data");
            words.Add("strain", "bad_data");
            words.Add("expect", "bad_data");
            words.Add("alcohol", "bad_data");
            words.Add("moment", "");
            return words;
        }

        public string ReturnUniqueWordsDelimited(Dictionary<string, string> words, string delimiter)
        {
            // Getting unique words			
            var uniqueWords = words.Keys.SelectMany(key => key.Split(new[] { ' ' }))
                .Select(word => word.Trim())
                       .Distinct(StringComparer.OrdinalIgnoreCase);

            return string.Join(delimiter, uniqueWords);
        }

        public List<string> ReturnWordsWithDuplicatesList(Dictionary<string, string> words)
        {
            var duplicateWords = words.Keys.SelectMany(key => key.Split(new[] { ' ' }))
            .Select(word => word.Trim().ToLower())
                .GroupBy(word => word)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key)
                .ToList();
            return duplicateWords;
        }

        public DuplicatesDTO[] ReturnDuplicatesDTO(Dictionary<string, string> words)
        {
            var wordGroups = words.Keys.SelectMany(key => key.Split(new[] { ' ' }))
                .Select(word => word.Trim().ToLower())
                    .GroupBy(word => word)
                     .Where(g => g.Count() > 1)
                    .Select(g => new DuplicatesDTO { Word = g.Key, Count = g.Count() });

            return wordGroups.ToArray();
        }
    }

    public class DuplicatesDTO
    {
        public string Word { get; set; }
        public int? Count { get; set; }

    }
}
