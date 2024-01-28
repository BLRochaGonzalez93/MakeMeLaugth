using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Chat", menuName = "Assets/Chat/Chat")]
public class ChatBehaviour : ScriptableObject
{
    public int id;

    public List<string> questionInteraction; 
    public List<string> response;
    public List<int> nextId;
}
