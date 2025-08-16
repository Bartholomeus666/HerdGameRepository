using UnityEngine;

public class HandlePlayerScripts : MonoBehaviour
{
    public MonoBehaviour Movementscript;

    public void DisableMovement()
    {
        Movementscript.enabled = false;
    }
}
