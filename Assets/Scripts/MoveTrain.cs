using System;
using UnityEditor;
using UnityEngine;

public class MoveTrain : MonoBehaviour {

    //public GameObject prefabBlackTrain;

    private void Start()
    {

        Debug.Log("black train Created");

        try
        {
            gameObject.GetComponent<Renderer>().enabled = false;
            
            iTween.MoveTo(gameObject,
                iTween.Hash("path", iTweenPath.GetPath("TrainPath"), "time", 130, "easytype", iTween.EaseType.easeOutSine));

        }
        catch (Exception e)
        {            
            Debug.Log(e.Message);
        }
      
    }

    private void Update()
    {
        if (gameObject.GetComponent<Renderer>().enabled == false)
        {
            gameObject.GetComponent<Renderer>().enabled = true;
        }

    }

    void OnTriggerEnter(Collider other)
    {
        gameObject.GetComponent<Renderer>().enabled = false;
        Destroy(gameObject);
        Debug.Log("black train destroyd");
    }
}
