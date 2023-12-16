using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class soundmanager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    void Start()
    {
        if(PlayerPrefs.HasKey("SoundVolume")){
            PlayerPrefs.SetFloat("SoundVolume",1f);
            Load();
        }
        else{
            Load();
        }
    }
    public void ChangeVolume(){
        AudioListener.volume=volumeSlider.value;
        Save();
    }
    private void Load(){
        volumeSlider.value=PlayerPrefs.GetFloat("SoundVolume");
    }
    private void Save(){
        PlayerPrefs.SetFloat("SoundVolume",volumeSlider.value);
        PlayerPrefs.Save();
    }
}
