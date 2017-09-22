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
// Unoffical sample for the Genomics v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Upload, process, query, and search Genomics data in the cloud.
// API Documentation Link https://cloud.google.com/genomics
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Genomics/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Genomics.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Genomics.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Genomics.v1;
using Google.Apis.Genomics.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Genomicsv1.Methods
{
  
    public static class OperationsSample
    {


        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the operation, but success is not guaranteed. Clients may use Operations.GetOperation or Operations.ListOperations to check whether the cancellation succeeded or the operation completed despite cancellation. 
        /// Documentation https://developers.google.com/genomics/v1/reference/operations/cancel
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Genomics service.</param>  
        /// <param name="name">The name of the operation resource to be cancelled.</param>
        /// <param name="body">A valid Genomics v1 body.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Cancel(GenomicsService service, string name, CancelOperationRequest body)
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
                return service.Operations.Cancel(body, name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Operations.Cancel failed.", ex);
            }
        }

        /// <summary>
        /// Gets the latest state of a long-running operation.  Clients can use thismethod to poll the operation result at intervals as recommended by the APIservice. 
        /// Documentation https://developers.google.com/genomics/v1/reference/operations/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Genomics service.</param>  
        /// <param name="name">The name of the operation resource.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Get(GenomicsService service, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.Operations.Get(name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Operations.Get failed.", ex);
            }
        }
        public class OperationsListOptionalParms
        {
            /// The standard list page token.
            public string PageToken { get; set; }  
            /// The maximum number of results to return. If unspecified, defaults to256. The maximum value is 2048.
            public int? PageSize { get; set; }  
            /// A string for filtering Operations.The following filter fields are supported&#58;* projectId&#58; Required. Corresponds to  OperationMetadata.projectId.* createTime&#58; The time this job was created, in seconds from the  [epoch](http://en.wikipedia.org/wiki/Unix_time). Can use `>=` and/or `<=`  operators.* status&#58; Can be `RUNNING`, `SUCCESS`, `FAILURE`, or `CANCELED`. Only  one status may be specified.* labels.key where key is a label key.Examples&#58;* `projectId = my-project AND createTime >= 1432140000`* `projectId = my-project AND createTime >= 1432140000 AND createTime <= 1432150000 AND status = RUNNING`* `projectId = my-project AND labels.color = *`* `projectId = my-project AND labels.color = red`
            public string Filter { get; set; }  
        
        }
 
        /// <summary>
        /// Lists operations that match the specified filter in the request. 
        /// Documentation https://developers.google.com/genomics/v1/reference/operations/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Genomics service.</param>  
        /// <param name="name">The name of the operation's parent resource.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ListOperationsResponseResponse</returns>
        public static ListOperationsResponse List(GenomicsService service, string name, OperationsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Building the initial request.
                var request = service.Operations.List(name);

                // Applying optional parameters to the request.                
                request = (OperationsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Operations.List failed.", ex);
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