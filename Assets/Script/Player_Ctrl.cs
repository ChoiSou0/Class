using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Ctrl : MonoBehaviour
{
    public GameObject cam;
    Rigidbody rb;
    public int Jump_cnt;
    public int Player_Speed;
    public int JumpForce;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        float xSpeed = Input.GetAxis("Horizontal");
        float zSpeed = Input.GetAxis("Vertical");

        Vector3 Pos = transform.position;

        Pos.x += xSpeed * Time.deltaTime * Player_Speed;
        Pos.z += zSpeed * Time.deltaTime * Player_Speed;

        transform.position = Pos;

        //See
        
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Jump_cnt > 0)
        {
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            Jump_cnt--;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            Jump_cnt = 1;
        }
    }

}
