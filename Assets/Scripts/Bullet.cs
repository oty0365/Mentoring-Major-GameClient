using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2D;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float lifeTime;
    private void Start()
    {
        rb2D.linearVelocityY = moveSpeed;
        StartCoroutine(LifeFlow());
    }

    private IEnumerator LifeFlow()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
}
