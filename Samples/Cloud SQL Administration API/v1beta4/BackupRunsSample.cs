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
// Unoffical sample for the Sqladmin v1beta4 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Creates and configures Cloud SQL instances, which provide fully-managed MySQL databases.
// API Documentation Link https://cloud.google.com/sql/docs/reference/latest
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Sqladmin/v1beta4/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Sqladmin.v1beta4/ 
// Install Command: PM>  Install-Package Google.Apis.Sqladmin.v1beta4
//
//------------------------------------------------------------------------------  
using Google.Apis.Sqladmin.v1beta4;
using Google.Apis.Sqladmin.v1beta4.Data;
using System;

namespace GoogleSamplecSharpSample.Sqladminv1beta4.Methods
{
  
    public static class BackupRunsSample
    {


        /// <summary>
        /// Deletes the backup taken by a backup run. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/backupRuns/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        /// <param name="id">The ID of the Backup Run to delete. To find a Backup Run ID, use the list method.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Delete(SqladminService service, string project, string instance, string id)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (instance == null)
                    throw new ArgumentNullException(instance);
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                return service.BackupRuns.Delete(project, instance, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request BackupRuns.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves a resource containing information about a backup run. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/backupRuns/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        /// <param name="id">The ID of this Backup Run.</param>
        /// <returns>BackupRunResponse</returns>
        public static BackupRun Get(SqladminService service, string project, string instance, string id)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (instance == null)
                    throw new ArgumentNullException(instance);
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                return service.BackupRuns.Get(project, instance, id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request BackupRuns.Get failed.", ex);
            }
        }

        /// <summary>
        /// Creates a new backup run on demand. This method is applicable only to Second Generation instances. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/backupRuns/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        /// <param name="body">A valid Sqladmin v1beta4 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Insert(SqladminService service, string project, string instance, BackupRun body)
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
                if (instance == null)
                    throw new ArgumentNullException(instance);

                // Make the request.
                return service.BackupRuns.Insert(body, project, instance).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request BackupRuns.Insert failed.", ex);
            }
        }
        public class BackupRunsListOptionalParms
        {
            /// Maximum number of backup runs per response.
            public int? MaxResults { get; set; }  
            /// A previously-returned page token representing part of the larger set of results to view.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Lists all backup runs associated with a given instance and configuration in the reverse chronological order of the enqueued time. 
        /// Documentation https://developers.google.com/sqladmin/v1beta4/reference/backupRuns/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Sqladmin service.</param>  
        /// <param name="project">Project ID of the project that contains the instance.</param>
        /// <param name="instance">Cloud SQL instance ID. This does not include the project ID.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>BackupRunsListResponseResponse</returns>
        public static BackupRunsListResponse List(SqladminService service, string project, string instance, BackupRunsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (instance == null)
                    throw new ArgumentNullException(instance);

                // Building the initial request.
                var request = service.BackupRuns.List(project, instance);

                // Applying optional parameters to the request.                
                request = (BackupRunsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request BackupRuns.List failed.", ex);
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