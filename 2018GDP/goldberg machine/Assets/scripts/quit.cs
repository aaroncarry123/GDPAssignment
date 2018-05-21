using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class quit : MonoBehaviour
{


    public Button m_Button;
    // Use this for initialization
    void Start()
    {

        Button btn = m_Button.GetComponent<Button>();

        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void TaskOnClick()
    {
        Application.Quit();

    }
}
