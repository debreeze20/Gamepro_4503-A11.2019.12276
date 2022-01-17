using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemy : MonoBehaviour
{

    public GameObject wombs;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("CreateEnemy", 5f, 7.5f);
    }

    void CreateEnemy() {
        Instantiate(wombs);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
