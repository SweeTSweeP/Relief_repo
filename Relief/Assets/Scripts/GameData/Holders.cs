using UnityEngine;

namespace GameData
{
    public class Holders : MonoBehaviour
    {
        [SerializeField] private Transform[] treeHolders;
        [SerializeField] private Transform[] houseHolders;

        private int _currentTreeIndex;
        private int _currentHouseIndex;
        
        public void SetTreeParent(GameObject tree)
        {
            if (IsAbleToAddTree())
            {
                tree.transform.SetParent(treeHolders[_currentTreeIndex]);
                tree.transform.position = treeHolders[_currentTreeIndex].position;
                _currentTreeIndex++;
            }
        }

        public bool IsAbleToAddTree() => 
            _currentTreeIndex < treeHolders.Length;

        public void SetHouseParent(GameObject house)
        {
            if (IsAbleToAddHouse())
            {
                house.transform.SetParent(houseHolders[_currentHouseIndex]);
                house.transform.position = houseHolders[_currentHouseIndex].position;
                _currentHouseIndex++;
            }
        }

        public bool IsAbleToAddHouse() => 
            _currentHouseIndex < houseHolders.Length;
    }
}