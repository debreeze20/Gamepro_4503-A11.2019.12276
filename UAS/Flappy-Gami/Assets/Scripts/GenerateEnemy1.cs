using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemy1 : MonoBehaviour
{

    public GameObject junpei;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("CreateEnemy", 5f, 7.5f);
    }

    void CreateEnemy() {
        Instantiate(junpei);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
