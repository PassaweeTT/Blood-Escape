using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2.5f;
    public float speedRun = 2.5f;
    private float baseSpeed;
    public float dashTime;
    public int sss = 0;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator anime;
    
    [SerializeField] private bool isWalk;
    [SerializeField] private bool isRun;
    [SerializeField] private bool SW;

    [SerializeField] LayerMask groundLayer;

    public static Player instance;

    private void Awake()
    {
        instance = this;
        rb = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        baseSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
        FlipSprite();
        AnimePlayer();
        if (Input.GetButtonDown("Jump"))
        {
            StartCoroutine(playerDash());
        }
        
    }

    void Walk()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, rb.velocity.y);
        isWalk = (Input.GetAxisRaw("Horizontal") != 0);
            
        if (Input.GetButtonDown("Fire3"))
        {
            speed += speedRun;
            isRun = true;
            
        }
        if (Input.GetButtonUp("Fire3"))
        {
            isRun = false;
            speed = baseSpeed;
        }
    }
    
    void FlipSprite()
    {
        bool flip = Mathf.Abs(rb.velocity.x) > Mathf.Epsilon;
        if (flip)
        {
            transform.localScale = new Vector2(Mathf.Sign(rb.velocity.x),1f);
        }
    }

    void AnimePlayer()
    {
        anime.SetBool("isWalk", isWalk);
        anime.SetBool("isRun", isRun);
        anime.SetBool("SW", SW);
    }

    public void swordSW(int getSword)
    {
        sss = getSword;
        if(sss >= 1)
        {
            SW = true;
        }
        
    }

    IEnumerator playerDash()
    {
            print("AA");
            speed += 30;
            yield return new WaitForSeconds(dashTime);
            speed = baseSpeed;
    }

   
}
