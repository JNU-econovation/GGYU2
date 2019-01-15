using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class NextScene2 : MonoBehaviour
{
    public GameObject Fade;
    public void nScene() // 다음스테이지
    {
        GetComponent<Button>().interactable = false;
        Fade.SetActive(true);
        StartCoroutine(DarkUp());
    }

    IEnumerator DarkUp()
    {
        Fade.GetComponent<FadeController>().FadeIn(0.5f);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(PlayerPrefs.GetInt("chapter") + 1);
    }
}
