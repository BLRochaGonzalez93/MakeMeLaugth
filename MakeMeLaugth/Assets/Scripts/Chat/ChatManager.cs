using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChatManager : MonoBehaviour
{
    public CharacterChatBehaviour girl;

    public TextMeshProUGUI question;
    public List<TextMeshProUGUI> responses;
    private ChatBehaviour chat;

    // Start is called before the first frame update
    void Start()
    {
        //girl.characterId = PlayerPrefs.GetInt("id");
        chat = girl.conversations[0];
        question.text = chat.question;

        Debug.Log(responses.Count);
        for (int i = 0; i < responses.Count; i++)
        {
            responses[i].gameObject.transform.parent.gameObject.SetActive(false);
        }

        for (int i = 0; i < chat.response.Count; i++)
        {
            responses[i].text = chat.response[i];
            responses[i].gameObject.transform.parent.gameObject.SetActive(true);
        }
    }

    public void ChargeNextR0()
    {
        Debug.Log(chat.nextId[0]);
        if (chat.nextId[0] == 404) SceneManager.LoadScene(4);
        else if (chat.nextId[0] == 100) SceneManager.LoadScene(3);
        else
        {
            ChatBehaviour chat2 = girl.conversations[chat.nextId[0]];
            chat = chat2;
            question.text = chat2.question;

            for (int i = 0; i < responses.Count; i++)
            {
                responses[i].gameObject.transform.parent.gameObject.SetActive(false);
            }

            for (int i = 0; i < chat2.response.Count; i++)
            {
                responses[i].text = chat2.response[i];
                responses[i].gameObject.transform.parent.gameObject.SetActive(true);
            }
        }
    }

    public void ChargeNextR1()
    {
        Debug.Log(chat.nextId[1]);
        if (chat.nextId[1] == 404) SceneManager.LoadScene(4);
        else if (chat.nextId[1] == 100) SceneManager.LoadScene(3);
        else
        {
            ChatBehaviour chat2 = girl.conversations[chat.nextId[1]];
            chat = chat2;
            question.text = chat2.question;

            for (int i = 0; i < responses.Count; i++)
            {
                responses[i].gameObject.transform.parent.gameObject.SetActive(false);
            }

            for (int i = 0; i < chat2.response.Count; i++)
            {
                responses[i].text = chat2.response[i];
                responses[i].gameObject.transform.parent.gameObject.SetActive(true);
            }
        }
    }

    public void ChargeNextR2()
    {
        Debug.Log(chat.nextId[2]);
        if (chat.nextId[2] == 404) SceneManager.LoadScene(4);
        else if (chat.nextId[2] == 100) SceneManager.LoadScene(3);
        else
        {
            ChatBehaviour chat2 = girl.conversations[chat.nextId[2]];
            chat = chat2;
            question.text = chat2.question;

            for (int i = 0; i < responses.Count; i++)
            {
                responses[i].gameObject.transform.parent.gameObject.SetActive(false);
            }

            for (int i = 0; i < chat2.response.Count; i++)
            {
                responses[i].text = chat2.response[i];
                responses[i].gameObject.transform.parent.gameObject.SetActive(true);
            }
        }
    }

    public void ChargeNextR3()
    {
        Debug.Log(chat.nextId[3]);
        if (chat.nextId[3] == 404) SceneManager.LoadScene(4);
        else if (chat.nextId[3] == 100) SceneManager.LoadScene(3);
        else
        {
            ChatBehaviour chat2 = girl.conversations[chat.nextId[3]];
            chat = chat2;
            question.text = chat2.question;

            for (int i = 0; i < responses.Count; i++)
            {
                responses[i].gameObject.transform.parent.gameObject.SetActive(false);
            }

            for (int i = 0; i < chat2.response.Count; i++)
            {
                responses[i].text = chat2.response[i];
                responses[i].gameObject.transform.parent.gameObject.SetActive(true);
            }
        }
    }
}
