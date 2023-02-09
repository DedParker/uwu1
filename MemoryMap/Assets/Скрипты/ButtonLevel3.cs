using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLevel3 : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Map3 new");
    }
}
