using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace UnipPimFazenda.Config
{
    public class LowercaseRouteConvention : IApplicationModelConvention
    {
        public void Apply(ApplicationModel application)
        {
            foreach (var controller in application.Controllers)
            {
                foreach (var selector in controller.Selectors)
                {
                    if (selector.AttributeRouteModel != null)
                    {
                        selector.AttributeRouteModel.Template = selector.AttributeRouteModel?.Template?.ToLowerInvariant();
                    }
                }
            }
        }
    }
}