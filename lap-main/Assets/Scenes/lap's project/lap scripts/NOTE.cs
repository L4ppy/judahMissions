using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NOTE : MonoBehaviour
{
    private int ammo = 6; private int mgz = 3;
    // Start is called before the first frame update
    void Start()
    {
        ammo = ammo - 1;
        Debug.Log("Now reading ammo as " + ammo);
        Debug.Log("Now reading ammo as " + mgz);

        //Debug.Log("ïnside the start function");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (ammo > 0)
            {

                ammo = ammo - 1;
                Debug.Log("You have " + ammo + " bullets remaining");
            }
            else if (ammo < 1)
            {
                Debug.Log("Your gun is empty. Hit R to reload");
            }
            // Debug.Log("ïnside the start function");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (ammo < 1)
            {
                ammo = 5;
                
                Debug.Log("Reload successfully");
               
            }
            else if (ammo > 0 || mgz < 1)
            { Debug.Log("Reload Error");
                ammo = 0;
            }

            if (mgz > 0)
            {
                mgz = mgz - 1;
                Debug.Log("You have " + mgz + " clips remaining");
            }

            else if (mgz < 1)
            { Debug.Log("run out ammo"); }
        }
    }
}
