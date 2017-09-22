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
// Unoffical sample for the Reports reports_v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Fetches reports for the administrators of G Suite customers about the usage, collaboration, security, and risk for their users.
// API Documentation Link https://developers.google.com/admin-sdk/reports/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Reports/reports_v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Reports.reports_v1/ 
// Install Command: PM>  Install-Package Google.Apis.Reports.reports_v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Reports.reports_v1;
using Google.Apis.Reports.reports_v1.Data;
using System;

namespace GoogleSamplecSharpSample.Reportsreports_v1.Methods
{
  
    public static class ActivitiesSample
    {

        public class ActivitiesListOptionalParms
        {
            /// IP Address of host where the event was performed. Supports both IPv4 and IPv6 addresses.
            public string ActorIpAddress { get; set; }  
            /// Represents the customer for which the data is to be fetched.
            public string CustomerId { get; set; }  
            /// Return events which occurred at or before this time.
            public string EndTime { get; set; }  
            /// Name of the event being queried.
            public string EventName { get; set; }  
            /// Event parameters in the form [parameter1 name][operator][parameter1 value],[parameter2 name][operator][parameter2 value],...
            public string Filters { get; set; }  
            /// Number of activity records to be shown in each page.
            public int? MaxResults { get; set; }  
            /// Token to specify next page.
            public string PageToken { get; set; }  
            /// Return events which occurred at or after this time.
            public string StartTime { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of activities for a specific customer and application. 
        /// Documentation https://developers.google.com/reports/reports_v1/reference/activities/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Reports service.</param>  
        /// <param name="userKey">Represents the profile id or the user email for which the data should be filtered. When 'all' is specified as the userKey, it returns usageReports for all users.</param>
        /// <param name="applicationName">Application name for which the events are to be retrieved.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ActivitiesResponse</returns>
        public static Activities List(ReportsService service, string userKey, string applicationName, ActivitiesListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (userKey == null)
                    throw new ArgumentNullException(userKey);
                if (applicationName == null)
                    throw new ArgumentNullException(applicationName);

                // Building the initial request.
                var request = service.Activities.List(userKey, applicationName);

                // Applying optional parameters to the request.                
                request = (ActivitiesResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Activities.List failed.", ex);
            }
        }
        public class ActivitiesWatchOptionalParms
        {
            /// IP Address of host where the event was performed. Supports both IPv4 and IPv6 addresses.
            public string ActorIpAddress { get; set; }  
            /// Represents the customer for which the data is to be fetched.
            public string CustomerId { get; set; }  
            /// Return events which occurred at or before this time.
            public string EndTime { get; set; }  
            /// Name of the event being queried.
            public string EventName { get; set; }  
            /// Event parameters in the form [parameter1 name][operator][parameter1 value],[parameter2 name][operator][parameter2 value],...
            public string Filters { get; set; }  
            /// Number of activity records to be shown in each page.
            public int? MaxResults { get; set; }  
            /// Token to specify next page.
            public string PageToken { get; set; }  
            /// Return events which occurred at or after this time.
            public string StartTime { get; set; }  
        
        }
 
        /// <summary>
        /// Push changes to activities 
        /// Documentation https://developers.google.com/reports/reports_v1/reference/activities/watch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Reports service.</param>  
        /// <param name="userKey">Represents the profile id or the user email for which the data should be filtered. When 'all' is specified as the userKey, it returns usageReports for all users.</param>
        /// <param name="applicationName">Application name for which the events are to be retrieved.</param>
        /// <param name="body">A valid Reports reports_v1 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ChannelResponse</returns>
        public static Channel Watch(ReportsService service, string userKey, string applicationName, Channel body, ActivitiesWatchOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (userKey == null)
                    throw new ArgumentNullException(userKey);
                if (applicationName == null)
                    throw new ArgumentNullException(applicationName);

                // Building the initial request.
                var request = service.Activities.Watch(body, userKey, applicationName);

                // Applying optional parameters to the request.                
                request = (ActivitiesResource.WatchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Activities.Watch failed.", ex);
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