using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private GameObject gc;
    private bool isOnGrand = true;
    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) & isOnGrand)
        {
            rb.AddForce(new Vector2(0, 100f));
            Debug.Log("‚â‚ ");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(1f, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-1f, rb.velocity.y);
        }
        this.isOnGrand = gc.GetComponent<GroundCheck>().isGround();
    }
}
