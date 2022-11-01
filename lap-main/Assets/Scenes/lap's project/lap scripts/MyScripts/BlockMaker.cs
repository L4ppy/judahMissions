using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMaker : MonoBehaviour

{
    public GameObject block;
    private int blockWidth = 2;
    private int blockHeight = 1;
    var blockwin = GameObject.FindGameObjectWithTag("greenBlock")
    List<GameObject> blockList = new List<GameObject>();
    // Start is called before the first frame update
    void Start() {
        StartCoroutine(BuildWall());
        Debug.Log("list count :" + blockList.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator BuildWall()
    {
        
            //Instantiate (Block, this.transform.position, Quaternion.identity);
            for (int xAxis = 0; xAxis < 5; xAxis++)
            { 
                for (int yAxis = 0; yAxis < 5; yAxis++)
                {
                    GameObject latesBlock = Instantiate(block, new Vector3(this.transform.position.x + blockWidth * xAxis, this.transform.position.y + blockHeight * yAxis, this.transform.position.z), Quaternion.identity);
                    blockList.Add(latesBlock);
                    //Debug.Log("adding new block to the list. Reading element " + i + " as " + blockList[j]);
                    yield return new WaitForSeconds(0.2f);
                }
            }
        //StartCoroutine(DestroyWall());
    }

    IEnumerator DestroyWall() 
    {
        for (int xAxis = 0; xAxis < blockList.Count; xAxis++)
        {
            Destroy(blockList[xAxis]);
            yield return new WaitForSeconds(0.2f);
        }
    }

    void CountBlocks()
    {
        for (int i = 0; i < blockList ; i++)
        {
            if (GameObject.FindGameObjectsWithTag("greenBlock").Length = blockList.Count)
            {
                
            }
            else if (GameObject.FindGameObjectsWithTag("greenBlock").Length < blockList.Count )
            {
                Debug.Log("you hit " + GameObject.FindGameObjectsWithTag("greenBlock").Length);
            }

                
        }
    }
}
