using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

namespace ChangeScene_Manager
{
    public enum SCENE_NAME
    {
        SCENE_ITSUKI = 0,
        SCENE_TEST,
        SCENE_MAX
    };

    public class SceneScript : MonoBehaviour
    {
        public static void ChangeScene(SCENE_NAME NextScene)
        {
            SceneManager.LoadScene((int)NextScene, LoadSceneMode.Single);
        }
    }
}
