using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

public class Ball_script : MonoBehaviour
{ 
    public Rigidbody sphere_rigidbody; 
    [SerializeField] 
    private float force = 5f; 
    [SerializeField] 
    private Text[] Who_won;  
    private float Score_of_player_1 = 0f; 
    private float scroe_of_player_2 = 0f;   
    [SerializeField] 
    private GameManager game_Manager_1;
        void Start()
    {
        sphere_rigidbody = this.gameObject.GetComponent<Rigidbody>(); 
        sphere_rigidbody.AddForce(new Vector3(force,0,0),ForceMode.VelocityChange); 
        Who_won[0] = GameObject.Find("Text_1").GetComponent<Text>(); 
        Who_won[1] = GameObject.Find("Score_player_1").GetComponent<Text>(); 
        Who_won[2] = GameObject.Find("Score_player_2").GetComponent<Text>();
        
    }

    // Update is called once per frame
   void OnCollisionEnter(Collision other) 
   {   
       
       if(other.gameObject.name == "Player_1") 
       {  
           Who_won[1].text = "Score is" + (Score_of_player_1+10); 
           sphere_rigidbody.AddForce(new Vector3(-force,0,0),ForceMode.VelocityChange);
       } 
       else if(other.gameObject.name == "Player_2") 
       {  
           Who_won[2].text = "Score is" + (scroe_of_player_2+10); 
           sphere_rigidbody.AddForce(new Vector3(force,0,0),ForceMode.VelocityChange);
       }  
       if(other.gameObject.tag == "Player_1_is_winner") 
       {        
           game_Manager_1.Game_over();
           Who_won[0].text = "Player_1 has won\nPress \"R\" to restart"; 
           Who_won[0].enabled = true;
           Debug.Log("player_1_is_winner"); 
           
           Destroy(this.gameObject);
       } 
       else if(other.gameObject.tag == "Player_2_is_winner") 
       {   
           game_Manager_1.Game_over();
           Who_won[0].text = "Player_2 has won\nPress \"R\" to restart"; 
           Who_won[0].enabled = true; 
           Debug.Log("Player_2_is_winner");
          
           Destroy(this.gameObject);
       } 
    


   }
}
