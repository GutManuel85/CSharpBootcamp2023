namespace P07_Project_ToDoList
{
    internal class P07_Project_ToDoList
    {
        public static void Main(string[] args)
        {
            // Anwendung: Todo-List
            // Add, View, Delete, Quit

            int toDoListSize = 3;
            string[] toDoList = new string[toDoListSize + 1];
            int currentTaskCount = 0;
            string command = "";

            while (command != "quit")
            {
                Console.WriteLine("Please write 'add', 'view', 'delete' or 'quit'");
                command = Console.ReadLine().ToLower();

                if (command == "add")
                {
                    if (currentTaskCount < toDoList.Length - 1)
                    {
                        Console.WriteLine("Please enter a task to add.");
                        string task = Console.ReadLine();
                        toDoList[currentTaskCount] = task;
                        currentTaskCount++;
                    }
                    else
                    {
                        Console.WriteLine("ToDo-List is full.");
                    }
                }
                else if (command == "view")
                {
                    Console.WriteLine("Your current tasks are:");
                    for (int i = 0; i < currentTaskCount; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + toDoList[i]);
                    }
                }
                else if (command == "delete")
                {
                    Console.WriteLine("Please enter the number of the task to delete:");
                    int taskNumber = int.Parse(Console.ReadLine()) - 1;
                    if (taskNumber < 0 || taskNumber >= currentTaskCount)
                    {
                        Console.WriteLine("Invalid task number");
                    }
                    else
                    {
                        for (int i = taskNumber; i < currentTaskCount; i++)
                        {
                            toDoList[i] = toDoList[i + 1];
                        }
                        currentTaskCount--;
                        Console.WriteLine("Task removed.");
                    }

                }
                else if (command == "quit")
                {
                    Console.WriteLine("Goodby!");
                }
            }

        }
    }
}
