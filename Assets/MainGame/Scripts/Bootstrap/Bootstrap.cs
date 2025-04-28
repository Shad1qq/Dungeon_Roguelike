using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Assets.MainGame.Scripts.Bootstrap
{
    public class Bootstrap:MonoBehaviour
    {
        private InputSystem _inputActions;

        private const int sceneID = 1;

        [Inject]
        private void Constructor(InputSystem inputActions)
        {
            _inputActions = inputActions;
        }

        private void Start()
        {
            _inputActions.Enable();
            SceneManager.LoadSceneAsync(sceneID);
            
        }

        private void OnDestroy()
        {
            _inputActions.Disable();
        }
    }
}
