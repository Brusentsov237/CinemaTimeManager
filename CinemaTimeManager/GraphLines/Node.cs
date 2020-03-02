using System;
using System.Collections.Generic;
using System.Text;

namespace GraphLines
{
    public class Node
    {
        public int timeLeft { get; } //осталось времени
        public string[] filmNames{ get; } //список фильмов
        public int[] duration { get; } //список длительности фильмов
        public string variantOfShedule { get; } //строка для добавления названия фильма в ответ 
        public List<Node> nodes { get; } //список ссылок на следущие ноды
        public List<string> list = new List<string>(); //лист для исключения повторений

        public Node(int timeLeft, string[] filmNames, int[] duration, string variantOfShedule, List<string> list)
        {
            this.timeLeft = timeLeft;
            this.filmNames = filmNames;
            this.duration = duration;
            this.variantOfShedule = variantOfShedule;
            this.nodes = new List<Node>();
            this.list = list;
        }
    }
}
