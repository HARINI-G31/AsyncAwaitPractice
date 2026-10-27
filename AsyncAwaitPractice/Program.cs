using AsyncAwaitPractice;
using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    public static async Task Main(string[] args)
    {
        LearnAsyncProgramming obj = new LearnAsyncProgramming();

        await obj.BasicAsync();
        await obj.TaskTrackingAsync();
        await obj.SequentialAsync();
        await obj.ConcurrentAsync();
        await obj.WhenAllAsync();

    }
}