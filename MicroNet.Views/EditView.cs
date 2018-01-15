using System;
using System.Drawing;
using MicroNet.Views.Model;
using  MicroNet.WinformMVC;
using  MicroNet.WinformMVC.Validation;

namespace MicroNet.Views
{
    [MvcView("EditView")]
    public partial class EditView : BaseView, IView<ContactModel>
    {
        ContactModel _model;

        public EditView()
        {
            InitializeComponent();
        }

        public void BindModel(ContactModel model)
        {
            _model = model;
            BindDataSource(model, null);
        }

        protected override void DoShowModelError(ModelState state)
        {
            lblErrorMessage.Visible = true;
            lblErrorMessage.ForeColor = Color.IndianRed;
            lblErrorMessage.Text = "Should show model error here";
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            InvokeAction("Modify", _model);
        }

        private void lkViewList_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}