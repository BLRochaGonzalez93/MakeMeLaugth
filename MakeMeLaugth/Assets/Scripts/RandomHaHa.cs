using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomHaHa : MonoBehaviour
{
    private Vector2 topLeftMargin;
    private Vector2 bottomRightMargin;

    public List<Image> poolHahas;

    private void Start()
    {
        topLeftMargin = new Vector2(0, 1080);
        bottomRightMargin = new Vector2(1920, 0);
    }

    public void ShowHaHa()
    {
        for (int i = 0; i < poolHahas.Count; i++)
        {
            if (!poolHahas[i].IsActive())
            {
                poolHahas[i].transform.position =  new Vector2(Random.Range(topLeftMargin.x, bottomRightMargin.x), Random.Range(topLeftMargin.y, bottomRightMargin.y));
                poolHahas[i].gameObject.SetActive(true);
                StartCoroutine(AutoHide(poolHahas[i].gameObject));
                return;
            }
        }
    }

    IEnumerator AutoHide(GameObject haha)
    {
        yield return new WaitForSeconds(1);
        haha.SetActive(false);
    }
}
