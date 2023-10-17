using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kimdpkjaScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public Logiccript logic;
    public SoundEffectLayer sound;
    public bool kimIsAlive = true;
    public int deadZone = -5;
    public bool soundHeared = false;
    


    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Kim Dokja";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logiccript>();
        sound = GameObject.FindGameObjectWithTag("Canvas").GetComponent<SoundEffectLayer>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && kimIsAlive){
             myRigidbody.velocity = Vector2.up * flapStrength;
            sound.jump();
        }


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }


    private void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.layer == 6){
            Debug.Log("game over text");
            kimIsAlive = false;
            sound.hit();
            logic.gameOver();
            Destroy(gameObject);
        }
    }


}
