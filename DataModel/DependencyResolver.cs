﻿using DataModel.Unit_of_Work;
using Resolver;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{

    [Export(typeof(IComponent))]
    public class DependencyResolver: IComponent
    {
        public void SetUp(IRegisterComponent registerComponent)
        {
            registerComponent.RegisterType<IUnitOfWork, Unit_of_Work.UnitOfWork>();
        }
    }
}
