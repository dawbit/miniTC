using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

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

                    foreach (var dir in Directory.GetFiles(CurrentPath).ToList())
                        allItems.Add(dir);

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

        public void Copy(string Item, string Source, string Destination)
        {
            try
            {
                if (Item == null || Item.Contains("Error"))
                {
                    MessageBox.Show("Error: You need to pick something.");
                    return;
                }
                if (Destination == "" || Destination == null)
                {
                    MessageBox.Show("Error: You need to select the destination.");
                    return;
                }
                string ItemName = Item.Substring(Source.Length);
                Console.WriteLine(Destination + ItemName);
                File.Copy(Item, Destination + ItemName);
                MessageBox.Show("Success! Your file was copied successfully.");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Error: You don't have permission to take this action.");
            }
            catch (IOException)
            {
                string ItemName = Item.Substring(Source.Length);
                MessageBox.Show("Error: Item " + ItemName + " already exists.");
            }
        }
    }
}

