﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Muli_Pariwar_Lagat.Areas.pariwarlagat.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController:Controller
    {
    }
}