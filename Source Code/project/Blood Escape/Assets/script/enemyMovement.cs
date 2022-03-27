using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public int hp = 100;
    public float speed = 3f;
    [SerializeField] private Rigidbody2D rb;
    private int direction = -1;
    int check = 0;
    int appear = 1;
    public GameObject deathEffect;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.localScale = new Vector2(-1, 1);
    }
    // Update is called once per frame
    void Update()
    {
        if (check >= 1)
        {
            rb.velocity = new Vector2(speed * direction, rb.velocity.y);
        }
    }
    public void TakeDamage (int damage)
    {
        hp -= damage;
        if(hp <= 0)
        {
            Die();
        }
    }
    
    void Die()
    {
        
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            walking();
        }
    }
    void walking()
    {
        check += 1;
    }
}
