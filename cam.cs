using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    public GameObject kamera;
    public GameObject player;

    public float sens;
    private float Xrot;
    private float Yrot;

    private void Start()
    {
        
    }

    void Update()
    {
        Yrot = Mathf.Clamp(Yrot, -90, 90);

        Xrot -= Input.GetAxis("Mouse X") * sens;
        Yrot -= Input.GetAxis("Mouse Y") * sens;

        kamera.transform.rotation = Quaternion.Euler(Yrot,-Xrot, 0);

        if (Input.GetKey(KeyCode.W))
        {
            player.transform.Translate(kamera.transform.forward * Time.deltaTime*10);
        }
        

       
        


        



        
    }
}
