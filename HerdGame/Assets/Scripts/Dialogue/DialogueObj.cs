using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

[CreateAssetMenu(fileName = "New Dialogue", menuName = "Dialogue")]
public class DialogueObj : ScriptableObject
{
    public string[] dialogueLines;
    public string dialogueName;

    public UnityEvent OnDialogueFinished;

    public void DialogueEnded()
    {
        OnDialogueFinished?.Invoke();
    }
}
