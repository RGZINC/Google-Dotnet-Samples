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
// Unoffical sample for the Cloudresourcemanager v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: The Google Cloud Resource Manager API provides methods for creating, reading, and updating project metadata.
// API Documentation Link https://cloud.google.com/resource-manager
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Cloudresourcemanager/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Cloudresourcemanager.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Cloudresourcemanager.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Cloudresourcemanager.v1;
using Google.Apis.Cloudresourcemanager.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Cloudresourcemanagerv1.Methods
{
  
    public static class LiensSample
    {


        /// <summary>
        /// Delete a Lien by `name`.Callers of this method will require permission on the `parent` resource.For example, a Lien with a `parent` of `projects/1234` requires permission`resourcemanager.projects.updateLiens`. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/liens/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="name">The name/identifier of the Lien to delete.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Delete(CloudresourcemanagerService service, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.Liens.Delete(name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Liens.Delete failed.", ex);
            }
        }
        public class LiensListOptionalParms
        {
            /// The `next_page_token` value returned from a previous List request, if any.
            public string PageToken { get; set; }  
            /// The maximum number of items to return. This is a suggestion for the server.
            public int? PageSize { get; set; }  
            /// The name of the resource to list all attached Liens.For example, `projects/1234`.
            public string Parent { get; set; }  
        
        }
 
        /// <summary>
        /// List all Liens applied to the `parent` resource.Callers of this method will require permission on the `parent` resource.For example, a Lien with a `parent` of `projects/1234` requires permission`resourcemanager.projects.get`. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/liens/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ListLiensResponseResponse</returns>
        public static ListLiensResponse List(CloudresourcemanagerService service, LiensListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Liens.List();

                // Applying optional parameters to the request.                
                request = (LiensResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Liens.List failed.", ex);
            }
        }

        /// <summary>
        /// Create a Lien which applies to the resource denoted by the `parent` field.Callers of this method will require permission on the `parent` resource.For example, applying to `projects/1234` requires permission`resourcemanager.projects.updateLiens`.NOTE: Some resources may limit the number of Liens which may be applied. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/liens/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="body">A valid Cloudresourcemanager v1 body.</param>
        /// <returns>LienResponse</returns>
        public static Lien Create(CloudresourcemanagerService service, Lien body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Liens.Create(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Liens.Create failed.", ex);
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