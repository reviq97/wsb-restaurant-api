﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsb_restaurant_domain.Dtos
{
    public record LoginRequest(string email, string password);
}
