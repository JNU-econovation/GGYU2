using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextScene : MonoBehaviour
{
    GameObject Dark;
    void Start()
    {
        Dark = GameObject.Find("Dark");
    }

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
        StartCoroutine(DarkUp());
    }
    public void ccScene()
    {
        if (PlayerPrefs.GetInt("chapter", 1).Equals(1))
        {
            SceneManager.LoadScene("C1");
        }
        else if (PlayerPrefs.GetInt("chapter", 1) <= 8)
        {
            SceneManager.LoadScene("C2");
        }
        else if (PlayerPrefs.GetInt("chapter", 1) <= 12)
        {
            SceneManager.LoadScene("C3");
        }
        else if (PlayerPrefs.GetInt("chapter", 1) <= 17)
        {
            SceneManager.LoadScene("C4");
        }
        else if (PlayerPrefs.GetInt("chapter", 1) == 18)
        {
            SceneManager.LoadScene("C5");
        }
    }

    IEnumerator DarkUp()
    {
        for(int i=0;i<35;i++)
        {
            yield return new WaitForSeconds(0.01f);
            Dark.transform.Translate(0, 70f, 0);
        }
        yield return null;
        SceneManager.LoadScene(int.Parse(transform.name));
    }
}
