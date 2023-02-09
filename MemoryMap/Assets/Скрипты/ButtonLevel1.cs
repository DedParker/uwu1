using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLevel1 : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Map1 new");
    }
}
