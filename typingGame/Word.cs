using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word {

    public string word;
    private int index;

    WordDisplay display;

    public Word (string word, WordDisplay display)
    {
        this.word = word;
        index = 0;
        this.display = display;
        display.SetWord(word);
    }

    public char GetNextLetter ()
    {
        return word[index];
    }

    public void TypeLetter ()
    {
        index++;
        display.RemoveLetter();
    }

    public bool WordTyped()
    {
        bool wordTyped = (index >= word.Length);
        if (wordTyped)
        {
            display.RemoveWord();
            ScoreCountScript.scoreValue += 1;
        }

        return wordTyped;
    }

}
