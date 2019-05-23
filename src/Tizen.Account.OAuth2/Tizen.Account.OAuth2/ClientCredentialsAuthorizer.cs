﻿/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Tizen.Account.OAuth2
{
    /// <summary>
    /// The ClientCredentialsAuthorizer is used to obtain access tokens using Client Credentials Grant flow as described at https://tools.ietf.org/html/rfc6749#section-4.4
    /// </summary>
    /// <since_tizen> 3 </since_tizen>
    public class ClientCredentialsAuthorizer : Authorizer
    {
        /// <summary>
        /// The constructor
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        public ClientCredentialsAuthorizer()
        {

        }

        /// <summary>
        /// Authorization not supported through this API for this flow.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        /// <exception cref="InvalidOperationException">Thrown when the operation is not supported</exception>
        public  Task<AuthorizationResponse> AuthorizeAsync(AuthorizationRequest request)
        {
            Log.Error(ErrorFactory.LogTag, "Authorization is not supported in this flow");
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Refreshing access token is not supported in this flow.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        /// <exception cref="InvalidOperationException">Thrown when the operation is not supported</exception>
        public override Task<TokenResponse> RefreshAccessTokenAsync(RefreshTokenRequest request)
        {
            Log.Error(ErrorFactory.LogTag, "Refreshing access token is not supported in this flow");
            throw new InvalidOperationException();
        }

        /// <summary>
        /// Retrieves access token using client credentials.
        /// The authroization request parameters should be as defined in https://tools.ietf.org/html/rfc6749#section-4.4.2
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        /// <param name="request">The token request <see cref="ClientCredentialsTokenRequest"/></param>
        /// <returns>The response containing access token.</returns>
        /// <privilege>http://tizen.org/privilege/internet</privilege>
        /// <exception cref="ArgumentException">Thrown when method failed due to invalid argumets</exception>
        /// <exception cref="OAuth2Exception">Thrown when method fails due to server error</exception>
        public  async Task<TokenResponse> GetAccessTokenAsync(TokenRequest request)
        {
            IntPtr requestHandle = GetRequestHandle(request as ClientCredentialsTokenRequest);
            return await Task.Run(() => GetAccessToken(requestHandle));
        }

        // Fill device request handle for access token
        private IntPtr GetRequestHandle(ClientCredentialsTokenRequest request)
        {
            if (request == null)
            {
                Log.Error(ErrorFactory.LogTag, "Invalid request or request is null");
                throw ErrorFactory.GetException((int)OAuth2Error.InvalidParameter);
            }

            IntPtr requestHandle;
            int ret = Interop.Request.Create(out requestHandle);
            if (ret != (int)OAuth2Error.None)
            {
                Log.Error(ErrorFactory.LogTag, "Interop failed");
                throw ErrorFactory.GetException(ret);
            }

            ret = Interop.Request.SetTokenEndPointUrl(requestHandle, request.TokenEndpoint.ToString());
            if (ret != (int)OAuth2Error.None)
            {
                Log.Error(ErrorFactory.LogTag, "Interop failed");
                throw ErrorFactory.GetException(ret);
            }

            ret = Interop.Request.SetRedirectionUrl(requestHandle, request.RedirectionEndPoint.ToString());
            if (ret != (int)OAuth2Error.None)
            {
                Log.Error(ErrorFactory.LogTag, "Interop failed");
                throw ErrorFactory.GetException(ret);
            }

            ret = Interop.Request.SetGrantType(requestHandle, Interop.GrantType.ClientCredentials);
            if (ret != (int)OAuth2Error.None)
            {
                Log.Error(ErrorFactory.LogTag, "Interop failed");
                throw ErrorFactory.GetException(ret);
            }

            if (request.ClientSecrets.Id != null)
            {
                ret = Interop.Request.SetClientId(requestHandle, request.ClientSecrets.Id);
                if (ret != (int)OAuth2Error.None)
                {
                    Log.Error(ErrorFactory.LogTag, "Interop failed");
                    throw ErrorFactory.GetException(ret);
                }
            }

            if (request.ClientSecrets.Secret != null)
            {
                ret = Interop.Request.SetClientSecret(requestHandle, request.ClientSecrets.Secret);
                if (ret != (int)OAuth2Error.None)
                {
                    Log.Error(ErrorFactory.LogTag, "Interop failed");
                    throw ErrorFactory.GetException(ret);
                }
            }

            if (request.Scopes != null)
            {
                string scope = string.Join(" ", request.Scopes);
                ret = Interop.Request.SetScope(requestHandle, scope);
                if (ret != (int)OAuth2Error.None)
                {
                    Log.Error(ErrorFactory.LogTag, "Interop failed");
                    throw ErrorFactory.GetException(ret);
                }
            }

            if (request.CustomData != null)
            {
                foreach (var item in request.CustomData)
                {
                    ret = Interop.Request.AddCustomData(requestHandle, item.Key, item.Value);
                    if (ret != (int)OAuth2Error.None)
                    {
                        Log.Error(ErrorFactory.LogTag, "Interop failed");
                        throw ErrorFactory.GetException(ret);
                    }
                }
            }

            ret = Interop.Request.SetClientAuthenticationType(requestHandle, (int) request.AuthenticationScheme);
            if (ret != (int)OAuth2Error.None)
            {
                Log.Error(ErrorFactory.LogTag, "Interop failed");
                throw ErrorFactory.GetException(ret);
            }

            return requestHandle;
        }
    }
}
