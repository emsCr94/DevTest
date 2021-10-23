using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using DevTest.Model;
using System.Threading;

namespace DevTest.Controller
{
    public class FileWatcherController
    {
        /*  
            This class executes the logic implemented on FileWatcher main class as a controller
            for that logic.It uses an instance of FileWatcher.cs
        */

        private readonly FileWatcher fileWatcher = new FileWatcher();

        /// <summary>
        ///    This method starts a thread that will execute FileWatcher main class method
        ///    main class method WatchFiles will execute the logic to look up for files
        ///
        /// <Parameters>
        ///     boolean state -> the state from the user interface button
        ///     string folder -> the path selecte in the user interface
        /// </Parameters>
        /// </summary>
        public bool WatchFiles(bool state, string folder) 
        {
            Task watchFiles;
            CancellationTokenSource waitToken = new CancellationTokenSource();

            if (state)
            {
     
                setState(true);
                watchFiles = Task.Run(async () =>  
                {
                    while (true)
                    {
                        fileWatcher.WatchFiles(@folder);
                        await Task.Delay(0, waitToken.Token); 
                    }
                }, waitToken.Token);

            }
            else 
            {
                setState(false);
                try
                {
                    waitToken.Cancel();
                }
                catch(TaskCanceledException)
                {
                    Console.WriteLine("Task canceled");
                }
                finally
                {
                    waitToken.Dispose();
                }

            }
            return true;
        }


        /// <summary>
        ///    This method returns the actual state of the folder watcher
        ///
        /// <Parameters>
        ///     none
        /// </Parameters>
        /// </summary>
        public bool getState() 
        {
            return true ? fileWatcher.State == "on" : false;
        }

        /// <summary>
        ///    This method sets the actual state of the folder watcher
        ///
        /// <Parameters>
        ///     bool state -> the state from the user interface button
        /// </Parameters>
        /// </summary>
        public void setState(bool state)
        {
            if (state)
            {
                fileWatcher.State = "on";
            }
            else 
            {
                fileWatcher.State = "off";
            }
        }
    }
}
