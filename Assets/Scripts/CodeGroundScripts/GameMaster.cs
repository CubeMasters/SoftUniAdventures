using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    public static GameMaster GM;
    public static int GamesCompleted = 0;

    void Awake()
    {


        if (GM != null)
        {
            Destroy(GM);
        }
        else
        {
            GM = this;
        }

        DontDestroyOnLoad(this);
    }
}
