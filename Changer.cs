using System;
using System.Collections.Generic;

namespace CharacterChanger
{
    public class Changer
    {
        public void CharacterChange()
        {
            Console.Write("Lütfen bir cümle giriniz..: ");
            string text=Console.ReadLine();
            string[] empty = text.Split(' ');
            for (int c = 0; c < empty.Length; c++)
            {
                char[] letters = empty[c].ToCharArray();
                int lettersLength=letters.Length;
                char temp=letters[0];
                letters[0]=letters[lettersLength-1];
                letters[lettersLength-1]=temp;
                string changedWord=string.Concat(letters);
                Console.Write(changedWord+" ");
            }
        }
    }
}