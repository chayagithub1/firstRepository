using System.Diagnostics.Eventing.Reader;

namespace ex2
{
    public class TaskMengerServise: ITaskManegerServise
    {
        static Task1 t1 = new Task1 { Title = "Hw", Desc = "so hard, but ברוך ה we are so smart ❤", Target_date = DateTime.Today, preference = Preference.a };
        static Task1 t2 = new Task1 { Title = "Go walking", Desc = "be healthy 🍎", Target_date = DateTime.Today, preference = Preference.b };
        static Task1 t3 = new Task1 { Title = "Do project", Desc = "finish? no: good luck yes: excellent", Target_date = DateTime.MaxValue, preference = Preference.c };
        static List<Task1> taskList = new List<Task1>() {t1,t2,t3};


        private readonly ILogger _logger;
        //cor
        public TaskMengerServise(ILogger<TaskMengerServise> logger)
        {
            _logger = logger;
        }


        public void myLog1()
        {
            _logger.LogInformation("now i'm in taskManager page ",
            DateTime.UtcNow.ToLongTimeString());
        }

        public void myLog2()
        {
            _logger.LogDebug(" my Log2 is running...",
            DateTime.UtcNow.ToLongTimeString());
        }


        void ITaskManegerServise.CreateTask(Task1 t)
        {
            taskList.Add(t);
            return;
        }

        void ITaskManegerServise.UpdateTask(string title, Task1 t)
        {
            Task1 tt = taskList.Find(e => e.Title == title);
      
            tt.Desc = t.Desc;
            tt.Target_date = t.Target_date;
            tt.preference = t.preference;
        }

        void ITaskManegerServise.DeleteTask(string title )
        {
            Task1 t = taskList.Find(e => e.Title == title);
            taskList.Remove(t);
        }

        
       
        


    }
}
