using UnityEngine;
using Yarn.Unity;
using UnityEngine.SceneManagement;

public class FadeScript : MonoBehaviour
{
    public Animator animator;

    private int LevelToLoad;

    [YarnCommand("Fadeout")]
    public void FadeToLevel(int levelIndex)
    {
        FadeToLevel(2);
        animator.SetTrigger("FadeOut");
        LevelToLoad = levelIndex;
    }
    // Update is called once per frame
    void Update()
        
    {
        if (Input.GetKeyDown("space"))
            {
            FadeToLevel(2);
            }
    }


    public void OnFadeComplete ()
    {
        SceneManager.LoadScene(2);
    }
}
