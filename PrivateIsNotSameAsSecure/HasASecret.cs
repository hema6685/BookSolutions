﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PrivateIsNotSameAsSecure
{
    class HasASecret
    {
        // This class has a secret field. Does the private keyword make it secure?
        private string secret = "xyzzy";
    }
}
