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
// Unoffical sample for the Spectrum v1explorer API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: API for spectrum-management functions.
// API Documentation Link http://developers.google.com/spectrum
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Spectrum/v1explorer/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Spectrum.v1explorer/ 
// Install Command: PM>  Install-Package Google.Apis.Spectrum.v1explorer
//
//------------------------------------------------------------------------------  
using Google.Apis.Spectrum.v1explorer;
using Google.Apis.Spectrum.v1explorer.Data;
using System;

namespace GoogleSamplecSharpSample.Spectrumv1explorer.Methods
{
  
    public static class PawsSample
    {


        /// <summary>
        /// Requests information about the available spectrum for a device at a location. Requests from a fixed-mode device must include owner information so the device can be registered with the database. 
        /// Documentation https://developers.google.com/spectrum/v1explorer/reference/paws/getSpectrum
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Spectrum service.</param>  
        /// <param name="body">A valid Spectrum v1explorer body.</param>
        /// <returns>PawsGetSpectrumResponseResponse</returns>
        public static PawsGetSpectrumResponse GetSpectrum(SpectrumService service, PawsGetSpectrumRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Paws.GetSpectrum(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Paws.GetSpectrum failed.", ex);
            }
        }

        /// <summary>
        /// The Google Spectrum Database does not support batch requests, so this method always yields an UNIMPLEMENTED error. 
        /// Documentation https://developers.google.com/spectrum/v1explorer/reference/paws/getSpectrumBatch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Spectrum service.</param>  
        /// <param name="body">A valid Spectrum v1explorer body.</param>
        /// <returns>PawsGetSpectrumBatchResponseResponse</returns>
        public static PawsGetSpectrumBatchResponse GetSpectrumBatch(SpectrumService service, PawsGetSpectrumBatchRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Paws.GetSpectrumBatch(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Paws.GetSpectrumBatch failed.", ex);
            }
        }

        /// <summary>
        /// Initializes the connection between a white space device and the database. 
        /// Documentation https://developers.google.com/spectrum/v1explorer/reference/paws/init
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Spectrum service.</param>  
        /// <param name="body">A valid Spectrum v1explorer body.</param>
        /// <returns>PawsInitResponseResponse</returns>
        public static PawsInitResponse Init(SpectrumService service, PawsInitRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Paws.Init(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Paws.Init failed.", ex);
            }
        }

        /// <summary>
        /// Notifies the database that the device has selected certain frequency ranges for transmission. Only to be invoked when required by the regulator. The Google Spectrum Database does not operate in domains that require notification, so this always yields an UNIMPLEMENTED error. 
        /// Documentation https://developers.google.com/spectrum/v1explorer/reference/paws/notifySpectrumUse
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Spectrum service.</param>  
        /// <param name="body">A valid Spectrum v1explorer body.</param>
        /// <returns>PawsNotifySpectrumUseResponseResponse</returns>
        public static PawsNotifySpectrumUseResponse NotifySpectrumUse(SpectrumService service, PawsNotifySpectrumUseRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Paws.NotifySpectrumUse(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Paws.NotifySpectrumUse failed.", ex);
            }
        }

        /// <summary>
        /// The Google Spectrum Database implements registration in the getSpectrum method. As such this always returns an UNIMPLEMENTED error. 
        /// Documentation https://developers.google.com/spectrum/v1explorer/reference/paws/register
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Spectrum service.</param>  
        /// <param name="body">A valid Spectrum v1explorer body.</param>
        /// <returns>PawsRegisterResponseResponse</returns>
        public static PawsRegisterResponse Register(SpectrumService service, PawsRegisterRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Paws.Register(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Paws.Register failed.", ex);
            }
        }

        /// <summary>
        /// Validates a device for white space use in accordance with regulatory rules. The Google Spectrum Database does not support master/slave configurations, so this always yields an UNIMPLEMENTED error. 
        /// Documentation https://developers.google.com/spectrum/v1explorer/reference/paws/verifyDevice
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Spectrum service.</param>  
        /// <param name="body">A valid Spectrum v1explorer body.</param>
        /// <returns>PawsVerifyDeviceResponseResponse</returns>
        public static PawsVerifyDeviceResponse VerifyDevice(SpectrumService service, PawsVerifyDeviceRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Paws.VerifyDevice(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Paws.VerifyDevice failed.", ex);
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