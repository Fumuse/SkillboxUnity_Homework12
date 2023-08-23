using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private SceneAsset _scene;

    private int _sceneBuildIndex = 0;

    private void Start()
    {
        string scenePath = AssetDatabase.GetAssetPath(_scene);
        if (scenePath != null)
        {
            _sceneBuildIndex = SceneUtility.GetBuildIndexByScenePath(scenePath);
        }
    }

    public void LoadLevelScene()
    {
        SceneManager.LoadScene(_sceneBuildIndex);
    }

    public void RestartCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
