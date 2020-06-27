using Loundry.Models;
using Loundry.Requests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Threading;

namespace Loundry
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new ApplicationContext();
            int MaxThreadsCount = Environment.ProcessorCount * 4;
            ThreadPool.SetMaxThreads(MaxThreadsCount, MaxThreadsCount);
            ThreadPool.SetMinThreads(2, 2);
            new Server(80);
            //db.SaveChanges();
        }
    }
}
