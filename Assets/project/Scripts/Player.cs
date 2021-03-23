using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Camera playerCamera;
    public GameObject BulletPrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject Bulletobject = Instantiate(BulletPrefab);
            Bulletobject.transform.position = playerCamera.transform.position + playerCamera.transform.forward;
            Bulletobject.transform.forward = playerCamera.transform.forward;
        }
            
    }
}
