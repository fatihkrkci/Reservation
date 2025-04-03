// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
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
            new ApiResource("ResourceOcelot"){ Scopes = { "OcelotFullPermission" } },
            new ApiResource(IdentityServerConstants.LocalApi.ScopeName)
        };

        public static IEnumerable<IdentityResource> IdentityResources => new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResources.Email()
        };

        public static IEnumerable<ApiScope> ApiScopes => new ApiScope[]
        {
            new ApiScope("BookingFullPermission", "Full Authority For Booking Operations"),
            new ApiScope("BookingReadPermission", "Reading Authority For Booking Operations"),
            new ApiScope("BookingUpdatePermission", "Update Authority For Booking Operations"),
            new ApiScope("ReviewFullPermission", "Full Authority For Review Operations"),
            new ApiScope("PaymentFullPermission", "Full Authority For Payment Operations"),
            new ApiScope("BasketFullPermission", "Full Authority For Basket Operations"),
            new ApiScope("MessageFullPermission", "Full Authority For Message Operations"),
            new ApiScope("OcelotFullPermission", "Full Authority For Ocelot Operations"),
            new ApiScope(IdentityServerConstants.LocalApi.ScopeName)
        };

        public static IEnumerable<Client> Clients => new Client[]
        {
            new Client
            {
                ClientId = "ReservationVisitorId",
                ClientName = "Reservation Visitor User",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = { new Secret("reservationsecret".Sha256()) },
                AccessTokenLifetime = 600,
                AllowedScopes = { "BookingReadPermission", "OcelotFullPermission" },
                AllowAccessTokensViaBrowser = true
            },

            new Client
            {
                ClientId = "ReservationAdminId",
                ClientName = "Reservation Admin User",
                AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                ClientSecrets = { new Secret("reservationsecret".Sha256()) },
                AllowedScopes = { "BookingReadPermission", "BookingFullPermission", "BookingUpdatePermission", "ReviewFullPermission", "PaymentFullPermission", "BasketFullPermission", "MessageFullPermission", "OcelotFullPermission", 
                IdentityServerConstants.LocalApi.ScopeName,
                IdentityServerConstants.StandardScopes.Email,
                IdentityServerConstants.StandardScopes.OpenId,
                IdentityServerConstants.StandardScopes.Profile
                },
                AccessTokenLifetime = 600
            }
        };
    }
}