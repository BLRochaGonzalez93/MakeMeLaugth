using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnifeAttack : MonoBehaviour
{
    public List<Transform> poolKnifePos;
    public Image knifeImage;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            KnifeStab();
        }

        if (Input.GetMouseButtonUp(0))
        {
            KnifeRetract();
        }
    }

    public void KnifeStab()
    {
        int posChosen = Random.Range(1, poolKnifePos.Count);
        knifeImage.transform.position = new Vector3(poolKnifePos[posChosen].position.x, poolKnifePos[posChosen].position.y);
    }

    public void KnifeRetract()
    {
        knifeImage.transform.position = new Vector3(poolKnifePos[0].position.x, poolKnifePos[0].position.y);
    }
}
