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
// Unoffical sample for the Youtube v3 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Supports core YouTube features, such as uploading videos, creating and managing playlists, searching for content, and much more.
// API Documentation Link https://developers.google.com/youtube/v3
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Youtube/v3/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Youtube.v3/ 
// Install Command: PM>  Install-Package Google.Apis.Youtube.v3
//
//------------------------------------------------------------------------------  
using Google.Apis.Youtube.v3;
using Google.Apis.Youtube.v3.Data;
using System;

namespace GoogleSamplecSharpSample.Youtubev3.Methods
{
  
    public static class CommentsSample
    {


        /// <summary>
        /// Deletes a comment. 
        /// Documentation https://developers.google.com/youtube/v3/reference/comments/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Youtube service.</param>  
        /// <param name="id">The id parameter specifies the comment ID for the resource that is being deleted.</param>
        public static void Delete(YoutubeService service, string id)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                 service.Comments.Delete(id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Comments.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Creates a reply to an existing comment. Note: To create a top-level comment, use the commentThreads.insert method. 
        /// Documentation https://developers.google.com/youtube/v3/reference/comments/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Youtube service.</param>  
        /// <param name="part">The part parameter identifies the properties that the API response will include. Set the parameter value to snippet. The snippet part has a quota cost of 2 units.</param>
        /// <param name="body">A valid Youtube v3 body.</param>
        /// <returns>CommentResponse</returns>
        public static Comment Insert(YoutubeService service, string part, Comment body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (part == null)
                    throw new ArgumentNullException(part);

                // Make the request.
                return service.Comments.Insert(body, part).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Comments.Insert failed.", ex);
            }
        }
        public class CommentsListOptionalParms
        {
            /// The id parameter specifies a comma-separated list of comment IDs for the resources that are being retrieved. In a comment resource, the id property specifies the comment's ID.
            public string Id { get; set; }  
            /// The maxResults parameter specifies the maximum number of items that should be returned in the result set.Note: This parameter is not supported for use in conjunction with the id parameter.
            public int? MaxResults { get; set; }  
            /// The pageToken parameter identifies a specific page in the result set that should be returned. In an API response, the nextPageToken property identifies the next page of the result that can be retrieved.Note: This parameter is not supported for use in conjunction with the id parameter.
            public string PageToken { get; set; }  
            /// The parentId parameter specifies the ID of the comment for which replies should be retrieved.Note: YouTube currently supports replies only for top-level comments. However, replies to replies may be supported in the future.
            public string ParentId { get; set; }  
            /// This parameter indicates whether the API should return comments formatted as HTML or as plain text.
            public string TextFormat { get; set; }  
        
        }
 
        /// <summary>
        /// Returns a list of comments that match the API request parameters. 
        /// Documentation https://developers.google.com/youtube/v3/reference/comments/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Youtube service.</param>  
        /// <param name="part">The part parameter specifies a comma-separated list of one or more comment resource properties that the API response will include.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>CommentListResponseResponse</returns>
        public static CommentListResponse List(YoutubeService service, string part, CommentsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (part == null)
                    throw new ArgumentNullException(part);

                // Building the initial request.
                var request = service.Comments.List(part);

                // Applying optional parameters to the request.                
                request = (CommentsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Comments.List failed.", ex);
            }
        }

        /// <summary>
        /// Expresses the caller's opinion that one or more comments should be flagged as spam. 
        /// Documentation https://developers.google.com/youtube/v3/reference/comments/markAsSpam
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Youtube service.</param>  
        /// <param name="id">The id parameter specifies a comma-separated list of IDs of comments that the caller believes should be classified as spam.</param>
        public static void MarkAsSpam(YoutubeService service, string id)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (id == null)
                    throw new ArgumentNullException(id);

                // Make the request.
                 service.Comments.MarkAsSpam(id).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Comments.MarkAsSpam failed.", ex);
            }
        }
        public class CommentsSetModerationStatusOptionalParms
        {
            /// The banAuthor parameter lets you indicate that you want to automatically reject any additional comments written by the comment's author. Set the parameter value to true to ban the author.Note: This parameter is only valid if the moderationStatus parameter is also set to rejected.
            public bool? BanAuthor { get; set; }  
        
        }
 
        /// <summary>
        /// Sets the moderation status of one or more comments. The API request must be authorized by the owner of the channel or video associated with the comments. 
        /// Documentation https://developers.google.com/youtube/v3/reference/comments/setModerationStatus
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Youtube service.</param>  
        /// <param name="id">The id parameter specifies a comma-separated list of IDs that identify the comments for which you are updating the moderation status.</param>
        /// <param name="moderationStatus">Identifies the new moderation status of the specified comments.</param>
        /// <param name="optional">Optional paramaters.</param>
        public static void SetModerationStatus(YoutubeService service, string id, string moderationStatus, CommentsSetModerationStatusOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (id == null)
                    throw new ArgumentNullException(id);
                if (moderationStatus == null)
                    throw new ArgumentNullException(moderationStatus);

                // Building the initial request.
                var request = service.Comments.SetModerationStatus(id, moderationStatus);

                // Applying optional parameters to the request.                
                request = (CommentsResource.SetModerationStatusRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                 request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Comments.SetModerationStatus failed.", ex);
            }
        }

        /// <summary>
        /// Modifies a comment. 
        /// Documentation https://developers.google.com/youtube/v3/reference/comments/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Youtube service.</param>  
        /// <param name="part">The part parameter identifies the properties that the API response will include. You must at least include the snippet part in the parameter value since that part contains all of the properties that the API request can update.</param>
        /// <param name="body">A valid Youtube v3 body.</param>
        /// <returns>CommentResponse</returns>
        public static Comment Update(YoutubeService service, string part, Comment body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (part == null)
                    throw new ArgumentNullException(part);

                // Make the request.
                return service.Comments.Update(body, part).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Comments.Update failed.", ex);
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