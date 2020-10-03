﻿using System;
using System.Collections.Generic;
using Definux.Emeraude.Admin.UI.HtmlBuilders;
using Definux.Emeraude.Admin.UI.UIElements.Form.Helpers;
using Definux.Utilities.Extensions;

namespace Definux.Emeraude.Admin.UI.UIElements.Form.Implementations
{
    /// <summary>
    /// Implementation of <see cref="FormElement"/> that renders a dropdown based on specified <see cref="IFormElementDatabaseView"/>.
    /// </summary>
    public class FormDatabaseViewDropdownElement : FormElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormDatabaseViewDropdownElement"/> class.
        /// </summary>
        public FormDatabaseViewDropdownElement()
            : base()
        {
        }

        /// <inheritdoc/>
        public override void DefineHtmlBuilder()
        {
            var entitySample = (IFormElementDatabaseView)this.ServiceProvider.GetService((Type)this.DataSource);

            this.HtmlBuilder = new DropdownHtmlBuilder<Guid>((Dictionary<Guid, string>)entitySample, this.TargetProperty, this.Value.GetGuidValueOrDefault(), this.IsNullable);
        }
    }
}
