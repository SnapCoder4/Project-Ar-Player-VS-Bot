using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartMenu : MonoBehaviour
{
 public GameObject ConfirmPanel;
 public GameObject AboutPanel;
 public void exit()
 {
    Application.Quit();
 }
 public void play(string scene_name)
 {
    SceneManager.LoadScene(scene_name);
 }
 public void ConfirmClicked()
 {
    ConfirmPanel.SetActive(true);
    AboutPanel.SetActive(false);
 }
 public void AboutClicked()
 {
    ConfirmPanel.SetActive(false);
    AboutPanel.SetActive(true);
 }
 public void back()
 {
    ConfirmPanel.SetActive(false);
    AboutPanel.SetActive(false);
 }
}