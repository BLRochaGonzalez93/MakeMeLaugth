using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChatManager : MonoBehaviour
{
    public CharacterChatBehaviour girl;

    public List<string> questions;
    public List<int> questionsIDs;
    public List<Sprite> facialExpresionAsResponse;
    public List<Image> chatBlob;
    public List<TextMeshProUGUI> responses;
    private ChatBehaviour chat;
    public Sprite blobHer;
    public Sprite blobHim;
    public Image girlImage, guyImage;

    void Start()
    {
        chat = girl.conversations[PlayerPrefs.GetInt("IDwoman")];

        CargeQuestions();
        ChargeQuestionIds();
        ChargeFacialExpresions();
        ChargeResponses();

        StartCoroutine(ReplaceTexts());
    }

    private void CargeQuestions()
    {
        for (int i = 0; i < questions.Count; i++)
        {
            questions.Clear();
        }

        for (int i = 0; i < chat.questionInteraction.Count; i++)
        {
            questions.Add(chat.questionInteraction[i]);
        }
    }

    private void ChargeQuestionIds()
    {
        for (int i = 0; i < questionsIDs.Count; i++)
        {
            questionsIDs.Clear();
        }

        for (int i = 0; i < chat.idSpeaker.Count; i++)
        {
            questionsIDs.Add(chat.idSpeaker[i]);
        }
    }

    private void ChargeFacialExpresions()
    {
        for (int i = 0; i < facialExpresionAsResponse.Count; i++)
        {
            facialExpresionAsResponse.Clear();
        }

        for (int i = 0; i < chat.facialExpresions.Count; i++)
        {
            facialExpresionAsResponse.Add(chat.facialExpresions[i]);
        }
    }

    private void ChargeResponses()
    {
        for (int i = 0; i < responses.Count; i++)
        {
            responses[i].gameObject.transform.parent.gameObject.SetActive(false);
        }
    }

    IEnumerator ReplaceTexts()
    {
        for (int i = 0; i < chatBlob.Count; i++)
        {
            chatBlob[i].gameObject.SetActive(false);
            chatBlob[i].gameObject.GetComponentInChildren<TextMeshProUGUI>().text = "";
        }

        yield return new WaitForSeconds(1f);
        if (questions.Count <= chatBlob.Count)
        {
            for (int i = 0; i < questions.Count; i++)
            {
                if (chatBlob[i].gameObject.activeSelf == false)
                {
                    chatBlob[i].gameObject.SetActive(true);
                    if (questionsIDs[i] == 0) chatBlob[i].gameObject.GetComponent<Image>().sprite = blobHim;
                    else chatBlob[i].gameObject.GetComponent<Image>().sprite = blobHer;
                    chatBlob[i].gameObject.GetComponentInChildren<TextMeshProUGUI>().text = questions[i];
                }
                girlImage.sprite = facialExpresionAsResponse[i];
                yield return new WaitForSeconds(1f);
            }
        }
        else
        {
            for (int i = 0; i < chatBlob.Count; i++)
            {
                if (chatBlob[i].gameObject.activeSelf == false)
                {
                    chatBlob[i].gameObject.SetActive(true);
                    if (questionsIDs[i] == 0) chatBlob[i].gameObject.GetComponent<Image>().sprite = blobHim;
                    else chatBlob[i].gameObject.GetComponent<Image>().sprite = blobHer;
                    chatBlob[i].gameObject.GetComponentInChildren<TextMeshProUGUI>().text = questions[i];
                }
                girlImage.sprite = facialExpresionAsResponse[i];
                yield return new WaitForSeconds(1f);
            }

            for (int i = chatBlob.Count; i < questions.Count; i++)
            {
                for (int j = 1; j < chatBlob.Count; j++)
                {
                    chatBlob[j - 1].gameObject.GetComponentInChildren<TextMeshProUGUI>().text = chatBlob[j].gameObject.GetComponentInChildren<TextMeshProUGUI>().text;
                    chatBlob[j - 1].gameObject.GetComponent<Image>().sprite = chatBlob[j].gameObject.GetComponent<Image>().sprite;
                    if (questionsIDs[i] == 0) chatBlob[j].gameObject.GetComponent<Image>().sprite = blobHim;
                    else chatBlob[j].gameObject.GetComponent<Image>().sprite = blobHer;
                }

                chatBlob[chatBlob.Count - 1].gameObject.GetComponentInChildren<TextMeshProUGUI>().text = questions[i];
                girlImage.sprite = facialExpresionAsResponse[i];

                yield return new WaitForSeconds(1f);
            }
        }

        for (int i = 0; i < chat.response.Count; i++)
        {
            responses[i].text = chat.response[i];
            responses[i].gameObject.transform.parent.gameObject.SetActive(true);
        }
    }

    public void ChargeNextR0()
    {
        if (chat.nextId[0] == 404) SceneManager.LoadScene("Blocked");
        else if (chat.nextId[0] == 100) SceneManager.LoadScene(3);
        else
        {
            ChatBehaviour chat2 = girl.conversations[chat.nextId[0]];
            chat = chat2;

            CargeQuestions();
            ChargeQuestionIds();
            ChargeFacialExpresions();
            ChargeResponses();

            StartCoroutine(ReplaceTexts());
        }
    }

    public void ChargeNextR1()
    {
        if (chat.nextId[1] == 404) SceneManager.LoadScene("Blocked");
        else if (chat.nextId[1] == 100) SceneManager.LoadScene(3);
        else
        {
            ChatBehaviour chat2 = girl.conversations[chat.nextId[1]];
            chat = chat2;

            CargeQuestions();
            ChargeQuestionIds();
            ChargeFacialExpresions();
            ChargeResponses();

            StartCoroutine(ReplaceTexts());
        }
    }

    public void ChargeNextR2()
    {
        if (chat.nextId[2] == 404) SceneManager.LoadScene("Blocked");
        else if (chat.nextId[2] == 100) SceneManager.LoadScene(3);
        else
        {
            ChatBehaviour chat2 = girl.conversations[chat.nextId[2]];
            chat = chat2;

            CargeQuestions();
            ChargeQuestionIds();
            ChargeFacialExpresions();
            ChargeResponses();

            StartCoroutine(ReplaceTexts());
        }
    }

    public void ChargeNextR3()
    {
        if (chat.nextId[3] == 404) SceneManager.LoadScene("Blocked");
        else if (chat.nextId[3] == 100) SceneManager.LoadScene(3);
        else
        {
            ChatBehaviour chat2 = girl.conversations[chat.nextId[3]];
            chat = chat2;

            CargeQuestions();
            ChargeQuestionIds();
            ChargeFacialExpresions();
            ChargeResponses();

            StartCoroutine(ReplaceTexts());
        }
    }
}
