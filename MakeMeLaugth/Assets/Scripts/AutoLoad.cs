using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AutoLoad : MonoBehaviour
{
    public GameObject loadingScreen;
    public TextMeshProUGUI loadingText;
    public int sceneIndex;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        loadingText.text = "Cargando...";
    }

    private void Update()
    {
        timer += Time.deltaTime;
        ChangeLoadingText();
        if (timer >= 8)
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }

    private void ChangeLoadingText()
    {
        if ((int)timer % 2 == 0)
        {
            loadingText.text = "Cargando...";
        }
        else if ((int)timer % 2 != 0)
        {
            loadingText.text = "";
        }
    }
}
