using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObs : MonoBehaviour
{

    public GameObject spirits;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("CreateObstacle", 2f, 2.5f);
    }

    void CreateObstacle() {
        Instantiate(spirits);
        score++;
    }

    void OnGUI() {
        GUI.color = Color.black;
        GUILayout.Label("Score : "+score.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
