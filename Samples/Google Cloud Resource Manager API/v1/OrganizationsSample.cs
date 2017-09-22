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
// Unoffical sample for the Cloudresourcemanager v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: The Google Cloud Resource Manager API provides methods for creating, reading, and updating project metadata.
// API Documentation Link https://cloud.google.com/resource-manager
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/Cloudresourcemanager/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library (https://github.com/google/google-api-dotnet-client)
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.Cloudresourcemanager.v1/ 
// Install Command: PM>  Install-Package Google.Apis.Cloudresourcemanager.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.Cloudresourcemanager.v1;
using Google.Apis.Cloudresourcemanager.v1.Data;
using System;

namespace GoogleSamplecSharpSample.Cloudresourcemanagerv1.Methods
{
  
    public static class OrganizationsSample
    {


        /// <summary>
        /// Lists `Constraints` that could be applied on the specified resource. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/organizations/listAvailableOrgPolicyConstraints
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="resource">Name of the resource to list `Constraints` for.</param>
        /// <param name="body">A valid Cloudresourcemanager v1 body.</param>
        /// <returns>ListAvailableOrgPolicyConstraintsResponseResponse</returns>
        public static ListAvailableOrgPolicyConstraintsResponse ListAvailableOrgPolicyConstraints(CloudresourcemanagerService service, string resource, ListAvailableOrgPolicyConstraintsRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Make the request.
                return service.Organizations.ListAvailableOrgPolicyConstraints(body, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Organizations.ListAvailableOrgPolicyConstraints failed.", ex);
            }
        }

        /// <summary>
        /// Lists all the `Policies` set for a particular resource. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/organizations/listOrgPolicies
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="resource">Name of the resource to list Policies for.</param>
        /// <param name="body">A valid Cloudresourcemanager v1 body.</param>
        /// <returns>ListOrgPoliciesResponseResponse</returns>
        public static ListOrgPoliciesResponse ListOrgPolicies(CloudresourcemanagerService service, string resource, ListOrgPoliciesRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Make the request.
                return service.Organizations.ListOrgPolicies(body, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Organizations.ListOrgPolicies failed.", ex);
            }
        }

        /// <summary>
        /// Gets the access control policy for an Organization resource. May be emptyif no such policy or resource exists. The `resource` field should be theorganization's resource name, e.g. "organizations/123".Authorization requires the Google IAM permission`resourcemanager.organizations.getIamPolicy` on the specified organization 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/organizations/getIamPolicy
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="resource">REQUIRED: The resource for which the policy is being requested.See the operation documentation for the appropriate value for this field.</param>
        /// <param name="body">A valid Cloudresourcemanager v1 body.</param>
        /// <returns>PolicyResponse</returns>
        public static Policy GetIamPolicy(CloudresourcemanagerService service, string resource, GetIamPolicyRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Make the request.
                return service.Organizations.GetIamPolicy(body, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Organizations.GetIamPolicy failed.", ex);
            }
        }

        /// <summary>
        /// Searches Organization resources that are visible to the user and satisfythe specified filter. This method returns Organizations in an unspecifiedorder. New Organizations do not necessarily appear at the end of theresults.Search will only return organizations on which the user has the permission`resourcemanager.organizations.get` 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/organizations/search
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="body">A valid Cloudresourcemanager v1 body.</param>
        /// <returns>SearchOrganizationsResponseResponse</returns>
        public static SearchOrganizationsResponse Search(CloudresourcemanagerService service, SearchOrganizationsRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Organizations.Search(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Organizations.Search failed.", ex);
            }
        }

        /// <summary>
        /// Gets a `Policy` on a resource.If no `Policy` is set on the resource, a `Policy` is returned with defaultvalues including `POLICY_TYPE_NOT_SET` for the `policy_type oneof`. The`etag` value can be used with `SetOrgPolicy()` to create or update a`Policy` during read-modify-write. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/organizations/getOrgPolicy
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="resource">Name of the resource the `Policy` is set on.</param>
        /// <param name="body">A valid Cloudresourcemanager v1 body.</param>
        /// <returns>OrgPolicyResponse</returns>
        public static OrgPolicy GetOrgPolicy(CloudresourcemanagerService service, string resource, GetOrgPolicyRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Make the request.
                return service.Organizations.GetOrgPolicy(body, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Organizations.GetOrgPolicy failed.", ex);
            }
        }

        /// <summary>
        /// Fetches an Organization resource identified by the specified resource name. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/organizations/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="name">The resource name of the Organization to fetch, e.g. "organizations/1234".</param>
        /// <returns>OrganizationResponse</returns>
        public static Organization Get(CloudresourcemanagerService service, string name)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (name == null)
                    throw new ArgumentNullException(name);

                // Make the request.
                return service.Organizations.Get(name).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Organizations.Get failed.", ex);
            }
        }

        /// <summary>
        /// Gets the effective `Policy` on a resource. This is the result of merging`Policies` in the resource hierarchy. The returned `Policy` will not havean `etag`set because it is a computed `Policy` across multiple resources. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/organizations/getEffectiveOrgPolicy
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="resource">The name of the resource to start computing the effective `Policy`.</param>
        /// <param name="body">A valid Cloudresourcemanager v1 body.</param>
        /// <returns>OrgPolicyResponse</returns>
        public static OrgPolicy GetEffectiveOrgPolicy(CloudresourcemanagerService service, string resource, GetEffectiveOrgPolicyRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Make the request.
                return service.Organizations.GetEffectiveOrgPolicy(body, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Organizations.GetEffectiveOrgPolicy failed.", ex);
            }
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified Organization.The `resource` field should be the organization's resource name,e.g. "organizations/123".There are no permissions required for making this API call. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/organizations/testIamPermissions
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="resource">REQUIRED: The resource for which the policy detail is being requested.See the operation documentation for the appropriate value for this field.</param>
        /// <param name="body">A valid Cloudresourcemanager v1 body.</param>
        /// <returns>TestIamPermissionsResponseResponse</returns>
        public static TestIamPermissionsResponse TestIamPermissions(CloudresourcemanagerService service, string resource, TestIamPermissionsRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Make the request.
                return service.Organizations.TestIamPermissions(body, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Organizations.TestIamPermissions failed.", ex);
            }
        }

        /// <summary>
        /// Clears a `Policy` from a resource. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/organizations/clearOrgPolicy
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="resource">Name of the resource for the `Policy` to clear.</param>
        /// <param name="body">A valid Cloudresourcemanager v1 body.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty ClearOrgPolicy(CloudresourcemanagerService service, string resource, ClearOrgPolicyRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Make the request.
                return service.Organizations.ClearOrgPolicy(body, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Organizations.ClearOrgPolicy failed.", ex);
            }
        }

        /// <summary>
        /// Updates the specified `Policy` on the resource. Creates a new `Policy` forthat `Constraint` on the resource if one does not exist.Not supplying an `etag` on the request `Policy` results in an unconditionalwrite of the `Policy`. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/organizations/setOrgPolicy
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="resource">Resource name of the resource to attach the `Policy`.</param>
        /// <param name="body">A valid Cloudresourcemanager v1 body.</param>
        /// <returns>OrgPolicyResponse</returns>
        public static OrgPolicy SetOrgPolicy(CloudresourcemanagerService service, string resource, SetOrgPolicyRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Make the request.
                return service.Organizations.SetOrgPolicy(body, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Organizations.SetOrgPolicy failed.", ex);
            }
        }

        /// <summary>
        /// Sets the access control policy on an Organization resource. Replaces anyexisting policy. The `resource` field should be the organization's resourcename, e.g. "organizations/123".Authorization requires the Google IAM permission`resourcemanager.organizations.setIamPolicy` on the specified organization 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/organizations/setIamPolicy
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="resource">REQUIRED: The resource for which the policy is being specified.See the operation documentation for the appropriate value for this field.</param>
        /// <param name="body">A valid Cloudresourcemanager v1 body.</param>
        /// <returns>PolicyResponse</returns>
        public static Policy SetIamPolicy(CloudresourcemanagerService service, string resource, SetIamPolicyRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (resource == null)
                    throw new ArgumentNullException(resource);

                // Make the request.
                return service.Organizations.SetIamPolicy(body, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Organizations.SetIamPolicy failed.", ex);
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