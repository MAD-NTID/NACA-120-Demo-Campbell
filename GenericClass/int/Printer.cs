public class Printer
{
    private int size;
    private int front;
    private int[] jobs;

    public int TotalJobs => size;

    public Printer(int capacity)
    {
        this.jobs = new int[capacity];
        this.front = this.size = 0;
    }

    public bool Add(int job)
    {
        //the printer is full, no new job can be added
        if(this.size == this.jobs.Length)
            return false;
        
        //there is spot available so we insert at location <size>
        this.jobs[size] = job;
        this.size++;
        return true;
    }

    public int Print()
    {
        if(this.size == 0)
            return 0;
        
        int document = this.jobs[front];
        this.jobs[front] = 0;
        this.front++;
        this.size--;

        return document;
    }

    public bool Cancel(int job)
    {
        for(int i = 0; i < this.jobs.Length; i++)
        {
            if(this.jobs[i] == job)
            {
                this.jobs[i] = 0;
                this.size--;
                return true;
            }
        }

        return false;
    }
}