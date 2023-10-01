// criar uma fila utilizado o código da pilha
// dequeue() enqueue() peek()

using System;

namespace QueueClass {
    class Program {
        static void Main(string[] args)
        {
            Queue fila = new Queue(); // Use a classe Queue do namespace StackClass

            fila.Enqueue(10);
            fila.Enqueue(9);
            fila.Enqueue(100);
            fila.Enqueue(50);

            fila.PrintQueue();
        }
    }
}