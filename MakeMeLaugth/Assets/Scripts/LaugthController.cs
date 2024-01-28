using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LaugthController : MonoBehaviour
{
    public AudioSource LaugthSound;

    private void Start()
    {
        StartCoroutine(StartToLaught());
    }
    IEnumerator StartToLaught()
    {
        yield return new WaitForSeconds(2f);
        LaugthSound.Play();
        yield return new WaitForSeconds(5f);
        LaugthSound.Play();
        yield return new WaitForSeconds(4f);
        LaugthSound.Play();
    }
}
