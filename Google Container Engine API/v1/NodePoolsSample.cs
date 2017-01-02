﻿// Copyright 2017 DAIMTO :  www.daimto.com
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
//     Template File Name:  Methodtemplate.tt
//     Build date: 01/02/2017 22:33:12
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the container v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Builds and manages clusters that run container-based applications, powered by open source Kubernetes technology.
// API Documentation Link https://cloud.google.com/container-engine/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/container/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.container.v1/ 
// Install Command: PM>  Install-Package Google.Apis.container.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.container.v1;
using Google.Apis.container.v1.Data;
using System;

namespace GoogleSamplecSharpSample.containerv1.Methods
{
  
    public static class NodePoolsSample
    {


        /// <summary>
        /// Lists the node pools for a cluster. 
        /// Documentation https://developers.google.com/container/v1/reference/nodePools/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated container service.</param>  
        /// <param name="projectId">The Google Developers Console [project ID or project number](https://developers.google.com/console/help/new/#projectnumber).</param>
        /// <param name="zone">The name of the Google Compute Engine [zone](/compute/docs/zones#available) in which the cluster resides.</param>
        /// <param name="clusterId">The name of the cluster.</param>
        /// <returns>ListNodePoolsResponseResponse</returns>
        public static ListNodePoolsResponse List(containerService service, string projectId, string zone, string clusterId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);
                if (zone == null)
                    throw new ArgumentNullException(zone);
                if (clusterId == null)
                    throw new ArgumentNullException(clusterId);

                // Make the request.
                return service.NodePools.List(projectId, zone, clusterId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request NodePools.List failed.", ex);
            }
        }


        /// <summary>
        /// Retrieves the node pool requested. 
        /// Documentation https://developers.google.com/container/v1/reference/nodePools/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated container service.</param>  
        /// <param name="projectId">The Google Developers Console [project ID or project number](https://developers.google.com/console/help/new/#projectnumber).</param>
        /// <param name="zone">The name of the Google Compute Engine [zone](/compute/docs/zones#available) in which the cluster resides.</param>
        /// <param name="clusterId">The name of the cluster.</param>
        /// <param name="nodePoolId">The name of the node pool.</param>
        /// <returns>NodePoolResponse</returns>
        public static NodePool Get(containerService service, string projectId, string zone, string clusterId, string nodePoolId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);
                if (zone == null)
                    throw new ArgumentNullException(zone);
                if (clusterId == null)
                    throw new ArgumentNullException(clusterId);
                if (nodePoolId == null)
                    throw new ArgumentNullException(nodePoolId);

                // Make the request.
                return service.NodePools.Get(projectId, zone, clusterId, nodePoolId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request NodePools.Get failed.", ex);
            }
        }


        /// <summary>
        /// Creates a node pool for a cluster. 
        /// Documentation https://developers.google.com/container/v1/reference/nodePools/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated container service.</param>  
        /// <param name="projectId">The Google Developers Console [project ID or project number](https://developers.google.com/console/help/new/#projectnumber).</param>
        /// <param name="zone">The name of the Google Compute Engine [zone](/compute/docs/zones#available) in which the cluster resides.</param>
        /// <param name="clusterId">The name of the cluster.</param>
        /// <param name="body">A valid container v1 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Create(containerService service, string projectId, string zone, string clusterId, CreateNodePoolRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);
                if (zone == null)
                    throw new ArgumentNullException(zone);
                if (clusterId == null)
                    throw new ArgumentNullException(clusterId);

                // Make the request.
                return service.NodePools.Create(body, projectId, zone, clusterId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request NodePools.Create failed.", ex);
            }
        }


        /// <summary>
        /// Deletes a node pool from a cluster. 
        /// Documentation https://developers.google.com/container/v1/reference/nodePools/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated container service.</param>  
        /// <param name="projectId">The Google Developers Console [project ID or project number](https://developers.google.com/console/help/new/#projectnumber).</param>
        /// <param name="zone">The name of the Google Compute Engine [zone](/compute/docs/zones#available) in which the cluster resides.</param>
        /// <param name="clusterId">The name of the cluster.</param>
        /// <param name="nodePoolId">The name of the node pool to delete.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Delete(containerService service, string projectId, string zone, string clusterId, string nodePoolId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);
                if (zone == null)
                    throw new ArgumentNullException(zone);
                if (clusterId == null)
                    throw new ArgumentNullException(clusterId);
                if (nodePoolId == null)
                    throw new ArgumentNullException(nodePoolId);

                // Make the request.
                return service.NodePools.Delete(projectId, zone, clusterId, nodePoolId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request NodePools.Delete failed.", ex);
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