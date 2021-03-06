using UnityEditor;
using UnityEngine;

/// <summary>
/// This script allows for movement between scenes and exiting the game
/// </summary>
public class SceneManager : MonoBehaviour
{
	/// <summary>
	/// Changes the currently active scene to the scene associated with the SceneIndex number
	/// </summary>
	/// <param name="SceneIndex">The number associated with the scene</param>
	public void ChangeLevel(int SceneIndex)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneIndex);
    }

	/// <summary>
	/// Checks if the game is being run in the editor or not, and closes the game.
	/// </summary>
	public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
			Application.Quit();
#endif
    }
}