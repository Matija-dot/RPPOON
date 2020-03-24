using System;
using System.Collections.Generic;
using System.Text;

namespace LabExercise_1
{
    class ToDo
    {
        private List<Note> tasks;

        public ToDo()
        {
            this.tasks = new List<Note>();
        }

        public void Add(Note task)
        {
            tasks.Add(task);
        }
        public void Complete(Note task)
        {
            tasks.Remove(task);
        }
        public void CompleteHighestPriority()
        {
            int maxImportance = Int32.MinValue;
            for (int i = tasks.Count - 1; i >= 0; i--)
            {
                if (tasks[i].Importance > maxImportance)
                {
                    maxImportance = tasks[i].Importance;
                }
            }
            for (int i = tasks.Count - 1; i >= 0; i--)
            {
                if (tasks[i].Importance == maxImportance)
                {
                    tasks.RemoveAt(i);
                }
            }
        }
        public Note Get(int taskNumber)
        {
            int index = taskNumber - 1;
            if ((index >= 0) && (index < tasks.Count))
            {
                return this.tasks[index];
            }
            else throw new System.ArgumentException("Task is out of range.", "index");
        }        
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Note task in this.tasks)
            {
                stringBuilder.Append(task.ToString());
            }
            return stringBuilder.ToString();
        }
    }
}
