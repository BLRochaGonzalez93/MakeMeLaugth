using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelSelection : MonoBehaviour
{
    public int id;

    public Image picture;

    public Button button;

    public Color dead;

    public Color alive;
    

    void Start(){
        //GirlStatus();
    }
    private void GirlStatus(){
        PlayerPrefs.SetInt("status", 1);
        if (PlayerPrefs.GetInt("status") == 0){
            picture.color = dead;
            button.interactable = false;
        }
        else{
            picture.color = alive;
        }
    }

    public void SelectLevel(){
        PlayerPrefs.SetInt("id",id);
        SceneManager.LoadScene("MainScene");
    }
    

}
