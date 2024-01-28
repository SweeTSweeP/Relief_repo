using GameData;
using House;
using UnityEngine;

namespace GameDataSpawner
{
    public class GameDataSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject houseTemplate;
        [SerializeField] private GameObject treeTemplate;

        [SerializeField] private Holders holders;
        [SerializeField] private FenceActivator fenceActivator;

        public void SpawnHouse()
        {
            if (!holders.IsAbleToAddHouse()) return;
            
            var house = Instantiate(houseTemplate);
            
            fenceActivator.AddFenceState(house.GetComponent<FenceState>());
                
            holders.SetHouseParent(house);
        }

        public void SpawnTree()
        {
            if (!holders.IsAbleToAddTree()) return;
            
            var tree = Instantiate(treeTemplate);
                
            holders.SetTreeParent(tree);
        }
    }
}