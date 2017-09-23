﻿// Copyright 2017 DAIMTO ([Linda Lawton](https://twitter.com/LindaLawtonDK)) :  [www.daimto.com](http://www.daimto.com/)
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by DAIMTO-Google-apis-Sample-generator 1.0.0
//     Template File Name:  methodTemplate.tt
//     Build date: 2017-09-23
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Partners v2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Searches certified companies and creates contact leads with them, and also audits the usage of clients.
// API Documentation Link https://developers.google.com/partners/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Partners/v2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Partners.v2/ 
// Install Command: PM>  Install-Package Google.Apis.Partners.v2
//
//------------------------------------------------------------------------------  
using Google.Apis.Partners.v2;
using Google.Apis.Partners.v2.Data;
using System;

namespace GoogleSamplecSharpSample.Partnersv2.Methods
{
  
    public static class UsersSample
    {

        public class UsersDeleteCompanyRelationOptionalParms
        {
            /// Logged-in user ID to impersonate instead of the user's ID.
            public string RequestMetadata.userOverrides.userId { get; set; }  
            /// Google Partners session ID.
            public string RequestMetadata.partnersSessionId { get; set; }  
            /// Identifier to indicate where the traffic comes from.An identifier has multiple letters created by a team which redirected thetraffic to us.
            public string RequestMetadata.trafficSource.trafficSourceId { get; set; }  
            /// Locale to use for the current request.
            public string RequestMetadata.locale { get; set; }  
            /// IP address to use instead of the user's geo-located IP address.
            public string RequestMetadata.userOverrides.ipAddress { get; set; }  
            /// Experiment IDs the current request belongs to.
            public string RequestMetadata.experimentIds { get; set; }  
            /// Second level identifier to indicate where the traffic comes from.An identifier has multiple letters created by a team which redirected thetraffic to us.
            public string RequestMetadata.trafficSource.trafficSubId { get; set; }  
        
        }
 
        /// <summary>
        /// Deletes a user's company relation. Unaffiliaites the user from a company. 
        /// Documentation https://developers.google.com/partners/v2/reference/users/deleteCompanyRelation
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Partners service.</param>  
        /// <param name="userId">The ID of the user. Can be set to <code>me</code> to meanthe currently authenticated user.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty DeleteCompanyRelation(PartnersService service, string userId, UsersDeleteCompanyRelationOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (userId == null)
                    throw new ArgumentNullException(userId);

                // Building the initial request.
                var request = service.Users.DeleteCompanyRelation(userId);

                // Applying optional parameters to the request.                
                request = (UsersResource.DeleteCompanyRelationRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.DeleteCompanyRelation failed.", ex);
            }
        }
        public class UsersCreateCompanyRelationOptionalParms
        {
            /// Experiment IDs the current request belongs to.
            public string RequestMetadata.experimentIds { get; set; }  
            /// Second level identifier to indicate where the traffic comes from.An identifier has multiple letters created by a team which redirected thetraffic to us.
            public string RequestMetadata.trafficSource.trafficSubId { get; set; }  
            /// Google Partners session ID.
            public string RequestMetadata.partnersSessionId { get; set; }  
            /// Logged-in user ID to impersonate instead of the user's ID.
            public string RequestMetadata.userOverrides.userId { get; set; }  
            /// Identifier to indicate where the traffic comes from.An identifier has multiple letters created by a team which redirected thetraffic to us.
            public string RequestMetadata.trafficSource.trafficSourceId { get; set; }  
            /// Locale to use for the current request.
            public string RequestMetadata.locale { get; set; }  
            /// IP address to use instead of the user's geo-located IP address.
            public string RequestMetadata.userOverrides.ipAddress { get; set; }  
        
        }
 
