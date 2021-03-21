using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2_script : MonoBehaviour
{  
    [SerializeField] 
    private float force;
    private Rigidbody Player_rigidbody; 
    // Start is called before the first frame update
    void Start()
    {
        Player_rigidbody = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    { 
        if(Input.GetKey(KeyCode.W) == true)    
        {  
            Player_rigidbody.AddForce(new Vector3(0,force * Time.deltaTime,0),ForceMode.Force);

        } 
        else if(Input.GetKey(KeyCode.S) == true)  
        { 
            Player_rigidbody.AddForce(new Vector3(0,-force * Time.deltaTime,0),ForceMode.Force);
        }
        
    }
}
