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
// Unoffical sample for the Dns v2beta1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Configures and serves authoritative DNS records.
// API Documentation Link https://developers.google.com/cloud-dns
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Dns/v2beta1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Dns.v2beta1/ 
// Install Command: PM>  Install-Package Google.Apis.Dns.v2beta1
//
//------------------------------------------------------------------------------  
using Google.Apis.Dns.v2beta1;
using Google.Apis.Dns.v2beta1.Data;
using System;

namespace GoogleSamplecSharpSample.Dnsv2beta1.Methods
{
  
    public static class ManagedZoneOperationsSample
    {

        public class ManagedZoneOperationsGetOptionalParms
        {
            /// For mutating operation requests only. An optional identifier specified by the client. Must be unique for operation resources in the Operations collection.
            public string ClientOperationId { get; set; }  
        
        }
 
        /// <summary>
        /// Fetch the representation of an existing Operation. 
        /// Documentation https://developers.google.com/dns/v2beta1/reference/managedZoneOperations/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dns service.</param>  
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="managedZone">Identifies the managed zone addressed by this request.</param>
        /// <param name="operation">Identifies the operation addressed by this request.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Get(DnsService service, string project, string managedZone, string operation, ManagedZoneOperationsGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (managedZone == null)
                    throw new ArgumentNullException(managedZone);
                if (operation == null)
                    throw new ArgumentNullException(operation);

                // Building the initial request.
                var request = service.ManagedZoneOperations.Get(project, managedZone, operation);

                // Applying optional parameters to the request.                
                request = (ManagedZoneOperationsResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ManagedZoneOperations.Get failed.", ex);
            }
        }
        public class ManagedZoneOperationsListOptionalParms
        {
            /// Optional. Maximum number of results to be returned. If unspecified, the server will decide how many results to return.
            public int? MaxResults { get; set; }  
            /// Optional. A tag returned by a previous list request that was truncated. Use this parameter to continue a previous list request.
            public string PageToken { get; set; }  
            /// Sorting criterion. The only supported values are START_TIME and ID.
            public string SortBy { get; set; }  
        
        }
 
        /// <summary>
        /// Enumerate Operations for the given ManagedZone. 
        /// Documentation https://developers.google.com/dns/v2beta1/reference/managedZoneOperations/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dns service.</param>  
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="managedZone">Identifies the managed zone addressed by this request.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ManagedZoneOperationsListResponseResponse</returns>
        public static ManagedZoneOperationsListResponse List(DnsService service, string project, string managedZone, ManagedZoneOperationsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (managedZone == null)
                    throw new ArgumentNullException(managedZone);

                // Building the initial request.
                var request = service.ManagedZoneOperations.List(project, managedZone);

                // Applying optional parameters to the request.                
                request = (ManagedZoneOperationsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ManagedZoneOperations.List failed.", ex);
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