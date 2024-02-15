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
        public string option1 = "-1";

        public FolderWatcherInfo(String path, String search = "*", String method = "folder", string op1 = "")
        {
            filePath = path;
            searchString = search;
            watchMethod = method;
            option1 = op1;
        }

        public FolderWatcherInfo()
        {
        }
    }
}
