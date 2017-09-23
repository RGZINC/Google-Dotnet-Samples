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
// Unoffical sample for the Games v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: The API for Google Play Game Services.
// API Documentation Link https://developers.google.com/games/services/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Games/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Games.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Games.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Games.v1;
using Google.Apis.Games.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Gamesv1.Methods
{
  
    public static class ScoresSample
    {

        public class ScoresGetOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
            /// The types of ranks to return. If the parameter is omitted, no ranks will be returned.
            public string IncludeRankType { get; set; }  
            /// The preferred language to use for strings returned by this method.
            public string Language { get; set; }  
            /// The maximum number of leaderboard scores to return in the response. For any response, the actual number of leaderboard scores returned may be less than the specified maxResults.
            public int? MaxResults { get; set; }  
            /// The token returned by the previous request.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Get high scores, and optionally ranks, in leaderboards for the currently authenticated player. For a specific time span, leaderboardId can be set to ALL to retrieve data for all leaderboards in a given time span.NOTE: You cannot ask for 'ALL' leaderboards and 'ALL' timeSpans in the same request; only one parameter may be set to 'ALL'. 
        /// Documentation https://developers.google.com/games/v1/reference/scores/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="playerId">A player ID. A value of me may be used in place of the authenticated player's ID.</param>
        /// <param name="leaderboardId">The ID of the leaderboard. Can be set to 'ALL' to retrieve data for all leaderboards for this application.</param>
        /// <param name="timeSpan">The time span for the scores and ranks you're requesting.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>PlayerLeaderboardScoreListResponseResponse</returns>
        public static PlayerLeaderboardScoreListResponse Get(GamesService service, string playerId, string leaderboardId, string timeSpan, ScoresGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (playerId == null)
                    throw new ArgumentNullException(playerId);
                if (leaderboardId == null)
                    throw new ArgumentNullException(leaderboardId);
                if (timeSpan == null)
                    throw new ArgumentNullException(timeSpan);

                // Building the initial request.
                var request = service.Scores.Get(playerId, leaderboardId, timeSpan);

                // Applying optional parameters to the request.                
                request = (ScoresResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Scores.Get failed.", ex);
            }
        }
        public class ScoresListOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
            /// The preferred language to use for strings returned by this method.
            public string Language { get; set; }  
            /// The maximum number of leaderboard scores to return in the response. For any response, the actual number of leaderboard scores returned may be less than the specified maxResults.
            public int? MaxResults { get; set; }  
            /// The token returned by the previous request.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Lists the scores in a leaderboard, starting from the top. 
        /// Documentation https://developers.google.com/games/v1/reference/scores/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="leaderboardId">The ID of the leaderboard.</param>
        /// <param name="collection">The collection of scores you're requesting.</param>
        /// <param name="timeSpan">The time span for the scores and ranks you're requesting.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>LeaderboardScoresResponse</returns>
        public static LeaderboardScores List(GamesService service, string leaderboardId, string collection, string timeSpan, ScoresListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (leaderboardId == null)
                    throw new ArgumentNullException(leaderboardId);
                if (collection == null)
                    throw new ArgumentNullException(collection);
                if (timeSpan == null)
                    throw new ArgumentNullException(timeSpan);

                // Building the initial request.
                var request = service.Scores.List(leaderboardId, collection, timeSpan);

                // Applying optional parameters to the request.                
                request = (ScoresResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Scores.List failed.", ex);
            }
        }
        public class ScoresListWindowOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
            /// The preferred language to use for strings returned by this method.
            public string Language { get; set; }  
            /// The maximum number of leaderboard scores to return in the response. For any response, the actual number of leaderboard scores returned may be less than the specified maxResults.
            public int? MaxResults { get; set; }  
            /// The token returned by the previous request.
            public string PageToken { get; set; }  
            /// The preferred number of scores to return above the player's score. More scores may be returned if the player is at the bottom of the leaderboard; fewer may be returned if the player is at the top. Must be less than or equal to maxResults.
            public int? ResultsAbove { get; set; }  
            /// True if the top scores should be returned when the player is not in the leaderboard. Defaults to true.
            public bool? ReturnTopIfAbsent { get; set; }  
        
        }
 
        /// <summary>
        /// Lists the scores in a leaderboard around (and including) a player's score. 
        /// Documentation https://developers.google.com/games/v1/reference/scores/listWindow
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="leaderboardId">The ID of the leaderboard.</param>
        /// <param name="collection">The collection of scores you're requesting.</param>
        /// <param name="timeSpan">The time span for the scores and ranks you're requesting.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>LeaderboardScoresResponse</returns>
        public static LeaderboardScores ListWindow(GamesService service, string leaderboardId, string collection, string timeSpan, ScoresListWindowOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (leaderboardId == null)
                    throw new ArgumentNullException(leaderboardId);
                if (collection == null)
                    throw new ArgumentNullException(collection);
                if (timeSpan == null)
                    throw new ArgumentNullException(timeSpan);

                // Building the initial request.
                var request = service.Scores.ListWindow(leaderboardId, collection, timeSpan);

                // Applying optional parameters to the request.                
                request = (ScoresResource.ListWindowRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Scores.ListWindow failed.", ex);
            }
        }
        public class ScoresSubmitOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
            /// The preferred language to use for strings returned by this method.
            public string Language { get; set; }  
            /// Additional information about the score you're submitting. Values must contain no more than 64 URI-safe characters as defined by section 2.3 of RFC 3986.
            public string ScoreTag { get; set; }  
        
        }
 
        /// <summary>
        /// Submits a score to the specified leaderboard. 
        /// Documentation https://developers.google.com/games/v1/reference/scores/submit
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="leaderboardId">The ID of the leaderboard.</param>
        /// <param name="score">The score you're submitting. The submitted score is ignored if it is worse than a previously submitted score, where worse depends on the leaderboard sort order. The meaning of the score value depends on the leaderboard format type. For fixed-point, the score represents the raw value. For time, the score represents elapsed time in milliseconds. For currency, the score represents a value in micro units.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>PlayerScoreResponseResponse</returns>
        public static PlayerScoreResponse Submit(GamesService service, string leaderboardId, string score, ScoresSubmitOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (leaderboardId == null)
                    throw new ArgumentNullException(leaderboardId);
                if (score == null)
                    throw new ArgumentNullException(score);

                // Building the initial request.
                var request = service.Scores.Submit(leaderboardId, score);

                // Applying optional parameters to the request.                
                request = (ScoresResource.SubmitRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Scores.Submit failed.", ex);
            }
        }
        public class ScoresSubmitMultipleOptionalParms
        {
            /// The last-seen mutation timestamp.
            public string ConsistencyToken { get; set; }  
            /// The preferred language to use for strings returned by this method.
            public string Language { get; set; }  
        
        }
 
        /// <summary>
        /// Submits multiple scores to leaderboards. 
        /// Documentation https://developers.google.com/games/v1/reference/scores/submitMultiple
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Games service.</param>  
        /// <param name="body">A valid Games v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>PlayerScoreListResponseResponse</returns>
        public static PlayerScoreListResponse SubmitMultiple(GamesService service, PlayerScoreSubmissionList body, ScoresSubmitMultipleOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Building the initial request.
                var request = service.Scores.SubmitMultiple(body);

                // Applying optional parameters to the request.                
                request = (ScoresResource.SubmitMultipleRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Scores.SubmitMultiple failed.", ex);
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