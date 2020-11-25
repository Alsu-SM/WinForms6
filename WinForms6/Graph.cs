using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms6
{
    public class Graph
    {
        int NodeCount; // число вершин графа

        int[,] Matrix; // матрица смежности

        public Graph(int n, int[,] M) //конструктор
        {
            NodeCount = n;
            Matrix = new int[n, n];
            Matrix = M;
        }

        public int funcNodeCount // возвращает количество вершин графа
        {
            get { return NodeCount; }
        }

        public int[,] funcMatrix // возвращает количество вершин графа
        {
            get { return Matrix; }
        }

        public List<int> GetNeighbours(int NodeNumber) // возвращает список соседей заданной вершины
        {
            List<int> Neighbours = new List<int>();

            for (int i = 0; i < NodeCount; i++)
            {
                if (Matrix[NodeNumber, i] == 1)
                    Neighbours.Add(i);
            }

            return Neighbours;
        }

        public void RemoveNode(int NodeNumber) //удаление вершины
        {
            NodeCount--;
            // помечаем удаленную вершину в матрице смежности
            for (int i = 0; i < NodeCount; i++)
            {
                Matrix[i, NodeNumber] = -1;
                Matrix[NodeNumber,i] = -1;

            }
        }

    
        public void AddNode() // добавление вершины
        {
            NodeCount++;
            int NodeNumber = NodeCount;

            int[,] temp = new int[NodeCount, NodeCount];
            for (int i = 0; i < NodeCount - 1; i++)
                for (int j = 0; j < NodeCount - 1; j++)
                    temp[i, j] = Matrix[i, j];
            for (int i = 0; i < NodeCount; i++)
            { 
                temp[i, NodeCount-1] = 0;
                temp[NodeCount-1, i] = 0;
            }

            Matrix = new int[NodeCount, NodeCount];
            Matrix = temp;
        }

        public void AddEdge(int Node1, int Node2)
        {
            if (IsNode(Node1) && IsNode(Node2))
            {
                Matrix[Node1, Node2] = 1;
                Matrix[Node2, Node1] = 1;
            }
        }
        public bool IsEdge(int Node1, int Node2) // есть ли ребро между двумя вершинами
        {
            if (Matrix[Node1, Node2] == 1 || Matrix[Node2, Node1] == 1)
                return true;
            else return false;
        }

        public void RemoveEdge(int Node1, int Node2)
        {
            if (IsNode(Node1) && IsNode(Node2))
            {
                Matrix[Node1, Node2] = 0;
                Matrix[Node2, Node1] = 0;
            }
        }

        public bool IsNode(int NodeNumber) // есть ли вершина
        {
            if (NodeNumber > NodeCount || NodeNumber < 0) //вершины нет
                return false;
            if (Matrix[NodeNumber, NodeNumber] == -1) // вершина удалена
                return false;
            else return true;

        }

        public int[] tempBigraph()  //является ли двудольным
        {
            int[] temp = new int[funcNodeCount];
            for (int j = 0; j < funcNodeCount; j++)
                temp[j] = -1;

            int listLength;
          
            temp[0] = 0;
           
            List<int> Neighbours = new List<int>(); 
            
            List<int> tempList = new List<int>();
            
            tempList.Add(0);

            int i = 0;
            while(tempList.Count!=funcNodeCount)
            {
                Neighbours = GetNeighbours(i);
                listLength = Neighbours.Count;
                for (int j = 0; j < listLength; j++)
                {
                    if (tempList.Contains(j))
                        Neighbours.Remove(j);
                }

                if (Neighbours.Count==0)
                {
                    for (int j = 0; j < funcNodeCount; j++)
                    {
                        if (temp[j] == -1)
                        {
                            tempList.Add(j);
                            if (temp[i] == 0)
                                temp[j] = 1;
                            if (temp[i] == 1)
                                temp[j] = 0;
                            i = j;
                            break;
                        }
                    }
                    continue;
                }

                tempList.AddRange(Neighbours);
                

                for (int j = i; j < listLength; j++)
                {
                    if (temp[i] == 0)
                        temp[tempList[j+1]] = 1;
                    if (temp[i] == 1)
                        temp[tempList[j+1]] = 0;
                }

                i = Neighbours[0];

            }

            return temp;
        }

        public bool IsBigraph(int[] temp)
        {
            List<int> First = new List<int>();
            List<int> Second = new List<int>();
            for (int i = 0; i < funcNodeCount; i++) // разделяем на два списка
            {
                if (temp[i] == 0)
                    First.Add(i);
                if (temp[i] == 1)
                    Second.Add(i);
            }

            int firstLength, secondLength;
            firstLength = First.Count;
            secondLength = Second.Count;

            for (int i = 0; i < firstLength-1; i++)
            {
                for (int j = i + 1; j < firstLength; j++)
                {
                    if (IsEdge(First[i], First[j]))
                        return false;
                }    
            }

            for (int i = 0; i < secondLength - 1; i++)
            {
                for (int j = i + 1; j < secondLength; j++)
                {
                    if (IsEdge(Second[i], Second[j]))
                        return false;
                }
            }

            return true;
        }

        public bool IsEuler() // является ли Эйлеровым (все степени четные)
        {
            for(int i = 0; i < NodeCount; i++)
            {
                if(GetNeighbours(i).Count % 2 != 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