        /// <summary>
        /// Creates a user's company relation. Affiliates the user to a company. 
        /// Documentation https://developers.google.com/partners/v2/reference/users/createCompanyRelation
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Partners service.</param>  
        /// <param name="userId">The ID of the user. Can be set to <code>me</code> to meanthe currently authenticated user.</param>
        /// <param name="body">A valid Partners v2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>CompanyRelationResponse</returns>
        public static CompanyRelation CreateCompanyRelation(PartnersService service, string userId, CompanyRelation body, UsersCreateCompanyRelationOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (userId == null)
                    throw new ArgumentNullException(userId);

                // Building the initial request.
                var request = service.Users.CreateCompanyRelation(body, userId);

                // Applying optional parameters to the request.                
                request = (UsersResource.CreateCompanyRelationRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.CreateCompanyRelation failed.", ex);
            }
        }
        public class UsersGetOptionalParms
        {
            /// Specifies what parts of the user information to return.
            public string UserView { get; set; }  
            /// Identifier to indicate where the traffic comes from.An identifier has multiple letters created by a team which redirected thetraffic to us.
            public string RequestMetadata.trafficSource.trafficSourceId { get; set; }  
            /// Locale to use for the current request.
            public string RequestMetadata.locale { get; set; }  
            /// IP address to use instead of the user's geo-located IP address.
            public string RequestMetadata.userOverrides.ipAddress { get; set; }  
            /// Experiment IDs the current request belongs to.
            public string RequestMetadata.experimentIds { get; set; }  
            /// Second level identifier to indicate where the traffic comes from.An identifier has multiple letters created by a team which redirected thetraffic to us.
            public string RequestMetadata.trafficSource.trafficSubId { get; set; }  
            /// Logged-in user ID to impersonate instead of the user's ID.
            public string RequestMetadata.userOverrides.userId { get; set; }  
            /// Google Partners session ID.
            public string RequestMetadata.partnersSessionId { get; set; }  
        
        }
 
        /// <summary>
        /// Gets a user. 
        /// Documentation https://developers.google.com/partners/v2/reference/users/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Partners service.</param>  
        /// <param name="userId">Identifier of the user. Can be set to <code>me</code> to mean the currentlyauthenticated user.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>UserResponse</returns>
        public static User Get(PartnersService service, string userId, UsersGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (userId == null)
                    throw new ArgumentNullException(userId);

                // Building the initial request.
                var request = service.Users.Get(userId);

                // Applying optional parameters to the request.                
                request = (UsersResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.Get failed.", ex);
            }
        }
        public class UsersUpdateProfileOptionalParms
        {
            /// Logged-in user ID to impersonate instead of the user's ID.
            public string RequestMetadata.userOverrides.userId { get; set; }  
            /// Google Partners session ID.
            public string RequestMetadata.partnersSessionId { get; set; }  
            /// Identifier to indicate where the traffic comes from.An identifier has multiple letters created by a team which redirected thetraffic to us.
            public string RequestMetadata.trafficSource.trafficSourceId { get; set; }  
            /// Locale to use for the current request.
            public string RequestMetadata.locale { get; set; }  
            /// IP address to use instead of the user's geo-located IP address.
            public string RequestMetadata.userOverrides.ipAddress { get; set; }  
            /// Experiment IDs the current request belongs to.
            public string RequestMetadata.experimentIds { get; set; }  
            /// Second level identifier to indicate where the traffic comes from.An identifier has multiple letters created by a team which redirected thetraffic to us.
            public string RequestMetadata.trafficSource.trafficSubId { get; set; }  
        
        }
 
        /// <summary>
        /// Updates a user's profile. A user can only update their own profile andshould only be called within the context of a logged in user. 
        /// Documentation https://developers.google.com/partners/v2/reference/users/updateProfile
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Partners service.</param>  
        /// <param name="body">A valid Partners v2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>UserProfileResponse</returns>
        public static UserProfile UpdateProfile(PartnersService service, UserProfile body, UsersUpdateProfileOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Building the initial request.
                var request = service.Users.UpdateProfile(body);

                // Applying optional parameters to the request.                
                request = (UsersResource.UpdateProfileRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Users.UpdateProfile failed.", ex);
            }
        }
        
        }

        public static class SampleHelpers
        {

        /// <summary>
        /// Using reflection to apply optional parameters to the request.  
        /// 
        /// If the optonal parameters are null then we will just return the request as is.
        /// </summary>
        /// <param name="request">The request. </param>
        /// <param name="optional">The optional parameters. </param>
        /// <returns></returns>
        public static object ApplyOptionalParms(object request, object optional)
        {
            if (optional == null)
                return request;

            System.Reflection.PropertyInfo[] optionalProperties = (optional.GetType()).GetProperties();

            foreach (System.Reflection.PropertyInfo property in optionalProperties)
            {
                // Copy value from optional parms to the request.  They should have the same names and datatypes.
                System.Reflection.PropertyInfo piShared = (request.GetType()).GetProperty(property.Name);
				if (property.GetValue(optional, null) != null) // TODO Test that we do not add values for items that are null
					piShared.SetValue(request, property.GetValue(optional, null), null);
            }

            return request;
        }
    }
}