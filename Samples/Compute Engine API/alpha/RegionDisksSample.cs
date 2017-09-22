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
// Unoffical sample for the Compute alpha API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Creates and runs virtual machines on Google Cloud Platform.
// API Documentation Link https://developers.google.com/compute/docs/reference/latest/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Compute/alpha/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Compute.alpha/ 
// Install Command: PM>  Install-Package Google.Apis.Compute.alpha
//
//------------------------------------------------------------------------------  
using Google.Apis.Compute.alpha;
using Google.Apis.Compute.alpha.Data;
using System;

namespace GoogleSamplecSharpSample.Computealpha.Methods
{
  
    public static class RegionDisksSample
    {

        public class RegionDisksCreateSnapshotOptionalParms
        {
            /// NA
            public bool? GuestFlush { get; set; }  
            /// An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed.For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments.The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
            public string RequestId { get; set; }  
        
        }
 
        /// <summary>
        /// Creates a snapshot of this regional disk. 
        /// Documentation https://developers.google.com/compute/alpha/reference/regionDisks/createSnapshot
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region for this request.</param>
        /// <param name="disk">Name of the regional persistent disk to snapshot.</param>
        /// <param name="body">A valid Compute alpha body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>OperationResponse</returns>
        public static Operation CreateSnapshot(ComputeService service, string project, string region, string disk, Snapshot body, RegionDisksCreateSnapshotOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);
                if (disk == null)
                    throw new ArgumentNullException(disk);

                // Building the initial request.
                var request = service.RegionDisks.CreateSnapshot(body, project, region, disk);

                // Applying optional parameters to the request.                
                request = (RegionDisksResource.CreateSnapshotRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RegionDisks.CreateSnapshot failed.", ex);
            }
        }
        public class RegionDisksDeleteOptionalParms
        {
            /// An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed.For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments.The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
            public string RequestId { get; set; }  
        
        }
 
        /// <summary>
        /// Deletes the specified regional persistent disk. Deleting a regional disk removes all the replicas of its data permanently and is irreversible. However, deleting a disk does not delete any snapshots previously made from the disk. You must separately delete snapshots. 
        /// Documentation https://developers.google.com/compute/alpha/reference/regionDisks/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region for this request.</param>
        /// <param name="disk">Name of the regional persistent disk to delete.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Delete(ComputeService service, string project, string region, string disk, RegionDisksDeleteOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);
                if (disk == null)
                    throw new ArgumentNullException(disk);

                // Building the initial request.
                var request = service.RegionDisks.Delete(project, region, disk);

                // Applying optional parameters to the request.                
                request = (RegionDisksResource.DeleteRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RegionDisks.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Returns a specified regional persistent disk. 
        /// Documentation https://developers.google.com/compute/alpha/reference/regionDisks/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region for this request.</param>
        /// <param name="disk">Name of the regional persistent disk to return.</param>
        /// <returns>DiskResponse</returns>
        public static Disk Get(ComputeService service, string project, string region, string disk)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);
                if (disk == null)
                    throw new ArgumentNullException(disk);

