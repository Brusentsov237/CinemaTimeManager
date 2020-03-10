using System;
using System.Collections.Generic;
using System.Text;

namespace GraphLines
{
    public class CinemaTimeManager
    {
        Node root;
        public List<Node> resultEnds = new List<Node>();
        public CinemaTimeManager(Node node)
        {
            root = node;
            
        }

        public void CreateShedules()
        {
            Create(root);
        }
        public void DisplayAnswer()
        {
            MakeAnswer(root);
        }

        
        
        private void Create(Node node)
        {
            for (int i = 0; i < node.duration.Length; i++) //перебираем сеансы
            {

                if ((node.duration[i] <= node.timeLeft)) //если в рабочем дне осталось время для сеанса
                {

                    Node newNode; //создаётся новая нода

                    newNode = new Node(node.timeLeft - node.duration[i], node.filmNames, node.duration, node.variantOfShedule + node.filmNames[i] + "\n", node.list);

                    node.nodes.Add(newNode); //она добавляется в лист некстов

                    Create(newNode); //и мы спускаемся глубже по ветке, пока не закончится время
                }
            }
        }
        private void MakeAnswer(Node node)
        {
            
            if (node.nodes.Count != 0)
            {
                foreach (Node i in node.nodes)
                {
                    MakeAnswer(i);
                }
            }
            else
            {
                resultEnds.Add(node);
                //Console.WriteLine(node.variantOfShedule);
                //Console.WriteLine($"свободное оставшееся время{node.timeLeft} \n");
            }
        }
        public  List<Node> Sort()
        {
            for (int i = 0; i< resultEnds.Count-1; i++)
            {
                int min = i;
                for (int j = i + 1; j< resultEnds.Count; j++)
                {
                    if (resultEnds[j].timeLeft < resultEnds[min].timeLeft)
                    {
                        min = j;
                    }
                }
                Node dummy = resultEnds[i];
                resultEnds[i] = resultEnds[min];
                resultEnds[min] = dummy;
            }
            return resultEnds;
        }
    }
}
