using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuFunc : MonoBehaviour
{
    private string userN;
    //public GameObject inputField;
    //private string lozestring;

    private void Update()
    {
        
    }

    public void LoadSceneOne()
    {
        SceneManager.LoadScene(1);
    }


    public void EnterUser(string s)
    {
        userN = s;
        //Debug.Log("Hello");
        //Debug.Log(userN);

        GameManager.Instance.userName = userN;

        Debug.Log(GameManager.Instance.userName);
    }




}
