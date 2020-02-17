using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody2D mario;
    public static bool guapo = false;
    SpriteRenderer marioGrande;
    string nameOfSprite;
    public Sprite sprite2;
    public AudioSource forward;
    // Start is called before the first frame update
    void Start()
    {
        mario = GetComponent<Rigidbody2D>();
        marioGrande = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            jump();
    }

    void jump()
    {
        if (mario)
        {
            if (Mathf.Abs(mario.velocity.y) < 0.05f)
                mario.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
        }
    }

    private void FixedUpdate()
    {
        if(mario)
        {
            mario.AddForce(new Vector2(Input.GetAxis("Horizontal") * 10, 0));
        }
        if (Input.GetKeyDown("d"))
        {
            if (transform.rotation != Quaternion.Euler(0, 180, 0))
                transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        if (Input.GetKeyDown("a"))
        {
            if (transform.rotation != Quaternion.Euler(0, 0, 0))
                transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

            Destroy(gameObject);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Mushroom"))
        {
            guapo = !guapo;
            forward.Play();
            marioGrande.sprite = sprite2;
            Destroy(other.gameObject);
        }
    }


}

