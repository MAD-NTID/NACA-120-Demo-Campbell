using System.ComponentModel;

public class Printer<T>
{
    private int size;
    private int front;
    private T[] jobs;

    public int TotalJobs => size;

    public Printer(int capacity)
    {
        this.jobs = new T[capacity];
        this.front = this.size = 0;
    }

    public bool Add(T job)
    {
        //the printer is full, no new job can be added
        if(this.size == this.jobs.Length)
            return false;
        
        //there is spot available so we insert at location <size>
        this.jobs[size] = job;
        this.size++;
        return true;
    }

    public T Print()
    {
        if(this.size == 0)
            return default;
        
        T document = this.jobs[front];
        this.jobs[front] = default;
        this.front++;
        this.size--;

        return document;
    }

    public bool Cancel(T job)
    {
        bool match = false;
        for(int i = 0; i < this.jobs.Length; i++)
        {
            T element = this.jobs[i];
            match  = EqualityComparer<T>.Default.Equals(element, job);
            if(match)
            {
                this.jobs[i] = default;
                this.size--;
                break;
            }

        }

        return match;
    }
}