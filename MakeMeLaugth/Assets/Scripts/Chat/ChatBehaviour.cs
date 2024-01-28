using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Chat", menuName = "Assets/Chat/Chat")]
public class ChatBehaviour : ScriptableObject
{
    public int id;

    public List<string> questionInteraction; 
    public List<int> idSpeaker; 
    public List<string> response;
    public List<int> nextId;
    public List<Sprite> facialExpresions;
}
