using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueueClass
{
    public class Queue
    {
        static readonly int MAX = 1000;
        Queue<int> queue = new Queue<int>(); // Usar Queue em vez de um array

        public bool IsEmpty()
        {
            return queue.Count == 0; // Verifique se a fila está vazia
        }

        public void Enqueue(int data) // Adicionar um elemento à fila
        {
            if (queue.Count >= MAX)
            {
                Console.WriteLine("Queue Overflow");
            }
            else
            {
                queue.Enqueue(data);
            }
        }

        public int Dequeue() // Remover e retornar o elemento da frente da fila
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Queue Underflow");
                return 0;
            }

            return queue.Dequeue();
        }

        public void Peek()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Queue Underflow");
                return;
            }


            Console.WriteLine($"O elemento na frente da fila é: {queue.Peek()}");
        }


        public void PrintQueue()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Queue Underflow");
                return;
            }


            Console.WriteLine("Itens da fila:");
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}