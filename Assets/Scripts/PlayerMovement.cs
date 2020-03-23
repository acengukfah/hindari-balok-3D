using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500;
    public bool leftKeys = false;
    public bool rightKeys = false;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ((Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow))))
        {
            leftKeys = true;
        }else
        {
            leftKeys = false;
        }

        if ((Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow))))
        {
            rightKeys = true;
        }else 
        { 
            rightKeys = false;
        }

        if (rightKeys)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (leftKeys)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}