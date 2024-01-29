using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KillingTimer : MonoBehaviour
{
    float timer;
    float timerMax;
    public Image timeImage;

    public int sceneIndex;
    private int girlID;

    // Start is called before the first frame update
    void Start()
    {
        timerMax = 15;
        timer = timerMax;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timeImage.fillAmount = timer / timerMax;

        if (timer <= 0)
        {
            PlayerPrefs.SetInt("Score", GetComponent<KnifeAttack>().points);
            SceneManager.LoadScene(sceneIndex);
            girlID = PlayerPrefs.GetInt("IDwoman");
            string wm = "woman" + girlID + "alive";
            PlayerPrefs.SetInt(wm, 0);
        }
    }
}
