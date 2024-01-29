using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LaugthController : MonoBehaviour
{
    public AudioSource LaugthSound;

    public List<GameObject> girls;
    public int girlID;

    private void Start()
    {
        girlID = PlayerPrefs.GetInt("IDwoman");
        for (int i = 0; i < girls.Count; i++)
        {
            if (i == girlID)
            {
                girls[i].gameObject.SetActive(true);
            }
            else
            {
                girls[i].gameObject.SetActive(false);
            }
        }

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
