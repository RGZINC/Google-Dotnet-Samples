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
// Unoffical sample for the Drive v2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages files in Drive including uploading, downloading, searching, detecting changes, and updating sharing permissions.
// API Documentation Link https://developers.google.com/drive/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Drive/v2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Drive.v2/ 
// Install Command: PM>  Install-Package Google.Apis.Drive.v2
//
//------------------------------------------------------------------------------  
using Google.Apis.Drive.v2;
using Google.Apis.Drive.v2.Data;
using System;

namespace GoogleSamplecSharpSample.Drivev2.Methods
{
  
    public static class FilesSample
    {

        public class FilesCopyOptionalParms
        {
            /// Whether to convert this file to the corresponding Google Docs format.
            public bool? Convert { get; set; }  
            /// Whether to attempt OCR on .jpg, .png, .gif, or .pdf uploads.
            public bool? Ocr { get; set; }  
            /// If ocr is true, hints at the language to use. Valid values are BCP 47 codes.
            public string OcrLanguage { get; set; }  
            /// Whether to pin the head revision of the new copy. A file can have a maximum of 200 pinned revisions.
            public bool? Pinned { get; set; }  
            /// Whether the requesting application supports Team Drives.
            public bool? SupportsTeamDrives { get; set; }  
            /// The language of the timed text.
            public string TimedTextLanguage { get; set; }  
            /// The timed text track name.
            public string TimedTextTrackName { get; set; }  
            /// The visibility of the new file. This parameter is only relevant when the source is not a native Google Doc and convert=false.
            public string Visibility { get; set; }  
        
        }
 
        /// <summary>
        /// Creates a copy of the specified file. 
        /// Documentation https://developers.google.com/drive/v2/reference/files/copy
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID of the file to copy.</param>
        /// <param name="body">A valid Drive v2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>FileResponse</returns>
        public static File Copy(DriveService service, string fileId, File body, FilesCopyOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);

                // Building the initial request.
                var request = service.Files.Copy(body, fileId);

                // Applying optional parameters to the request.                
                request = (FilesResource.CopyRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Files.Copy failed.", ex);
            }
        }
        public class FilesDeleteOptionalParms
        {
            /// Whether the requesting application supports Team Drives.
            public bool? SupportsTeamDrives { get; set; }  
        
        }
 
        /// <summary>
        /// Permanently deletes a file by ID. Skips the trash. The currently authenticated user must own the file or be an organizer on the parent for Team Drive files. 
        /// Documentation https://developers.google.com/drive/v2/reference/files/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID of the file to delete.</param>
        /// <param name="optional">Optional paramaters.</param>
        public static void Delete(DriveService service, string fileId, FilesDeleteOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);

                // Building the initial request.
                var request = service.Files.Delete(fileId);

