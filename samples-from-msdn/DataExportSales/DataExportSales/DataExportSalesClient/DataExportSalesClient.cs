﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using System.Net.Http;
using DataExportSales;
using Microsoft.Rest;

namespace DataExportSales
{
    public partial class DataExportSalesClient : ServiceClient<DataExportSalesClient>, IDataExportSalesClient
    {
        private Uri _baseUri;
        
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
            set { this._baseUri = value; }
        }
        
        private ServiceClientCredentials _credentials;
        
        /// <summary>
        /// Credentials for authenticating with the service.
        /// </summary>
        public ServiceClientCredentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }
        
        private IMetadata _metadata;
        
        public virtual IMetadata Metadata
        {
            get { return this._metadata; }
        }
        
        private IProfiles _profiles;
        
        public virtual IProfiles Profiles
        {
            get { return this._profiles; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DataExportSalesClient class.
        /// </summary>
        public DataExportSalesClient()
            : base()
        {
            this._metadata = new Metadata(this);
            this._profiles = new Profiles(this);
            this._baseUri = new Uri("https://discovery.crmreplication.azure.net");
        }
        
        /// <summary>
        /// Initializes a new instance of the DataExportSalesClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public DataExportSalesClient(params DelegatingHandler[] handlers)
            : base(handlers)
        {
            this._metadata = new Metadata(this);
            this._profiles = new Profiles(this);
            this._baseUri = new Uri("https://discovery.crmreplication.azure.net");
        }
        
        /// <summary>
        /// Initializes a new instance of the DataExportSalesClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public DataExportSalesClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers)
            : base(rootHandler, handlers)
        {
            this._metadata = new Metadata(this);
            this._profiles = new Profiles(this);
            this._baseUri = new Uri("https://discovery.crmreplication.azure.net");
        }
        
        /// <summary>
        /// Initializes a new instance of the DataExportSalesClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public DataExportSalesClient(Uri baseUri, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._baseUri = baseUri;
        }
        
        /// <summary>
        /// Initializes a new instance of the DataExportSalesClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials for authenticating with the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public DataExportSalesClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
        }
        
        /// <summary>
        /// Initializes a new instance of the DataExportSalesClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials for authenticating with the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public DataExportSalesClient(Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._baseUri = baseUri;
            this._credentials = credentials;
            
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
        }
    }
}
