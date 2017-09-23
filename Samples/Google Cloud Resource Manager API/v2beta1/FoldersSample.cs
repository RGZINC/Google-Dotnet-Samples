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
// Unoffical sample for the Cloudresourcemanager v2beta1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: The Google Cloud Resource Manager API provides methods for creating, reading, and updating project metadata.
// API Documentation Link https://cloud.google.com/resource-manager
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Cloudresourcemanager/v2beta1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Cloudresourcemanager.v2beta1/ 
// Install Command: PM>  Install-Package Google.Apis.Cloudresourcemanager.v2beta1
//
//------------------------------------------------------------------------------  
using Google.Apis.Cloudresourcemanager.v2beta1;
using Google.Apis.Cloudresourcemanager.v2beta1.Data;
using System;

namespace GoogleSamplecSharpSample.Cloudresourcemanagerv2beta1.Methods
{
  
    public static class FoldersSample
    {


        /// <summary>
        /// Gets the access control policy for a Folder. The returned policy may beempty if no such policy or resource exists. The `resource` field shouldbe the Folder's resource name, e.g. "folders/1234".The caller must have `resourcemanager.folders.getIamPolicy` permissionon the identified folder. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v2beta1/reference/folders/getIamPolicy
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="resource">REQUIRED: The resource for which the policy is being requested.See the operation documentation for the appropriate value for this field.</param>
        /// <param name="body">A valid Cloudresourcemanager v2beta1 body.</param>
        /// <returns>PolicyResponse</returns>
        public static Policy GetIamPolicy(CloudresourcemanagerService service, string resource, GetIamPolicyRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Make the request.
                return service.Folders.GetIamPolicy(body, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Folders.GetIamPolicy failed.", ex);
            }
        }

        /// <summary>
        /// Search for folders that match specific filter criteria.Search provides an eventually consistent view of the folders a user hasaccess to which meet the specified filter criteria.This will only return folders on which the caller has thepermission `resourcemanager.folders.get`. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v2beta1/reference/folders/search
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="body">A valid Cloudresourcemanager v2beta1 body.</param>
        /// <returns>SearchFoldersResponseResponse</returns>
        public static SearchFoldersResponse Search(CloudresourcemanagerService service, SearchFoldersRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Folders.Search(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Folders.Search failed.", ex);
            }
        }
        public class FoldersPatchOptionalParms
        {
            /// Fields to be updated.Only the `display_name` can be updated.
            public string UpdateMask { get; set; }  
        
        }
 
