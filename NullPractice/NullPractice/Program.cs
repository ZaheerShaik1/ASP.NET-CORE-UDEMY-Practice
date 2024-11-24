
using NullPractice;

TaskClass task1 = new TaskClass()
{
    TaskName = "Learning",
    completedOn = "10-09-2023"
};

TaskClass task2 = new TaskClass()
{
    TaskName = "Executing",
    completedOn = "09-11-2002"
};

TeamMember tm1 = new TeamMember();

tm1.name = "zaheer";
tm1.emailId = "zaheer@gmail.com";

tm1.Tasks.Add(task1);
tm1.Tasks.Add(task2);

Console.WriteLine("Assigned Tasks:");
foreach (var task in tm1.Tasks)
{
    Console.WriteLine($"- Task: {task.TaskName}, Completed On: {task.completedOn}");
}