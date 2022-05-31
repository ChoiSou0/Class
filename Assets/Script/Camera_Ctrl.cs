using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Ctrl : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject bullet;
    [SerializeField] int Power;
    float xCam, yCam;
    [SerializeField] float Shoot_DelTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        See();
        Shoot();
    }

    void See()
    {
        float xMouse = Input.GetAxis("Mouse X");
        float yMouse = Input.GetAxis("Mouse Y");

        xCam += xMouse * Power * Time.deltaTime;
        yCam += yMouse * Power * Time.deltaTime;

        if (yCam > 30)
        {
            yCam = 30;
        }
        else if (yCam < -30)
        {
            yCam = -30;
        }

        if (xCam > 50)
        {
            xCam = 50;
        }
        else if (xCam < -50)
        { 
            xCam = -50;
        }

        transform.eulerAngles = new Vector3 (-yCam, xCam, 0);

        // Player Rotation

        Player.transform.Rotate(0, xMouse, 0);
    }

    void Shoot()
    {
        Shoot_DelTime += Time.deltaTime;

        if (Input.GetKey(KeyCode.Mouse0) && Shoot_DelTime >= 0.3f)
        {
            Instantiate(bullet, this.transform.position, Quaternion.EulerAngles(-yCam, xCam, 0));
            Shoot_DelTime = 0;
        }
    }
}
