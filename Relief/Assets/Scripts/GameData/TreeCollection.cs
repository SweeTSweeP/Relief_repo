using System.Collections.Generic;
using UnityEngine;

namespace GameData
{
    public class TreeCollection : ITreeCollection
    {
        private List<GameObject> _treeCollection = new();

        public void AddTree(GameObject tree) => 
            _treeCollection.Add(tree);
    }
}