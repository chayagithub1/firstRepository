namespace ex2
{
    public interface ITaskManegerServise
    {
        public void CreateTask(Task1 p);

        void UpdateTask( string title, Task1 p);
        void DeleteTask(string t);


    }
}
