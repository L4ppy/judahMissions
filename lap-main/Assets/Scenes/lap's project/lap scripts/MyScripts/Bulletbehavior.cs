using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletbehavior : MonoBehaviour    
{
   
    // Start is called before the first frame update
    void Start()
    {
        
        Destroy(this, 1f);
        
    }
   void OnCollisionEnter(Collision coll)
   {
      if (coll.collider.tag == "Block")
        {
            Destroy(this, 0.02f);             
        }
      
   }
}
