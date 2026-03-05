using System;
using System.Collections;
using UnityEditor;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2D;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float lifeTime;
    [SerializeField] private SpriteRenderer sr;
    private void Start()
    {
        rb2D.linearVelocityY = -moveSpeed;
        StartCoroutine(LifeFlow());
        StartCoroutine(TurnFlow());
    }

    private IEnumerator TurnFlow()
    {
        while (true)
        {
            yield return new WaitForSeconds(1); 
            sr.flipX = !sr.flipX;
        }
    }
    
    private IEnumerator LifeFlow()
    {
        yield return new WaitForSeconds(lifeTime);
        #if UNITY_EDITOR
            EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("bullet"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
