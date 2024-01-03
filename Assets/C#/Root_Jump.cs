using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Root_Jump : MonoBehaviour
{

    private Rigidbody rb;

    public int jumpPower;

    private int JumpCount = 0;

    public AudioSource soundJump;

    // Start is called before the first frame update
    void Start()
    {
        soundJump = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (JumpCount == 0)
            {
                soundJump.time = 0.12f;
                soundJump.Play();
                rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
                JumpCount++;
            }
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Ground")
        {
            JumpCount = 0;
        }
        if(collision.transform.tag == "Enemy")
        {
            //Debug.Log("Dead");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
