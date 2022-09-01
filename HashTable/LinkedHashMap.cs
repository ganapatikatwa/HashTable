using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class LinkedHashMap<K,V> where K:IComparable
    {
        private readonly int Numbuckets;
        readonly List<LinkedList<K, V>> BucketList;
        
        public LinkedHashMap(int NumBuckets)
        {
            this.Numbuckets = NumBuckets;
            BucketList= new List<LinkedList<K,V>>(NumBuckets);

            for (int i = 0; i < this.Numbuckets; i++)
                BucketList.Add(null);
        }

        public V Get(K key)
        {
            int index = GetBucketIndex(key);
            LinkedList<K,V>myLinkedList= BucketList[index];
            if (myLinkedList == null)
                return default;
            MyMapNode<K, V> myMapNode = myLinkedList.Search(key);
            return (myMapNode == null) ? default : myMapNode.value;
        }

        private int GetBucketIndex(K key)
        {
            int hashCode= Math.Abs(key.GetHashCode());
            int index = hashCode% Numbuckets;
            return index;
        }
        public void Add(K key, V value)
        {
            int index =this.GetBucketIndex(key);
            LinkedList<K, V> mylinkedList = BucketList[index];
            if(mylinkedList==null)
            {
                mylinkedList = new LinkedList<K, V>();
                BucketList[index] = mylinkedList;

            }
            MyMapNode<K,V>myMapNode= mylinkedList.Search(key);
            if(myMapNode== null)
            {
                myMapNode = new MyMapNode<K, V>(key, value);
                mylinkedList.Append(myMapNode);
            }
            else myMapNode.value = value;
        }
    }
}
