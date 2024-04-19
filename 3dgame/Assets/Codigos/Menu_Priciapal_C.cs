using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Menu_Priciapal_C : MonoBehaviour
{
    [Header("Options")]
    public Slider volumeFX;
    public Slider volumenMaster;
    public Toggle mute;
    public AudioMixer mixer;
    public AudioSource fxsource;
    public AudioClip clicksound;
    private float lastvolume;

    [Header("Panels")]
    public GameObject mainpanel;
    public GameObject opticonpanel;
    
   
    private void Awake()
    {
        volumeFX.onValueChanged.AddListener(ChangeVolumenFX);
        volumenMaster.onValueChanged.AddListener(ChangeVolumenMaster);
    }
    public void PlayLevel(string levelname)
    {
        SceneManager.LoadScene(levelname);
    }
    public void Exitgame() 
    {
        Application.Quit();
    }

    public void SetMute()
    {
        
        if (mute.isOn)
        {
            mixer.GetFloat("VolMaster", out lastvolume);
            mixer.SetFloat("VolMaster", -80);
            

        }
        else
        {
            mixer.SetFloat("VolMaster", lastvolume);
        }
    }
    public void OpenPanel(GameObject panel)
    {
        mainpanel.SetActive(false);
        opticonpanel.SetActive(false);

        panel.SetActive(true);
        PlaySoundButton();
    }

    public void ChangeVolumenMaster(float v)
    {
        mixer.SetFloat("VolMaster", v);
    }
    public void ChangeVolumenFX(float v)
    {
        mixer.SetFloat("VolFX", v);
    }
    public void PlaySoundButton()
    {
        fxsource.PlayOneShot(clicksound);
    }
}
