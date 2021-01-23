using UnityEngine;
using TMPro;

public class InputManager : MonoBehaviour
{
    public TMP_InputField previewInput;
    public TMP_Text keyText;
    public TMP_Text instructionsText;

    public void AppendText()
    {
        if (instructionsText.text == "")
            previewInput.text += keyText.text;
    }

    public void Backspace()
    {
        if (previewInput.text.Length > 0)
            previewInput.text = previewInput.text.Substring(0, previewInput.text.Length - 1);
    }

}
