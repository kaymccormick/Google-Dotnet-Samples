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
// Unoffical sample for the Resourceviews v1beta2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: The Resource View API allows users to create and manage logical sets of Google Compute Engine instances.
// API Documentation Link https://developers.google.com/compute/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Resourceviews/v1beta2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Resourceviews.v1beta2/ 
// Install Command: PM>  Install-Package Google.Apis.Resourceviews.v1beta2
//
//------------------------------------------------------------------------------  
using Google.Apis.Resourceviews.v1beta2;
using Google.Apis.Resourceviews.v1beta2.Data;
using System;

namespace GoogleSamplecSharpSample.Resourceviewsv1beta2.Methods
{
  
    public static class ZoneOperationsSample
    {


        /// <summary>
        /// Retrieves the specified zone-specific operation resource. 
        /// Documentation https://developers.google.com/resourceviews/v1beta2/reference/zoneOperations/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Resourceviews service.</param>  
        /// <param name="project">Name of the project scoping this request.</param>
        /// <param name="zone">Name of the zone scoping this request.</param>
        /// <param name="operation">Name of the operation resource to return.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Get(ResourceviewsService service, string project, string zone, string operation)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (zone == null)
                    throw new ArgumentNullException(zone);
                if (operation == null)
                    throw new ArgumentNullException(operation);

                // Make the request.
                return service.ZoneOperations.Get(project, zone, operation).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ZoneOperations.Get failed.", ex);
            }
        }
        public class ZoneOperationsListOptionalParms
        {
            /// Optional. Filter expression for filtering listed resources.
            public string Filter { get; set; }  
            /// Optional. Maximum count of results to be returned. Maximum value is 500 and default value is 500.
            public int? MaxResults { get; set; }  
            /// Optional. Tag returned by a previous list request truncated by maxResults. Used to continue a previous list request.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves the list of operation resources contained within the specified zone. 
        /// Documentation https://developers.google.com/resourceviews/v1beta2/reference/zoneOperations/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Resourceviews service.</param>  
        /// <param name="project">Name of the project scoping this request.</param>
        /// <param name="zone">Name of the zone scoping this request.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>OperationListResponse</returns>
        public static OperationList List(ResourceviewsService service, string project, string zone, ZoneOperationsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (zone == null)
                    throw new ArgumentNullException(zone);

                // Building the initial request.
                var request = service.ZoneOperations.List(project, zone);

                // Applying optional parameters to the request.                
                request = (ZoneOperationsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request ZoneOperations.List failed.", ex);
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