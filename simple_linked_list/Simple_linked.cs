using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_linked_list
{
    /// <summary>
    /// this class has the object node
    /// what have the head where pint to the next list node object
    /// and the information named data
    /// </summary>
    public class Node
    {
        public Node next;
        public int data;
    }
    /// <summary>
    /// this class contain the list options to add and show nodes list values
    /// </summary>
    public class Simple_linked
    {

        public Node list;

        /// <summary>
        /// this function print all nodes has got the object node
        /// </summary>
        public void printAllNodes()
        {
            Node cur = list;
            while (cur != null)
            {
                Console.WriteLine("line " + cur.data);
                cur = cur.next;
            }

        }
        /// <summary>
        /// this function add values to the list object
        /// the fucntion is divided by two parts
        /// the first part ask if the object head got values
        /// if it havent values, it add values, but the pointer of the 
        /// next node list goes empty
        /// the second part ask if head contain something inside
        /// in this case drive an loop to find the 
        /// previous list and will add into the head the new list element
        /// </summary>
        /// <param name="data"></param>
        public void addNodes(int data)
        {
            if (list == null)
            {
                Node toAdd = new Node();
                toAdd.data = data;
                toAdd.next = null;
                list = toAdd;
            }
            else
            {
                Node toAdd = new Node();
                // add data
                toAdd.data = data;
                // create a temporaly object of  previous node
                // this temporaly object if has got changes, also will affect head object
                Node current = list;
                // if the temporaly node object has not got anything in its head 
                while (current.next != null)
                {
                    // will add the value of this
                    current = current.next;
                }
                // then add the new element into the previous node object
                // when I added the new value, alo current modify head
                current.next = toAdd;
            }

        }

        public void delete(int info_to_delete)
        {
            Node tempList = list;
            Node prev = null;

            while (tempList != null)
            {

                if (tempList.data != info_to_delete)
                {
                    prev = tempList;
                    tempList = tempList.next;
                }
                else
                {
                    if (prev == null && tempList.next == null)
                    {
                        tempList = null;
                    }
                    else if (prev == null && tempList.next != null)
                    {
                        Node firstNode;
                        firstNode = tempList.next;
                        list = firstNode;
                        tempList = null;
                    }
                    else if (prev != null && tempList.next == null)
                    {
                        tempList = null;
                        list = tempList;
                    }
                    else if (prev != null && tempList.next != null)
                    {
                        prev.next = tempList.next;

                    }

                }
            }
            //Console.WriteLine("line " + cur.data);
        }

    }
}
