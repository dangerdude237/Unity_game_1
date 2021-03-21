using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

public class UI_manager : MonoBehaviour
{ 
    [SerializeField] 
    public Text[] Who_won_text;  
    void Start() 
    { 
        Who_won_text[1].text = "Score = 0"; 
        Who_won_text[2].text = "Score = 0";
    }
    
}
