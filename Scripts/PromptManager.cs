using UnityEngine;
using TMPro;
using System;
using Unity.Collections;

public class PromptManager : MonoBehaviour
{
    public TMP_Text timer;
    public TMP_Text combo;

    //Create an array of letters in the alphabet weighted by their frequency.
    //Do this by including multiple instances of the same letter.
    public string[] alphabet = new string[] {
        "E","E","E","E","E","E","E","E","E","E","E","E",
        "T","T","T","T","T","T","T","T","T",
        "A","A","A","A","A","A","A","A",
        "O","O","O","O","O","O","O","O",
        "I","I","I","I","I","I","I",
        "N","N","N","N","N","N","N",
        "S","S","S","S","S","S",
        "R","R","R","R","R","R",
        "H","H","H","H","H","H",
        "D","D","D","D",
        "L","L","L","L",
        "U","U","U",
        "C","C","C",
        "M","M","M",
        "F","F",
        "Y","Y",
        "W","W",
        "G","G",
        "P","P",
        "B","B",
        "V",
        "K",
        "X",
        "Q",
        "J",
        "Z"};
    
    //Create a variable object to send the output to later. It is a Text Mesh Pro text field, so be sure to use TMP_Text.
    public TMP_Text promptField;
    public TMP_Text instructionsText;

    //Create the function to get a new prompt when called (e.g., but pressing a button).
    public void GetPrompt()
    {

        if (instructionsText.text != "")
        {
            instructionsText.text = "";

            //Initialize prompt string. This will also erase anything that was already in the prompt field.
            string prompt = "";

            //Create a random object.
            System.Random rand = new System.Random();

            //We want three random letters, so three random indices. Loop through the counter three times, then.
            for (int i = 0; i <= 2; i++)

                //Concatenate each new random letter to the prompt string. 
                prompt += alphabet[rand.Next(alphabet.Length)];

            //Finally, set the text of the prompt text field to the generated prompt text.
            promptField.text = prompt;

        }

        if (instructionsText.text == "")
        {

            string prompt = "";

            System.Random rand = new System.Random();

            for (int i = 0; i <= 2; i++)
                prompt += alphabet[rand.Next(alphabet.Length)];

            promptField.text = prompt;

        }

    }
    public void ResetUsedWords()
    {
        SubmitManager.usedWords.Clear();
        //SubmitManager.matches.Clear();
    }

    public void ResetCombo()
    {
        SubmitManager.c = 0;
        combo.text = "";
    }

}
