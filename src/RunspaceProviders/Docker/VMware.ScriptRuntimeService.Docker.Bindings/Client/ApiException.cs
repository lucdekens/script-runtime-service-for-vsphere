﻿/* 
 * Docker Engine API
 *
 * The Engine API is an HTTP API served by Docker Engine. It is the API the Docker client uses to communicate with the Engine, so everything the Docker client can do can be done with the API.  Most of the client's commands map directly to API endpoints (e.g. `docker ps` is `GET /containers/json`). The notable exception is running containers, which consists of several API calls.  # Errors  The API uses standard HTTP status codes to indicate the success or failure of the API call. The body of the response will be JSON in the following format:  ``` {   \"message\": \"page not found\" } ```  # Versioning  The API is usually changed in each release, so API calls are versioned to ensure that clients don't break. To lock to a specific version of the API, you prefix the URL with its version, for example, call `/v1.30/info` to use the v1.30 version of the `/info` endpoint. If the API version specified in the URL is not supported by the daemon, a HTTP `400 Bad Request` error message is returned.  If you omit the version-prefix, the current version of the API (v1.39) is used. For example, calling `/info` is the same as calling `/v1.39/info`. Using the API without a version-prefix is deprecated and will be removed in a future release.  Engine releases in the near future should support this version of the API, so your client will continue to work even if it is talking to a newer Engine.  The API uses an open schema model, which means server may add extra properties to responses. Likewise, the server will ignore any extra query parameters and request body properties. When you write clients, you need to ignore additional properties in responses to ensure they do not break when talking to newer daemons.   # Authentication  Authentication for registries is handled client side. The client has to send authentication details to various endpoints that need to communicate with registries, such as `POST /images/(name)/push`. These are sent as `X-Registry-Auth` header as a Base64 encoded (JSON) string with the following structure:  ``` {   \"username\": \"string\",   \"password\": \"string\",   \"email\": \"string\",   \"serveraddress\": \"string\" } ```  The `serveraddress` is a domain/IP without a protocol. Throughout this structure, double quotes are required.  If you have already got an identity token from the [`/auth` endpoint](#operation/SystemAuth), you can just pass this instead of credentials:  ``` {   \"identitytoken\": \"9cbaf023786cd7...\" } ``` 
 *
 * OpenAPI spec version: 1.39
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;

namespace VMware.ScriptRuntimeService.Docker.Bindings.Client
{
   /// <summary>
   /// API Exception
   /// </summary>
   public class ApiException : Exception
   {
      /// <summary>
      /// Gets or sets the error code (HTTP status code)
      /// </summary>
      /// <value>The error code (HTTP status code).</value>
      public int ErrorCode { get; set; }

      /// <summary>
      /// Gets or sets the error content (body json object)
      /// </summary>
      /// <value>The error content (Http response body).</value>
      public dynamic ErrorContent { get; private set; }

      /// <summary>
      /// Initializes a new instance of the <see cref="ApiException"/> class.
      /// </summary>
      public ApiException() { }

      /// <summary>
      /// Initializes a new instance of the <see cref="ApiException"/> class.
      /// </summary>
      /// <param name="errorCode">HTTP status code.</param>
      /// <param name="message">Error message.</param>
      public ApiException(int errorCode, string message) : base(message)
      {
         this.ErrorCode = errorCode;
      }

      /// <summary>
      /// Initializes a new instance of the <see cref="ApiException"/> class.
      /// </summary>
      /// <param name="errorCode">HTTP status code.</param>
      /// <param name="message">Error message.</param>
      /// <param name="errorContent">Error content.</param>
      public ApiException(int errorCode, string message, dynamic errorContent = null) : base(message)
      {
         this.ErrorCode = errorCode;
         this.ErrorContent = errorContent;
      }
   }
}