                // Applying optional parameters to the request.                
                request = (FilesResource.DeleteRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                 request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Files.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Permanently deletes all of the user's trashed files. 
        /// Documentation https://developers.google.com/drive/v2/reference/files/emptyTrash
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        public static void EmptyTrash(DriveService service)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Make the request.
                 service.Files.EmptyTrash().Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Files.EmptyTrash failed.", ex);
            }
        }

        /// <summary>
        /// Exports a Google Doc to the requested MIME type and returns the exported content. Please note that the exported content is limited to 10MB. 
        /// Documentation https://developers.google.com/drive/v2/reference/files/export
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="mimeType">The MIME type of the format requested for this export.</param>
        public static void Export(DriveService service, string fileId, string mimeType)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);
                if (mimeType == null)
                    throw new ArgumentNullException(mimeType);

                // Make the request.
                 service.Files.Export(fileId, mimeType).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Files.Export failed.", ex);
            }
        }
        public class FilesGenerateIdsOptionalParms
        {
            /// Maximum number of IDs to return.
            public int? MaxResults { get; set; }  
            /// The space in which the IDs can be used to create new files. Supported values are 'drive' and 'appDataFolder'.
            public string Space { get; set; }  
        
        }
 
        /// <summary>
        /// Generates a set of file IDs which can be provided in insert requests. 
        /// Documentation https://developers.google.com/drive/v2/reference/files/generateIds
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>GeneratedIdsResponse</returns>
        public static GeneratedIds GenerateIds(DriveService service, FilesGenerateIdsOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Files.GenerateIds();

                // Applying optional parameters to the request.                
                request = (FilesResource.GenerateIdsRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Files.GenerateIds failed.", ex);
            }
        }
        public class FilesGetOptionalParms
        {
            /// Whether the user is acknowledging the risk of downloading known malware or other abusive files.
            public bool? AcknowledgeAbuse { get; set; }  
            /// This parameter is deprecated and has no function.
            public string Projection { get; set; }  
            /// Specifies the Revision ID that should be downloaded. Ignored unless alt=media is specified.
            public string RevisionId { get; set; }  
            /// Whether the requesting application supports Team Drives.
            public bool? SupportsTeamDrives { get; set; }  
            /// Deprecated: Use files.update with modifiedDateBehavior=noChange, updateViewedDate=true and an empty request body.
            public bool? UpdateViewedDate { get; set; }  
        
        }
 
        /// <summary>
        /// Gets a file's metadata by ID. 
        /// Documentation https://developers.google.com/drive/v2/reference/files/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID for the file in question.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>FileResponse</returns>
        public static File Get(DriveService service, string fileId, FilesGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);

                // Building the initial request.
                var request = service.Files.Get(fileId);

                // Applying optional parameters to the request.                
                request = (FilesResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Files.Get failed.", ex);
            }
        }
        public class FilesInsertOptionalParms
        {
            /// Whether to convert this file to the corresponding Google Docs format.
            public bool? Convert { get; set; }  
            /// Whether to attempt OCR on .jpg, .png, .gif, or .pdf uploads.
            public bool? Ocr { get; set; }  
            /// If ocr is true, hints at the language to use. Valid values are BCP 47 codes.
            public string OcrLanguage { get; set; }  
            /// Whether to pin the head revision of the uploaded file. A file can have a maximum of 200 pinned revisions.
            public bool? Pinned { get; set; }  
            /// Whether the requesting application supports Team Drives.
            public bool? SupportsTeamDrives { get; set; }  
            /// The language of the timed text.
            public string TimedTextLanguage { get; set; }  
            /// The timed text track name.
            public string TimedTextTrackName { get; set; }  
            /// Whether to use the content as indexable text.
            public bool? UseContentAsIndexableText { get; set; }  
            /// The visibility of the new file. This parameter is only relevant when convert=false.
            public string Visibility { get; set; }  
        
        }
 
        /// <summary>
        /// Insert a new file. 
        /// Documentation https://developers.google.com/drive/v2/reference/files/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="body">A valid Drive v2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>FileResponse</returns>
        public static File Insert(DriveService service, File body, FilesInsertOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Building the initial request.
                var request = service.Files.Insert(body);

                // Applying optional parameters to the request.                
                request = (FilesResource.InsertRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Files.Insert failed.", ex);
            }
        }
        public class FilesListOptionalParms
        {
            /// Comma-separated list of bodies of items (files/documents) to which the query applies. Supported bodies are 'default', 'domain', 'teamDrive' and 'allTeamDrives'. 'allTeamDrives' must be combined with 'default'; all other values must be used in isolation. Prefer 'default' or 'teamDrive' to 'allTeamDrives' for efficiency.
            public string Corpora { get; set; }  
            /// The body of items (files/documents) to which the query applies. Deprecated: use 'corpora' instead.
            public string Corpus { get; set; }  
            /// Whether Team Drive items should be included in results.
            public bool? IncludeTeamDriveItems { get; set; }  
            /// The maximum number of files to return per page. Partial or empty result pages are possible even before the end of the files list has been reached.
            public int? MaxResults { get; set; }  
            /// A comma-separated list of sort keys. Valid keys are 'createdDate', 'folder', 'lastViewedByMeDate', 'modifiedByMeDate', 'modifiedDate', 'quotaBytesUsed', 'recency', 'sharedWithMeDate', 'starred', 'title', and 'title_natural'. Each key sorts ascending by default, but may be reversed with the 'desc' modifier. Example usage: ?orderBy=folder,modifiedDate desc,title. Please note that there is a current limitation for users with approximately one million files in which the requested sort order is ignored.
            public string OrderBy { get; set; }  
            /// Page token for files.
            public string PageToken { get; set; }  
            /// This parameter is deprecated and has no function.
            public string Projection { get; set; }  
            /// Query string for searching files.
            public string Q { get; set; }  
            /// A comma-separated list of spaces to query. Supported values are 'drive', 'appDataFolder' and 'photos'.
            public string Spaces { get; set; }  
            /// Whether the requesting application supports Team Drives.
            public bool? SupportsTeamDrives { get; set; }  
            /// ID of Team Drive to search.
            public string TeamDriveId { get; set; }  
        
        }
 
        /// <summary>
        /// Lists the user's files. 
        /// Documentation https://developers.google.com/drive/v2/reference/files/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>FileListResponse</returns>
        public static FileList List(DriveService service, FilesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Files.List();

                // Applying optional parameters to the request.                
                request = (FilesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Files.List failed.", ex);
            }
        }
        public class FilesPatchOptionalParms
        {
            /// Comma-separated list of parent IDs to add.
            public string AddParents { get; set; }  
            /// This parameter is deprecated and has no function.
            public bool? Convert { get; set; }  
            /// Determines the behavior in which modifiedDate is updated. This overrides setModifiedDate.
            public string ModifiedDateBehavior { get; set; }  
            /// Whether a blob upload should create a new revision. If false, the blob data in the current head revision is replaced. If true or not set, a new blob is created as head revision, and previous unpinned revisions are preserved for a short period of time. Pinned revisions are stored indefinitely, using additional storage quota, up to a maximum of 200 revisions. For details on how revisions are retained, see the Drive Help Center.
            public bool? NewRevision { get; set; }  
            /// Whether to attempt OCR on .jpg, .png, .gif, or .pdf uploads.
            public bool? Ocr { get; set; }  
            /// If ocr is true, hints at the language to use. Valid values are BCP 47 codes.
            public string OcrLanguage { get; set; }  
            /// Whether to pin the new revision. A file can have a maximum of 200 pinned revisions.
            public bool? Pinned { get; set; }  
            /// Comma-separated list of parent IDs to remove.
            public string RemoveParents { get; set; }  
            /// Whether to set the modified date with the supplied modified date.
            public bool? SetModifiedDate { get; set; }  
            /// Whether the requesting application supports Team Drives.
            public bool? SupportsTeamDrives { get; set; }  
            /// The language of the timed text.
            public string TimedTextLanguage { get; set; }  
            /// The timed text track name.
            public string TimedTextTrackName { get; set; }  
            /// Whether to update the view date after successfully updating the file.
            public bool? UpdateViewedDate { get; set; }  
            /// Whether to use the content as indexable text.
            public bool? UseContentAsIndexableText { get; set; }  
        
        }
 
        /// <summary>
        /// Updates file metadata and/or content. This method supports patch semantics. 
        /// Documentation https://developers.google.com/drive/v2/reference/files/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID of the file to update.</param>
        /// <param name="body">A valid Drive v2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>FileResponse</returns>
        public static File Patch(DriveService service, string fileId, File body, FilesPatchOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);

                // Building the initial request.
                var request = service.Files.Patch(body, fileId);

                // Applying optional parameters to the request.                
                request = (FilesResource.PatchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Files.Patch failed.", ex);
            }
        }
        public class FilesTouchOptionalParms
        {
            /// Whether the requesting application supports Team Drives.
            public bool? SupportsTeamDrives { get; set; }  
        
        }
 
        /// <summary>
        /// Set the file's updated time to the current server time. 
        /// Documentation https://developers.google.com/drive/v2/reference/files/touch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID of the file to update.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>FileResponse</returns>
        public static File Touch(DriveService service, string fileId, FilesTouchOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);

                // Building the initial request.
                var request = service.Files.Touch(fileId);

                // Applying optional parameters to the request.                
                request = (FilesResource.TouchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Files.Touch failed.", ex);
            }
        }
        public class FilesTrashOptionalParms
        {
            /// Whether the requesting application supports Team Drives.
            public bool? SupportsTeamDrives { get; set; }  
        
        }
 
        /// <summary>
        /// Moves a file to the trash. The currently authenticated user must own the file or be an organizer on the parent for Team Drive files. 
        /// Documentation https://developers.google.com/drive/v2/reference/files/trash
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID of the file to trash.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>FileResponse</returns>
        public static File Trash(DriveService service, string fileId, FilesTrashOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);

                // Building the initial request.
                var request = service.Files.Trash(fileId);

                // Applying optional parameters to the request.                
                request = (FilesResource.TrashRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Files.Trash failed.", ex);
            }
        }
        public class FilesUntrashOptionalParms
        {
            /// Whether the requesting application supports Team Drives.
            public bool? SupportsTeamDrives { get; set; }  
        
        }
 
        /// <summary>
        /// Restores a file from the trash. 
        /// Documentation https://developers.google.com/drive/v2/reference/files/untrash
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID of the file to untrash.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>FileResponse</returns>
        public static File Untrash(DriveService service, string fileId, FilesUntrashOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);

                // Building the initial request.
                var request = service.Files.Untrash(fileId);

                // Applying optional parameters to the request.                
                request = (FilesResource.UntrashRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Files.Untrash failed.", ex);
            }
        }
        public class FilesUpdateOptionalParms
        {
            /// Comma-separated list of parent IDs to add.
            public string AddParents { get; set; }  
            /// This parameter is deprecated and has no function.
            public bool? Convert { get; set; }  
            /// Determines the behavior in which modifiedDate is updated. This overrides setModifiedDate.
            public string ModifiedDateBehavior { get; set; }  
            /// Whether a blob upload should create a new revision. If false, the blob data in the current head revision is replaced. If true or not set, a new blob is created as head revision, and previous unpinned revisions are preserved for a short period of time. Pinned revisions are stored indefinitely, using additional storage quota, up to a maximum of 200 revisions. For details on how revisions are retained, see the Drive Help Center.
            public bool? NewRevision { get; set; }  
            /// Whether to attempt OCR on .jpg, .png, .gif, or .pdf uploads.
            public bool? Ocr { get; set; }  
            /// If ocr is true, hints at the language to use. Valid values are BCP 47 codes.
            public string OcrLanguage { get; set; }  
            /// Whether to pin the new revision. A file can have a maximum of 200 pinned revisions.
            public bool? Pinned { get; set; }  
            /// Comma-separated list of parent IDs to remove.
            public string RemoveParents { get; set; }  
            /// Whether to set the modified date with the supplied modified date.
            public bool? SetModifiedDate { get; set; }  
            /// Whether the requesting application supports Team Drives.
            public bool? SupportsTeamDrives { get; set; }  
            /// The language of the timed text.
            public string TimedTextLanguage { get; set; }  
            /// The timed text track name.
            public string TimedTextTrackName { get; set; }  
            /// Whether to update the view date after successfully updating the file.
            public bool? UpdateViewedDate { get; set; }  
            /// Whether to use the content as indexable text.
            public bool? UseContentAsIndexableText { get; set; }  
        
        }
 
        /// <summary>
        /// Updates file metadata and/or content. 
        /// Documentation https://developers.google.com/drive/v2/reference/files/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID of the file to update.</param>
        /// <param name="body">A valid Drive v2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>FileResponse</returns>
        public static File Update(DriveService service, string fileId, File body, FilesUpdateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);

                // Building the initial request.
                var request = service.Files.Update(body, fileId);

                // Applying optional parameters to the request.                
                request = (FilesResource.UpdateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Files.Update failed.", ex);
            }
        }
        public class FilesWatchOptionalParms
        {
            /// Whether the user is acknowledging the risk of downloading known malware or other abusive files.
            public bool? AcknowledgeAbuse { get; set; }  
            /// This parameter is deprecated and has no function.
            public string Projection { get; set; }  
            /// Specifies the Revision ID that should be downloaded. Ignored unless alt=media is specified.
            public string RevisionId { get; set; }  
            /// Whether the requesting application supports Team Drives.
            public bool? SupportsTeamDrives { get; set; }  
            /// Deprecated: Use files.update with modifiedDateBehavior=noChange, updateViewedDate=true and an empty request body.
            public bool? UpdateViewedDate { get; set; }  
        
        }
 
        /// <summary>
        /// Subscribe to changes on a file 
        /// Documentation https://developers.google.com/drive/v2/reference/files/watch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID for the file in question.</param>
        /// <param name="body">A valid Drive v2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ChannelResponse</returns>
        public static Channel Watch(DriveService service, string fileId, Channel body, FilesWatchOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);

                // Building the initial request.
                var request = service.Files.Watch(body, fileId);

                // Applying optional parameters to the request.                
                request = (FilesResource.WatchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Files.Watch failed.", ex);
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