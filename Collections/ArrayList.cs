namespace Collections
{
    public class ArrayList
    {
        //array type must be object because arrayList is not a fixed type Collection
        object[] list;

        public int length { get ; private set ; }

        public ArrayList()
        {
            list = new object[0];
        }

        /// <summary>
        /// Add new item to ArrayList
        /// </summary>
        /// <param name="item">new item</param>
        /// <returns>The new item index in the ArrayList</returns>
        public int Add(object item)
        {
            object[] newList = new object[list.Length + 1];

            for (int i = 0; i < list.Length; i++)
            {
                newList[i] = list[i];
            }

            newList[newList.Length - 1] = item;

            list = newList;
            length = list.Length;

            return list.Length - 1;

        }

        public int Insert(int index , object item)
        {
            object[] newList = new object[list.Length+1];
            newList[index] = item;

            for (int i = 0; i < list.Length; i++)
            {
                if (newList[i]==null)
                {
                    newList[i] = list[i];
                }
                else
                {
                    newList[i + 1] = list[i];
                }
            }

            list = newList;
            length = list.Length;

            return list.Length - 1;
        }

        public object Read(int index)
        {
            return list[index];
        }

    }
}
