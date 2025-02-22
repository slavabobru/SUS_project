using UnityEngine;

public class Jump_Script : MonoBehaviour
{
    public int doubleJump = 0;
    public float jumpSp = 4.0f;
    public bool ifonland = false;
    public bool funtime;
    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        if (ifonland && Input.GetKey(KeyCode.Space))
        {
            Jump();
            //SleepTimeout("0.5f");
        }
        else if (!ifonland && doubleJump < 2 && Input.GetKey(KeyCode.Space))
        {
            Jump();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("land"))
        {
            ifonland = true;
            doubleJump = 0;
        }
        if (collision.gameObject.CompareTag("Save_Zone"))
        {
            ifonland = true;
            doubleJump = 0;
        }
        if (collision.gameObject.CompareTag("enemy"))
        {
            ifonland = true;
            doubleJump = 0;
        }

        if (collision.gameObject.CompareTag("SmallCoin"))
        {
            Debug.Log("MONEY IS CONSUMABLE");
            Destroy(collision.gameObject);
            ifonland = true;
            doubleJump = 0;
        }
    }
    private void Jump()
    {
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, jumpSp, rb.linearVelocity.z);
        doubleJump++;
        ifonland = false;
    }
}
