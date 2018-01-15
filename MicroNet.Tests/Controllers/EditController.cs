using MicroNet.DataMapping;
using MicroNet.Filters;
using MicroNet.Services;
using MicroNet.Views.Model;
using MicroNet.Views.Utils;
using MicroNet.WinformMVC;

namespace MicroNet.Controllers
{
    [MvcController(Constant.EditController)]
    public class EditController : BaseController
    {
        readonly IContactService _contactService;

        public EditController(IContactService contactService, IView<ContactModel> view)
            : base(view)
        {
            _contactService = contactService;
        }

        [RoleBasedAuthorization(Roles = Constant.AdminRoles)]
        public override IActionResult DisplayView<TModel>(TModel model)
        {
            return base.DisplayView(model);
        }

        public IActionResult Modify(ContactModel model)
        {
            // Validate model here


            if (!model.IsEdit)
                _contactService.AddContact(model.ToEntity());
            else
                _contactService.UpdateContact(model.ToEntity());

            return RedirectTo(Constant.ListController);
        }
    }
}
