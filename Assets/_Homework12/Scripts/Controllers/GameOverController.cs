using UnityEngine;

[RequireComponent(typeof(PauseController))]
public class GameOverController : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverOverlay;
    private PauseController _pauseController;
    
    private void Awake()
    {
        _pauseController = GetComponent<PauseController>();
    }

    public void GameOver()
    {
        _pauseController.SetPause(true);
        _gameOverOverlay.SetActive(true);
    }
}