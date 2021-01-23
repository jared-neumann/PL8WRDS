using TMPro;
using UnityEngine;

public class PauseGame : MonoBehaviour
{

    public static int pause;
    public TMP_Text instructions;
    public TMP_Text promptField;
    public TMP_InputField wordInput;
    public GameObject keyboard;
    public GameObject preview;
    public GameObject pauseMenu;
    public GameObject pauseRateArea;
    public TMP_Text pauseRateText;
    private string prompt;
    public TMP_Text timer;

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

    void Start()
    {
        Time.timeScale = 1;
        pause = 1;
    }
    public void Pause()
    {
        pause += 1;

        if (pause % 2 == 0 && timer.text != "0")
        {
            Time.timeScale = 0;
            keyboard.SetActive(false);
            preview.SetActive(false);
            pauseMenu.SetActive(true);

            if (PlayerPrefs.GetString("mode") == "INF")
            {
                pauseRateArea.SetActive(true);
                
            }

            promptField.text = "";
            wordInput.text = "";

        }

        if (pause % 2 == 1)
        {
            Time.timeScale = 1;
            keyboard.SetActive(true);
            preview.SetActive(true);
            pauseMenu.SetActive(false);

            if (PlayerPrefs.GetString("mode") == "INF")
            {
                pauseRateArea.SetActive(false);
            }

            if (instructions.text == "")
            {
                prompt = "";

                System.Random rand = new System.Random();

                for (int i = 0; i <= 2; i++)
                    prompt += alphabet[rand.Next(alphabet.Length)];

                promptField.text = prompt;
            }
            

        }
    }
}