        /// <summary>
        /// Updates a Folder, changing its display_name.Changes to the folder display_name will be rejected if they violate eitherthe display_name formatting rules or naming constraints described inthe [CreateFolder] documentation.+ The Folder's display name must start and end with a letter or digit,may contain letters, digits, spaces, hyphens and underscores and can beno longer than 30 characters. This is captured by the regular expression:[\p{L}\p{N}]({\p{L}\p{N}_- ]{0,28}[\p{L}\p{N}])?.The caller must have `resourcemanager.folders.update` permission on theidentified folder.If the update fails due to the unique name constraint then aPreconditionFailure explaining this violation will be returnedin the Status.details field. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v2beta1/reference/folders/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="name">Output only. The resource name of the Folder.Its format is `folders/{folder_id}`, for example: "folders/1234".</param>
        /// <param name="body">A valid Cloudresourcemanager v2beta1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>FolderResponse</returns>
        public static Folder Patch(CloudresourcemanagerService service, string name, Folder body, FoldersPatchOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Building the initial request.
                var request = service.Folders.Patch(body, name);

                // Applying optional parameters to the request.                
                request = (FoldersResource.PatchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Folders.Patch failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves a Folder identified by the supplied resource name.Valid Folder resource names have the format `folders/{folder_id}`(for example, `folders/1234`).The caller must have `resourcemanager.folders.get` permission on theidentified folder. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v2beta1/reference/folders/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="name">The resource name of the Folder to retrieve.Must be of the form `folders/{folder_id}`.</param>
        /// <returns>FolderResponse</returns>
        public static Folder Get(CloudresourcemanagerService service, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.Folders.Get(name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Folders.Get failed.", ex);
            }
        }

        /// <summary>
        /// Cancels the deletion request for a Folder. This method may only becalled on a Folder in the [DELETE_REQUESTED] state.In order to succeed, the Folder's parent must be in the [ACTIVE] state.In addition, reintroducing the folder into the tree must not violatefolder naming, height and fanout constraints described in the[CreateFolder] documentation.The caller must have `resourcemanager.folders.undelete` permission on theidentified folder. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v2beta1/reference/folders/undelete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="name">The resource name of the Folder to undelete.Must be of the form `folders/{folder_id}`.</param>
        /// <param name="body">A valid Cloudresourcemanager v2beta1 body.</param>
        /// <returns>FolderResponse</returns>
        public static Folder Undelete(CloudresourcemanagerService service, string name, UndeleteFolderRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.Folders.Undelete(body, name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Folders.Undelete failed.", ex);
            }
        }

        /// <summary>
        /// Moves a Folder under a new resource parent.Returns an Operation which can be used to track the progress of thefolder move workflow.Upon success the Operation.response field will be populated with themoved Folder.Upon failure, a FolderOperationError categorizing the failure cause willbe returned - if the failure occurs synchronously then theFolderOperationError will be returned via the Status.details fieldand if it occurs asynchronously then the FolderOperation will be returnedvia the the Operation.error field.In addition, the Operation.metadata field will be populated with aFolderOperation message as an aid to stateless clients.Folder moves will be rejected if they violate either the naming, heightor fanout constraints described in the [CreateFolder] documentation.The caller must have `resourcemanager.folders.move` permission on thefolder's current and proposed new parent. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v2beta1/reference/folders/move
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="name">The resource name of the Folder to move.Must be of the form folders/{folder_id}</param>
        /// <param name="body">A valid Cloudresourcemanager v2beta1 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Move(CloudresourcemanagerService service, string name, MoveFolderRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.Folders.Move(body, name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Folders.Move failed.", ex);
            }
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified Folder.The `resource` field should be the Folder's resource name,e.g. "folders/1234".There are no permissions required for making this API call. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v2beta1/reference/folders/testIamPermissions
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="resource">REQUIRED: The resource for which the policy detail is being requested.See the operation documentation for the appropriate value for this field.</param>
        /// <param name="body">A valid Cloudresourcemanager v2beta1 body.</param>
        /// <returns>TestIamPermissionsResponseResponse</returns>
        public static TestIamPermissionsResponse TestIamPermissions(CloudresourcemanagerService service, string resource, TestIamPermissionsRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Make the request.
                return service.Folders.TestIamPermissions(body, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Folders.TestIamPermissions failed.", ex);
            }
        }

        /// <summary>
        /// Requests deletion of a Folder. The Folder is moved into the[DELETE_REQUESTED] state immediately, and is deleted approximately 30 dayslater. This method may only be called on an empty Folder in the [ACTIVE]state, where a Folder is empty if it doesn't contain any Folders orProjects in the [ACTIVE] state.The caller must have `resourcemanager.folders.delete` permission on theidentified folder. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v2beta1/reference/folders/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="name">the resource name of the Folder to be deleted.Must be of the form `folders/{folder_id}`.</param>
        /// <returns>FolderResponse</returns>
        public static Folder Delete(CloudresourcemanagerService service, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.Folders.Delete(name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Folders.Delete failed.", ex);
            }
        }
        public class FoldersListOptionalParms
        {
            /// The resource name of the Organization or Folder whose Folders arebeing listed.Must be of the form `folders/{folder_id}` or `organizations/{org_id}`.Access to this method is controlled by checking the`resourcemanager.folders.list` permission on the `parent`.
            public string Parent { get; set; }  
            /// Controls whether Folders in the [DELETE_REQUESTED} state shouldbe returned.
            public bool? ShowDeleted { get; set; }  
            /// A pagination token returned from a previous call to `ListFolders`that indicates where this listing should continue from.This field is optional.
            public string PageToken { get; set; }  
            /// The maximum number of Folders to return in the response.This field is optional.
            public int? PageSize { get; set; }  
        
        }
 
        /// <summary>
        /// Lists the Folders that are direct descendants of supplied parent resource.List provides a strongly consistent view of the Folders underneaththe specified parent resource.List returns Folders sorted based upon the (ascending) lexical orderingof their display_name.The caller must have `resourcemanager.folders.list` permission on theidentified parent. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v2beta1/reference/folders/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ListFoldersResponseResponse</returns>
        public static ListFoldersResponse List(CloudresourcemanagerService service, FoldersListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Folders.List();

                // Applying optional parameters to the request.                
                request = (FoldersResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Folders.List failed.", ex);
            }
        }
        public class FoldersCreateOptionalParms
        {
            /// The resource name of the new Folder's parent.Must be of the form `folders/{folder_id}` or `organizations/{org_id}`.
            public string Parent { get; set; }  
        
        }
 
        /// <summary>
        /// Creates a Folder in the resource hierarchy.Returns an Operation which can be used to track the progress of thefolder creation workflow.Upon success the Operation.response field will be populated with thecreated Folder.In order to succeed, the addition of this new Folder must not violatethe Folder naming, height or fanout constraints.+ The Folder's display_name must be distinct from all other Folder's thatshare its parent.+ The addition of the Folder must not cause the active Folder hierarchyto exceed a height of 4. Note, the full active + deleted Folder hierarchyis allowed to reach a height of 8; this provides additional headroom whenmoving folders that contain deleted folders.+ The addition of the Folder must not cause the total number of Foldersunder its parent to exceed 100.If the operation fails due to a folder constraint violation,a PreconditionFailure explaining the violation will be returned.If the failure occurs synchronously then the PreconditionFailurewill be returned via the Status.details field and if it occursasynchronously then the PreconditionFailure will be returnedvia the the Operation.error field.The caller must have `resourcemanager.folders.create` permission on theidentified parent. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v2beta1/reference/folders/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="body">A valid Cloudresourcemanager v2beta1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Create(CloudresourcemanagerService service, Folder body, FoldersCreateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Building the initial request.
                var request = service.Folders.Create(body);

                // Applying optional parameters to the request.                
                request = (FoldersResource.CreateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Folders.Create failed.", ex);
            }
        }

        /// <summary>
        /// Sets the access control policy on a Folder, replacing any existing policy.The `resource` field should be the Folder's resource name, e.g."folders/1234".The caller must have `resourcemanager.folders.setIamPolicy` permissionon the identified folder. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v2beta1/reference/folders/setIamPolicy
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="resource">REQUIRED: The resource for which the policy is being specified.See the operation documentation for the appropriate value for this field.</param>
        /// <param name="body">A valid Cloudresourcemanager v2beta1 body.</param>
        /// <returns>PolicyResponse</returns>
        public static Policy SetIamPolicy(CloudresourcemanagerService service, string resource, SetIamPolicyRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Make the request.
                return service.Folders.SetIamPolicy(body, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Folders.SetIamPolicy failed.", ex);
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