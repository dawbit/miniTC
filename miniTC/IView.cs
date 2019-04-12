using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTC
{
    interface IView
    {
        IPanel LeftPanel { get; }
        IPanel RightPanel { get; }



        //string[] Drives { set; }
        //string[] Items { get;  set; }
        //string CurrentPath { get; set; }

        //void ErrorMessage(string message);

        //event Func<string[]> GetDrives;
        //event Func<string, string[]> LoadFilesToDir;
        //event Func<string> GetPath;
    }
}
