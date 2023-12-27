using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float shootingRange = 100f;
    public GameObject wall;
    public GameObject window;

    void Update()
    {
        
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger)) 
        {
            Shoot();
        }
    }

    void Shoot()
    {
        
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, shootingRange))
        {
            
            if (hit.transform.CompareTag("Wall"))
            {
                wall.SetActive(false);
                //HandleWallHit(hit.transform.gameObject);
            }
            else if (hit.transform.CompareTag("Window"))
            {
                window.SetActive(false);
                //HandleWindowHit(hit.transform.gameObject);
            }
        }
    }

   /* void HandleWallHit(GameObject wall)
    {
        
        Debug.Log("Hit a wall!");
    }

    void HandleWindowHit(GameObject window)
    {
        
        window.SetActive(false);
        Debug.Log("Window disappeared!");
    }*/
}
