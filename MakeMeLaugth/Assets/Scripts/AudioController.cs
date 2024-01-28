using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource ClickSound;

    public void onClickSoundButton()
    {
        
        ClickSound.Play();
        
    }
  
}
