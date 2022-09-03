using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MapGenerator : MonoBehaviour
{
    public GameObject node;
    public GameObject map;
    private int randomSeed;
    public int totalNodesBeforeBossFight,floorCount;
    private Vector3 newNodePosition;


    Dictionary<int, Vector3> floorAndNodePosition = new Dictionary<int, Vector3>();

    private void Awake()
    {
        Random.Range(0, 3);//To generate random seeds
        NodeCreation();
    }

    void Start()
    {
        
            
        

    }

    void lineDraw(Dictionary<int, Vector3> floorAndNodePosition)
    {
        //floorAndNodePosition;
    }

    void NodeClassification()
    {

    }
    
    void NodeCreation()
    {
        float portionalWidthOfMap = map.GetComponent<SpriteRenderer>().bounds.size.x; //Took the dimensions of the map
        float portionalHeightOfMap = map.GetComponent<SpriteRenderer>().bounds.size.y;
        float nodeDiameter = node.GetComponent<SpriteRenderer>().bounds.size.x;
        {
            for (int j = 0; j < 10; j++)
            {
                floorCount++;//where we start to play is floor zero,first fight's at floor one.
                for (var i = 0; i < 5; i++)
                {
                    float k = Random.Range(-0.3f, 0.3f);
                    newNodePosition = new Vector3 (k + nodeDiameter * 2 - portionalWidthOfMap / 2 + i * portionalWidthOfMap / 5, k + nodeDiameter - portionalHeightOfMap / 2 + portionalHeightOfMap / 3 * j, -1);
                    Instantiate(node, newNodePosition, Quaternion.identity); //totalNodesBeforeBossFight will be added as divider of portional height of map
                    floorAndNodePosition.Add(floorCount,newNodePosition);


                }
            }
        }

        
    }


}


