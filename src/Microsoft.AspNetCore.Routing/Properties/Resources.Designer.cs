// <auto-generated />
namespace Microsoft.AspNetCore.Routing
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNetCore.Routing.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// Value must be greater than or equal to {0}.
        /// </summary>
        internal static string ArgumentMustBeGreaterThanOrEqualTo
        {
            get => GetString("ArgumentMustBeGreaterThanOrEqualTo");
        }

        /// <summary>
        /// Value must be greater than or equal to {0}.
        /// </summary>
        internal static string FormatArgumentMustBeGreaterThanOrEqualTo(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("ArgumentMustBeGreaterThanOrEqualTo"), p0);

        /// <summary>
        /// The value for argument '{0}' should be less than or equal to the value for the argument '{1}'.
        /// </summary>
        internal static string RangeConstraint_MinShouldBeLessThanOrEqualToMax
        {
            get => GetString("RangeConstraint_MinShouldBeLessThanOrEqualToMax");
        }

        /// <summary>
        /// The value for argument '{0}' should be less than or equal to the value for the argument '{1}'.
        /// </summary>
        internal static string FormatRangeConstraint_MinShouldBeLessThanOrEqualToMax(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("RangeConstraint_MinShouldBeLessThanOrEqualToMax"), p0, p1);

        /// <summary>
        /// The '{0}' property of '{1}' must not be null.
        /// </summary>
        internal static string PropertyOfTypeCannotBeNull
        {
            get => GetString("PropertyOfTypeCannotBeNull");
        }

        /// <summary>
        /// The '{0}' property of '{1}' must not be null.
        /// </summary>
        internal static string FormatPropertyOfTypeCannotBeNull(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("PropertyOfTypeCannotBeNull"), p0, p1);

        /// <summary>
        /// The supplied route name '{0}' is ambiguous and matched more than one route.
        /// </summary>
        internal static string NamedRoutes_AmbiguousRoutesFound
        {
            get => GetString("NamedRoutes_AmbiguousRoutesFound");
        }

        /// <summary>
        /// The supplied route name '{0}' is ambiguous and matched more than one route.
        /// </summary>
        internal static string FormatNamedRoutes_AmbiguousRoutesFound(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("NamedRoutes_AmbiguousRoutesFound"), p0);

        /// <summary>
        /// A default handler must be set on the {0}.
        /// </summary>
        internal static string DefaultHandler_MustBeSet
        {
            get => GetString("DefaultHandler_MustBeSet");
        }

        /// <summary>
        /// A default handler must be set on the {0}.
        /// </summary>
        internal static string FormatDefaultHandler_MustBeSet(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("DefaultHandler_MustBeSet"), p0);

        /// <summary>
        /// The constructor to use for activating the constraint type '{0}' is ambiguous. Multiple constructors were found with the following number of parameters: {1}.
        /// </summary>
        internal static string DefaultInlineConstraintResolver_AmbiguousCtors
        {
            get => GetString("DefaultInlineConstraintResolver_AmbiguousCtors");
        }

        /// <summary>
        /// The constructor to use for activating the constraint type '{0}' is ambiguous. Multiple constructors were found with the following number of parameters: {1}.
        /// </summary>
        internal static string FormatDefaultInlineConstraintResolver_AmbiguousCtors(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("DefaultInlineConstraintResolver_AmbiguousCtors"), p0, p1);

        /// <summary>
        /// Could not find a constructor for constraint type '{0}' with the following number of parameters: {1}.
        /// </summary>
        internal static string DefaultInlineConstraintResolver_CouldNotFindCtor
        {
            get => GetString("DefaultInlineConstraintResolver_CouldNotFindCtor");
        }

        /// <summary>
        /// Could not find a constructor for constraint type '{0}' with the following number of parameters: {1}.
        /// </summary>
        internal static string FormatDefaultInlineConstraintResolver_CouldNotFindCtor(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("DefaultInlineConstraintResolver_CouldNotFindCtor"), p0, p1);

        /// <summary>
        /// The constraint type '{0}' which is mapped to constraint key '{1}' must implement the '{2}' interface.
        /// </summary>
        internal static string DefaultInlineConstraintResolver_TypeNotConstraint
        {
            get => GetString("DefaultInlineConstraintResolver_TypeNotConstraint");
        }

        /// <summary>
        /// The constraint type '{0}' which is mapped to constraint key '{1}' must implement the '{2}' interface.
        /// </summary>
        internal static string FormatDefaultInlineConstraintResolver_TypeNotConstraint(object p0, object p1, object p2)
            => string.Format(CultureInfo.CurrentCulture, GetString("DefaultInlineConstraintResolver_TypeNotConstraint"), p0, p1, p2);

        /// <summary>
        /// The constraint entry '{0}' - '{1}' on the route '{2}' must have a string value or be of a type which implements '{3}'.
        /// </summary>
        internal static string RouteConstraintBuilder_ValidationMustBeStringOrCustomConstraint
        {
            get => GetString("RouteConstraintBuilder_ValidationMustBeStringOrCustomConstraint");
        }

        /// <summary>
        /// The constraint entry '{0}' - '{1}' on the route '{2}' must have a string value or be of a type which implements '{3}'.
        /// </summary>
        internal static string FormatRouteConstraintBuilder_ValidationMustBeStringOrCustomConstraint(object p0, object p1, object p2, object p3)
            => string.Format(CultureInfo.CurrentCulture, GetString("RouteConstraintBuilder_ValidationMustBeStringOrCustomConstraint"), p0, p1, p2, p3);

        /// <summary>
        /// The constraint entry '{0}' - '{1}' on the route '{2}' could not be resolved by the constraint resolver of type '{3}'.
        /// </summary>
        internal static string RouteConstraintBuilder_CouldNotResolveConstraint
        {
            get => GetString("RouteConstraintBuilder_CouldNotResolveConstraint");
        }

        /// <summary>
        /// The constraint entry '{0}' - '{1}' on the route '{2}' could not be resolved by the constraint resolver of type '{3}'.
        /// </summary>
        internal static string FormatRouteConstraintBuilder_CouldNotResolveConstraint(object p0, object p1, object p2, object p3)
            => string.Format(CultureInfo.CurrentCulture, GetString("RouteConstraintBuilder_CouldNotResolveConstraint"), p0, p1, p2, p3);

        /// <summary>
        /// Two or more routes named '{0}' have different templates.
        /// </summary>
        internal static string AttributeRoute_DifferentLinkGenerationEntries_SameName
        {
            get => GetString("AttributeRoute_DifferentLinkGenerationEntries_SameName");
        }

        /// <summary>
        /// Two or more routes named '{0}' have different templates.
        /// </summary>
        internal static string FormatAttributeRoute_DifferentLinkGenerationEntries_SameName(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("AttributeRoute_DifferentLinkGenerationEntries_SameName"), p0);

        /// <summary>
        /// Unable to find the required services. Please add all the required services by calling '{0}.{1}' inside the call to '{2}' in the application startup code.
        /// </summary>
        internal static string UnableToFindServices
        {
            get => GetString("UnableToFindServices");
        }

        /// <summary>
        /// Unable to find the required services. Please add all the required services by calling '{0}.{1}' inside the call to '{2}' in the application startup code.
        /// </summary>
        internal static string FormatUnableToFindServices(object p0, object p1, object p2)
            => string.Format(CultureInfo.CurrentCulture, GetString("UnableToFindServices"), p0, p1, p2);

        /// <summary>
        /// The '{0}' has no '{1}'. '{2}' requires a dispatcher.
        /// </summary>
        internal static string DispatcherFeatureIsRequired
        {
            get => GetString("DispatcherFeatureIsRequired");
        }

        /// <summary>
        /// The '{0}' has no '{1}'. '{2}' requires a dispatcher.
        /// </summary>
        internal static string FormatDispatcherFeatureIsRequired(object p0, object p1, object p2)
            => string.Format(CultureInfo.CurrentCulture, GetString("DispatcherFeatureIsRequired"), p0, p1, p2);

        /// <summary>
        /// The route parameter '{0}' has both an inline default value and an explicit default value specified. A route parameter cannot contain an inline default value when a default value is specified explicitly. Consider removing one of them.
        /// </summary>
        internal static string TemplateRoute_CannotHaveDefaultValueSpecifiedInlineAndExplicitly
        {
            get => GetString("TemplateRoute_CannotHaveDefaultValueSpecifiedInlineAndExplicitly");
        }

        /// <summary>
        /// The route parameter '{0}' has both an inline default value and an explicit default value specified. A route parameter cannot contain an inline default value when a default value is specified explicitly. Consider removing one of them.
        /// </summary>
        internal static string FormatTemplateRoute_CannotHaveDefaultValueSpecifiedInlineAndExplicitly(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("TemplateRoute_CannotHaveDefaultValueSpecifiedInlineAndExplicitly"), p0);

        /// <summary>
        /// An error occurred while creating the route with name '{0}' and template '{1}'.
        /// </summary>
        internal static string TemplateRoute_Exception
        {
            get => GetString("TemplateRoute_Exception");
        }

        /// <summary>
        /// An error occurred while creating the route with name '{0}' and template '{1}'.
        /// </summary>
        internal static string FormatTemplateRoute_Exception(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("TemplateRoute_Exception"), p0, p1);

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
