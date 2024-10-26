
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace UnipPimFazenda.Config
{
    public class RoutePrefixConvention : IApplicationModelConvention
    {
        private readonly AttributeRouteModel _centralPrefix;

        public RoutePrefixConvention(string routePrefix)
        {
            _centralPrefix = new AttributeRouteModel(new RouteAttribute(routePrefix));
        }

        public void Apply(ApplicationModel application)
        {
            foreach (var controller in application.Controllers)
            {
                foreach (var selector in controller.Selectors)
                {

                    selector.AttributeRouteModel = AttributeRouteModel.CombineAttributeRouteModel(_centralPrefix, selector.AttributeRouteModel);
                }
            }
        }
    }
}