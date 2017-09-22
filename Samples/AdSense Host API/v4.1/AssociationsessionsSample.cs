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
//     Build date: 2017-09-22
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------  
// About 
// 
// Unoffical sample for the Adsensehost v4.1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Generates performance reports, generates ad codes, and provides publisher management capabilities for AdSense Hosts.
// API Documentation Link https://developers.google.com/adsense/host/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Adsensehost/v4_1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Adsensehost.v4_1/ 
// Install Command: PM>  Install-Package Google.Apis.Adsensehost.v4_1
//
//------------------------------------------------------------------------------  
using Google.Apis.Adsensehost.v4_1;
using Google.Apis.Adsensehost.v4_1.Data;
using System;

namespace GoogleSamplecSharpSample.Adsensehostv4_1.Methods
{
  
    public static class AssociationsessionsSample
    {

        public class AssociationsessionsStartOptionalParms
        {
            /// The preferred locale of the user.
            public string UserLocale { get; set; }  
            /// The locale of the user's hosted website.
            public string WebsiteLocale { get; set; }  
        
        }
 
        /// <summary>
        /// Create an association session for initiating an association with an AdSense user. 
        /// Documentation https://developers.google.com/adsensehost/v4.1/reference/associationsessions/start
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Adsensehost service.</param>  
        /// <param name="productCode">Products to associate with the user.</param>
        /// <param name="websiteUrl">The URL of the user's hosted website.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>AssociationSessionResponse</returns>
        public static AssociationSession Start(AdsensehostService service, string productCode, string websiteUrl, AssociationsessionsStartOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (productCode == null)
                    throw new ArgumentNullException(productCode);
                if (websiteUrl == null)
                    throw new ArgumentNullException(websiteUrl);

                // Building the initial request.
                var request = service.Associationsessions.Start(productCode, websiteUrl);

                // Applying optional parameters to the request.                
                request = (AssociationsessionsResource.StartRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Associationsessions.Start failed.", ex);
            }
        }

        /// <summary>
        /// Verify an association session after the association callback returns from AdSense signup. 
        /// Documentation https://developers.google.com/adsensehost/v4.1/reference/associationsessions/verify
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Adsensehost service.</param>  
        /// <param name="token">The token returned to the association callback URL.</param>
        /// <returns>AssociationSessionResponse</returns>
        public static AssociationSession Verify(AdsensehostService service, string token)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (token == null)
                    throw new ArgumentNullException(token);

                // Make the request.
                return service.Associationsessions.Verify(token).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Associationsessions.Verify failed.", ex);
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