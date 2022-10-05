using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class MyLinkedListData<T>
    {
        public T? Data;
        public MyLinkedListData<T>? Next;
        public MyLinkedListData<T>? Prev;
    }

    class MyLinkedList<T>
    {
        public MyLinkedListData<T>? FirstRoom = null;
        public MyLinkedListData<T>? LastRoom = null;
        public int Count = 0;

        public MyLinkedListData<T> AddLast(T data)
        {
            MyLinkedListData<T> newRoom = new MyLinkedListData<T>();
            newRoom.Data = data;

            if (FirstRoom == null)
                FirstRoom = newRoom;

            if (LastRoom != null)
            {
                LastRoom.Next = newRoom;
                newRoom.Prev = LastRoom;
            }

            LastRoom = newRoom;
            Count++;
            return newRoom;
        }

        public void Remove(MyLinkedListData<T> room)
        {
            if (FirstRoom == room)
                FirstRoom = FirstRoom.Next;

            if (LastRoom == room)
                LastRoom = LastRoom.Prev;

            if (room.Prev != null)
                room.Prev.Next = room.Next;

            if (room.Next != null)
                room.Next.Prev = room.Prev;

            Count--;
        }
    }

    class Board
    {
        public MyLinkedList<int> _data = new MyLinkedList<int>();

        public void Initialize()
        {
            _data.AddLast(101);
            _data.AddLast(102);
            MyLinkedListData<int> node = _data.AddLast(103);
            _data.AddLast(104);
            _data.AddLast(105);

            _data.Remove(node);
        }

        static void Main(String[] args)
        {
            Board board = new Board();
            board.Initialize();
        }
    }
}
