using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuFuckery : MonoBehaviour {

	public void Restart()
    {
        Time.timeScale = 1.0f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void Pause()
    {
        Time.timeScale = 0.0f;
    }
}
