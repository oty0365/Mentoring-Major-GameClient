using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2D;
    [SerializeField] private float moveSpeed;
    private void Start()
    {
        rb2D.linearVelocityY = 1*moveSpeed;
    }
}
