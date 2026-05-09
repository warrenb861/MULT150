using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public string sceneToLoad = "wbaker_Hour16";


	public void LoadGame ()
	{
		SceneManager.LoadScene(sceneToLoad);
	}
}
