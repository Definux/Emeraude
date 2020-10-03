﻿namespace Definux.Emeraude.Resources
{
    /// <summary>
    /// Application roots are named folders of the application directory.
    /// </summary>
    public enum ApplicationRoots
    {
        /// <summary>
        /// Directory placed in web project directory named 'privateroot'.
        /// </summary>
        Private = 0,

        /// <summary>
        /// Directory placed in the web project directory named 'wwwroot'.
        /// </summary>
        Public = 1,
    }

    /// <summary>
    /// Classification of the route types.
    /// </summary>
    public enum RouteType
    {
        Client = 1,
        Admin = 2,
        Api = 3,
    }
}
