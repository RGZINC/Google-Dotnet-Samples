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
  
    public static class LiveStreamsSample
    {

        public class LiveStreamsDeleteOptionalParms
        {
            /// Note: This parameter is intended exclusively for YouTube content partners.The onBehalfOfContentOwner parameter indicates that the request's authorization credentials identify a YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This parameter is intended for YouTube content partners that own and manage many different YouTube channels. It allows content owners to authenticate once and get access to all their video and channel data, without having to provide authentication credentials for each individual channel. The CMS account that the user authenticates with must be linked to the specified YouTube content owner.
            public string OnBehalfOfContentOwner { get; set; }  
            /// This parameter can only be used in a properly authorized request. Note: This parameter is intended exclusively for YouTube content partners.The onBehalfOfContentOwnerChannel parameter specifies the YouTube channel ID of the channel to which a video is being added. This parameter is required when a request specifies a value for the onBehalfOfContentOwner parameter, and it can only be used in conjunction with that parameter. In addition, the request must be authorized using a CMS account that is linked to the content owner that the onBehalfOfContentOwner parameter specifies. Finally, the channel that the onBehalfOfContentOwnerChannel parameter value specifies must be linked to the content owner that the onBehalfOfContentOwner parameter specifies.This parameter is intended for YouTube content partners that own and manage many different YouTube channels. It allows content owners to authenticate once and perform actions on behalf of the channel specified in the parameter value, without having to provide authentication credentials for each separate channel.
            public string OnBehalfOfContentOwnerChannel { get; set; }  
        
        }
 
        /// <summary>
        /// Deletes a video stream. 
        /// Documentation https://developers.google.com/youtube/v3/reference/liveStreams/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Youtube service.</param>  
        /// <param name="id">The id parameter specifies the YouTube live stream ID for the resource that is being deleted.</param>
        /// <param name="optional">Optional paramaters.</param>
        public static void Delete(YoutubeService service, string id, LiveStreamsDeleteOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (id == null)
                    throw new ArgumentNullException(id);

                // Building the initial request.
                var request = service.LiveStreams.Delete(id);

                // Applying optional parameters to the request.                
                request = (LiveStreamsResource.DeleteRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                 request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request LiveStreams.Delete failed.", ex);
            }
        }
        public class LiveStreamsInsertOptionalParms
        {
            /// Note: This parameter is intended exclusively for YouTube content partners.The onBehalfOfContentOwner parameter indicates that the request's authorization credentials identify a YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This parameter is intended for YouTube content partners that own and manage many different YouTube channels. It allows content owners to authenticate once and get access to all their video and channel data, without having to provide authentication credentials for each individual channel. The CMS account that the user authenticates with must be linked to the specified YouTube content owner.
            public string OnBehalfOfContentOwner { get; set; }  
            /// This parameter can only be used in a properly authorized request. Note: This parameter is intended exclusively for YouTube content partners.The onBehalfOfContentOwnerChannel parameter specifies the YouTube channel ID of the channel to which a video is being added. This parameter is required when a request specifies a value for the onBehalfOfContentOwner parameter, and it can only be used in conjunction with that parameter. In addition, the request must be authorized using a CMS account that is linked to the content owner that the onBehalfOfContentOwner parameter specifies. Finally, the channel that the onBehalfOfContentOwnerChannel parameter value specifies must be linked to the content owner that the onBehalfOfContentOwner parameter specifies.This parameter is intended for YouTube content partners that own and manage many different YouTube channels. It allows content owners to authenticate once and perform actions on behalf of the channel specified in the parameter value, without having to provide authentication credentials for each separate channel.
            public string OnBehalfOfContentOwnerChannel { get; set; }  
        
        }
 
        /// <summary>
        /// Creates a video stream. The stream enables you to send your video to YouTube, which can then broadcast the video to your audience. 
        /// Documentation https://developers.google.com/youtube/v3/reference/liveStreams/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Youtube service.</param>  
        /// <param name="part">The part parameter serves two purposes in this operation. It identifies the properties that the write operation will set as well as the properties that the API response will include.The part properties that you can include in the parameter value are id, snippet, cdn, and status.</param>
        /// <param name="body">A valid Youtube v3 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>LiveStreamResponse</returns>
        public static LiveStream Insert(YoutubeService service, string part, LiveStream body, LiveStreamsInsertOptionalParms optional = null)
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

                // Building the initial request.
                var request = service.LiveStreams.Insert(body, part);

                // Applying optional parameters to the request.                
                request = (LiveStreamsResource.InsertRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request LiveStreams.Insert failed.", ex);
            }
        }
        public class LiveStreamsListOptionalParms
        {
            /// The id parameter specifies a comma-separated list of YouTube stream IDs that identify the streams being retrieved. In a liveStream resource, the id property specifies the stream's ID.
            public string Id { get; set; }  
            /// The maxResults parameter specifies the maximum number of items that should be returned in the result set.
            public int? MaxResults { get; set; }  
            /// The mine parameter can be used to instruct the API to only return streams owned by the authenticated user. Set the parameter value to true to only retrieve your own streams.
            public bool? Mine { get; set; }  
            /// Note: This parameter is intended exclusively for YouTube content partners.The onBehalfOfContentOwner parameter indicates that the request's authorization credentials identify a YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This parameter is intended for YouTube content partners that own and manage many different YouTube channels. It allows content owners to authenticate once and get access to all their video and channel data, without having to provide authentication credentials for each individual channel. The CMS account that the user authenticates with must be linked to the specified YouTube content owner.
            public string OnBehalfOfContentOwner { get; set; }  
            /// This parameter can only be used in a properly authorized request. Note: This parameter is intended exclusively for YouTube content partners.The onBehalfOfContentOwnerChannel parameter specifies the YouTube channel ID of the channel to which a video is being added. This parameter is required when a request specifies a value for the onBehalfOfContentOwner parameter, and it can only be used in conjunction with that parameter. In addition, the request must be authorized using a CMS account that is linked to the content owner that the onBehalfOfContentOwner parameter specifies. Finally, the channel that the onBehalfOfContentOwnerChannel parameter value specifies must be linked to the content owner that the onBehalfOfContentOwner parameter specifies.This parameter is intended for YouTube content partners that own and manage many different YouTube channels. It allows content owners to authenticate once and perform actions on behalf of the channel specified in the parameter value, without having to provide authentication credentials for each separate channel.
            public string OnBehalfOfContentOwnerChannel { get; set; }  
            /// The pageToken parameter identifies a specific page in the result set that should be returned. In an API response, the nextPageToken and prevPageToken properties identify other pages that could be retrieved.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Returns a list of video streams that match the API request parameters. 
        /// Documentation https://developers.google.com/youtube/v3/reference/liveStreams/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Youtube service.</param>  
        /// <param name="part">The part parameter specifies a comma-separated list of one or more liveStream resource properties that the API response will include. The part names that you can include in the parameter value are id, snippet, cdn, and status.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>LiveStreamListResponseResponse</returns>
        public static LiveStreamListResponse List(YoutubeService service, string part, LiveStreamsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (part == null)
                    throw new ArgumentNullException(part);

                // Building the initial request.
                var request = service.LiveStreams.List(part);

                // Applying optional parameters to the request.                
                request = (LiveStreamsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request LiveStreams.List failed.", ex);
            }
        }
        public class LiveStreamsUpdateOptionalParms
        {
            /// Note: This parameter is intended exclusively for YouTube content partners.The onBehalfOfContentOwner parameter indicates that the request's authorization credentials identify a YouTube CMS user who is acting on behalf of the content owner specified in the parameter value. This parameter is intended for YouTube content partners that own and manage many different YouTube channels. It allows content owners to authenticate once and get access to all their video and channel data, without having to provide authentication credentials for each individual channel. The CMS account that the user authenticates with must be linked to the specified YouTube content owner.
            public string OnBehalfOfContentOwner { get; set; }  
            /// This parameter can only be used in a properly authorized request. Note: This parameter is intended exclusively for YouTube content partners.The onBehalfOfContentOwnerChannel parameter specifies the YouTube channel ID of the channel to which a video is being added. This parameter is required when a request specifies a value for the onBehalfOfContentOwner parameter, and it can only be used in conjunction with that parameter. In addition, the request must be authorized using a CMS account that is linked to the content owner that the onBehalfOfContentOwner parameter specifies. Finally, the channel that the onBehalfOfContentOwnerChannel parameter value specifies must be linked to the content owner that the onBehalfOfContentOwner parameter specifies.This parameter is intended for YouTube content partners that own and manage many different YouTube channels. It allows content owners to authenticate once and perform actions on behalf of the channel specified in the parameter value, without having to provide authentication credentials for each separate channel.
            public string OnBehalfOfContentOwnerChannel { get; set; }  
        
        }
 
        /// <summary>
        /// Updates a video stream. If the properties that you want to change cannot be updated, then you need to create a new stream with the proper settings. 
        /// Documentation https://developers.google.com/youtube/v3/reference/liveStreams/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Youtube service.</param>  
        /// <param name="part">The part parameter serves two purposes in this operation. It identifies the properties that the write operation will set as well as the properties that the API response will include.The part properties that you can include in the parameter value are id, snippet, cdn, and status.Note that this method will override the existing values for all of the mutable properties that are contained in any parts that the parameter value specifies. If the request body does not specify a value for a mutable property, the existing value for that property will be removed.</param>
        /// <param name="body">A valid Youtube v3 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>LiveStreamResponse</returns>
        public static LiveStream Update(YoutubeService service, string part, LiveStream body, LiveStreamsUpdateOptionalParms optional = null)
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

                // Building the initial request.
                var request = service.LiveStreams.Update(body, part);

                // Applying optional parameters to the request.                
                request = (LiveStreamsResource.UpdateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request LiveStreams.Update failed.", ex);
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