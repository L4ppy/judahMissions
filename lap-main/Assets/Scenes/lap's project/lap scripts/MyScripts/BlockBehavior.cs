using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class BlockBehavior : MonoBehaviour
{
    Material material;
    public GameObject DestroyedBlock;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip[] audioClips;
    

    private Score scoreScript;
    //private Score scoreScript;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Block";
        audioSource = GameObject.Find("Audio Source").GetComponent<AudioSource>();

        scoreScript = GameObject.Find("_ScoreManager").GetComponent<Score>();
        

        material = this.GetComponent<MeshRenderer>().material;
    }
    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "ammo")
        {
            //if (this.gameobject.tag == "redblock")
            //{
            //    destroy(this.gameobject);
            //}
            //debug.log("block detected collion " + coll.gameobject.tag);
            //material.color = color.red;
            //gameobject.tag = "redblock";

            switch (this.gameObject.tag)
            {   
                case "Block":
                    material.color = Color.red;
                    gameObject.tag = "redBlock";
                    scoreScript.updateScore(10);
                    break;
                case "redBlock":
                    material.color = Color.yellow;
                    gameObject.tag = "yellowBlock";
                    scoreScript.updateScore(25);
                    break;
                case "yellowBlock":
                    material.color = Color.green;
                    gameObject.tag = "greenBlock";
                    scoreScript.updateScore(50);
                    break;
                case "greenBlock":
                    Destroy(this.gameObject);
                    audioSource.PlayOneShot(audioClips[0]);
                    scoreScript.currentScore = 0;
                    SmokeOut();
                    break; 
               

            }  
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void SmokeOut() => Instantiate(DestroyedBlock, this.transform.position, Quaternion.identity);

    
}
