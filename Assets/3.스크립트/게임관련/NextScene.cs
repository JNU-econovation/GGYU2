using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextScene : MonoBehaviour
{
    void Start()
    {

    }

    public void cScene() // restart버튼
    {
        SceneManager.LoadScene(GetComponent<GameMgr>().Stage);
    }
    public void qScene() // 로비씬으로
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void nScene() // 다음스테이지
    {
        SceneManager.LoadScene(GetComponent<GameMgr>().Stage + 1);
    }
    public void sScene()
    {
        SceneManager.LoadScene(int.Parse(transform.name));
    }
}
