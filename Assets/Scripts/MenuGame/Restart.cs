using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public Button Button;

    private void Start()
    {
        Button.onClick.AddListener(Reset);
    }

    public void Reset()
    {
         SceneManager.LoadScene("SampleScene");
    }

    ~Restart()
    {
        Button.onClick.RemoveListener(Reset);
    }
}
