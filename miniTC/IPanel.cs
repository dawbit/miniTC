using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTC
{
    public interface IPanel
    {
        string[] Drives { set; }
        string[] Items { get;  set; }
        string CurrentPath { get; set; }
        string SelectedDirectory { get; }

        event Func<string[]> GetDrives;
        event Func<string[]> GetItems;
        event Action SelectedDirectoryChange;
        event Func<string> Backwards;
    }
}
