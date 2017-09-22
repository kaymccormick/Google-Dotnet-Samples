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
// Unoffical sample for the Storage v1beta2 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Lets you store and retrieve potentially-large, immutable data objects.
// API Documentation Link https://developers.google.com/storage/docs/json_api/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Storage/v1beta2/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Storage.v1beta2/ 
// Install Command: PM>  Install-Package Google.Apis.Storage.v1beta2
//
//------------------------------------------------------------------------------  
using Google.Apis.Storage.v1beta2;
using Google.Apis.Storage.v1beta2.Data;
using System;

namespace GoogleSamplecSharpSample.Storagev1beta2.Methods
{
  
    public static class ObjectsSample
    {

        public class ObjectsComposeOptionalParms
        {
            /// Makes the operation conditional on whether the object's current generation matches the given value.
            public string IfGenerationMatch { get; set; }  
            /// Makes the operation conditional on whether the object's current metageneration matches the given value.
            public string IfMetagenerationMatch { get; set; }  
        
        }
 
        /// <summary>
        /// Concatenates a list of existing objects into a new object in the same bucket. 
        /// Documentation https://developers.google.com/storage/v1beta2/reference/objects/compose
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="destinationBucket">Name of the bucket in which to store the new object.</param>
        /// <param name="destinationObject">Name of the new object.</param>
        /// <param name="body">A valid Storage v1beta2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ObjectResponse</returns>
        public static Object Compose(StorageService service, string destinationBucket, string destinationObject, ComposeRequest body, ObjectsComposeOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (destinationBucket == null)
                    throw new ArgumentNullException(destinationBucket);
                if (destinationObject == null)
                    throw new ArgumentNullException(destinationObject);

                // Building the initial request.
                var request = service.Objects.Compose(body, destinationBucket, destinationObject);

                // Applying optional parameters to the request.                
                request = (ObjectsResource.ComposeRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Objects.Compose failed.", ex);
            }
        }
        public class ObjectsCopyOptionalParms
        {
            /// Makes the operation conditional on whether the destination object's current generation matches the given value.
            public string IfGenerationMatch { get; set; }  
            /// Makes the operation conditional on whether the destination object's current generation does not match the given value.
            public string IfGenerationNotMatch { get; set; }  
            /// Makes the operation conditional on whether the destination object's current metageneration matches the given value.
            public string IfMetagenerationMatch { get; set; }  
            /// Makes the operation conditional on whether the destination object's current metageneration does not match the given value.
            public string IfMetagenerationNotMatch { get; set; }  
            /// Makes the operation conditional on whether the source object's generation matches the given value.
            public string IfSourceGenerationMatch { get; set; }  
            /// Makes the operation conditional on whether the source object's generation does not match the given value.
            public string IfSourceGenerationNotMatch { get; set; }  
            /// Makes the operation conditional on whether the source object's current metageneration matches the given value.
            public string IfSourceMetagenerationMatch { get; set; }  
            /// Makes the operation conditional on whether the source object's current metageneration does not match the given value.
            public string IfSourceMetagenerationNotMatch { get; set; }  
            /// Set of properties to return. Defaults to noAcl, unless the object resource specifies the acl property, when it defaults to full.
            public string Projection { get; set; }  
            /// If present, selects a specific revision of the source object (as opposed to the latest version, the default).
            public string SourceGeneration { get; set; }  
        
        }
 
        /// <summary>
        /// Copies an object to a destination in the same location. Optionally overrides metadata. 
        /// Documentation https://developers.google.com/storage/v1beta2/reference/objects/copy
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="sourceBucket">Name of the bucket in which to find the source object.</param>
        /// <param name="sourceObject">Name of the source object.</param>
        /// <param name="destinationBucket">Name of the bucket in which to store the new object. Overrides the provided object metadata's bucket value, if any.</param>
        /// <param name="destinationObject">Name of the new object. Required when the object metadata is not otherwise provided. Overrides the object metadata's name value, if any.</param>
        /// <param name="body">A valid Storage v1beta2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ObjectResponse</returns>
        public static Object Copy(StorageService service, string sourceBucket, string sourceObject, string destinationBucket, string destinationObject, Object body, ObjectsCopyOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (sourceBucket == null)
                    throw new ArgumentNullException(sourceBucket);
                if (sourceObject == null)
                    throw new ArgumentNullException(sourceObject);
                if (destinationBucket == null)
                    throw new ArgumentNullException(destinationBucket);
                if (destinationObject == null)
                    throw new ArgumentNullException(destinationObject);

                // Building the initial request.
                var request = service.Objects.Copy(body, sourceBucket, sourceObject, destinationBucket, destinationObject);

                // Applying optional parameters to the request.                
                request = (ObjectsResource.CopyRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Objects.Copy failed.", ex);
            }
        }
        public class ObjectsDeleteOptionalParms
        {
            /// If present, permanently deletes a specific revision of this object (as opposed to the latest version, the default).
            public string Generation { get; set; }  
            /// Makes the operation conditional on whether the object's current generation matches the given value.
            public string IfGenerationMatch { get; set; }  
            /// Makes the operation conditional on whether the object's current generation does not match the given value.
            public string IfGenerationNotMatch { get; set; }  
            /// Makes the operation conditional on whether the object's current metageneration matches the given value.
            public string IfMetagenerationMatch { get; set; }  
            /// Makes the operation conditional on whether the object's current metageneration does not match the given value.
            public string IfMetagenerationNotMatch { get; set; }  
        
        }
 
