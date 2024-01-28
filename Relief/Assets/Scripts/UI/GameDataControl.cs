using DataSpawner;
using House;
using UnityEngine;
using UnityEngine.UI;

public class GameDataControl : MonoBehaviour
{
    [SerializeField] private GameDataSpawner gameDataSpawner;
    [SerializeField] private FenceActivator fenceActivator;

    [SerializeField] private Button addHouseButton;
    [SerializeField] private Button addTreeButton;
    [SerializeField] private Button showHideFenceButton;

    private bool _fenceState;

    private void Start()
    {
        InitSpawnHouseButton();
        InitSpawnTreeButton();
        InitShowHideFenceButton();
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
}
