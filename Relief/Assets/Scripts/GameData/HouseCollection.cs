using System.Collections.Generic;
using UnityEngine;

namespace GameData
{
    public class HouseCollection : IHouseCollection
    {
        private List<GameObject> _houseCollection = new();

        public void AddHouse(GameObject house) => 
            _houseCollection.Add(house);
    }
}