using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Trigger : MonoBehaviour
{
    [SerializeField] private string tagCol;
    public UnityEvent getTrigger;
    public UnityEvent ExtraEvent;

    private InputSystem_Actions _inputActions;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagCol))
        {
            getTrigger?.Invoke();
        }
    }

    private void Start()
    {
        _inputActions = new InputSystem_Actions();
        _inputActions.Enable();
        _inputActions.Player.Interact.performed += ShootEvent;
    }

    private void ShootEvent(InputAction.CallbackContext context)
    {
        Debug.Log("shoot");
        ExtraEvent?.Invoke();
    }

    private void OnDisable()
    {
        _inputActions.Player.Interact.performed -= ShootEvent;
        _inputActions.Disable();
    }
}
