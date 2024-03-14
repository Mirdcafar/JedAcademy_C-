namespace ConsoleApp1.ToDoList;

public class Storage
{
    public void Add(Class1 classe)
    {
        FileName.ToDo.Add(classe);
    }

    public Class1 Remove(int id)
    {

        var todoToRemove = FileName.ToDo.FirstOrDefault(x => x.Id == id);


        if (todoToRemove != null)
        {
            FileName.ToDo.Remove(todoToRemove);
            return todoToRemove;
        }
        else
        {
            return null;
        }
    }

    public Class1 Find(int id)
    {
        
        var todo = FileName.ToDo.FirstOrDefault(x => x.Id == id);

        if (todo != null)
        {
            return todo;
        }
        else
        {
            return null;
        }
    }
}
