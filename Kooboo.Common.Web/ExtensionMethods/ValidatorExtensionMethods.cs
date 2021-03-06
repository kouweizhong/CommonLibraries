﻿#region License
// 
// Copyright (c) 2013, Kooboo team
// 
// Licensed under the BSD License
// See the file LICENSE.txt for details.
// 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace System.Web.Mvc
{
    public static class ValidatorExtensionMethods
    {
        public static ModelClientValidationRule Remote(string url, string errorMessage = "", string httpMethod = "POST")
        {
            ModelClientValidationRemoteRule clientValidationRule = new ModelClientValidationRemoteRule(errorMessage, url, httpMethod, "");

            return clientValidationRule;
        }
    }
}
