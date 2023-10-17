using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMiddleScript : MonoBehaviour
{

    public Logiccript logic;
    public WallSpawnScript spawn;
    // Start is called before the first frame update
    void Start()
    {
          logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logiccript>();
      


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col) {

        Debug.Log(col.gameObject.tag);

        if (col.gameObject.tag == "Kim") {

            Debug.Log("skor artar");
            logic.addScore(1);
        }

        /* if (col.gameObject.layer == 3){
            logic.addScore(1);
        }*/
        
    }
}