        /// <summary>
        /// Deletes data blobs and associated metadata. Deletions are permanent if versioning is not enabled for the bucket, or if the generation parameter is used. 
        /// Documentation https://developers.google.com/storage/v1beta2/reference/objects/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="bucket">Name of the bucket in which the object resides.</param>
        /// <param name="object">Name of the object.</param>
        /// <param name="optional">Optional paramaters.</param>
        public static void Delete(StorageService service, string bucket, string object, ObjectsDeleteOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);
                if (object == null)
                    throw new ArgumentNullException(object);

                // Building the initial request.
                var request = service.Objects.Delete(bucket, object);

                // Applying optional parameters to the request.                
                request = (ObjectsResource.DeleteRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                 request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Objects.Delete failed.", ex);
            }
        }
        public class ObjectsGetOptionalParms
        {
            /// If present, selects a specific revision of this object (as opposed to the latest version, the default).
            public string Generation { get; set; }  
            /// Makes the operation conditional on whether the object's generation matches the given value.
            public string IfGenerationMatch { get; set; }  
            /// Makes the operation conditional on whether the object's generation does not match the given value.
            public string IfGenerationNotMatch { get; set; }  
            /// Makes the operation conditional on whether the object's current metageneration matches the given value.
            public string IfMetagenerationMatch { get; set; }  
            /// Makes the operation conditional on whether the object's current metageneration does not match the given value.
            public string IfMetagenerationNotMatch { get; set; }  
            /// Set of properties to return. Defaults to noAcl.
            public string Projection { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves objects or their associated metadata. 
        /// Documentation https://developers.google.com/storage/v1beta2/reference/objects/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="bucket">Name of the bucket in which the object resides.</param>
        /// <param name="object">Name of the object.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ObjectResponse</returns>
        public static Object Get(StorageService service, string bucket, string object, ObjectsGetOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);
                if (object == null)
                    throw new ArgumentNullException(object);

                // Building the initial request.
                var request = service.Objects.Get(bucket, object);

                // Applying optional parameters to the request.                
                request = (ObjectsResource.GetRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Objects.Get failed.", ex);
            }
        }
        public class ObjectsInsertOptionalParms
        {
            /// Makes the operation conditional on whether the object's current generation matches the given value.
            public string IfGenerationMatch { get; set; }  
            /// Makes the operation conditional on whether the object's current generation does not match the given value.
            public string IfGenerationNotMatch { get; set; }  
            /// Makes the operation conditional on whether the object's current metageneration matches the given value.
            public string IfMetagenerationMatch { get; set; }  
            /// Makes the operation conditional on whether the object's current metageneration does not match the given value.
            public string IfMetagenerationNotMatch { get; set; }  
            /// Name of the object. Required when the object metadata is not otherwise provided. Overrides the object metadata's name value, if any.
            public string Name { get; set; }  
            /// Set of properties to return. Defaults to noAcl, unless the object resource specifies the acl property, when it defaults to full.
            public string Projection { get; set; }  
        
        }
 
        /// <summary>
        /// Stores new data blobs and associated metadata. 
        /// Documentation https://developers.google.com/storage/v1beta2/reference/objects/insert
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="bucket">Name of the bucket in which to store the new object. Overrides the provided object metadata's bucket value, if any.</param>
        /// <param name="body">A valid Storage v1beta2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ObjectResponse</returns>
        public static Object Insert(StorageService service, string bucket, Object body, ObjectsInsertOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);

                // Building the initial request.
                var request = service.Objects.Insert(body, bucket);

                // Applying optional parameters to the request.                
                request = (ObjectsResource.InsertRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Objects.Insert failed.", ex);
            }
        }
        public class ObjectsListOptionalParms
        {
            /// Returns results in a directory-like mode. items will contain only objects whose names, aside from the prefix, do not contain delimiter. Objects whose names, aside from the prefix, contain delimiter will have their name, truncated after the delimiter, returned in prefixes. Duplicate prefixes are omitted.
            public string Delimiter { get; set; }  
            /// Maximum number of items plus prefixes to return. As duplicate prefixes are omitted, fewer total results may be returned than requested.
            public int? MaxResults { get; set; }  
            /// A previously-returned page token representing part of the larger set of results to view.
            public string PageToken { get; set; }  
            /// Filter results to objects whose names begin with this prefix.
            public string Prefix { get; set; }  
            /// Set of properties to return. Defaults to noAcl.
            public string Projection { get; set; }  
            /// If true, lists all versions of a file as distinct results.
            public bool? Versions { get; set; }  
        
        }
 
