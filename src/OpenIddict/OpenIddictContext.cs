﻿/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/openiddict/core for more information concerning
 * the license and the contributors participating to this project.
 */

using System;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using OpenIddict.Models;

namespace OpenIddict {
    public class OpenIddictContext<TUser, TRole, TKey> : IdentityDbContext<TUser, TRole, TKey>
        where TUser : IdentityUser<TKey>
        where TRole : IdentityRole<TKey>
        where TKey : IEquatable<TKey> {
        public DbSet<Application> Applications { get; set; }
    }

    public class OpenIddictContext<TUser> : OpenIddictContext<TUser, IdentityRole, string> where TUser : IdentityUser { }
}