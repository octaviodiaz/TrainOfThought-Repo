using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using System.Collections;

public class CreateTrains : MonoBehaviour
{

    private float myTimer = 10.0f;
    private GameObject blackTrain;
    private Vector3 blackTrainIPosition;
    private int blackTrainCounter = 0;
    private List<GameObject> blackTrains = null;

    void Start()
    {
        
       
        blackTrain = GameObject.Find("blackTrain");
        blackTrainIPosition = new Vector3(blackTrain.transform.position.x, blackTrain.transform.position.y, blackTrain.transform.position.z);
    
        List<GameObject> blackTrains = new List<GameObject>();
        for (int i = 0; i < 1000; i++)
        {
            blackTrains.Add(GameObject.Find("blackTrain").gameObject);
        }

    }

    // Update is called once per frame
    private void Update()
    {
        if (myTimer > 0)
        {
            myTimer -= Time.deltaTime;
        }
        if (myTimer <= 0)
        {
            myTimer = 10.0f;
            
            Instantiate(blackTrains[blackTrainCounter++], blackTrainIPosition, Quaternion.identity);
            Debug.Log("new black train");
        
        }
    }
}


