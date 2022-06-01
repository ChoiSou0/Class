using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Ctrl : MonoBehaviour
{
    public int Bullet_Speed;
    Camera_Ctrl camera;

    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.Find("MainCamera").GetComponent<Camera_Ctrl>();
        this.transform.rotation = camera.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Bullet_Speed * Time.deltaTime);
    }
}
