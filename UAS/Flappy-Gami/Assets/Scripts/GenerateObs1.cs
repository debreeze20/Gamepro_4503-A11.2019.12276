using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObs1 : MonoBehaviour
{

    public GameObject spirits;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("CreateObstacle", 1f, 4.5f);
    }

    void CreateObstacle() {
        Instantiate(spirits);
        score++;
        SaveLoadHighScore.SaveHighScore(score);
        if (score >= 20) {
            GUIManager.saveLevel(1);
        }
        if (score >= 40) {
            GUIManager.saveLevel(2);
        }
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
