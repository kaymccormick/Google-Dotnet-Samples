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
// Unoffical sample for the Androidpublisher v1.1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Lets Android application developers access their Google Play accounts.
// API Documentation Link https://developers.google.com/android-publisher
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Androidpublisher/v1_1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Androidpublisher.v1_1/ 
// Install Command: PM>  Install-Package Google.Apis.Androidpublisher.v1_1
//
//------------------------------------------------------------------------------  
using Google.Apis.Androidpublisher.v1_1;
using Google.Apis.Androidpublisher.v1_1.Data;
using System;

namespace GoogleSamplecSharpSample.Androidpublisherv1_1.Methods
{
  
    public static class PurchasesSample
    {


        /// <summary>
        /// Cancels a user's subscription purchase. The subscription remains valid until its expiration time. 
        /// Documentation https://developers.google.com/androidpublisher/v1.1/reference/purchases/cancel
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidpublisher service.</param>  
        /// <param name="packageName">The package name of the application for which this subscription was purchased (for example, 'com.some.thing').</param>
        /// <param name="subscriptionId">The purchased subscription ID (for example, 'monthly001').</param>
        /// <param name="token">The token provided to the user's device when the subscription was purchased.</param>
        public static void Cancel(AndroidpublisherService service, string packageName, string subscriptionId, string token)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (packageName == null)
                    throw new ArgumentNullException(packageName);
                if (subscriptionId == null)
                    throw new ArgumentNullException(subscriptionId);
                if (token == null)
                    throw new ArgumentNullException(token);

                // Make the request.
                 service.Purchases.Cancel(packageName, subscriptionId, token).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Purchases.Cancel failed.", ex);
            }
        }

        /// <summary>
        /// Checks whether a user's subscription purchase is valid and returns its expiry time. 
        /// Documentation https://developers.google.com/androidpublisher/v1.1/reference/purchases/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Androidpublisher service.</param>  
        /// <param name="packageName">The package name of the application for which this subscription was purchased (for example, 'com.some.thing').</param>
        /// <param name="subscriptionId">The purchased subscription ID (for example, 'monthly001').</param>
        /// <param name="token">The token provided to the user's device when the subscription was purchased.</param>
        /// <returns>SubscriptionPurchaseResponse</returns>
        public static SubscriptionPurchase Get(AndroidpublisherService service, string packageName, string subscriptionId, string token)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (packageName == null)
                    throw new ArgumentNullException(packageName);
                if (subscriptionId == null)
                    throw new ArgumentNullException(subscriptionId);
                if (token == null)
                    throw new ArgumentNullException(token);

                // Make the request.
                return service.Purchases.Get(packageName, subscriptionId, token).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Purchases.Get failed.", ex);
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