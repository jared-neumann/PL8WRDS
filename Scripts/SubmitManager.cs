using UnityEngine;
using TMPro;
using System;
using System.Collections.Generic;
using DawgSharp;
using System.IO;
using UnityEngine.Networking;
using System.Security.Cryptography;
using System.Linq;

public class SubmitManager : MonoBehaviour
{
    public TMP_InputField previewInput;
    public TMP_Text instructions;
    public TMP_Text prompt;
    public static List<string> usedWords = new List<string>();
    public TMP_InputField score;
    public AudioSource valid;
    public AudioSource invalid;
    private int points = 0;
    //private DawgBuilder<bool> dawg;
    //private Dawg<bool> dawgFile;
    private TextAsset wordlist;
    private string[] words;
    public GameObject comboArea;
    public TMP_Text combo;
    public static int c = 0;
    //public static List<string> matches = new List<string>();
    //public List<int> counterTotals = new List<int>();
    public void Start()
    {
        wordlist = (TextAsset)Resources.Load("wordlist_cs", typeof(TextAsset));
        words = wordlist.text.Split(',');
    }

    public void Submit()
    {
        if (instructions.text == "")
        {

            string word = previewInput.text.ToLower();
            char[] promptLetters = prompt.text.ToLower().ToCharArray();

            //if (matches.Count == 0 && prompt.text != "")
           // {

                //int counter = 0;

                //foreach (string w in words)
                //{
                //    if (w.IndexOf(promptLetters[0]) >= 0)
                //    {
                //        int a = w.IndexOf(promptLetters[0]);
                //        string aSlice = w.Substring(a + 1);
                //
                //        if (aSlice.IndexOf(promptLetters[1]) >= 0)
                //        {
                //            int b = aSlice.IndexOf(promptLetters[1]);
                //            string bSlice = aSlice.Substring(b + 1);
                //
                //            if (bSlice.IndexOf(promptLetters[2]) >= 0)
                //            {
                                //matches.Add(w);
                                //Debug.Log(w);
                                //counter += 1;

                //            }
                //        }
                //    }
                //}
                //Debug.Log(counter.ToString());
                //counterTotals.Add(counter);
                //Debug.Log(counterTotals.Sum()/counterTotals.Count);
                //counter = 0;
                
            //}

            if (Array.Exists(words, x => x == word) 
                && word != ""
                && !usedWords.Contains(word)
                && prompt.text != "")
            {
                
                if (word.IndexOf(promptLetters[0]) >= 0)
                {
                    int a = word.IndexOf(promptLetters[0]);
                    string aSlice = word.Substring(a+1);

                    if (aSlice.IndexOf(promptLetters[1]) >= 0)
                    {
                        int b = aSlice.IndexOf(promptLetters[1]);
                        string bSlice = aSlice.Substring(b+1);

                        if (bSlice.IndexOf(promptLetters[2]) >= 0)
                        {
                            usedWords.Add(word);
                            points += 10 + 2*(usedWords.Count - 1);
                            c += 2*(usedWords.Count-1);
                            valid.Play();

                        }

                        else
                        {
                            invalid.Play();
                        }
                    }

                    else
                    {
                        invalid.Play();
                    }

                }

                else
                {
                    invalid.Play();
                }
    
            }

            else
            {
                invalid.Play();
            }

            previewInput.text = "";
            score.text = points.ToString();

            if (combo.text != null)
            {
                
                if(c > 0)
                {
                    combo.text = "+" + c.ToString();
                }
                
            }

        }
    
    }
}
