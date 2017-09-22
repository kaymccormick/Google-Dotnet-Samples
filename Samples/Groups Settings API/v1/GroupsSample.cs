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
// Unoffical sample for the Groupssettings v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Lets you manage permission levels and related settings of a group.
// API Documentation Link https://developers.google.com/google-apps/groups-settings/get_started
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Groupssettings/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Groupssettings.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Groupssettings.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Groupssettings.v1;
using Google.Apis.Groupssettings.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Groupssettingsv1.Methods
{
  
    public static class GroupsSample
    {


        /// <summary>
        /// Gets one resource by id. 
        /// Documentation https://developers.google.com/groupssettings/v1/reference/groups/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Groupssettings service.</param>  
        /// <param name="groupUniqueId">The resource ID</param>
        /// <returns>GroupsResponse</returns>
        public static Groups Get(GroupssettingsService service, string groupUniqueId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (groupUniqueId == null)
                    throw new ArgumentNullException(groupUniqueId);

                // Make the request.
                return service.Groups.Get(groupUniqueId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Groups.Get failed.", ex);
            }
        }

        /// <summary>
        /// Updates an existing resource. This method supports patch semantics. 
        /// Documentation https://developers.google.com/groupssettings/v1/reference/groups/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Groupssettings service.</param>  
        /// <param name="groupUniqueId">The resource ID</param>
        /// <param name="body">A valid Groupssettings v1 body.</param>
        /// <returns>GroupsResponse</returns>
        public static Groups Patch(GroupssettingsService service, string groupUniqueId, Groups body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (groupUniqueId == null)
                    throw new ArgumentNullException(groupUniqueId);

                // Make the request.
                return service.Groups.Patch(body, groupUniqueId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Groups.Patch failed.", ex);
            }
        }

        /// <summary>
        /// Updates an existing resource. 
        /// Documentation https://developers.google.com/groupssettings/v1/reference/groups/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Groupssettings service.</param>  
        /// <param name="groupUniqueId">The resource ID</param>
        /// <param name="body">A valid Groupssettings v1 body.</param>
        /// <returns>GroupsResponse</returns>
        public static Groups Update(GroupssettingsService service, string groupUniqueId, Groups body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (groupUniqueId == null)
                    throw new ArgumentNullException(groupUniqueId);

                // Make the request.
                return service.Groups.Update(body, groupUniqueId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Groups.Update failed.", ex);
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