        /// <summary>
        /// Retrieves a list of objects matching the criteria. 
        /// Documentation https://developers.google.com/storage/v1beta2/reference/objects/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="bucket">Name of the bucket in which to look for objects.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ObjectsResponse</returns>
        public static Objects List(StorageService service, string bucket, ObjectsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);

                // Building the initial request.
                var request = service.Objects.List(bucket);

                // Applying optional parameters to the request.                
                request = (ObjectsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Objects.List failed.", ex);
            }
        }
        public class ObjectsPatchOptionalParms
        {
            /// If present, selects a specific revision of this object (as opposed to the latest version, the default).
            public string Generation { get; set; }  
            /// Makes the operation conditional on whether the object's current generation matches the given value.
            public string IfGenerationMatch { get; set; }  
            /// Makes the operation conditional on whether the object's current generation does not match the given value.
            public string IfGenerationNotMatch { get; set; }  
            /// Makes the operation conditional on whether the object's current metageneration matches the given value.
            public string IfMetagenerationMatch { get; set; }  
            /// Makes the operation conditional on whether the object's current metageneration does not match the given value.
            public string IfMetagenerationNotMatch { get; set; }  
            /// Set of properties to return. Defaults to full.
            public string Projection { get; set; }  
        
        }
 
        /// <summary>
        /// Updates a data blob's associated metadata. This method supports patch semantics. 
        /// Documentation https://developers.google.com/storage/v1beta2/reference/objects/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="bucket">Name of the bucket in which the object resides.</param>
        /// <param name="object">Name of the object.</param>
        /// <param name="body">A valid Storage v1beta2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ObjectResponse</returns>
        public static Object Patch(StorageService service, string bucket, string object, Object body, ObjectsPatchOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);
                if (object == null)
                    throw new ArgumentNullException(object);

                // Building the initial request.
                var request = service.Objects.Patch(body, bucket, object);

                // Applying optional parameters to the request.                
                request = (ObjectsResource.PatchRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Objects.Patch failed.", ex);
            }
        }
        public class ObjectsUpdateOptionalParms
        {
            /// If present, selects a specific revision of this object (as opposed to the latest version, the default).
            public string Generation { get; set; }  
            /// Makes the operation conditional on whether the object's current generation matches the given value.
            public string IfGenerationMatch { get; set; }  
            /// Makes the operation conditional on whether the object's current generation does not match the given value.
            public string IfGenerationNotMatch { get; set; }  
            /// Makes the operation conditional on whether the object's current metageneration matches the given value.
            public string IfMetagenerationMatch { get; set; }  
            /// Makes the operation conditional on whether the object's current metageneration does not match the given value.
            public string IfMetagenerationNotMatch { get; set; }  
            /// Set of properties to return. Defaults to full.
            public string Projection { get; set; }  
        
        }
 
        /// <summary>
        /// Updates a data blob's associated metadata. 
        /// Documentation https://developers.google.com/storage/v1beta2/reference/objects/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="bucket">Name of the bucket in which the object resides.</param>
        /// <param name="object">Name of the object.</param>
        /// <param name="body">A valid Storage v1beta2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ObjectResponse</returns>
        public static Object Update(StorageService service, string bucket, string object, Object body, ObjectsUpdateOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);
                if (object == null)
                    throw new ArgumentNullException(object);

                // Building the initial request.
                var request = service.Objects.Update(body, bucket, object);

                // Applying optional parameters to the request.                
                request = (ObjectsResource.UpdateRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Objects.Update failed.", ex);
            }
        }
        public class ObjectsWatchAllOptionalParms
        {
            /// Returns results in a directory-like mode. items will contain only objects whose names, aside from the prefix, do not contain delimiter. Objects whose names, aside from the prefix, contain delimiter will have their name, truncated after the delimiter, returned in prefixes. Duplicate prefixes are omitted.
            public string Delimiter { get; set; }  
            /// Maximum number of items plus prefixes to return. As duplicate prefixes are omitted, fewer total results may be returned than requested.
            public int? MaxResults { get; set; }  
            /// A previously-returned page token representing part of the larger set of results to view.
            public string PageToken { get; set; }  
            /// Filter results to objects whose names begin with this prefix.
            public string Prefix { get; set; }  
            /// Set of properties to return. Defaults to noAcl.
            public string Projection { get; set; }  
            /// If true, lists all versions of a file as distinct results.
            public bool? Versions { get; set; }  
        
        }
 
        /// <summary>
        /// Watch for changes on all objects in a bucket. 
        /// Documentation https://developers.google.com/storage/v1beta2/reference/objects/watchAll
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Storage service.</param>  
        /// <param name="bucket">Name of the bucket in which to look for objects.</param>
        /// <param name="body">A valid Storage v1beta2 body.</param>
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ChannelResponse</returns>
        public static Channel WatchAll(StorageService service, string bucket, Channel body, ObjectsWatchAllOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (bucket == null)
                    throw new ArgumentNullException(bucket);

                // Building the initial request.
                var request = service.Objects.WatchAll(body, bucket);

                // Applying optional parameters to the request.                
                request = (ObjectsResource.WatchAllRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Objects.WatchAll failed.", ex);
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