                // Make the request.
                return service.RegionDisks.Get(project, region, disk).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RegionDisks.Get failed.", ex);
            }
        }
        public class RegionDisksInsertOptionalParms
        {
            /// An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed.For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments.The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
            public string RequestId { get; set; }  
            /// Optional. Source image to restore onto a disk.
            public string SourceImage { get; set; }  
        
        }
 
        /// <summary>
        /// Creates a persistent regional disk in the specified project using the data included in the request. 
        /// Documentation https://developers.google.com/compute/alpha/reference/regionDisks/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region for this request.</param>
        /// <param name="body">A valid Compute alpha body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Insert(ComputeService service, string project, string region, Disk body, RegionDisksInsertOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);

                // Building the initial request.
                var request = service.RegionDisks.Insert(body, project, region);

                // Applying optional parameters to the request.                
                request = (RegionDisksResource.InsertRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RegionDisks.Insert failed.", ex);
            }
        }
        public class RegionDisksListOptionalParms
        {
            /// Sets a filter {expression} for filtering listed resources. Your {expression} must be in the format: field_name comparison_string literal_string.The field_name is the name of the field you want to compare. Only atomic field types are supported (string, number, boolean). The comparison_string must be either eq (equals) or ne (not equals). The literal_string is the string value to filter to. The literal value must be valid for the type of field you are filtering by (string, number, boolean). For string fields, the literal value is interpreted as a regular expression using RE2 syntax. The literal value must match the entire field.For example, to filter for instances that do not have a name of example-instance, you would use name ne example-instance.You can filter on nested fields. For example, you could filter on instances that have set the scheduling.automaticRestart field to true. Use filtering on nested fields to take advantage of labels to organize and search for results based on label values.To filter on multiple expressions, provide each separate expression within parentheses. For example, (scheduling.automaticRestart eq true) (zone eq us-central1-f). Multiple expressions are treated as AND expressions, meaning that resources must match all expressions to pass the filters.
            public string Filter { get; set; }  
            /// The maximum number of results per page that should be returned. If the number of available results is larger than maxResults, Compute Engine returns a nextPageToken that can be used to get the next page of results in subsequent list requests. Acceptable values are 0 to 500, inclusive. (Default: 500)
            public int? MaxResults { get; set; }  
            /// Sorts list results by a certain order. By default, results are returned in alphanumerical order based on the resource name.You can also sort results in descending order based on the creation timestamp using orderBy="creationTimestamp desc". This sorts results based on the creationTimestamp field in reverse chronological order (newest result first). Use this to sort resources like operations so that the newest operation is returned first.Currently, only sorting by name or creationTimestamp desc is supported.
            public string OrderBy { get; set; }  
            /// Specifies a page token to use. Set pageToken to the nextPageToken returned by a previous list request to get the next page of results.
            public string PageToken { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves the list of persistent disks contained within the specified region. 
        /// Documentation https://developers.google.com/compute/alpha/reference/regionDisks/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">Name of the region for this request.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>DiskListResponse</returns>
        public static DiskList List(ComputeService service, string project, string region, RegionDisksListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);

                // Building the initial request.
                var request = service.RegionDisks.List(project, region);

                // Applying optional parameters to the request.                
                request = (RegionDisksResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RegionDisks.List failed.", ex);
            }
        }
        public class RegionDisksResizeOptionalParms
        {
            /// An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed.For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments.The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
            public string RequestId { get; set; }  
        
        }
 
        /// <summary>
        /// Resizes the specified regional persistent disk. 
        /// Documentation https://developers.google.com/compute/alpha/reference/regionDisks/resize
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">The project ID for this request.</param>
        /// <param name="region">Name of the region for this request.</param>
        /// <param name="disk">Name of the regional persistent disk.</param>
        /// <param name="body">A valid Compute alpha body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Resize(ComputeService service, string project, string region, string disk, RegionDisksResizeRequest body, RegionDisksResizeOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);
                if (disk == null)
                    throw new ArgumentNullException(disk);

                // Building the initial request.
                var request = service.RegionDisks.Resize(body, project, region, disk);

                // Applying optional parameters to the request.                
                request = (RegionDisksResource.ResizeRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RegionDisks.Resize failed.", ex);
            }
        }
        public class RegionDisksSetLabelsOptionalParms
        {
            /// An optional request ID to identify requests. Specify a unique request ID so that if you must retry your request, the server will know to ignore the request if it has already been completed.For example, consider a situation where you make an initial request and the request times out. If you make the request again with the same request ID, the server can check if original operation with the same request ID was received, and if so, will ignore the second request. This prevents clients from accidentally creating duplicate commitments.The request ID must be a valid UUID with the exception that zero UUID is not supported (00000000-0000-0000-0000-000000000000).
            public string RequestId { get; set; }  
        
        }
 
        /// <summary>
        /// Sets the labels on the target regional disk. 
        /// Documentation https://developers.google.com/compute/alpha/reference/regionDisks/setLabels
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">The region for this request.</param>
        /// <param name="resource">Name of the resource for this request.</param>
        /// <param name="body">A valid Compute alpha body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>OperationResponse</returns>
        public static Operation SetLabels(ComputeService service, string project, string region, string resource, RegionSetLabelsRequest body, RegionDisksSetLabelsOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Building the initial request.
                var request = service.RegionDisks.SetLabels(body, project, region, resource);

                // Applying optional parameters to the request.                
                request = (RegionDisksResource.SetLabelsRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RegionDisks.SetLabels failed.", ex);
            }
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource. 
        /// Documentation https://developers.google.com/compute/alpha/reference/regionDisks/testIamPermissions
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Compute service.</param>  
        /// <param name="project">Project ID for this request.</param>
        /// <param name="region">The name of the region for this request.</param>
        /// <param name="resource">Name of the resource for this request.</param>
        /// <param name="body">A valid Compute alpha body.</param>
        /// <returns>TestPermissionsResponseResponse</returns>
        public static TestPermissionsResponse TestIamPermissions(ComputeService service, string project, string region, string resource, TestPermissionsRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (project == null)
                    throw new ArgumentNullException(project);
                if (region == null)
                    throw new ArgumentNullException(region);
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Make the request.
                return service.RegionDisks.TestIamPermissions(body, project, region, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request RegionDisks.TestIamPermissions failed.", ex);
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