using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    Vector3 kekiri;
    // Start is called before the first frame update
    void Start()
    {
        kekiri = new Vector3(-1,0,0);
    }

    void OnCollisionEnter2D (Collision2D coll) {
        if (coll.gameObject.tag.Equals ("nueTag")) {
            Debug.Log("Get Coin");
            Destroy (this.gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position+(kekiri*speed*Time.deltaTime);
    }
}
