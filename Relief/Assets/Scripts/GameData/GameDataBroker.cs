using UnityEngine;

namespace GameData
{
    public class GameDataBroker : MonoBehaviour
    {
        private ITreeCollection _treeCollection;
        private IHouseCollection _houseCollection;
        
        private void Start()
        {
            _treeCollection = new TreeCollection();
            _houseCollection = new HouseCollection();
        }

        public void AddTree(GameObject tree) => 
            _treeCollection.AddTree(tree);

        public void AddHouse(GameObject house) => 
            _houseCollection.AddHouse(house);
    }
}