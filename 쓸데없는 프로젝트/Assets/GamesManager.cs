using UnityEngine;
using UnityEngine.SceneManagement;

public class GamesManager : MonoBehaviour
{
    #region SceneList

    int startMenu = 0;
    int ageCalculator = 1;

    #endregion SceneList

    public void goToStartMenu()
    {
        SceneManager.LoadScene(startMenu);
    }

    public void goToAgeCalculator()
    {
        SceneManager.LoadScene(ageCalculator);
    }
}
