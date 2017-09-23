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
// Unoffical sample for the Cloudnaturallanguage v1beta2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Provides natural language understanding technologies to developers. Examples include sentiment analysis, entity recognition, entity sentiment analysis, and text annotations.
// API Documentation Link https://cloud.google.com/natural-language/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Cloudnaturallanguage/v1beta2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Cloudnaturallanguage.v1beta2/ 
// Install Command: PM>  Install-Package Google.Apis.Cloudnaturallanguage.v1beta2
//
//------------------------------------------------------------------------------  
using Google.Apis.Cloudnaturallanguage.v1beta2;
using Google.Apis.Cloudnaturallanguage.v1beta2.Data;
using System;

namespace GoogleSamplecSharpSample.Cloudnaturallanguagev1beta2.Methods
{
  
    public static class DocumentsSample
    {


        /// <summary>
        /// A convenience method that provides all syntax, sentiment, entity, andclassification features in one call. 
        /// Documentation https://developers.google.com/cloudnaturallanguage/v1beta2/reference/documents/annotateText
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudnaturallanguage service.</param>  
        /// <param name="body">A valid Cloudnaturallanguage v1beta2 body.</param>
        /// <returns>AnnotateTextResponseResponse</returns>
        public static AnnotateTextResponse AnnotateText(CloudnaturallanguageService service, AnnotateTextRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Documents.AnnotateText(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Documents.AnnotateText failed.", ex);
            }
        }

        /// <summary>
        /// Classifies a document into categories. 
        /// Documentation https://developers.google.com/cloudnaturallanguage/v1beta2/reference/documents/classifyText
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudnaturallanguage service.</param>  
        /// <param name="body">A valid Cloudnaturallanguage v1beta2 body.</param>
        /// <returns>ClassifyTextResponseResponse</returns>
        public static ClassifyTextResponse ClassifyText(CloudnaturallanguageService service, ClassifyTextRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Documents.ClassifyText(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Documents.ClassifyText failed.", ex);
            }
        }

        /// <summary>
        /// Analyzes the sentiment of the provided text. 
        /// Documentation https://developers.google.com/cloudnaturallanguage/v1beta2/reference/documents/analyzeSentiment
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudnaturallanguage service.</param>  
        /// <param name="body">A valid Cloudnaturallanguage v1beta2 body.</param>
        /// <returns>AnalyzeSentimentResponseResponse</returns>
        public static AnalyzeSentimentResponse AnalyzeSentiment(CloudnaturallanguageService service, AnalyzeSentimentRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Documents.AnalyzeSentiment(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Documents.AnalyzeSentiment failed.", ex);
            }
        }

        /// <summary>
        /// Finds entities, similar to AnalyzeEntities in the text and analyzessentiment associated with each entity and its mentions. 
        /// Documentation https://developers.google.com/cloudnaturallanguage/v1beta2/reference/documents/analyzeEntitySentiment
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudnaturallanguage service.</param>  
        /// <param name="body">A valid Cloudnaturallanguage v1beta2 body.</param>
        /// <returns>AnalyzeEntitySentimentResponseResponse</returns>
        public static AnalyzeEntitySentimentResponse AnalyzeEntitySentiment(CloudnaturallanguageService service, AnalyzeEntitySentimentRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Documents.AnalyzeEntitySentiment(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Documents.AnalyzeEntitySentiment failed.", ex);
            }
        }

        /// <summary>
        /// Finds named entities (currently proper names and common nouns) in the textalong with entity types, salience, mentions for each entity, andother properties. 
        /// Documentation https://developers.google.com/cloudnaturallanguage/v1beta2/reference/documents/analyzeEntities
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudnaturallanguage service.</param>  
        /// <param name="body">A valid Cloudnaturallanguage v1beta2 body.</param>
        /// <returns>AnalyzeEntitiesResponseResponse</returns>
        public static AnalyzeEntitiesResponse AnalyzeEntities(CloudnaturallanguageService service, AnalyzeEntitiesRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Documents.AnalyzeEntities(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Documents.AnalyzeEntities failed.", ex);
            }
        }

        /// <summary>
        /// Analyzes the syntax of the text and provides sentence boundaries andtokenization along with part of speech tags, dependency trees, and otherproperties. 
        /// Documentation https://developers.google.com/cloudnaturallanguage/v1beta2/reference/documents/analyzeSyntax
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudnaturallanguage service.</param>  
        /// <param name="body">A valid Cloudnaturallanguage v1beta2 body.</param>
        /// <returns>AnalyzeSyntaxResponseResponse</returns>
        public static AnalyzeSyntaxResponse AnalyzeSyntax(CloudnaturallanguageService service, AnalyzeSyntaxRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Documents.AnalyzeSyntax(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Documents.AnalyzeSyntax failed.", ex);
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