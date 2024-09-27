using System;

namespace SavingInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList tdl = new TodoList();
            tdl.Add("Invite friends");
            tdl.Add("Order Pizza");
            tdl.Add("Bring Coca-cola");
            tdl.Add("Buy decorations");
            tdl.Add("Party");
            tdl.Display();

            PasswordManager pm = new PasswordManager("iluvpie", true);
            pm.Display();

            Console.WriteLine("Doing Reset....");
            tdl.Reset();
            tdl.Display();
            pm.Reset();
            pm.Display();
        }
    }
}
