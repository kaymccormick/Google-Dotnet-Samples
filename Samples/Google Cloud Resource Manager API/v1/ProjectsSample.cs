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
  
    public static class ProjectsSample
    {


        /// <summary>
        /// Lists `Constraints` that could be applied on the specified resource. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/projects/listAvailableOrgPolicyConstraints
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
                return service.Projects.ListAvailableOrgPolicyConstraints(body, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.ListAvailableOrgPolicyConstraints failed.", ex);
            }
        }

        /// <summary>
        /// Returns the IAM access control policy for the specified Project.Permission is denied if the policy or the resource does not exist.Authorization requires the Google IAM permission`resourcemanager.projects.getIamPolicy` on the project 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/projects/getIamPolicy
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
                return service.Projects.GetIamPolicy(body, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.GetIamPolicy failed.", ex);
            }
        }

        /// <summary>
        /// Gets a `Policy` on a resource.If no `Policy` is set on the resource, a `Policy` is returned with defaultvalues including `POLICY_TYPE_NOT_SET` for the `policy_type oneof`. The`etag` value can be used with `SetOrgPolicy()` to create or update a`Policy` during read-modify-write. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/projects/getOrgPolicy
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
                return service.Projects.GetOrgPolicy(body, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.GetOrgPolicy failed.", ex);
            }
        }

        /// <summary>
        /// Restores the Project identified by the specified`project_id` (for example, `my-project-123`).You can only use this method for a Project that has a lifecycle state ofDELETE_REQUESTED.After deletion starts, the Project cannot be restored.The caller must have modify permissions for this Project. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/projects/undelete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="projectId">The project ID (for example, `foo-bar-123`).Required.</param>
        /// <param name="body">A valid Cloudresourcemanager v1 body.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Undelete(CloudresourcemanagerService service, string projectId, UndeleteProjectRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);

                // Make the request.
                return service.Projects.Undelete(body, projectId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.Undelete failed.", ex);
            }
        }

        /// <summary>
        /// Gets the effective `Policy` on a resource. This is the result of merging`Policies` in the resource hierarchy. The returned `Policy` will not havean `etag`set because it is a computed `Policy` across multiple resources. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/projects/getEffectiveOrgPolicy
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
                return service.Projects.GetEffectiveOrgPolicy(body, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.GetEffectiveOrgPolicy failed.", ex);
            }
        }

        /// <summary>
        /// Updates the attributes of the Project identified by the specified`project_id` (for example, `my-project-123`).The caller must have modify permissions for this Project. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/projects/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="projectId">The project ID (for example, `my-project-123`).Required.</param>
        /// <param name="body">A valid Cloudresourcemanager v1 body.</param>
        /// <returns>ProjectResponse</returns>
        public static Project Update(CloudresourcemanagerService service, string projectId, Project body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);

                // Make the request.
                return service.Projects.Update(body, projectId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.Update failed.", ex);
            }
        }
        public class ProjectsListOptionalParms
        {
            /// An expression for filtering the results of the request.  Filter rules arecase insensitive. The fields eligible for filtering are:+ `name`+ `id`+ <code>labels.<em>key</em></code> where *key* is the name of a labelSome examples of using labels as filters:|Filter|Description||------|-----------||name:how*|The project's name starts with "how".||name:Howl|The project's name is `Howl` or `howl`.||name:HOWL|Equivalent to above.||NAME:howl|Equivalent to above.||labels.color:*|The project has the label `color`.||labels.color:red|The project's label `color` has the value `red`.||labels.color:red&nbsp;labels.size:big|The project's label `color` has the value `red` and its label `size` has the value `big`.If you specify a filter that has both `parent.type` and `parent.id`, thenthe `resourcemanager.projects.list` permission is checked on the parent.If the user has this permission, all projects under the parent will bereturned after remaining filters have been applied. If the user lacks thispermission, then all projects for which the user has the`resourcemanager.projects.get` permission will be returned after remainingfilters have been applied. If no filter is specified, the call will returnprojects for which the user has `resourcemanager.projects.get` permissions.Optional.
            public string Filter { get; set; }  
            /// A pagination token returned from a previous call to ListProjectsthat indicates from where listing should continue.Optional.
            public string PageToken { get; set; }  
            /// The maximum number of Projects to return in the response.The server can return fewer Projects than requested.If unspecified, server picks an appropriate default.Optional.
            public int? PageSize { get; set; }  
        
        }
 
        /// <summary>
        /// Lists Projects that are visible to the user and satisfy thespecified filter. This method returns Projects in an unspecified order.New Projects do not necessarily appear at the end of the list. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/projects/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="optional">Optional paramaters.</param>
        /// <returns>ListProjectsResponseResponse</returns>
        public static ListProjectsResponse List(CloudresourcemanagerService service, ProjectsListOptionalParms optional = null)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");

                // Building the initial request.
                var request = service.Projects.List();

                // Applying optional parameters to the request.                
                request = (ProjectsResource.ListRequest)SampleHelpers.ApplyOptionalParms(request, optional);

                // Requesting data.
                return request.Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.List failed.", ex);
            }
        }

        /// <summary>
        /// Updates the specified `Policy` on the resource. Creates a new `Policy` forthat `Constraint` on the resource if one does not exist.Not supplying an `etag` on the request `Policy` results in an unconditionalwrite of the `Policy`. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/projects/setOrgPolicy
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
                return service.Projects.SetOrgPolicy(body, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.SetOrgPolicy failed.", ex);
            }
        }

        /// <summary>
        /// Request that a new Project be created. The result is an Operation whichcan be used to track the creation process. It is automatically deletedafter a few hours, so there is no need to call DeleteOperation.Our SLO permits Project creation to take up to 30 seconds at the 90thpercentile. As of 2016-08-29, we are observing 6 seconds 50th percentilelatency. 95th percentile latency is around 11 seconds. We recommendpolling at the 5th second with an exponential backoff.Authorization requires the Google IAM permission`resourcemanager.projects.create` on the specified parent for the newproject. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/projects/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="body">A valid Cloudresourcemanager v1 body.</param>
        /// <returns>OperationResponse</returns>
        public static Operation Create(CloudresourcemanagerService service, Project body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");

                // Make the request.
                return service.Projects.Create(body).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.Create failed.", ex);
            }
        }

        /// <summary>
        /// Lists all the `Policies` set for a particular resource. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/projects/listOrgPolicies
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
                return service.Projects.ListOrgPolicies(body, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.ListOrgPolicies failed.", ex);
            }
        }

        /// <summary>
        /// Retrieves the Project identified by the specified`project_id` (for example, `my-project-123`).The caller must have read permissions for this Project. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/projects/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="projectId">The Project ID (for example, `my-project-123`).Required.</param>
        /// <returns>ProjectResponse</returns>
        public static Project Get(CloudresourcemanagerService service, string projectId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);

                // Make the request.
                return service.Projects.Get(projectId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.Get failed.", ex);
            }
        }

        /// <summary>
        /// Gets a list of ancestors in the resource hierarchy for the Projectidentified by the specified `project_id` (for example, `my-project-123`).The caller must have read permissions for this Project. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/projects/getAncestry
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="projectId">The Project ID (for example, `my-project-123`).Required.</param>
        /// <param name="body">A valid Cloudresourcemanager v1 body.</param>
        /// <returns>GetAncestryResponseResponse</returns>
        public static GetAncestryResponse GetAncestry(CloudresourcemanagerService service, string projectId, GetAncestryRequest body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);

                // Make the request.
                return service.Projects.GetAncestry(body, projectId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.GetAncestry failed.", ex);
            }
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified Project.There are no permissions required for making this API call. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/projects/testIamPermissions
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
                return service.Projects.TestIamPermissions(body, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.TestIamPermissions failed.", ex);
            }
        }

        /// <summary>
        /// Marks the Project identified by the specified`project_id` (for example, `my-project-123`) for deletion.This method will only affect the Project if the following criteria are met:+ The Project does not have a billing account associated with it.+ The Project has a lifecycle state ofACTIVE.This method changes the Project's lifecycle state fromACTIVEto DELETE_REQUESTED.The deletion starts at an unspecified time,at which point the Project is no longer accessible.Until the deletion completes, you can check the lifecycle statechecked by retrieving the Project with GetProject,and the Project remains visible to ListProjects.However, you cannot update the project.After the deletion completes, the Project is not retrievable bythe  GetProject andListProjects methods.The caller must have modify permissions for this Project. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/projects/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated Cloudresourcemanager service.</param>  
        /// <param name="projectId">The Project ID (for example, `foo-bar-123`).Required.</param>
        /// <returns>EmptyResponse</returns>
        public static Empty Delete(CloudresourcemanagerService service, string projectId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (projectId == null)
                    throw new ArgumentNullException(projectId);

                // Make the request.
                return service.Projects.Delete(projectId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.Delete failed.", ex);
            }
        }

        /// <summary>
        /// Clears a `Policy` from a resource. 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/projects/clearOrgPolicy
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
                return service.Projects.ClearOrgPolicy(body, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.ClearOrgPolicy failed.", ex);
            }
        }

        /// <summary>
        /// Sets the IAM access control policy for the specified Project. Replacesany existing policy.The following constraints apply when using `setIamPolicy()`:+ Project does not support `allUsers` and `allAuthenticatedUsers` as`members` in a `Binding` of a `Policy`.+ The owner role can be granted only to `user` and `serviceAccount`.+ Service accounts can be made owners of a project directlywithout any restrictions. However, to be added as an owner, a user must beinvited via Cloud Platform console and must accept the invitation.+ A user cannot be granted the owner role using `setIamPolicy()`. The usermust be granted the owner role using the Cloud Platform Console and mustexplicitly accept the invitation.+ Invitations to grant the owner role cannot be sent using`setIamPolicy()`;they must be sent only using the Cloud Platform Console.+ Membership changes that leave the project without any owners that haveaccepted the Terms of Service (ToS) will be rejected.+ If the project is not part of an organization, there must be at leastone owner who has accepted the Terms of Service (ToS) agreement in thepolicy. Calling `setIamPolicy()` to remove the last ToS-accepted ownerfrom the policy will fail. This restriction also applies to legacyprojects that no longer have owners who have accepted the ToS. Edits toIAM policies will be rejected until the lack of a ToS-accepting owner isrectified.+ Calling this method requires enabling the App Engine Admin API.Note: Removing service accounts from policies or changing their rolescan render services completely inoperable. It is important to understandhow the service account is being used before removing or updating itsroles.Authorization requires the Google IAM permission`resourcemanager.projects.setIamPolicy` on the project 
        /// Documentation https://developers.google.com/cloudresourcemanager/v1/reference/projects/setIamPolicy
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
                return service.Projects.SetIamPolicy(body, resource).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request Projects.SetIamPolicy failed.", ex);
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