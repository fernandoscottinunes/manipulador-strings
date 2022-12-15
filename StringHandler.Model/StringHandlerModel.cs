using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringHandler.DAO;
using StringHandler.Entity;

namespace StringHandler.Model
{
    public class StringHandlerModel
    {

        public static int countWord(EntityStringHandler objStringHandler)
        {
            int wordCounter = 0;
            string phrase = objStringHandler.InputText;

            // Remover espaços adicionais entre palavras
            while (phrase.IndexOf("  ") >= 0)
            {
                phrase = phrase.Replace("  ", " ");
            }

            phrase = phrase.Trim();
            string[] wordsToCount = phrase.Split(' ');

            wordCounter = wordsToCount.Length;

            objStringHandler.OutputText = "O texto digitado contém " + wordCounter + " palavras.";
            return new StringHandlerDAO().insertHistory(objStringHandler);
        }

        public static int countCharacter(EntityStringHandler objStringHandler)
        {
            int letterCounter = 0;
            string phrase = objStringHandler.InputText;
            letterCounter = phrase.Length;

            objStringHandler.OutputText = "O texto digitado contém " + letterCounter + " caracteres.";
            return new StringHandlerDAO().insertHistory(objStringHandler);
        }

        public static int upperCaseText(EntityStringHandler objStringHandler)
        {
            objStringHandler.OutputText = objStringHandler.InputText.ToUpper();
            return new StringHandlerDAO().insertHistory(objStringHandler);
        }

        public static int lowerCaseText(EntityStringHandler objStringHandler)
        {
            objStringHandler.OutputText = objStringHandler.InputText.ToLower();
            return new StringHandlerDAO().insertHistory(objStringHandler);
        }


        public static int reverseWord(EntityStringHandler objStringHandler)
        {
            string phrase = objStringHandler.InputText;

            // Remover espaços adicionais entre palavras
            while (phrase.IndexOf("  ") >= 0)
            {
                phrase = phrase.Replace("  ", " ");
            }

            phrase = phrase.Trim();

            string[] wordsToReverse = phrase.Split(' ');

            Array.Reverse(wordsToReverse);

            objStringHandler.OutputText = string.Join(" ", wordsToReverse);
            return new StringHandlerDAO().insertHistory(objStringHandler);
        }

        public static int reverseCharacter(EntityStringHandler objStringHandler)
        {
            string phrase = objStringHandler.InputText;
            char[] charactersToReverse = phrase.ToCharArray();

            Array.Reverse(charactersToReverse);

            objStringHandler.OutputText = string.Join("", charactersToReverse);
            return new StringHandlerDAO().insertHistory(objStringHandler);
        }

        public static int wordWrap(EntityStringHandler objStringHandler)
        {
            string phrase = objStringHandler.InputText;

            // Remover espaços adicionais entre palavras
            while (phrase.IndexOf("  ") >= 0)
            {
                phrase = phrase.Replace("  ", " ");
            }
            phrase = phrase.Trim();
            phrase = phrase.Replace(" ", Environment.NewLine);

            objStringHandler.OutputText = phrase;
            return new StringHandlerDAO().insertHistory(objStringHandler);
        }

        public static int shuffleWord(EntityStringHandler objStringHandler)
        {

            string phrase = objStringHandler.InputText;

            while (phrase.IndexOf("  ") >= 0)
            {
                phrase = phrase.Replace("  ", " ");
            }
            phrase = phrase.Trim();

            string[] wordsToShuffle = phrase.Split(' ');

            Random random = new Random();

            wordsToShuffle = wordsToShuffle.OrderBy(x => random.Next()).ToArray();

            objStringHandler.OutputText = string.Join(" ", wordsToShuffle);
            return new StringHandlerDAO().insertHistory(objStringHandler);
        }

        public static int shuffleCharacter(EntityStringHandler objStringHandler)
        {
            string phrase = objStringHandler.InputText;
            char[] charactersToShuffle = phrase.ToCharArray();

            Random random = new Random();

            charactersToShuffle = charactersToShuffle.OrderBy(x => random.Next()).ToArray();

            objStringHandler.OutputText = string.Join("", charactersToShuffle);
            return new StringHandlerDAO().insertHistory(objStringHandler);
        }

        public List<EntityStringHandler> listHistory()
        {

            return new StringHandlerDAO().listHistory();
        }
    }
}
