using DataSpawner;
using House;
using MainCamera;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class GameDataControl : MonoBehaviour
    {
        [SerializeField] private GameDataSpawner gameDataSpawner;
        [SerializeField] private FenceActivator fenceActivator;
        [SerializeField] private CameraView cameraView;

        [SerializeField] private Button addHouseButton;
        [SerializeField] private Button addTreeButton;
        [SerializeField] private Button showHideFenceButton;
        [SerializeField] private Button cameraViewButton;

        private bool _fenceState;
        private bool _is2DView;

        private void Start()
        {
            InitSpawnHouseButton();
            InitSpawnTreeButton();
            InitShowHideFenceButton();
            InitCameraViewButton();
        }

        private void InitSpawnHouseButton() => 
            addHouseButton.onClick.AddListener(gameDataSpawner.SpawnHouse);

        private void InitSpawnTreeButton() => 
            addTreeButton.onClick.AddListener(gameDataSpawner.SpawnTree);

        private void InitShowHideFenceButton() =>
            showHideFenceButton.onClick.AddListener(()=>
            {
                _fenceState = !_fenceState;
                fenceActivator.SetFenceActive(_fenceState);
            });

        private void InitCameraViewButton()
        {
            cameraViewButton.onClick.AddListener(() =>
            {
                _is2DView = !_is2DView;

                if (_is2DView)
                    cameraView.Set2DView();
                else
                    cameraView.Set3DView();
            });
        }
    }
}
