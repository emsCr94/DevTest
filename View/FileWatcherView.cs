using DevTest.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTest.View
{
    class FileWatcherView
    {
        readonly FileWatcherController fileWatcherController = new FileWatcherController();

        public void WatchFiles(bool state, string folder) 
        {
            fileWatcherController.WatchFiles(state, folder);
        }

        public bool getState() 
        {
            Console.WriteLine(fileWatcherController.getState());
            return fileWatcherController.getState();
        }

        public void setState(bool state)
        {
            fileWatcherController.setState(state);
        }
    }
}
