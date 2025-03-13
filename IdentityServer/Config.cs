// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
        {
            new ApiResource("ResourceBooking"){ Scopes = { "BookingFullPermission"} },
            new ApiResource("ResourceBooking2"){ Scopes = { "BookingReadPermission"} },
            new ApiResource("ResourceBooking3"){ Scopes = { "BookingReadPermission", "BookingUpdatePermission" } },
            new ApiResource("ResourceReview"){ Scopes = { "ReviewFullPermission" } },
            new ApiResource("ResourcePayment"){ Scopes = { "PaymentFullPermission" } },
            new ApiResource("ResourceBasket"){ Scopes = { "BasketFullPermission" } },
            new ApiResource("ResourceMessage"){ Scopes = { "MessageFullPermission" } },
        };
    }
}