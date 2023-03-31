using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    private bool isEnter = false;
    private bool isStay = false;
    private bool isExit = false;
    private bool isOnGround = false;
    public bool isGround()
    {
        if(isEnter | isStay)
        {
            this.isOnGround = true;
        }
        else if(isExit)
        {
            this.isOnGround = false;
        }

        this.isEnter = false;
        this.isStay = false;
        this.isExit = false;

        return isOnGround;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            this.isEnter = true;
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            this.isStay = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            this.isExit = true;
        }
    }
}
