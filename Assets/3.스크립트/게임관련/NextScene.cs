using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextScene : MonoBehaviour
{
    public void cScene() // restart버튼
    {
        GameMgr.StarNum = 0;
        SceneManager.LoadScene(GetComponent<GameMgr>().Stage);
    }
    public void qScene() // 로비씬으로
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void nScene() // 다음스테이지
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("chapter")+ 1);
    }
    public void sScene()
    {
        SceneManager.LoadScene(int.Parse(transform.name));
    }
    public void ccScene()
    {
        SceneManager.LoadScene("Clear");
    }
}
