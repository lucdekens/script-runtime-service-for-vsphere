/* 
 * Script Runtime Service for vSphere
 *
 * # Script Runtime Service API    Script Runtime Service for vSphere (SRS) allows running PowerShell and PowerCLI scripts. SRS is a VC add-on that is deployed separately from VCSA. SRS can be accessed via REST API that allows you to create PowerShell instances and run PowerShell and PowerCLI scripts within. No Connect-VIServer is required to run PowerCLI against VC(s) SRS is registered to.    ## Authetication    SRS uses VC SSO as Identity and Authentication Server. Two types of authentication are supported. SIGN and Basic. SIGN authentication is purposed for Service-To-Service access to SRS resources. For convenience of the end-users SRS supports basic authentication passing username and password which are used to acquire SAML HoK token for SRS solution. When basic is used SRS exchanges the username and password for SAML HoK token from the SSO server. SRS uses the SAML token to Connect PowerCLI to VC services in further operations.   On successful authentication SRS returns API Key which is required to authorize further SRS API calls.
 *
 * OpenAPI spec version: 1.0-oas3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Client
{
    /// <summary>
    /// Formatter for 'date' swagger formats ss defined by full-date - RFC3339
    /// see https://github.com/OAI/OpenAPI-Specification/blob/master/versions/2.0.md#data-types
    /// </summary>
    public class SwaggerDateConverter : IsoDateTimeConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SwaggerDateConverter" /> class.
        /// </summary>
        public SwaggerDateConverter()
        {
            // full-date   = date-fullyear "-" date-month "-" date-mday
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
