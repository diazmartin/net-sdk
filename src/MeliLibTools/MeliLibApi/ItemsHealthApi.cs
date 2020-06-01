/* 
 * MELI Markeplace SDK
 *
 * This is a the codebase to generate a SDK for Open Platform Marketplace
 *
 * The version of the OpenAPI document: 0.0.24
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using MeliLibTools.Client;

namespace MeliLibTools.MeliLibApi
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IItemsHealthApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Return item health actions by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MeliLibTools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        void ItemsIdHealthActionsGet (string id, string accessToken);

        /// <summary>
        /// Return item health actions by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MeliLibTools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accessToken"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ItemsIdHealthActionsGetWithHttpInfo (string id, string accessToken);
        /// <summary>
        /// Return health by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MeliLibTools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        void ItemsIdHealthGet (string id, string accessToken);

        /// <summary>
        /// Return health by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MeliLibTools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accessToken"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ItemsIdHealthGetWithHttpInfo (string id, string accessToken);
        /// <summary>
        /// Return health levels.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MeliLibTools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId"></param>
        /// <returns></returns>
        void SitesSiteIdHealthLevelsGet (string siteId);

        /// <summary>
        /// Return health levels.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MeliLibTools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> SitesSiteIdHealthLevelsGetWithHttpInfo (string siteId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IItemsHealthApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Return item health actions by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MeliLibTools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accessToken"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ItemsIdHealthActionsGetAsync (string id, string accessToken);

        /// <summary>
        /// Return item health actions by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MeliLibTools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accessToken"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ItemsIdHealthActionsGetAsyncWithHttpInfo (string id, string accessToken);
        /// <summary>
        /// Return health by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MeliLibTools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accessToken"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ItemsIdHealthGetAsync (string id, string accessToken);

        /// <summary>
        /// Return health by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MeliLibTools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accessToken"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ItemsIdHealthGetAsyncWithHttpInfo (string id, string accessToken);
        /// <summary>
        /// Return health levels.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MeliLibTools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task SitesSiteIdHealthLevelsGetAsync (string siteId);

        /// <summary>
        /// Return health levels.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="MeliLibTools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SitesSiteIdHealthLevelsGetAsyncWithHttpInfo (string siteId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IItemsHealthApi : IItemsHealthApiSync, IItemsHealthApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ItemsHealthApi : IItemsHealthApi
    {
        private MeliLibTools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemsHealthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ItemsHealthApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemsHealthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ItemsHealthApi(String basePath)
        {
            this.Configuration = MeliLibTools.Client.Configuration.MergeConfigurations(
                MeliLibTools.Client.GlobalConfiguration.Instance,
                new MeliLibTools.Client.Configuration { BasePath = basePath }
            );
            this.Client = new MeliLibTools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new MeliLibTools.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = MeliLibTools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemsHealthApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ItemsHealthApi(MeliLibTools.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = MeliLibTools.Client.Configuration.MergeConfigurations(
                MeliLibTools.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new MeliLibTools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new MeliLibTools.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = MeliLibTools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemsHealthApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ItemsHealthApi(MeliLibTools.Client.ISynchronousClient client,MeliLibTools.Client.IAsynchronousClient asyncClient, MeliLibTools.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = MeliLibTools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public MeliLibTools.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public MeliLibTools.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public MeliLibTools.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public MeliLibTools.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Return item health actions by id. 
        /// </summary>
        /// <exception cref="MeliLibTools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public void ItemsIdHealthActionsGet (string id, string accessToken)
        {
             ItemsIdHealthActionsGetWithHttpInfo(id, accessToken);
        }

        /// <summary>
        /// Return item health actions by id. 
        /// </summary>
        /// <exception cref="MeliLibTools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accessToken"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public MeliLibTools.Client.ApiResponse<Object> ItemsIdHealthActionsGetWithHttpInfo (string id, string accessToken)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new MeliLibTools.Client.ApiException(400, "Missing required parameter 'id' when calling ItemsHealthApi->ItemsIdHealthActionsGet");

            // verify the required parameter 'accessToken' is set
            if (accessToken == null)
                throw new MeliLibTools.Client.ApiException(400, "Missing required parameter 'accessToken' when calling ItemsHealthApi->ItemsIdHealthActionsGet");

            MeliLibTools.Client.RequestOptions localVarRequestOptions = new MeliLibTools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
            };

            var localVarContentType = MeliLibTools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = MeliLibTools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (id != null)
                localVarRequestOptions.PathParameters.Add("id", MeliLibTools.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (accessToken != null)
            {
                localVarRequestOptions.QueryParameters.Add(MeliLibTools.Client.ClientUtils.ParameterToMultiMap("", "access_token", accessToken));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<Object>("/items/{id}/health/actions", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ItemsIdHealthActionsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Return item health actions by id. 
        /// </summary>
        /// <exception cref="MeliLibTools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accessToken"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ItemsIdHealthActionsGetAsync (string id, string accessToken)
        {
             await ItemsIdHealthActionsGetAsyncWithHttpInfo(id, accessToken);

        }

        /// <summary>
        /// Return item health actions by id. 
        /// </summary>
        /// <exception cref="MeliLibTools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accessToken"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<MeliLibTools.Client.ApiResponse<Object>> ItemsIdHealthActionsGetAsyncWithHttpInfo (string id, string accessToken)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new MeliLibTools.Client.ApiException(400, "Missing required parameter 'id' when calling ItemsHealthApi->ItemsIdHealthActionsGet");

            // verify the required parameter 'accessToken' is set
            if (accessToken == null)
                throw new MeliLibTools.Client.ApiException(400, "Missing required parameter 'accessToken' when calling ItemsHealthApi->ItemsIdHealthActionsGet");


            MeliLibTools.Client.RequestOptions localVarRequestOptions = new MeliLibTools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (id != null)
                localVarRequestOptions.PathParameters.Add("id", MeliLibTools.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (accessToken != null)
            {
                localVarRequestOptions.QueryParameters.Add(MeliLibTools.Client.ClientUtils.ParameterToMultiMap("", "access_token", accessToken));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/items/{id}/health/actions", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ItemsIdHealthActionsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Return health by id. 
        /// </summary>
        /// <exception cref="MeliLibTools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public void ItemsIdHealthGet (string id, string accessToken)
        {
             ItemsIdHealthGetWithHttpInfo(id, accessToken);
        }

        /// <summary>
        /// Return health by id. 
        /// </summary>
        /// <exception cref="MeliLibTools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accessToken"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public MeliLibTools.Client.ApiResponse<Object> ItemsIdHealthGetWithHttpInfo (string id, string accessToken)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new MeliLibTools.Client.ApiException(400, "Missing required parameter 'id' when calling ItemsHealthApi->ItemsIdHealthGet");

            // verify the required parameter 'accessToken' is set
            if (accessToken == null)
                throw new MeliLibTools.Client.ApiException(400, "Missing required parameter 'accessToken' when calling ItemsHealthApi->ItemsIdHealthGet");

            MeliLibTools.Client.RequestOptions localVarRequestOptions = new MeliLibTools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
            };

            var localVarContentType = MeliLibTools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = MeliLibTools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (id != null)
                localVarRequestOptions.PathParameters.Add("id", MeliLibTools.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (accessToken != null)
            {
                localVarRequestOptions.QueryParameters.Add(MeliLibTools.Client.ClientUtils.ParameterToMultiMap("", "access_token", accessToken));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<Object>("/items/{id}/health", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ItemsIdHealthGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Return health by id. 
        /// </summary>
        /// <exception cref="MeliLibTools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accessToken"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ItemsIdHealthGetAsync (string id, string accessToken)
        {
             await ItemsIdHealthGetAsyncWithHttpInfo(id, accessToken);

        }

        /// <summary>
        /// Return health by id. 
        /// </summary>
        /// <exception cref="MeliLibTools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="accessToken"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<MeliLibTools.Client.ApiResponse<Object>> ItemsIdHealthGetAsyncWithHttpInfo (string id, string accessToken)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new MeliLibTools.Client.ApiException(400, "Missing required parameter 'id' when calling ItemsHealthApi->ItemsIdHealthGet");

            // verify the required parameter 'accessToken' is set
            if (accessToken == null)
                throw new MeliLibTools.Client.ApiException(400, "Missing required parameter 'accessToken' when calling ItemsHealthApi->ItemsIdHealthGet");


            MeliLibTools.Client.RequestOptions localVarRequestOptions = new MeliLibTools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (id != null)
                localVarRequestOptions.PathParameters.Add("id", MeliLibTools.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (accessToken != null)
            {
                localVarRequestOptions.QueryParameters.Add(MeliLibTools.Client.ClientUtils.ParameterToMultiMap("", "access_token", accessToken));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/items/{id}/health", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ItemsIdHealthGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Return health levels. 
        /// </summary>
        /// <exception cref="MeliLibTools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId"></param>
        /// <returns></returns>
        public void SitesSiteIdHealthLevelsGet (string siteId)
        {
             SitesSiteIdHealthLevelsGetWithHttpInfo(siteId);
        }

        /// <summary>
        /// Return health levels. 
        /// </summary>
        /// <exception cref="MeliLibTools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public MeliLibTools.Client.ApiResponse<Object> SitesSiteIdHealthLevelsGetWithHttpInfo (string siteId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new MeliLibTools.Client.ApiException(400, "Missing required parameter 'siteId' when calling ItemsHealthApi->SitesSiteIdHealthLevelsGet");

            MeliLibTools.Client.RequestOptions localVarRequestOptions = new MeliLibTools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
            };

            var localVarContentType = MeliLibTools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = MeliLibTools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (siteId != null)
                localVarRequestOptions.PathParameters.Add("site_id", MeliLibTools.Client.ClientUtils.ParameterToString(siteId)); // path parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get<Object>("/sites/{site_id}/health_levels", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SitesSiteIdHealthLevelsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Return health levels. 
        /// </summary>
        /// <exception cref="MeliLibTools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task SitesSiteIdHealthLevelsGetAsync (string siteId)
        {
             await SitesSiteIdHealthLevelsGetAsyncWithHttpInfo(siteId);

        }

        /// <summary>
        /// Return health levels. 
        /// </summary>
        /// <exception cref="MeliLibTools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="siteId"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<MeliLibTools.Client.ApiResponse<Object>> SitesSiteIdHealthLevelsGetAsyncWithHttpInfo (string siteId)
        {
            // verify the required parameter 'siteId' is set
            if (siteId == null)
                throw new MeliLibTools.Client.ApiException(400, "Missing required parameter 'siteId' when calling ItemsHealthApi->SitesSiteIdHealthLevelsGet");


            MeliLibTools.Client.RequestOptions localVarRequestOptions = new MeliLibTools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (siteId != null)
                localVarRequestOptions.PathParameters.Add("site_id", MeliLibTools.Client.ClientUtils.ParameterToString(siteId)); // path parameter


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/sites/{site_id}/health_levels", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SitesSiteIdHealthLevelsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}