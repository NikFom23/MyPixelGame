using UnityEngine;
using UnityEngine.InputSystem;

public class HeriInputReader : MonoBehaviour
{
    [SerializeField]private Hero _hero;

  

    public void OnHorizontalMovement(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<Vector2>();
        _hero.SetDirection(direction);
    }

    public void OnSaySomething(InputAction.CallbackContext context)
    {
        if(context.canceled)
            _hero.SaySomthing();
    }
}
