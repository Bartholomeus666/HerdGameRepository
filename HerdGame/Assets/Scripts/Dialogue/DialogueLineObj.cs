using UnityEngine;

[CreateAssetMenu(fileName = "New DialogueLine", menuName = "DialogueLine")]
public class DialogueLineObj : ScriptableObject
{
    public string speakerName;
    public string lineText;
}
