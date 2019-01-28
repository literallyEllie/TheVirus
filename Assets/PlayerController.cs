using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 1f;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;

        spriteRenderer = GetComponent<SpriteRenderer>();

    }
	
	// 
	void FixedUpdate ()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            spriteRenderer.flipX = false;
            Vector3 targetPos = this.transform.position + Vector3.right * speed * Time.deltaTime;
            this.transform.Translate(targetPos - this.transform.position);
        }


        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            spriteRenderer.flipX = true;
            Vector3 targetPos = this.transform.position + Vector3.left * speed * Time.deltaTime;
            this.transform.Translate(targetPos - this.transform.position);
        }

    }

}
