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
// Unoffical sample for the Drive v3 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Manages files in Drive including uploading, downloading, searching, detecting changes, and updating sharing permissions.
// API Documentation Link https://developers.google.com/drive/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Drive/v3/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Drive.v3/ 
// Install Command: PM>  Install-Package Google.Apis.Drive.v3
//
//------------------------------------------------------------------------------  
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using System;

namespace GoogleSamplecSharpSample.Drivev3.Methods
{
  
    public static class PermissionsSample
    {

        public class PermissionsCreateOptionalParms
        {
            /// A custom message to include in the notification email.
            public string EmailMessage { get; set; }  
            /// Whether to send a notification email when sharing to users or groups. This defaults to true for users and groups, and is not allowed for other requests. It must not be disabled for ownership transfers.
            public bool? SendNotificationEmail { get; set; }  
            /// Whether the requesting application supports Team Drives.
            public bool? SupportsTeamDrives { get; set; }  
            /// Whether to transfer ownership to the specified user and downgrade the current owner to a writer. This parameter is required as an acknowledgement of the side effect.
            public bool? TransferOwnership { get; set; }  
        
        }
 
        /// <summary>
        /// Creates a permission for a file or Team Drive. 
        /// Documentation https://developers.google.com/drive/v3/reference/permissions/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID of the file or Team Drive.</param>
        /// <param name="body">A valid Drive v3 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>PermissionResponse</returns>
        public static Permission Create(DriveService service, string fileId, Permission body, PermissionsCreateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);

                // Building the initial request.
                var request = service.Permissions.Create(body, fileId);

                // Applying optional parameters to the request.                
                request = (PermissionsResource.CreateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Permissions.Create failed.", ex);
            }
        }
        public class PermissionsDeleteOptionalParms
        {
            /// Whether the requesting application supports Team Drives.
            public bool? SupportsTeamDrives { get; set; }  
        
        }
 
        /// <summary>
        /// Deletes a permission. 
        /// Documentation https://developers.google.com/drive/v3/reference/permissions/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID of the file or Team Drive.</param>
        /// <param name="permissionId">The ID of the permission.</param>
        /// <param name="optional">Optional paramaters.</param>
        public static void Delete(DriveService service, string fileId, string permissionId, PermissionsDeleteOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);
                if (permissionId == null)
                    throw new ArgumentNullException(permissionId);

                // Building the initial request.
                var request = service.Permissions.Delete(fileId, permissionId);

                // Applying optional parameters to the request.                
                request = (PermissionsResource.DeleteRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                 request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Permissions.Delete failed.", ex);
            }
        }
        public class PermissionsGetOptionalParms
        {
            /// Whether the requesting application supports Team Drives.
            public bool? SupportsTeamDrives { get; set; }  
        
        }
 
        /// <summary>
        /// Gets a permission by ID. 
        /// Documentation https://developers.google.com/drive/v3/reference/permissions/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID of the file.</param>
        /// <param name="permissionId">The ID of the permission.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>PermissionResponse</returns>
        public static Permission Get(DriveService service, string fileId, string permissionId, PermissionsGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);
                if (permissionId == null)
                    throw new ArgumentNullException(permissionId);

                // Building the initial request.
                var request = service.Permissions.Get(fileId, permissionId);

                // Applying optional parameters to the request.                
                request = (PermissionsResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Permissions.Get failed.", ex);
            }
        }
        public class PermissionsListOptionalParms
        {
            /// The maximum number of permissions to return per page. When not set for files in a Team Drive, at most 100 results will be returned. When not set for files that are not in a Team Drive, the entire list will be returned.
            public int? PageSize { get; set; }  
            /// The token for continuing a previous list request on the next page. This should be set to the value of 'nextPageToken' from the previous response.
            public string PageToken { get; set; }  
            /// Whether the requesting application supports Team Drives.
            public bool? SupportsTeamDrives { get; set; }  
        
        }
 
        /// <summary>
        /// Lists a file's or Team Drive's permissions. 
        /// Documentation https://developers.google.com/drive/v3/reference/permissions/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID of the file or Team Drive.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>PermissionListResponse</returns>
        public static PermissionList List(DriveService service, string fileId, PermissionsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);

                // Building the initial request.
                var request = service.Permissions.List(fileId);

                // Applying optional parameters to the request.                
                request = (PermissionsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Permissions.List failed.", ex);
            }
        }
        public class PermissionsUpdateOptionalParms
        {
            /// Whether to remove the expiration date.
            public bool? RemoveExpiration { get; set; }  
            /// Whether the requesting application supports Team Drives.
            public bool? SupportsTeamDrives { get; set; }  
            /// Whether to transfer ownership to the specified user and downgrade the current owner to a writer. This parameter is required as an acknowledgement of the side effect.
            public bool? TransferOwnership { get; set; }  
        
        }
 
        /// <summary>
        /// Updates a permission with patch semantics. 
        /// Documentation https://developers.google.com/drive/v3/reference/permissions/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Drive service.</param>  
        /// <param name="fileId">The ID of the file or Team Drive.</param>
        /// <param name="permissionId">The ID of the permission.</param>
        /// <param name="body">A valid Drive v3 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>PermissionResponse</returns>
        public static Permission Update(DriveService service, string fileId, string permissionId, Permission body, PermissionsUpdateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (fileId == null)
                    throw new ArgumentNullException(fileId);
                if (permissionId == null)
                    throw new ArgumentNullException(permissionId);

                // Building the initial request.
                var request = service.Permissions.Update(body, fileId, permissionId);

                // Applying optional parameters to the request.                
                request = (PermissionsResource.UpdateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Permissions.Update failed.", ex);
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