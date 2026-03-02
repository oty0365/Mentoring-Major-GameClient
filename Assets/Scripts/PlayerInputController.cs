using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private Rigidbody2D rb2D;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float moveSpeed;
    
    public void OnMove(InputAction.CallbackContext context)
    {
        var dir = context.ReadValue<float>();
        if (context.performed)
        {
            if (dir > 0)
            {
                sr.flipX = false;
            }
            else
            {
                sr.flipX = true;
            }
        }
        rb2D.linearVelocityX = dir*moveSpeed;
    }

    public void OnShoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Instantiate(bulletPrefab, rb2D.position, Quaternion.identity);
        }
    }
}
