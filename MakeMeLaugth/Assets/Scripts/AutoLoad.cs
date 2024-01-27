using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AutoLoad : MonoBehaviour
{
    public TextMeshProUGUI loadingText;
    public int sceneIndex;
    private float timer;
    private float maxTime;

    private State state = State.COMPLETED;

    private enum State
    {
        PLAYING, COMPLETED
    }

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        maxTime = 5;
        StartCoroutine(TypeText("Cargando..."));
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= maxTime)
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }

    private IEnumerator TypeText(string text)
    {
        loadingText.text = "";
        state = State.PLAYING;
        int wordIndex = 0;

        while(state != State.COMPLETED)
        {
            loadingText.text += text[wordIndex];
            yield return new WaitForSeconds(0.3f);
            if(++wordIndex == text.Length)
            {
                state = State.COMPLETED;
                break;
            }
        }
    }
}
