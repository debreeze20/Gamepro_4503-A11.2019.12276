using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    

    // Start is called before the first frame update
    

    void OnCollisionEnter2D (Collision2D coll) {
        if (coll.gameObject.tag == "nueTag") {
            Debug.Log("Get Coin");
            Destroy (gameObject);
        }
    }

    void OnCollisionStay2D (Collision2D coll) {
        
    }

    void OnCollisionExit2D (Collision2D coll) {
        
    }

    // Update is called once per frame
    
}
