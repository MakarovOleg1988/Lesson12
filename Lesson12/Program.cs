using System;
using System.Collections.Generic;

namespace Lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryMethod();
        }

        static void CollectoinMethod()
        {
            List<int> _list = new List<int>(6);
            //List<List<int>> _list2 = new List<List<int>>(6);
            _list.Add(1);

            for (int i = 0; i < 5; i++)
            {
                _list.Add(i);
                Console.WriteLine("Count:" + _list.Count);
                Console.WriteLine("Capacity:" + _list.Capacity);
            }

            int[][] _array = new int[5][];

            for (int i = 0; i < 5; i++)
            {
                _array[i] = new int[5];
            }

            int[,] _array2 = new int[5,5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    _array2[i, j] = i + j;
                }
            }

            //[0][0] | [0][1]| [0][2] | [0][3] | [0][4]
            //[1][0] | [1][1]| [1][2] | [1][3] | [1][4]
            //[2][0] | [2][1]| [2][2] | [2][3] | [2][4]
            //[3][0] | [3][1]| [3][2] | [3][3] | [3][4]
            //[4][0] | [4][1]| [4][2] | [4][3] | [4][4]
        }

        static void LinkedListMethod()
        {
            List<int> _list2 = new List<int>(5);
            LinkedList<int> _linkedList = new LinkedList<int>();

            for (int i2 = 0; i2 < 5; i2++)
            {
                _list2.Add(i2);
                _linkedList.AddFirst(i2);
            }

            _list2.AddRange(_linkedList);

            _list2.Remove(5); // удаление значения из списка
            _list2.RemoveAt(4); // удаления элемента под индексом 
            _list2.RemoveRange(2, 2); //удаление блока из списка 

            if (_list2.Contains(4)) // проверка содержания в ячейке коллекции
            { 
            
            }

            var _first = _linkedList.First;
            var _last = _linkedList.Last;
        }

        static void SortedListMethod()
        {
            SortedList<int, int> _sortedList = new SortedList<int, int>();

            Stack<int> _stack = new Stack<int>();

            for (int i3 = 0; i3 < 5; i3++)
            {
                _stack.Push(i3); //добавление элементов в Стек
            }

            var r1 = _stack.Pop();

        }
        static void DictionaryMethod()
        {
            Dictionary<string, string> _dictionary = new Dictionary<string, string>();

            _dictionary.Add("Бегать", "Run");
            Console.WriteLine(_dictionary["Бегать"]);

            Dictionary<int, string> _dictionary1 = new Dictionary<int, string>();

            _dictionary1.Add(1, "Run");
            Console.WriteLine(_dictionary1[1]);

            _dictionary1.Add(2, "Fall");
            Console.WriteLine(_dictionary1[2]);

            Dictionary<int, string> _dictionary3 = new Dictionary<int, string>()
            {
                {1, "One"}, {2, "Two"}, {3, "Three"}
            };

            Console.WriteLine(_dictionary3[1]);
            Console.WriteLine();
            Console.WriteLine(_dictionary3[2]);
            Console.WriteLine();
            Console.WriteLine(_dictionary3[3]);
        }
    }
}
