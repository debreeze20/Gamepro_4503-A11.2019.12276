using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCState : MonoBehaviour
{

    GameObject player, player2;
    Animator anim;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player2 = GameObject.FindGameObjectWithTag("nueTag");
        anim = GetComponent<Animator> ();
        float range = 2;
        transform.position = new Vector3 (transform.position.x, transform.position.y - range*Random.value, transform.position.z);
    }


    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance (transform.position, player.transform.position) < 4f ) {
            anim.SetBool("IsDekat", true);
            
        } else {
            anim.SetBool("IsDekat", false);
        }

        if (Vector3.Distance (transform.position, player.transform.position) < 1f ) {
            anim.SetBool("IsDestroy", true);
            Die();
            
        } else {
            anim.SetBool("IsDestroy", false);
        }
    }

    private void OnTriggerEnter (Collider other) {
        if (other.tag == "nueTag") {
            anim.SetTrigger("isDekat");
        }
    }

    void Die() {
        ScoreScript.scoreInt +=1;
        Debug.Log("Enemy Die");
        Destroy(gameObject);
        
    }

    void OnCollisionExit2D (Collision2D coll) {
        Die();
        
    }

}
