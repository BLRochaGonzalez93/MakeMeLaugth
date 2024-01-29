using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadManager : MonoBehaviour
{
    public int IDwoman;
    public int woman1alive;
    public int woman2alive;
    
    public void StarterValues()
    {
        IDwoman = 0;
        woman1alive = 1;
        woman2alive = 1;
        SetIDWoman(IDwoman);
        SetWoman1Alive(woman1alive);
        SetWoman2Alive(woman2alive);
    }
   
    public int GetIDWoman()
    {
        int val = PlayerPrefs.GetInt("IDwoman");
        IDwoman = val;
        return val;
    }

    public int GetWoman1Alive()
    {
        int val = PlayerPrefs.GetInt("woman1alive");
        woman1alive = val;
        return woman1alive;
    }

    public int GetWoman2Alive()
    {
        int val = PlayerPrefs.GetInt("woman2alive");
        woman2alive = val;
        return woman2alive;
    }

    public void SetIDWoman(int val) 
    {
        PlayerPrefs.SetInt("IDwoman", val);
    }
    public void SetWoman1Alive(int val)
    {
        PlayerPrefs.SetInt("woman1alive", val);
    }
    public void SetWoman2Alive(int val)
    {
        PlayerPrefs.SetInt("woman2alive", val);
    }

    public void ChargeScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
