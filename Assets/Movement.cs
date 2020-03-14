using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	private Rigidbody2D rb;
	public float xspeed;
	public float gravity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float mh = Input.GetAxis ("Horizontal");
        float mv = Input.GetAxis ("Vertical");
        Vector2 movement = new Vector2 (mh*xspeed, mv*gravity);
        rb.AddForce (movement);
    }
}
