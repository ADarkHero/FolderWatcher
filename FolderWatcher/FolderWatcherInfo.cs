using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderWatcher
{
    [Serializable]
    public class FolderWatcherInfo
    {
        public string filePath = "";
        public string searchString = "";
        public string watchMethod = "";

        public FolderWatcherInfo(String path, String search = "*", String method = "folder")
        {
            filePath = path;
            searchString = search;
            watchMethod = method;
        }

        public FolderWatcherInfo()
        {
        }
    }
}
