using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public delegate void Scene();
    private event Scene scene = () => { };
    private bool _isVisible = true;

    private void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
    private void OnGUI()
    {
        if (_isVisible)
        {
            GUI.Box(new Rect(10, 10, 200, 100), "Menu");
            {
              if(GUI.Button(new Rect(20, 40, 180, 30), "Restart"))
                {
                    scene += Restart;
                    scene.Invoke();
                }
            }
        }

        if (GUI.Button(new Rect(10, 350, 100, 30), "Menu"))
        {
            _isVisible = !_isVisible;
        }
    }
    ~Menu()
    {
        scene -= Restart;
    }
}

