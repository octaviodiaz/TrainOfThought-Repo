using System.Collections.Generic;
using System.Globalization;
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
    public GameObject prefabBlackTrain;

    void Start()
    {

        blackTrainIPosition = new Vector3(1.85f,-1.14f,0);
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

            GameObject blackT = (GameObject) Instantiate(prefabBlackTrain, blackTrainIPosition, Quaternion.identity);
            blackT.AddComponent<MoveTrain>();
       
            blackT.AddComponent<Rigidbody>();
            blackT.GetComponent<Rigidbody>().useGravity = false;
            blackT.GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.Discrete;

            blackT.AddComponent<BoxCollider>();
            blackT.GetComponent<BoxCollider>().isTrigger = true;
            blackT.GetComponent<BoxCollider>().size= new Vector3(.44f,.38f,.2f);


        }     
    }
}


