using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckMorse : MonoBehaviour
{
    public InputField inputField;
    public GameObject wrongInputWindow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckMorseCode()
    {
        if (inputField.text != "71")
        {
            wrongInputWindow.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene("Continue2");
        }
    }

    public void Goback()
    {
        wrongInputWindow.SetActive(false);
    }
}
