﻿using System;
using Beginor.AppFx.Core;
using NHibernate.AspNet.Identity;

namespace Beginor.OwinApp.Data.Entity {

    public class SampleEntity : Int32IdNameEntity {

        public virtual IdentityUser User { get; set; }

    }

}
