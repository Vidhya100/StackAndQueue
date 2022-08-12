namespace StackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedListStack list = new LinkedListStack();

            list.Push(56);
            list.Push(30);
            list.Push(70);
                
            list.Display();

            while (!list.IsEmpty())
            {
                list.Peek();
                list.Pop();
            }
         }
    }
}