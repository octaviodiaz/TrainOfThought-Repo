using UnityEngine;
using Random = System.Random;

public class CreateTrains : MonoBehaviour
{

    private float _myTimer = 4.0f;
    private Vector3 _startPosition;
    public GameObject PrefabBlackTrain;
    public GameObject PrefabYellowTrain;
    public GameObject PrefabPinkTrain;
    public GameObject PrefabGreenTrain;

    void Start()
    {
        _startPosition = new Vector3(1.85f,-1.14f,0);
    }

    // Update is called once per frame
    private void Update()
    {
        if (_myTimer > 0)
        {
            _myTimer -= Time.deltaTime;
        }
        if (_myTimer <= 0)
        {
            _myTimer = 4.0f;

            int randomNumber = new Random().Next(1, 5);

            switch (randomNumber)
            {
                case 1: CreateBlackTrain();
                    break;
                case 2: CreateGreenTrain();
                    break;
                case 3: CreatePinkTrain();
                    break;
                case 4: CreateYellowTrain();
                    break;
            }
        }     
    }


    private void CreateBlackTrain()
    {
        GameObject blackT = (GameObject)Instantiate(PrefabBlackTrain, _startPosition, Quaternion.identity);
        AddPhysicsTrain(blackT);
    }

    private void CreateYellowTrain()
    {
        GameObject yellowY = (GameObject)Instantiate(PrefabYellowTrain, _startPosition, Quaternion.identity);
        AddPhysicsTrain(yellowY);
    }

    private void CreatePinkTrain()
    {
        GameObject pinkT = (GameObject)Instantiate(PrefabPinkTrain, _startPosition, Quaternion.identity);
        AddPhysicsTrain(pinkT);
    }

    private void CreateGreenTrain()
    {
        GameObject greenT = (GameObject)Instantiate(PrefabGreenTrain, _startPosition, Quaternion.identity);
        AddPhysicsTrain(greenT);
    }

    private void AddPhysicsTrain(GameObject train)
    {
        train.AddComponent<MoveTrain>();
        //
        train.AddComponent<Rigidbody>();
        train.GetComponent<Rigidbody>().useGravity = false;
        train.GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.Discrete;
        //
        train.AddComponent<BoxCollider>();
        train.GetComponent<BoxCollider>().isTrigger = true;
        train.GetComponent<BoxCollider>().size = new Vector3(.44f, .38f, .2f);
    }
}


