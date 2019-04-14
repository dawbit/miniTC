using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTC
{
    class Presenter
    {
        IView view;
        Model model;

        PanelPresenter left;
        PanelPresenter right;
        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.model = model;

            this.left = new PanelPresenter(view.LeftPanel, model);
            this.right = new PanelPresenter(view.RightPanel, model);

            this.view.Copy += View_Copy;
        }

        private void View_Copy()
        {
            model.Copy(view.LeftPanel.SelectedDirectory, view.LeftPanel.CurrentPath, view.RightPanel.CurrentPath);
        }
    }
}