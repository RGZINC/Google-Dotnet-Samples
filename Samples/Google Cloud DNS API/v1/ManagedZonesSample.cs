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
// Unoffical sample for the Dns v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Configures and serves authoritative DNS records.
// API Documentation Link https://developers.google.com/cloud-dns
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Dns/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Dns.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Dns.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Dns.v1;
using Google.Apis.Dns.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Dnsv1.Methods
{
  
    public static class ManagedZonesSample
    {


        /// <summary>
        /// Create a new ManagedZone. 
        /// Documentation https://developers.google.com/dns/v1/reference/managedZones/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dns service.</param>  
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="body">A valid Dns v1 body.</param>
        /// <returns>ManagedZoneResponse</returns>
        public static ManagedZone Create(DnsService service, string project, ManagedZone body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);

                // Make the request.
                return service.ManagedZones.Create(body, project).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ManagedZones.Create failed.", ex);
            }
        }

        /// <summary>
        /// Delete a previously created ManagedZone. 
        /// Documentation https://developers.google.com/dns/v1/reference/managedZones/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dns service.</param>  
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="managedZone">Identifies the managed zone addressed by this request. Can be the managed zone name or id.</param>
        public static void Delete(DnsService service, string project, string managedZone)
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

                // Make the request.
                 service.ManagedZones.Delete(project, managedZone).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ManagedZones.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Fetch the representation of an existing ManagedZone. 
        /// Documentation https://developers.google.com/dns/v1/reference/managedZones/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dns service.</param>  
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="managedZone">Identifies the managed zone addressed by this request. Can be the managed zone name or id.</param>
        /// <returns>ManagedZoneResponse</returns>
        public static ManagedZone Get(DnsService service, string project, string managedZone)
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

                // Make the request.
                return service.ManagedZones.Get(project, managedZone).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ManagedZones.Get failed.", ex);
            }
        }
        public class ManagedZonesListOptionalParms
        {
            /// Restricts the list to return only zones with this domain name.
            public string DnsName { get; set; }  
            /// Optional. Maximum number of results to be returned. If unspecified, the server will decide how many results to return.
            public int? MaxResults { get; set; }  
            /// Optional. A tag returned by a previous list request that was truncated. Use this parameter to continue a previous list request.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Enumerate ManagedZones that have been created but not yet deleted. 
        /// Documentation https://developers.google.com/dns/v1/reference/managedZones/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Dns service.</param>  
        /// <param name="project">Identifies the project addressed by this request.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ManagedZonesListResponseResponse</returns>
        public static ManagedZonesListResponse List(DnsService service, string project, ManagedZonesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);

                // Building the initial request.
                var request = service.ManagedZones.List(project);

                // Applying optional parameters to the request.                
                request = (ManagedZonesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ManagedZones.List failed.", ex);
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