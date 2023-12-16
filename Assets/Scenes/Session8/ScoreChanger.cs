using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public int scorething;
    public string key="MyKeyForTest";
    public TMP_Text thisscore;
    GameObject gameObject;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("r")==true){
            ++scorething;
            PlayerPrefs.SetInt(key,scorething);
        }    
        if(Input.GetKey("c")==true){
            scorething=0;
        }
        if(Input.GetKey("f")==true){
            PlayerPrefs.DeleteAll();
        }
        if(Input.GetKey("v")==true){
            PlayerPrefs.Save();
        }
        
        
        thisscore.text="Number of hit(s):" + PlayerPrefs.GetInt(key,scorething);//.ToString();
    }
    

    
}
