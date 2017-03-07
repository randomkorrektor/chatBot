using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTypes;

namespace DataBase
{
    public static class KeyWordsManager
    {
        public static void AddKeyWord(string keyWord, string response)
        {
            Context.Instanse.KeyWords.Add(new DataTypes.KeyWords()
            {
                keyWord = keyWord,
                response = response
            });
            Context.Instanse.SaveChanges();
        }

        public static void DeleteKeyWord(string keyWord)
        {
            KeyWords word =
                Context.Instanse.KeyWords.First(k => k.keyWord == keyWord);
            Context.Instanse.KeyWords.Remove(word);
            Context.Instanse.SaveChanges();
        }

        //public static string wordFinder(string message)
        //{
        //    string[] words = message.Split(' ');
        //    List<KeyWords> word = new List<KeyWords>();

        //    for (int i = 0; i <= words.Count() - 1; i++)
        //    {
        //            word.AddRange(Context.Instanse.KeyWords.Where(k => k.keyWord == words[i]));
        //    }
        //    if(word.Count>0)
        //    {
        //        return word[0].response;
        //    }
        //    return "No comments(";
        //}

        public static string wordFinder(string message)
        {
            string[] words = message.Split(' ');
            KeyWordsManager.AddKeyWord("Hi", "Hi!");
            KeyWords[] d = Context.Instanse.KeyWords.ToArray();
            for (int i = 0; i <= words.Count() - 1; i++)
            {
                for (int j = 0; j < d.Length; j++)
                {
                    if (d[j].keyWord == words[i])
                    {
                        return d[j].response;
                    }
                }
            }
            return "No comments(";
        }
    }
}

