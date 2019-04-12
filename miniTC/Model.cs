using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace miniTC
{
    class Model
    {
        List<string> items = new List<string>();
        private string path;

        public Model() { }

        public string[] Drives()
        {
            List<string> readyDrives = new List<string>();
            foreach (var drive in DriveInfo.GetDrives().ToArray())
                if (drive.IsReady) readyDrives.Add(drive.ToString());

            return readyDrives.ToArray();
        }

        public string DirectoryPath
        {
            get
            {
                if (Path.GetDirectoryName(path) == null) return "";
                else return Path.GetDirectoryName(path);
            }
            set
            {
                path = value;
            }
        }

        public string ChangeDrive(string path)
        {
            return path;
        }

        public string[] GetFiles(string CurrentPath)
        {
            //items.Add(CurrentPath);
            if (Directory.Exists(CurrentPath))
            {
                List<string> allItems = new List<string>();

                try
                {
                    if (Directory.GetParent(CurrentPath) != null)
                    {
                        allItems.Add(Directory.GetParent(CurrentPath).ToString());
                    }

                    foreach (var dir in Directory.GetDirectories(CurrentPath).ToList())
                        allItems.Add(dir);
                    //allItems.Add(dir.Remove(0,CurrentPath.Length));

                    foreach (var dir in Directory.GetFiles(CurrentPath).ToList())
                        allItems.Add(dir);
                    //allItems.Add(dir.Remove(0, CurrentPath.Length));

                    return allItems.ToArray();
                }
                catch (UnauthorizedAccessException)
                {
                    throw new Exception("Access Denied");
                }
            }
            else return items.ToArray();

        }

        public string Backwards(string CurrentPath)
        {
            if (Directory.GetParent(CurrentPath) != null)
            {
                return Directory.GetParent(CurrentPath).ToString();
            }
            else return CurrentPath;
        }

        public string ChangePath(string CurrentPath, string selectedDirectory)
        {
            try
            {
                if (Directory.GetDirectories(CurrentPath).Contains(selectedDirectory) || (Directory.GetParent(CurrentPath) != null && Directory.GetParent(CurrentPath).ToString() == selectedDirectory))
                    return selectedDirectory;
                else return CurrentPath;
            }
            catch (UnauthorizedAccessException)
            {
                CurrentPath = "C:\\";
                return CurrentPath;
            }


        }
    }
}

