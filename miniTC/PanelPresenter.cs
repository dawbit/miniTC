using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTC
{
    class PanelPresenter
    {
        IPanel view;
        Model model;

        public PanelPresenter(IPanel view, Model model)
        {
            this.view = view;
            this.model = model;

            this.view.GetDrives += View_GetDrives;
            this.view.GetItems += View_GetItems;
            this.view.SelectedDirectoryChange += View_SelectedDirectoryChange;
            this.view.Backwards += View_Backwards;

        }

        private string[] View_GetItems()
        {
            return model.GetFiles(this.view.CurrentPath);
        }

        private string[] View_GetDrives()
        {
            return model.Drives();
        }

        private void View_SelectedDirectoryChange()
        {
            view.CurrentPath = model.ChangePath(view.CurrentPath, view.SelectedDirectory);
        }

        private string View_Backwards()
        {
            return model.Backwards(this.view.CurrentPath);
        }
    }
}
