 


// Copyright 2015 DAIMTO :  www.daimto.com
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
//     Build date: 11/17/2015 13:52:58
//     C# generater version: 1.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Google.Apis.Analytics.v3;
using Google.Apis.Analytics.v3.Data;

namespace DAIMTO.Analytics.v3.Sample
{
    class ManagementProfilesSample
    {
			 /// <summary>
		/// Deletes a view (profile).
		/// Documentation: https://developers.google.com/analytics//v3/profiles/delete
		/// </summary>
		/// <param name="service">Valid authentcated AnalyticsService</param>
		/// <param name="accountId">Account ID to delete the view (profile) for.</param>
       /// <param name="webPropertyId">Web property ID to delete the view (profile) for.</param>
       /// <param name="profileId">ID of the view (profile) to be deleted.</param>
        /// <returns></returns>
		 public static void delete(AnalyticsService service, string accountId, string webPropertyId, string profileId)
		 {
		  try
            {
                var request = service.Management.Profiles.Delete(accountId, webPropertyId, profileId);
		  request.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Request Failed " + ex.Message);
                throw ex;
            }
		 
		 
		 }
		 
		
		 /// <summary>
		/// Gets a view (profile) to which the user has access.
		/// Documentation: https://developers.google.com/analytics//v3/profiles/get
		/// </summary>
		/// <param name="service">Valid authentcated AnalyticsService</param>
		/// <param name="accountId">Account ID to retrieve the goal for.</param>
       /// <param name="webPropertyId">Web property ID to retrieve the goal for.</param>
       /// <param name="profileId">View (Profile) ID to retrieve the goal for.</param>
        /// <returns></returns>
		 public static Profile get(AnalyticsService service, string accountId, string webPropertyId, string profileId)
		 {
		  try
            {
                var request = service.Management.Profiles.Get(accountId, webPropertyId, profileId);
		  return  request.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Request Failed " + ex.Message);
                throw ex;
            }
		 
		 
		 }
		 
		
		 /// <summary>
		/// Create a new view (profile).
		/// Documentation: https://developers.google.com/analytics//v3/profiles/insert
		/// </summary>
		/// <param name="service">Valid authentcated AnalyticsService</param>
		/// <param name="body">Valid Profile Body</param>
       /// <param name="accountId">Account ID to create the view (profile) for.</param>
       /// <param name="webPropertyId">Web property ID to create the view (profile) for.</param>
        /// <returns></returns>
		 public static Profile insert(AnalyticsService service, Profile body, string accountId, string webPropertyId)
		 {
		  try
            {
                var request = service.Management.Profiles.Insert(body, accountId, webPropertyId);
		  return  request.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Request Failed " + ex.Message);
                throw ex;
            }
		 
		 
		 }
		 
		
		 /// <summary>
		/// Lists views (profiles) to which the user has access.
		/// Documentation: https://developers.google.com/analytics//v3/profiles/list
		/// </summary>
		/// <param name="service">Valid authentcated AnalyticsService</param>
		/// <param name="accountId">Account ID for the view (profiles) to retrieve. Can either be a specific account ID or '~all', which refers to all the accounts to which the user has access.</param>
       /// <param name="webPropertyId">Web property ID for the views (profiles) to retrieve. Can either be a specific web property ID or '~all', which refers to all the web properties to which the user has access.</param>
        /// <returns></returns>
		 public static Profiles list(AnalyticsService service, string accountId, string webPropertyId)
		 {
		  try
            {
                var request = service.Management.Profiles.List(accountId, webPropertyId);
		  return  request.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Request Failed " + ex.Message);
                throw ex;
            }
		 
		 
		 }
		 
		
		 /// <summary>
		/// Updates an existing view (profile). This method supports patch semantics.
		/// Documentation: https://developers.google.com/analytics//v3/profiles/patch
		/// </summary>
		/// <param name="service">Valid authentcated AnalyticsService</param>
		/// <param name="body">Valid Profile Body</param>
       /// <param name="accountId">Account ID to which the view (profile) belongs</param>
       /// <param name="webPropertyId">Web property ID to which the view (profile) belongs</param>
       /// <param name="profileId">ID of the view (profile) to be updated.</param>
        /// <returns></returns>
		 public static Profile patch(AnalyticsService service, Profile body, string accountId, string webPropertyId, string profileId)
		 {
		  try
            {
                var request = service.Management.Profiles.Patch(body, accountId, webPropertyId, profileId);
		  return  request.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Request Failed " + ex.Message);
                throw ex;
            }
		 
		 
		 }
		 
		
		 /// <summary>
		/// Updates an existing view (profile).
		/// Documentation: https://developers.google.com/analytics//v3/profiles/update
		/// </summary>
		/// <param name="service">Valid authentcated AnalyticsService</param>
		/// <param name="body">Valid Profile Body</param>
       /// <param name="accountId">Account ID to which the view (profile) belongs</param>
       /// <param name="webPropertyId">Web property ID to which the view (profile) belongs</param>
       /// <param name="profileId">ID of the view (profile) to be updated.</param>
        /// <returns></returns>
		 public static Profile update(AnalyticsService service, Profile body, string accountId, string webPropertyId, string profileId)
		 {
		  try
            {
                var request = service.Management.Profiles.Update(body, accountId, webPropertyId, profileId);
		  return  request.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Request Failed " + ex.Message);
                throw ex;
            }
		 
		 
		 }
		 
		
    }


}
