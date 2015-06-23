using System;
using UnityEditor;
using UnityEngine;

public class MoveTrain : MonoBehaviour {

    //public GameObject prefabBlackTrain;

    private void Start()
    {
        Debug.Log("train Created");
        moveToPath("TrainPath1");
       
    }


    private void Update()
    {
        if (gameObject.GetComponent<Renderer>().enabled == false)
        {
            gameObject.GetComponent<Renderer>().enabled = true;
        }

    }

    private void moveToPath(String path)
    {
        try
        {
            gameObject.GetComponent<Renderer>().enabled = false;
            iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath(path), "time", 8));
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Button1")
        {
            Debug.Log("button 1");
            if (other.gameObject.GetComponent<SpriteRenderer>().sprite.name == "arrow-left")
            {
                moveToPath("TrainPath3");
            }
            else
            {
                moveToPath("TrainPath2");
            }
        }
        else if (other.gameObject.name == "Button2")
        {
            if (other.gameObject.GetComponent<SpriteRenderer>().sprite.name == "arrow-right")
            {
                moveToPath("TrainPath4");
            }
            else
            {
                moveToPath("TrainPath7");
            }
        }
        else if (other.gameObject.name == "Button3")
        {
            if (other.gameObject.GetComponent<SpriteRenderer>().sprite.name == "arrow-right")
            {
                moveToPath("TrainPath5");
            }
            else
            {
                moveToPath("TrainPath6");
            }
        }
        else if (other.gameObject.name == "Blackhouse" ||  other.gameObject.name == "Pinkhouse" || 
            other.gameObject.name == "Yellowhouse" || other.gameObject.name == "Greenhouse" )
        {
            gameObject.GetComponent<Renderer>().enabled = false;
            Destroy(gameObject);
            Debug.Log("black train ");
        }

    }
 
}
