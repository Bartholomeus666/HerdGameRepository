using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class RunDialogue : MonoBehaviour
{
    public DialogueObj dialogueObj;

    [SerializeField] private GameObject CanvasPref;

    private GameObject Canvas;
    private TMP_Text currentDisplayedText;
    private int currentDisplayedIndex;

    public void StartDialogue()
    {
        if (dialogueObj != null)
        {
            PlayDialogue();
        }
        else
        {
            Debug.LogWarning("Dialogue object is not assigned.");
        }
    }

    public void PlayDialogue()
    {
        Canvas = Instantiate(CanvasPref, null);

        currentDisplayedText = Canvas.GetComponentInChildren<TMP_Text>();

        FirstLine();
    }

    private void FirstLine()
    {
        currentDisplayedIndex = 0;
        currentDisplayedText.text = dialogueObj.dialogueLines[currentDisplayedIndex];
    }

    public void NextLine()
    {
        currentDisplayedIndex++;
        Debug.Log("Next Line: " + currentDisplayedIndex);
        if (currentDisplayedIndex >= dialogueObj.dialogueLines.Length)
        {
            dialogueObj.DialogueEnded();
            currentDisplayedIndex = 0;
        }
        currentDisplayedText.text = dialogueObj.dialogueLines[currentDisplayedIndex];
    }


}
