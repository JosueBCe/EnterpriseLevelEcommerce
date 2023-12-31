﻿using eShopOnContainers.Models.Token;

namespace eShopOnContainers.Services.Identity;

public interface IIdentityService
{
    string CreateAuthorizationRequest();
    string CreateLogoutRequest(string token);
    Task<UserToken> GetTokenAsync(string code);
}