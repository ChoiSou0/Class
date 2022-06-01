using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target_Ctrl : MonoBehaviour
{
    [SerializeField] GameObject Player;
    Player_Ctrl player;
    public int Speed;
    Vector3 Vec;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0, Vec.y, 0);
        player = GameObject.Find("Player").GetComponent<Player_Ctrl>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.LookAt(player.transform.position);
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }

}
