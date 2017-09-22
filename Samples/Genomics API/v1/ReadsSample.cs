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
  
    public static class ReadsSample
    {


        /// <summary>
        /// Gets a list of reads for one or more read group sets.For the definitions of read group sets and other genomics resources, see[Fundamentals of GoogleGenomics](https://cloud.google.com/genomics/fundamentals-of-google-genomics)Reads search operates over a genomic coordinate space of reference sequence& position defined over the reference sequences to which the requestedread group sets are aligned.If a target positional range is specified, search returns all reads whosealignment to the reference genome overlap the range. A query whichspecifies only read group set IDs yields all reads in those read groupsets, including unmapped reads.All reads returned (including reads on subsequent pages) are ordered bygenomic coordinate (by reference sequence, then position). Reads withequivalent genomic coordinates are returned in an unspecified order. Thisorder is consistent, such that two queries for the same content (regardlessof page size) yield reads in the same order across their respective streamsof paginated responses.Implements[GlobalAllianceApi.searchReads](https://github.com/ga4gh/schemas/blob/v0.5.1/src/main/resources/avro/readmethods.avdl#L85). 
        /// Documentation https://developers.google.com/genomics/v1/reference/reads/search
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Genomics service.</param>  
        /// <param name="body">A valid Genomics v1 body.</param>
        /// <returns>SearchReadsResponseResponse</returns>
        public static SearchReadsResponse Search(GenomicsService service, SearchReadsRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Reads.Search(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Reads.Search failed.", ex);
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