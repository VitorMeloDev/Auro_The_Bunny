using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MenuAudio: MonoBehaviour
{
    public AudioMixer mixer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    
    float GetVol(float vol)
    {
        float newVol = 0;
        newVol = 20 * Mathf.Log10(vol);
        if (vol <= 0)
        {
            newVol = -80;
        }

        return newVol;
    }

    public void SetMasterVol(float vol)
    {
        
        mixer.SetFloat("MasterVol", GetVol(vol));
    }

    public void SetMusicVol(float vol)
    {
        mixer.SetFloat("MusicVol", GetVol(vol));
    }

    private void SetFloat(string v1, float v2)
    {
        throw new NotImplementedException();
    }

    public void SetSfxVol(float vol)
    {
        mixer.SetFloat("SFXvol", GetVol(vol));
    }
}
