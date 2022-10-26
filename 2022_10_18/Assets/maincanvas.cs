using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class maincanvas : MonoBehaviour
{
    public GameObject starcounttext;
    public int starcnt = 0;
    public GameObject[] star;
    public GameObject endingimage;

    private void Start()
    {
        star = GameObject.FindGameObjectsWithTag("star");
    }

    private void Update()
    {

        starcounttext.GetComponent<TextMeshProUGUI>().text = "" + starcnt + "/" + star.Length;
    }

    public void ending()
    {
        endingimage.SetActive(true);
    }

}
