using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Conversation", menuName = "Assets/Chat/Conversation")]
public class CharacterChatBehaviour : ScriptableObject
{
    public int characterId;
    public List<ChatBehaviour> conversations;
}
