using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<LoadManager>().SetIDWoman(GetComponent<LoadManager>().GetIDWoman());
        GetComponent<LoadManager>().SetWoman1Alive(GetComponent<LoadManager>().GetWoman1Alive());
        GetComponent<LoadManager>().SetWoman2Alive(GetComponent<LoadManager>().GetWoman2Alive());
    }

}
