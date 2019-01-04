using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextScene : MonoBehaviour {

	public void cScene()
    {
        SceneManager.LoadScene(GetComponent<GameMgr>().Stage);
    }
    public void qScene()
    {
        SceneManager.LoadScene("Lobby");
    }
    public void nScene()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("Stage")+1);
    }
    public void rScene()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("Stage", 1));
    }
}
