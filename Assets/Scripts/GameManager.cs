using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif //UNITY_EDITOR


public class GameManager : Singleton<GameManager>
{
    [SerializeField] private Camera cameraOffice = null;
    [SerializeField] private Camera cameraTask = null;

    [SerializeField] private GameObject EndDayUI = null;
    private void LaunchGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    private void SwitchCurrentCamera(Camera cameraToSwitch)
    {
        if(Camera.current != cameraToSwitch)
        {
            Camera.SetupCurrent(cameraToSwitch);
        }
    }

    private void LaunchNewTask(float durationTask)
    {
       // LevelReferences.Instance.taskManager.LaunchTask(durationTask);
        SwitchCurrentCamera(cameraTask);
    }

    public void EndDay()
    {
        EndDayUI.SetActive(true);
    }

    public void ReturnToOffice()
    {
        SwitchCurrentCamera(cameraOffice);
    }

    private void QuitGame()
    {
        {
#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif //UNITY_EDITOR
        }
    }
}
