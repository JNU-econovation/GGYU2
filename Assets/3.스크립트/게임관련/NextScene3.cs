using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class NextScene3 : MonoBehaviour
{
    public GameObject Fade;
    public void nScene() // 다음스테이지
    {
        PlayerPrefs.SetInt("Stage", 19);
        GetComponent<Button>().interactable = false;
        Fade.SetActive(true);
        StartCoroutine(DarkUp());
    }

    IEnumerator DarkUp()
    {
        Fade.GetComponent<FadeController>().FadeIn(0.5f);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Lobby");
    }
}
