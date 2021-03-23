using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Camera playerCamera;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Objectpoolingmanager.Instance.GetBullet();

            GameObject Bulletobject = Objectpoolingmanager.Instance.GetBullet();
            Bulletobject.transform.position = playerCamera.transform.position + playerCamera.transform.forward;
            Bulletobject.transform.forward = playerCamera.transform.forward;
        }
            
    }
}
