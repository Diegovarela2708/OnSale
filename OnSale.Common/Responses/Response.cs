﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnSale.Common.Responses
{
    public class Response
    {
        public bool IsSuccess { get; set; }

        public String Message { get; set; }

        public object Result { get; set; }
    }
}
