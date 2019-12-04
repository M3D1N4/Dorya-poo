using System;
using System.Collections;


namespace Stackk
{
    public class Stack<S>
    {
        readonly int m_Size;
        int m_StackPointer = 0;
        S[] m_Items;

        public Stack() : this(100)
        { }

        public Stack(int size){
            m_Size = size;
            m_Items = new S[m_Size];
        }
        public void Push(S item){
            if (m_StackPointer >= m_Size)
                throw new StackOverflowException();
            m_Items[m_StackPointer] = item;
            m_StackPointer++;
        }
        public S Pop(){
            //          Codigo que marca error si se trata de hacer popo a un stack vacio            //
            m_StackPointer--;

            if (m_StackPointer >= 0){
                return m_Items[m_StackPointer];
            }
            else{
                m_StackPointer = 0;
                throw new InvalidOperationException("No se puede hacer pop a un Stack vacio.");
            }
        }
    }

    class Program{
        static void Main(string[] args){
            string P = "Next";
            Stack stak = new Stack();
            stak.Push(6);
            stak.Push(5);
            stak.Push(4);
            stak.Push(3);
            stak.Push(2);
            stak.Push(1);

            Console.WriteLine("Numero total de elementos en Stack: {0}", stak.Count);

            //         El código de abajo realiza un pop mientras p sea igual a "Next"       //
            do{
                Console.WriteLine(stak.Pop());

                P = Console.ReadLine();
            } while (P == "Next");
            Console.ReadKey();
        }
    }
}